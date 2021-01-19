using System;
using System.Collections.Generic;
using System.Text;

namespace ZabavnayaBiblioteka.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine($"{DateTime.Now}: {data}");
        }
    }
}
