using ServerWcfService.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWcfService.Services
{
    public class MySimpleService : IMySimpleService
    {
        public string Hello(string hello)
        {
            return hello;
        }
    }
}
