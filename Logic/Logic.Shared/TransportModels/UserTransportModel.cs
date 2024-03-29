﻿using System;

namespace AspNetIdentity.Logic.Shared.TransportModels
{
    public class UserTransportModel : BaseTransportModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserName { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
    }
}
