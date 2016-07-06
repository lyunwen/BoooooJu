using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LittleDemon
{
    class Program
    {
        static void Main(string[] args)
        {
            APMDemo apm = new APMDemo();

            APMDemo.EndGetFoodDg += EndGetFood1;
            APMDemo.EndGetFoodDg += EndGetFood2;
            apm.BeginGetFood("小炒肉", null, "小炒白菜");
            //var at1 = new UU<ClassA>();
            //var bt = new UU<ClassB>();
            //Type ob1 = at1.say();
            //Type ob3 = bt.say();
            //bool y = ob1.Equals(ob3);
            Console.ReadLine();
        }
        
        public static void EndGetFood1(IAsyncResult ar)
        {
            Console.Write("Fun 1");
        }

        public static void EndGetFood2(IAsyncResult ar)
        {
            Console.Write("Fun 1");
        }
    }
    public class UU<T> where T : new()
    {
        public Type say()
        {
            return typeof(UU<T>);
        }
    }
    public class ClassA
    {
        public Type NameA { get; set; }
    }
    public class ClassB
    {
        public string NameB { get; set; }
    }
}
