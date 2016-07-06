using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logger
{
    public class DefaultLoggerManager : ILoggerManager
    {
        private ILogger _selectedLogger;
        public void SelectLogger(ILogger logger)
        {
            if (logger == null)
            {
                _selectedLogger = new DefaultLogger();
            }
            _selectedLogger = logger;
        }

        public ILogger GetLogger()
        {
            return _selectedLogger ?? new DefaultLogger();
        }
    }
}
