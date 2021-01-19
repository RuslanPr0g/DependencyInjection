using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public static class Startup
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
