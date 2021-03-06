﻿using SimpleInjector;
using PocSimpleInjector.Base.Interfaces;
using PocSimpleInjector.Base;

namespace PocSimpleInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Start();
            var clienteService = Bootstrap.Container.GetInstance<IClienteService>();
            clienteService.Adicionar();
        }


    }

    internal class Bootstrap
    {
        public static Container Container;

        public static void Start()
        {
            // Create the _container as usual.
            Container = new Container();

            // Register your types, for instance:
            Container.Register<IMensagem, Email>(Lifestyle.Singleton);
            Container.Register<IClienteService, ClienteService>(Lifestyle.Transient);
            Container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Transient);

            // Optionally verify the _container.
            Container.Verify();
        }
    }
}
