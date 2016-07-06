using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataDrager
{
    public class DefaultGrabber : IGrabber
    {
        private const string ContentType = "application/x-www-form-urlencoded";
        private const string UserAgent = "User-Agent:Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;"; 
        public string GetWebRequest(string url, string paraData, Encoding dataEncode, string Method)
        {
            
            string html = string.Empty;
            try
            {
                byte[] byteArray = dataEncode.GetBytes(paraData); //转化
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(url));
                webReq.Method = "POST";
                webReq.ContentType = ContentType;
                webReq.UserAgent = UserAgent;
                webReq.ContentLength = byteArray.Length;

                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                StreamReader srHtml = new StreamReader(response.GetResponseStream(), dataEncode);
                html = srHtml.ReadToEnd();
                srHtml.Close();
                response.Close();
            }
            catch (Exception ex)
            {

            }
            return html;
        }

        public string PostWebRequest(string url, string paraData, Encoding dataEncode, string Method)
        {
            string html = string.Empty;
            try
            {
                
                byte[] byteArray = dataEncode.GetBytes(paraData); //转化
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(url));
                webReq.Method = "POST";
                webReq.ContentType = ContentType;
                webReq.UserAgent = UserAgent;
                webReq.ContentLength = byteArray.Length;

                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                StreamReader srHtml = new StreamReader(response.GetResponseStream(), dataEncode);
                html = srHtml.ReadToEnd();
                srHtml.Close();
                response.Close();
            }
            catch (Exception ex)
            {

            }
            return html;
        }
    }
}
