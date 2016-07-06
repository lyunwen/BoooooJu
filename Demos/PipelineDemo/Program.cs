using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();
            for(var i = 0; i < 10; i++)
            { 
            }
            for(var j = 0; j < 10; j++)
            { 
            }
            Console.ReadKey();
            //如：婴儿期（0～3岁）、幼儿期（3～6岁）、儿童期搜索（6～11、12岁）、少年期（11、12～14、15岁）、青年期（16 - 28岁，有的认为应该到35岁）、成年期（35 - 60岁左右）、60—79岁为老年期，80—89岁 为高龄期，90岁以上为长寿期；  人生如潮水，有起有落，按年龄大致可划分为以下几个阶段： 
        }

        private static void Display(int i)
        {
            Console.WriteLine(i);
        }
    }
}
