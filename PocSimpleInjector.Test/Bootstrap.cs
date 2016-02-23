using PocSimpleInjector.Base;
using PocSimpleInjector.Base.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSimpleInjector.Test
{
    public class Bootstrap
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
