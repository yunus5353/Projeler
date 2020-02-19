using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
   public class LogManager
    {
        private ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.Log();
        }
    }
}
