using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Loger
{
    public interface ILoger
    {
        void Log<T>(T t);
        void Log(string Tips = null, Exception exception = null, string fileName = null, LogLevel level = LogLevel.Error);
        Task LogAsync(string Tips = null, Exception exception = null, string fileName = null, LogLevel level = LogLevel.Error);
    }
    public enum LogLevel
    {
        Error = 0,
        Debug = 1,
        Warn = 2,
        Info = 4,
    }
}