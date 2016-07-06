using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Common.Loger.Loger loger = new Common.Loger.Loger();
            loger.LogAsync("async");
            loger.Log("not async");
            Console.ReadKey();
        }
    }
}
