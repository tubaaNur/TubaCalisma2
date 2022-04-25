using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubaCalisma2
{
    // Interface#2 (Interface e somut atayabiliyoruz)
    interface ILogger
    {
        void Log();
    }
    class CustomerManagers
    {
        public ILogger Logger { get; set; } //(interface e somut atama)
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Eklendi.");
        }
    }

    class SQLLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("SQL Eklendi.");

        }

    }
    

    }


