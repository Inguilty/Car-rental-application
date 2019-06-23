using Microsoft.AspNet.Identity.EntityFramework;

namespace Logic.UI.Models
{
    /// <summary>
    /// Defines the model for roles needed by ASP.NET identity.
    /// </summary>
    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>
    {
    }
}
