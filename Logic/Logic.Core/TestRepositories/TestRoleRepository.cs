using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Shared.Interfaces;

namespace AspNetIdentity.Logic.Core.TestRepositories
{
    /// <summary>
    /// The repository for accessing role data for tests.
    /// </summary>
    public class TestRoleRepository : IRoleRepository
    {
        #region member vars

        private readonly Lazy<List<Role>> _store = new Lazy<List<Role>>(
            () =>
            {
                var result = new List<Role>();
                var lines = File.ReadAllLines(@"Stores\RoleStore.txt").ToList();
                lines.ForEach(
                    line =>
                    {
                        var parts = line.Split(';');
                        result.Add(
                            new Role
                            {
                                Id = int.Parse(parts[0]),
                                Name = parts[1]
                            });
                    });
                return result;
            });

        #endregion

        #region explicit interfaces

        /// <inheritdoc />
        public Task<int?> GetRoleIdByNameAsync(string roleName)
        {
            return Task.FromResult(_store.Value.SingleOrDefault(r => r.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase))?.Id);
        }

        #endregion
    }
}
