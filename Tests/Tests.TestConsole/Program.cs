using System;
using System.Linq;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Core.Utils;

namespace AspNetIdentity.Tests.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StartupUtil.InitLogic();
            using (var ctx = ContextUtil.Context)
            {
                Console.WriteLine(ctx.Roles.Count());
            }
            Console.ReadKey();
        }
    }
}
