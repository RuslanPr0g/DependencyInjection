using System;
using System.Collections.Generic;
using System.Text;
using ZabavnayaBiblioteka.Utilities;

namespace ZabavnayaBiblioteka
{
    public class BusinessLogic
    {
        public void PrecessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Getting started...");

            Console.WriteLine("In process...");

            dataAccess.LoadData();

            dataAccess.SaveData();

            logger.Log("Finish loading.");
        }
    }
}
