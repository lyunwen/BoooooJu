using BoooooJu.Service.Api.Dto.Account;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Clients
{
    public class UserService
    {
        public static async Task<UserBO> GetUserBOById(long id)
        {
            using (Base.BaseHttpClient client = new Base.BaseHttpClient(new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.GZip }))
            {
                var response = await client.GetAsync(string.Format("/user/GetUserBOById/{0}", id));
                response.EnsureSuccessStatusCode();
                return JsonSerializer.DeserializeFromString<UserBO>(await response.Content.ReadAsStringAsync());
            }
        }
        public static async Task<int> ResgiterByUserName(string userName, string password, string fromType = null)
        {
            using (Base.BaseHttpClient client = new Base.BaseHttpClient(new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.GZip }))
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string> {
                    { "userName",userName},
                    { "password",password},
                    { "fromType",fromType},
                });
                var response = await client.PostAsync(string.Format("/user/ResgiterByUserName"), content);
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result.ToInt32();
            }
        }
    }
}