using Common.Loger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Common.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer
            { 
                Enabled = true
            };
            timer.Elapsed += new ElapsedEventHandler(new TestClass().method);
            timer.BeginInit();
            timer.Start();
            Thread.Sleep(500000);
            Console.ReadLine();
        }
    }
    public class TestClass
    {
        public void method(object sender, ElapsedEventArgs e)
        {
           new DefaultLoger().LogAsync(DateTime.Now.ToShortTimeString(), null, null, LogLevel.Info);
        }
    }
}