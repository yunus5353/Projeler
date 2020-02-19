using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database loglandı");
        }
    }
}
