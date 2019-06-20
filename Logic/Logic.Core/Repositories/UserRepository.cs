using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Core.Extensions;
using AspNetIdentity.Logic.Shared.Enumerations;
using AspNetIdentity.Logic.Shared.Interfaces;
using AspNetIdentity.Logic.Shared.TransportModels;

namespace AspNetIdentity.Logic.Core.Repositories
{
    /// <summary>
    /// The repository for accessing user data.
    /// </summary>
    public class UserRepository : BaseRespository, IUserRepository
    {
        #region member vars

        private readonly IRoleRepository _roleRepository;

        #endregion

        #region constructors and destructors

        public UserRepository(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        #endregion

        #region explicit interfaces

        /// <inheritdoc />
        public async Task<int?> AddUserAsnyc(UserTransportModel model, string firstRoleName)
        {
            var roleId = await _roleRepository.GetRoleIdByNameAsync(firstRoleName);
            if (!roleId.HasValue)
            {
                HandleException(new ArgumentException("Role not found.", nameof(firstRoleName)));
                return null;
            }
            var newUser = model.ToEntity();
            newUser.EmailConfirmed = true;
            newUser.AccessFailedCount = 0;
            newUser.LockoutEnabled = false;
            newUser.LockoutEndDateUtc = null;
            newUser.SecurityStamp = Guid.NewGuid().ToString("N");
            var userRole = new UserRole
            {
                RoleId = roleId.Value
            };
            newUser.UserRoles.Add(userRole);
            DbContext.Users.Add(newUser);
            try
            {
                await DbContext.SaveChangesAsync();
                if (newUser.Id == 0)
                {
                    await DbContext.Entry(newUser).ReloadAsync();
                }
                return newUser.Id;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetRoleNamesAsync(int userId)
        {
            var user = await DbContext.Users.FindAsync(userId);
            return user?.UserRoles.Select(ur => ur.Role.Name);
        }

        /// <inheritdoc />
        public async Task<UserTransportModel> GetUserByIdAsync(int id)
        {
            var user = await DbContext.Users.FindAsync(id).ConfigureAwait(false);
            return user?.ToTransportModel();
        }

        /// <inheritdoc />
        public async Task<UserTransportModel> GetUserByMailAsync(string mailAddress)
        {
            var user = await DbContext.Users.SingleOrDefaultAsync(u => u
                .Email.Equals(mailAddress, StringComparison.Ordinal)).ConfigureAwait(false);
            return user?.ToTransportModel();
        }

        /// <inheritdoc />
        public async Task<UserTransportModel> GetUserByUserNameAsync(string userName)
        {
            var user = await DbContext.Users.SingleOrDefaultAsync(u => u
                .UserName.Equals(userName, StringComparison.Ordinal)).ConfigureAwait(false);
            return user?.ToTransportModel();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<UserTransportModel>> GetUsersAsync()
        {
            var users = await DbContext.Users.ToListAsync().ConfigureAwait(false);
            return users.Select(u => u.ToTransportModel()).ToList();
        }

        /// <inheritdoc />
        public async Task<PasswordCheckResult> IsPassCorrectAsync(string userName, string passHash)
        {
            var user = await GetUserByUserNameAsync(userName).ConfigureAwait(false);
            if (user == null)
            {
                return PasswordCheckResult.UserNotFound;
            }
            if (!user.EmailConfirmed)
            {
                return PasswordCheckResult.UserNotConfirmed;
            }
            if (user.LockoutEnabled)
            {
                return PasswordCheckResult.UserIsLocked;
            }
            if (!user.PasswordHash.Equals(passHash, StringComparison.Ordinal))
            {
                return PasswordCheckResult.PasswordIncorrect;
            }
            return PasswordCheckResult.Success;
        }

        /// <inheritdoc />
        public async Task<bool> UserExistsAsync(string userName)
        {
            return await DbContext.Users.AnyAsync(u => u.UserName.Equals(userName, StringComparison.Ordinal)).ConfigureAwait(false);
        }

        #endregion
    }
}
