using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logger;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Xml.Serialization;

namespace Common.Logger
{
    public class DefaultLogger : ILogger
    {
        private string LogBaseFilePath = AppDomain.CurrentDomain.BaseDirectory;

        public void Log<T>(T t, string fileName = null)
        {

            fileName = (fileName ?? DateTime.Now.Date.ToString("MM-dd"));
            var logFullPath = string.Format("{0}\\log\\{1}\\{2}", LogBaseFilePath, DateTime.Now.Date.Year.ToString(), DateTime.Now.Date.ToString("yyyy-MM"));
            DirectoryInfo directoryInfo = null;
            if (!Directory.Exists(logFullPath))
            {
                directoryInfo = Directory.CreateDirectory(logFullPath);
            }
            else
            {
                directoryInfo = new DirectoryInfo(logFullPath);
            }
            Type type = typeof(T);
            using (StreamWriter sw = new StreamWriter(logFullPath))
            {

            }
            //  XmlSerializer
        }
        public static void SerializeToXml(object srcObject, Type type, string xmlFilePath, string xmlRootName)
        {
            if (srcObject != null && !string.IsNullOrEmpty(xmlFilePath))
            {
                type = type != null ? type : srcObject.GetType();

                using (StreamWriter sw = new StreamWriter(xmlFilePath))
                {
                    XmlSerializer xs = string.IsNullOrEmpty(xmlRootName) ?
                        new XmlSerializer(type) :
                        new XmlSerializer(type, new XmlRootAttribute(xmlRootName));
                    xs.Serialize(sw, srcObject);
                }
            }
        }

        void ILogger.Log<T>(T t)
        {
            throw new NotImplementedException();
        }

        public void Log(string Tips, Exception exception, string fileName, LogLevel level)
        {
            DirectoryInfo directoryInfo = null;
            fileName = (fileName ?? DateTime.Now.Date.ToString("MM-dd"));
            var logFullPath = string.Format("{0}\\log\\{1}\\{2}", LogBaseFilePath, DateTime.Now.Date.Year.ToString(), DateTime.Now.Date.ToString("yyyy-MM"));
            if (!Directory.Exists(logFullPath))
            {
                directoryInfo = Directory.CreateDirectory(logFullPath);
            }
            else
            {
                directoryInfo = new DirectoryInfo(logFullPath);
            }

            StringBuilder infosSb = new StringBuilder("\r\n\r\n==================================================");
            string line = "\r\n";
            infosSb.AppendFormat("{0}LogTime:{1}    Type:{2}", line, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff"), level.ToString());
            if (null != Tips)
            {
                infosSb.AppendFormat("{0}Tips:{1}", line, Tips);
            }
            if (null != exception)
            {
                infosSb
                    .AppendFormat("{0}Ex_Message:{1}", line, exception.Message)
                    .AppendFormat("{0}Ex_Source:{1}", line, exception.Source)
                    .AppendFormat("{0}Ex_TargetSite:{1}", line, exception.TargetSite)
                    .AppendFormat("{0}Ex_InnerException:{1}", line, exception.InnerException)
                    .AppendFormat("{0}Ex_StackTrace:{1}", line, exception.StackTrace);
            }
            lock (this)
            {
                File.AppendAllText(string.Format("{0}\\{1}.log", directoryInfo.FullName, fileName), infosSb.ToString());
            }
        }

        public Task LogAsync(string Tips = null, Exception exception = null, string fileName = null, LogLevel level = LogLevel.Error)
        {
            return Task.Run(()=> Log(Tips,exception,fileName,level));
        }
    }
}