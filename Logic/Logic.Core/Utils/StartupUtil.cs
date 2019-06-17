using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Shared.TransportModels;
using AutoMapper;

namespace AspNetIdentity.Logic.Core.Utils
{
    public static class StartupUtil
    {
        public static void InitLogic(bool runsUnderTest = false)
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<User, UserTransportModel>();
                    cfg.CreateMap<UserTransportModel, User>();
                });
        }
    }
}
