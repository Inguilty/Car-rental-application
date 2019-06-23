﻿namespace Logic.UI.Models
{
    using System;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    /// <summary>
    /// Defines the model for user claims needed by ASP.NET identity.
    /// </summary>
    public class ApplicationUserClaim : IdentityUserClaim<int>
    {
    }
}
