using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logger
{
    /// <summary>
    /// 日志管理者负责日志实例类型的选择（默认为DefaultLogger）
    /// </summary>
    public interface ILoggerManager
    {
        ILogger GetLogger();
        void SelectLogger(ILogger logger);
    }
}
