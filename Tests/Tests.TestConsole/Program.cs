using AspNetIdentity.Data.Core;
using System;
using System.Linq;

namespace Tests.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = ContextUtil.Context)
            {
                Console.WriteLine(ctx.Roles.Count());
            }
            Console.ReadKey();
        }
    }
}
