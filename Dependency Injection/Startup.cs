using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using ZabavnayaBiblioteka;

namespace Dependency_Injection
{
    public static class Startup
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            
            return builder.Build();
        }
    }
}
