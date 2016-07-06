using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logger
{
    /// <summary>
    /// 日志工厂负责日志实例的创建
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}