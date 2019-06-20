using System.Reflection;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Core.Repositories;
using AspNetIdentity.Logic.Shared.Interfaces;
using AspNetIdentity.Logic.Shared.TransportModels;
using Autofac;
using AutoMapper;

namespace AspNetIdentity.Logic.Core.Utils
{
    /// <summary>
    /// Provides logic for wiring up often needed components on application startup
    /// </summary>
    public static class StartupUtil
    {
        public static void InitLogic(bool runsUnderTest = false)
        {
            //Initialize Automapper
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<User, UserTransportModel>();
                    cfg.CreateMap<UserTransportModel, User>();
                });

            //Initialize AutoFac as DI
            var builder = new ContainerBuilder();
            if (runsUnderTest)
            {
                //builder.RegisterType<TestRoleRepository>().As<IRoleRepository>();
                //builder.RegisterType<TestUserRepository>().As<IUserRepository>();
            }
            else
            {
                builder.RegisterType<UserRepository>().As<IUserRepository>();
                builder.RegisterType<RoleRepository>().As<IRoleRepository>();
                //var coreLogic = Assembly.GetExecutingAssembly();
                //builder.RegisterAssemblyTypes(coreLogic)
                //    .Where(t => !t.Name.Contains("Test") && t.Name.EndsWith("Repository"))
                //    .AsImplementedInterfaces();
            }

            Container = builder.Build();
        }
        /// <summary>
        /// The static AutoFac container for DI
        /// </summary>
        public static IContainer Container { get; private set; }
    }
}
