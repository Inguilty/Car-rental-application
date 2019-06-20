﻿using System.Threading.Tasks;

namespace AspNetIdentity.Logic.Shared.Interfaces
{
    /// <summary>
    /// Must be implemented by all repositories that are dealing with user data.
    /// </summary>
    public interface IRoleRepository
    {
        #region methods

        /// <summary>
        /// Retrieves the database id of a role with the given <paramref name="roleName" />.
        /// </summary>
        /// <param name="roleName">The case-insensitive name of the role.</param>
        /// <returns>The database id of the role or <c>null</c> if the role wasn't found.</returns>
        Task<int?> GetRoleIdByNameAsync(string roleName);

        #endregion
    }
}
