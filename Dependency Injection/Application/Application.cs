using System;
using System.Collections.Generic;
using System.Text;
using ZabavnayaBiblioteka;

namespace Dependency_Injection
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            this._businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.PrecessData();
        }
    }
}
