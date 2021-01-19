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

            using ()
            {

            }

                Console.ReadKey();
        }
    }
}
