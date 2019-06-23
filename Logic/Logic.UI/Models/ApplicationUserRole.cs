namespace Logic.UI.Models
{
    using System;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    /// <summary>
    /// Defines the model for user-role-mappings needed by ASP.NET identity.
    /// </summary>
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        #region properties

        /// <summary>
        /// The database-generated unqiue id of the entity.
        /// </summary>
        public long Id { get; set; }

        #endregion
    }
}
