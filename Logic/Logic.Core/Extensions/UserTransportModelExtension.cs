using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Shared.TransportModels;
using AutoMapper;

namespace AspNetIdentity.Logic.Core.Extensions
{
    public static class UserTransportModelExtension
    {
        public static User ToEntity(this UserTransportModel source)
        {
            var result = Mapper.Map<User>(source);
            return result;
        }
    }
}
