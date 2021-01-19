using System;
using System.Collections.Generic;
using System.Text;
using ZabavnayaBiblioteka.Utilities;

namespace ZabavnayaBiblioteka
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this._logger = logger;
            this._dataAccess = dataAccess;
        }

        public void PrecessData()
        {
            _logger.Log("Getting started...");

            Console.WriteLine("In process...");

            _dataAccess.LoadData();

            _dataAccess.SaveData();

            _logger.Log("Finish loading.");
        }
    }
}
