using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Timers;
using System.CodeDom.Compiler;
using BoooooJu.Service.Core.Addresses.Account;

namespace BoooooJu.Service.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserService service1 = new UserService();
            var user=service1.FindUserById(1);
            Core.Addresses.Diancan.DiancanService service = new Core.Addresses.Diancan.DiancanService();
            service.GetOrders(new Core.QueryParameter.Page { PageIndex = 1, PageSize = 10, Sort = Core.QueryParameter.Base.Sort.Asc }, Core.Dal.Rank.DC_OBOrder_Rank.OrderId);
            method();
            System.Threading.Thread.Sleep(100000);
        }
        private void method()
        {
            Timer _timer;
            int _Interval = 50000;
            _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = _Interval;
            _timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            _timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed1);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Hello world!");
            }
            //todo something
        }

        private void Timer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Hello world!");
            }
            //todo something
        }
    }
}
