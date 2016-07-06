using BoooooJu.Service.DPCore.Base;
using BoooooJu.Service.DPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlWhereTag tagName = new SqlWhereTag();
            Article article = new Article
            {
                Id = 6,
                ReferName = "ggg",
                Content = "test",
                LikeCount = 7
            }; 
            tagName.SqlIN(article.Id, new[] { "3","8", "10"}).SqlEQUALS(article.ReferName, "ggg").SqlIN(article.KeyWords,new string[] { "22","33"});
            Console.Write(tagName.ToWhere());

            Console.ReadKey();
            // BoooooJu.Service.DPCore.Account.AccountService service1 = new BoooooJu.Service.DPCore.Account.AccountService();
            // var foo = service1.FindUserInfoByCellPhone("13058171032"); 
            // var bar = service1.FindUserInfosByRole(new BoooooJu.Service.Core.QueryParameter.Page { PageSize = 10, PageIndex = 1, Sort = BoooooJu.Service.Core.QueryParameter.Base.Sort.Asc }, 2, BoooooJu.Service.Core.Dal.OBModels.User_Rank.Id, null);
            //  var test5 = service1.InsertUser(new User { CreateTime = DateTime.Now, Name = "小明", Sex = 1, Signature = "世界不大" });
            //List<User> users = new List<User> { new User { CreateTime = DateTime.Now, Name = "小明", Sex = 1, Signature = "世界不大" }, new User { CreateTime = DateTime.Now, Name = "小芳", Sex = 2, Signature = "世界这么大" } };
            //   users = new List<User>();
            //service1.InsertUsers(users);



            //BoooooJu.Service.DPCore.Diancan.DiancanService servie = new BoooooJu.Service.DPCore.Diancan.DiancanService();
            //servie.AddUser(new DC_User { Name = "dfgh2s", Password = "qq123123", PCAddress = "192.168.1.5" });
            //var test1 = servie.FindEnableFoods();
            //var test2 = servie.FindUsersByIp("192.168.1.3");
            //var testt3 = servie.GetOrders(new BoooooJu.Service.Core.QueryParameter.Page { PageIndex = 1, PageSize = 2, Sort = BoooooJu.Service.Core.QueryParameter.Base.Sort.Asc }, BoooooJu.Service.Core.Dal.Rank.DC_OBOrder_Rank.FoodId);


            BoooooJu.Service.DPCore.GoodsModule.GoodsService service1 = new BoooooJu.Service.DPCore.GoodsModule.GoodsService();
            var goodsInfo = service1.FindGoodsInfoById(1);
        }
    }
}