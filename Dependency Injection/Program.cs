using System;
using ZabavnayaBiblioteka;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            businessLogic.ProcessData();

            Console.ReadKey();
        }
    }
}
