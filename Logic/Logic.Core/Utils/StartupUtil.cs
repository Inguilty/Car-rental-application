using System;
using System.Reflection;
using AspNetIdentity.Data.Core;
using AspNetIdentity.Logic.Core.EventArgs;
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
        /// <summary>
        /// Is fired before Autofac container is being built so that the reciever can do
        /// Custom stuff with Autofac builder
        /// </summary>
        public static event EventHandler<ContainerBuilderEventArgs> AutofacBuilderReady;

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
                var coreLogic = Assembly.GetExecutingAssembly();
                builder.RegisterAssemblyTypes(coreLogic)
                    .Where(t => t.Name.Contains("Test") && t.Name.EndsWith("Repository"))
                    .AsImplementedInterfaces();
            }
            else
            {
                var coreLogic = Assembly.GetExecutingAssembly();
                builder.RegisterAssemblyTypes(coreLogic)
                    .Where(t => !t.Name.Contains("Test") && t.Name.EndsWith("Repository"))
                    .AsImplementedInterfaces();
            }

            AutofacBuilderReady?.Invoke(null, new ContainerBuilderEventArgs(builder));
            Container = builder.Build();
        }
        /// <summary>
        /// The static AutoFac container for DI
        /// </summary>
        public static IContainer Container { get; private set; }
    }
}
