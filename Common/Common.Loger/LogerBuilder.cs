using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Loger
{
    public class LogerBuilder
    {
        private IResolver<ILogerFactory> _serviceResolver;
        public LogerBuilder(IResolver<ILogerFactory> serviceRsover)
        {
            _serviceResolver=serviceRsover??new SingleServiceResolver<ILogerFactory>()
        }
    }
}
