using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.ServiceContracts.SMSService;
using System.Net;
using System.IO;

namespace BoooooJu.Service.Core.Addresses.SMSService
{
    public class DefaultSMSService : ISMSService
    {
        private const string APIKEY = "5180bb9d4c81d189644adad16e50c9e1";
        private const string USERNAME = "zhanku";
        private const string PASSWORD = "qwer1234";
        private const string SENDURL = "http://m.5c.com.cn/api/send/?";
        public string Send(List<string> cellPhones, string content)
        {
            if (cellPhones == null || (cellPhones.Count == 0) || content == null)
                return "error";

            //POST
            StringBuilder sbCellPhones = new StringBuilder();
            foreach (var foo in cellPhones)
            {
                if (sbCellPhones.Length == 0)
                {
                    sbCellPhones.Append(foo);
                }
                else
                {
                    sbCellPhones.Append(",").Append(foo);
                }
            }
            StringBuilder sbTemp = new StringBuilder();
            sbTemp.Append("apikey=").Append(APIKEY).Append("&username=").Append(USERNAME).Append("&password=").Append(PASSWORD).Append("&mobile=").Append(sbCellPhones.ToString()).Append("&content=").Append(content);
            byte[] bTemp = Encoding.GetEncoding("GBK").GetBytes(sbTemp.ToString());
            string result = PostRequest(SENDURL, bTemp);
            return result;
        }

        public string Query()
        {
            StringBuilder sbTemp = new StringBuilder();
            sbTemp.Append("apikey=");
            sbTemp.Append(USERNAME);
            sbTemp.Append("&username=");
            sbTemp.Append(PASSWORD);
            return "";
        }
        //POST方式发送得结果
        private static String PostRequest(string url, byte[] bData)
        {
            HttpWebRequest hwRequest;
            HttpWebResponse hwResponse;

            string strResult = string.Empty;
            try
            {
                hwRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                hwRequest.Timeout = 5000;
                hwRequest.Method = "POST";
                hwRequest.ContentType = "application/x-www-form-urlencoded";
                hwRequest.ContentLength = bData.Length;

                System.IO.Stream smWrite = hwRequest.GetRequestStream();
                smWrite.Write(bData, 0, bData.Length);
                smWrite.Close();
            }
            catch (System.Exception err)
            {
                WriteErrLog(err.ToString());
                return strResult;
            }

            //get response
            try
            {
                hwResponse = (HttpWebResponse)hwRequest.GetResponse();
                StreamReader srReader = new StreamReader(hwResponse.GetResponseStream(), Encoding.ASCII);
                strResult = srReader.ReadToEnd();
                srReader.Close();
                hwResponse.Close();
            }
            catch (System.Exception err)
            {
                WriteErrLog(err.ToString());
            }

            return strResult;
        }
        private static void WriteErrLog(string strErr)
        {
            Console.WriteLine(strErr);
            System.Diagnostics.Trace.WriteLine(strErr);
        }
    }
}
