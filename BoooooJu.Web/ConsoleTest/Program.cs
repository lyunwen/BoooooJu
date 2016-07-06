using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.Test();
            System.Threading.Thread.Sleep(1000);
        }
    }
    public class TestClass
    {
        public int Sum(string info)
        {
            if (info == null)
                return 0;
            return info.Length;
        }
        public static Task<int> SumAsync(string info)
        {
            return Task.Run(() => new TestClass().Sum(info));
        }
        public async static void Test()
        {
            int i = await TestClass.SumAsync("dfgdfg");
        }
    }
}
