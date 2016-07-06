using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.WeChat.Core.Clients.Base
{
    internal class BaseHttpClient : HttpClient
    {
        public BaseHttpClient()
        {
            this.BaseAddress = new Uri(_baseAddress);
        }
        public BaseHttpClient(HttpMessageHandler handler) : base(handler)
        {
            this.BaseAddress = new Uri(_baseAddress);
        }
        public BaseHttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
        {
            this.BaseAddress = new Uri(_baseAddress);
        }
        private string _baseAddress = System.Configuration.ConfigurationManager.AppSettings["WebApiAdrress"].ToLower();
    }
}
