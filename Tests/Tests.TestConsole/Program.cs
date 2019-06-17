using AspNetIdentity.Data.Core;
using System;
using System.Linq;
using AspNetIdentity.Logic.Core.Extensions;
using AspNetIdentity.Logic.Core.Utils;
using AutoMapper;
using AspNetIdentity.Logic.Shared.TransportModels;

namespace Tests.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StartupUtil.InitLogic();
            Console.ReadKey();
        }
    }
}
