using System;
using AspNetIdentity.Logic.Core.Utils;
using AspNetIdentity.Logic.Shared.Interfaces;
using Autofac;

namespace AspNetIdentity.Tests.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StartupUtil.InitLogic();
            //using (var ctx = ContextUtil.Context)
            //{
            //    Console.WriteLine(ctx.Roles.Count());
            //}

            var instance = StartupUtil.Container.Resolve<IUserRepository>();
            Console.ReadKey();
        }
    }
}
