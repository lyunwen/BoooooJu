using DpperDemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDapper
{
    class Program
    {
        static void Main(string[] args)
        {
     //   DapperTest.InsertObject("Data Source=120.24.185.131;Initial Catalog=BoooooJu;;user id=booooojuer;password=T23eW@nnn;MultipleActiveResultSets=True;");
           //DapperTest.OneToOne("Data Source=120.24.185.131;Initial Catalog=BoooooJu;;user id=booooojuer;password=T23eW@nnn;MultipleActiveResultSets=True;");
           //DapperTest.OneToMany("Data Source=120.24.185.131;Initial Catalog=BoooooJu;;user id=booooojuer;password=T23eW@nnn;MultipleActiveResultSets=True;");
        }
        /// <summary>
        /// 匹配方法
        /// </summary>
        /// <param name="testAtcg">测试序列</param>
        /// <param name="standerAtcg">标准序列</param>
        /// <returns>1.最高得分值2.对应的实验序列的最佳排序3.对应标准序列的位置序列</returns>
        public static Tuple<double,string,string>   Match(string testAtcg, string standerAtcg)
        {
            if (testAtcg == null || standerAtcg == null||standerAtcg.Length<testAtcg.Length)
            {
                return null;
            }
            int forSum = standerAtcg.Length - testAtcg.Length + 1;
            for(int i = 0; i < forSum; forSum++)
            {

            }
            //计算部分
            return new Tuple<double, string, string>(2.0, "ATCGGCATTGCTAGCTAG", "ATCGACATTGCTAGCTAG");
        }
    }
}
