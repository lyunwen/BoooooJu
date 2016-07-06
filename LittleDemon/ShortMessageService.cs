using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LittleDemon
{

    //------------------------------------------------
    //功能:	美联软通HTTP接口C#调用说明
    //日期:	2013-05-08
    //说明:	http://m.5c.com.cn/api/send/?apikey=32位加密码&username=用户名&password=密码&mobile=手机号&content=内容
    //状态:


    //返回值										说明
    //success:msgid								提交成功，发送状态请见4.1
    //error:msgid								提交失败
    //error:Missing username					用户名为空
    //error:Missing password					密码为空
    //error:Missing apikey						APIKEY为空
    //error:Missing recipient					手机号码为空
    //error:Missing message content				短信内容为空
    //error:Account is blocked					帐号被禁用
    //error:Unrecognized encoding				编码未能识别
    //error:APIKEY or password error			APIKEY 或密码错误
    //error:Unauthorized IP address				未授权 IP 地址
    //error:Account balance is insufficient		余额不足
    //error:Black keywords is:党中央			屏蔽词


    //------------------------------------------------
    namespace smsTest
    {
        class sendSMS
        {
            static void Main(string[] args)
            {
                string content = "c#接口内容";
                //POST
                StringBuilder sbTemp = new StringBuilder();
                sbTemp
                    .AppendFormat("account={0}&", "jiekou-clcs-03")
                    .AppendFormat("pswd={0}&", "Admin789")
                    .AppendFormat("mobile={0}&", "13058171032")
                    .AppendFormat("msg={0}&", "您好，您的验证码是888888")
                    .AppendFormat("needstatus={0}", "true");
                byte[] bTemp = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(sbTemp.ToString());
                String result = PostRequest("http://222.73.117.158/msg/HttpBatchSendSM?", bTemp);
                string result1 = GetRequest("http://222.73.117.158/msg/QueryBalance?account=jiekou-clcs-03&pswd=Admin789");
                Console.WriteLine(result);
            }

            //POST方式发送得结果
            private static String PostRequest(string url, byte[] bData)
            {
                HttpWebRequest hwRequest;
                HttpWebResponse hwResponse;

                string strResult = string.Empty;
                try
                {
                    hwRequest = (HttpWebRequest)WebRequest.Create(url);
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
                catch
                {
                    throw;
                }

                return strResult;
            }
            private static string GetRequest(string url)
            {
                HttpWebRequest hwRequest;
                HttpWebResponse hwResponse;

                string strResult = string.Empty;
                try
                {
                    hwRequest = (HttpWebRequest)WebRequest.Create(url);
                    hwRequest.Timeout = 5000;
                    hwRequest.Method = "Get";
                    hwRequest.ContentType = "application/x-www-form-urlencoded";
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
                catch
                {
                    throw;
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

}
