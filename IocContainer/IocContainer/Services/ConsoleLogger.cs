using IocContainer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IocContainer.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
