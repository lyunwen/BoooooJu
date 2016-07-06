using Common.Loger;
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
            try
            {
                YY u = null;
                u.Na3me = "rrr";
            }
            catch (Exception ex)
            {
                DefaultLoger loger = new DefaultLoger();
                for (int i = 0; i < 100; i++)
                {
                    loger.LogAsync(Tips: "除法问题" + i, exception: ex);
                }
            }
            Console.ReadKey();
        }
    }
    public class YY
    {
        public string Name { get; set; }
        public string Nam2e { get; set; }
        public string Na3me { get; set; }
        public string Na4me { get; set; }
        public string Na5me { get; set; }
    }
}
