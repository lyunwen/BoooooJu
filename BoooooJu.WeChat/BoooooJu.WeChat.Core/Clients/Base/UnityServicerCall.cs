using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.WeChat.Core.Clients.Base
{
    public abstract class UnityServicerCall<T> where T : class
    { 
        // 容器初始化，初始化必须在Builder注册类型实例后完成 
        internal static IContainer container;
        internal static readonly object syncRoot = new object();
        internal static volatile T t = null;
        
        /// <summary>
        /// 非线程安全Client，速度快，占用较小的固定资源，通常用于数据查询，当当前实例处于无法恢复的
        /// </summary>
        /// <returns>T类型客户端</returns>
        public virtual T GetStaticClient()
        {
            {
                if (t == null)
                {
                    lock (syncRoot)
                    {
                        if (t == null)
                        {
                            t = container.Resolve<T>();
                        }
                    }
                }
                else
                {
                    var foo = t as ClientBase<T>;
                    if (foo.State == CommunicationState.Faulted)
                    { 
                        t = GetClient();
                    }
                }
                return t;
            }

        }
        /// <summary>
        /// 线程安全Client，相对GetStaticClient()方法速度较慢，每次调用都需要通过IOC容器创建Client，通常用于数据存储
        /// </summary>
        /// <returns>T类型客户端</returns>
        public virtual T GetClient()
        {
            var client = container.Resolve<T>();
            return client;
        }
    }

    /// <summary>
    /// 防止代码爆炸以及容器注入额外的组件类型。
    /// </summary>
    internal abstract class ServicerContainerConfig
    {
        private readonly ContainerBuilder builder = new ContainerBuilder();
        internal virtual void RegisterType(ContainerBuilder builder)
        {
            //注册类型
        }
        internal virtual IContainer GetContainer()
        {
            RegisterType(builder);
            return builder.Build();
        }
    }
}
