using System;
using ZabavnayaBiblioteka;
using ZabavnayaBiblioteka.Utilities;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            IDataAccess dataAccess = new DataAccess();

            IBusinessLogic businessLogic = new BusinessLogic(logger, dataAccess);

            businessLogic.PrecessData();

            Console.ReadKey();
        }
    }
}
