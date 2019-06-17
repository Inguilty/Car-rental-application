﻿
namespace AspNetIdentity.Logic.Shared.TransportModels
{
    public class UserTransportModel : BaseTransportModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
