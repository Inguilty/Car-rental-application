using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Shared.TransportModels;
using AutoMapper;

namespace AspNetIdentity.Logic.Core.Extensions
{
    public static class UserExtensions
    {
        public static UserTransportModel ToTransportModel(this User source)
        {
            var result = Mapper.Map<UserTransportModel>(source);
            return result;
        }
    }
}
