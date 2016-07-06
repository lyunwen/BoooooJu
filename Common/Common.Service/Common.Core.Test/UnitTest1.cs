using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoooooJu.CommonService.Core;
using System.Timers;

namespace Common.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ActionExecutor.AddCircleAction(new ElapsedEventHandler(Timer_Elapsed),CircleTimeSpan.OneHour);
        }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Type t = typeof(string);
            var hh = Activator.CreateInstance(t);
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Hello world!");
            }
            //todo something
        }
    }
}
