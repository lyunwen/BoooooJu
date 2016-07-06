using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Autofac; 
using Common.Logger;

namespace Conmmon.Loger.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            new YY().Method();
        }
    }

    public class YY
    {
        [TestMethod]
        public async void Method()
        {
            ILoggerFactory loggerFactory = null;
            ILoggerManager loggerManager = null;
            var builder = new ContainerBuilder();
            builder.RegisterType<DefaultLoggerFactory>().As<ILoggerFactory>();
            builder.RegisterType<DefaultLoggerManager>().As<ILoggerManager>();
            using (var container = builder.Build())
            {
                // loggerManager = container.Resolve<ILoggerManager>();
                loggerFactory = container.Resolve<ILoggerFactory>();
            }
            var logger = loggerFactory.CreateLogger();
            await logger.LogAsync("Hello!");
            Thread.Sleep(1000);
        }
        public string Name { get; set; }
        public string Nam2e { get; set; }
        public string Na3me { get; set; }
        public string Na4me { get; set; }
        public string Na5me { get; set; }
    }
};
