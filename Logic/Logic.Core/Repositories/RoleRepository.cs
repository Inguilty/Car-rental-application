using System;
using System.Data.Entity;
using System.Threading.Tasks;
using AspNetIdentity.Logic.Shared.Interfaces;

namespace AspNetIdentity.Logic.Core.Repositories
{
    /// <summary>
    /// The repository for accessing role data.
    /// </summary>
    public class RoleRepository : BaseRespository, IRoleRepository
    {
        #region explicit interfaces

        /// <inheritdoc />
        public async Task<int?> GetRoleIdByNameAsync(string roleName)
        {
            var result = await DbContext.Roles.SingleOrDefaultAsync(r => r.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase)).ConfigureAwait(false);
            return result?.Id;
        }

        #endregion
    }
}
