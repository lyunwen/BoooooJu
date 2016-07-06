using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logger
{
    public class DefaultLoggerFactory : ILoggerFactory
    {
        private readonly ILoggerManager _loggerManager; 
        public DefaultLoggerFactory(ILoggerManager loggerManager)
        {
            if (loggerManager == null)
            {
                _loggerManager = new DefaultLoggerManager();
            }
            else
            {
                _loggerManager = loggerManager;
            }
        }
        public ILogger CreateLogger()
        {
            return _loggerManager.GetLogger();
        }
    }
}
