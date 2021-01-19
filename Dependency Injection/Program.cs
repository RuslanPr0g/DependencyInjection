using Autofac;
using System;
using ZabavnayaBiblioteka;
using ZabavnayaBiblioteka.Utilities;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Startup.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }

            Console.ReadKey();
        }
    }
}
