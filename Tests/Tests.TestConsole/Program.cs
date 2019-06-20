using System;
using System.Linq;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Core.Utils;
using AspNetIdentity.Logic.Shared.Interfaces;
using AspNetIdentity.Logic.Shared.TransportModels;
using Autofac;

namespace AspNetIdentity.Tests.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = ContextUtil.Context)
            //{
            //    Console.WriteLine(ctx.Roles.Count());
            //} 
            //StartupUtil.InitLogic();

            StartupUtil.InitLogic();
            var instance = StartupUtil.Container.Resolve<IUserRepository>();
            //var res = instance.AddUserAsnyc(
            //    new UserTransportModel
            //    {
            //        UserName = "TestUser",
            //        Email = "asd@dfsgh.com",
            //        PasswordHash = "fvsgnmgdnrssebabsn",
            //        FirstName = "SDADASASD",
            //        LastName = "SDADSADAS",
            //        Region = "SDADSAASD",
            //        Country = "Ukraine"
            //    },
            //    "Manager").Result;
            var res = instance.UserExistsAsync("TestUser").Result;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
