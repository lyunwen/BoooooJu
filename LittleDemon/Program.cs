using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleDemon
{
    class Program
    {
        static void main(string[] args)
        {
            var at1 = new UU<ClassA>();
            var bt = new UU<ClassB>();
            Type ob1 = at1.say();
            Type ob3 = bt.say();
            bool y = ob1.Equals(ob3);
            Console.ReadLine();
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
