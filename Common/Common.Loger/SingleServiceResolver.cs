using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Loger
{
    internal class SingleServiceResolver<TService> : IResolver<TService> where TService:class
    {
        private Lazy<TService> _currentValueFromResolver;
        private Func<TService> _currentValueThunk;
        private TService _defaultValue;
        private Func<IDependencyResolver> _resolverThunk;
        private string _callerMethodName;
        public SingleServiceResolver(Func<TService> t)
        {

        }
        public TService Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
