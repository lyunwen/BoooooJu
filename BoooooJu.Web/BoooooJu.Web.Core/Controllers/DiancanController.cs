//using BoooooJu.Web.Core.Clients;
//using BoooooJu.Web.Core.DiancanService;
//using BoooooJu.Web.Core.Filters;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Web.Mvc;

//namespace BoooooJu.Web.Core.Controllers
//{
//    public class DiancanController : Base.BoooooJuController
//    {
//        private IDiancanService _diancanClient = new UnityBaseService<IDiancanService>().GetClient();

//        [HttpPost]
//        public JsonResult SignIn(string accountName, string password)
//        {
//            var user = _diancanClient.FindUserByName(accountName);
//            if (user != null && user.Password == password)
//            {
//                Session[Base.SessionConfig.BoooooJuer] = new Base.BoooooJuer
//                {
//                    Id = user.Id,
//                    LogonIp = user.PCAddress,
//                    NickName = user.Name,
//                    Logon = DateTime.Now,
//                    Permits = (int)Base.BoooooJuPermit.Diancan
//                };
//                return Json(new { success = true });
//            }
//            else
//            {
//                return Json(new { success = false });
//            }
//        }
//        [HttpPost]
//        public JsonResult Register(string accountName, string password)
//        {
//            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
//                return Json(new { success = false });
//            if (_diancanClient.FindUserByName(accountName) != null)
//                return Json(new { success = false });
//            var user = _diancanClient.AddUser(new DC_User
//            {
//                Name = accountName,
//                Password = password,
//                PCAddress = GetRealIP()
//            });
//            if (user != null)
//            {
//                return Json(new { success = true });
//            }
//            else
//            {
//                return Json(new { success = false });
//            }
//        }


//        public ViewResult Order()
//        {
//            DC_Order todayOrder = null;
//            DC_User[] users = new UnityBaseService<IDiancanService>().GetClient().FindUsersByIp(GetRealIP());
           
//            ViewBag.TodayOrder = todayOrder;
//            ViewBag.User = null;
//            ViewBag.Foods = new UnityBaseService<IDiancanService>().GetClient().FindEnableFoods();
//            return View();
//        }
//        public JsonResult OrderPage(int pageIndex = 1, string orderBy = "OrderId", int sort = 0)
//        {
//            var ordersPage = new KeyValuePair<Page, OBDC_Order[]>();
//            var page = new Page { PageIndex = pageIndex, PageSize = 10, Sort = sort == 0 ? Sort.Asc : Sort.Desc };
//            switch (orderBy)
//            {
//                case "OrderId":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.OrderId); break;
//                case "OrderTime":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.OrderTime); break;
//                case "UpdateTime":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.UpdateTime); break;
//                case "UserId":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.UserId); break;
//                case "UserName":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.UserName); break;
//                case "FoodId":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.FoodId); break;
//                case "FoodName":
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.FoodName); break;
//                default:
//                    ordersPage = new UnityBaseService<IDiancanService>().GetClient().GetOrders(page, DC_OBOrder_Rank.OrderId); break;
//            }
//            return Json(ordersPage);
//        }
//        public JsonResult Register(string name)
//        {
//            IDiancanService DiancanClient = new UnityBaseService<IDiancanService>().GetClient();
//            DC_User user = DiancanClient.AddUser(new DC_User
//            {
//                Name = name,
//                PCAddress = GetRealIP()
//            });
//            return Json(new { success = (user != null) });
//        }

//        public JsonResult FindUser(string name)
//        {
//            var diancanClient = new UnityBaseService<IDiancanService>().GetClient();
//            var user = diancanClient.FindUserByName("name");
//            if (user == null)
//            {
//                return Json(new { success = false });
//            }
//            else
//            {
//                user.PCAddress = GetRealIP();
//                diancanClient.UpdateUserAsync(user);
//                return Json(new { success = true });
//            }
//        }

//        [BoAuthorize(Base.BoooooJuPermit.Diancan), HttpPost]
//        public JsonResult PlaceOrder(int foodId)
//        {
//            var diancanClient = new UnityBaseService<IDiancanService>().GetClient();
//            DC_Order order = diancanClient.PlaceOrder(new DC_Order
//            {
//                FoodId = foodId,
//                OrderTime = DateTime.Now,
//                UserId = boooooJuer.Id,
//                UpdateTime = DateTime.Now
//            });
//            return Json(new { success = (order != null) });
//        }

//        [BoAuthorize(Base.BoooooJuPermit.Diancan), HttpPost]
//        public JsonResult CanCelOrder()
//        {
//            var todayOrder = _diancanClient.GetTodayOrder(boooooJuer.Id);
//            if (todayOrder != null)
//            {
//                var su = _diancanClient.DeleteOrderById(todayOrder.Id);
//            }
//            return Json(new { success = true });
//        }




//        private string GetRealIP()
//        {
//            string result = String.Empty;
//            result = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
//            //可能有代理   
//            if (!string.IsNullOrWhiteSpace(result))
//            {
//                //没有"." 肯定是非IP格式  
//                if (result.IndexOf(".") == -1)
//                {
//                    result = null;
//                }
//                else
//                {
//                    //有","，估计多个代理。取第一个不是内网的IP。  
//                    if (result.IndexOf(",") != -1)
//                    {
//                        result = result.Replace(" ", string.Empty).Replace("\"", string.Empty);

//                        string[] temparyip = result.Split(",;".ToCharArray());

//                        if (temparyip != null && temparyip.Length > 0)
//                        {
//                            for (int i = 0; i < temparyip.Length; i++)
//                            {
//                                //找到不是内网的地址  
//                                if (IsIPAddress(temparyip[i]) && temparyip[i].Substring(0, 3) != "10." && temparyip[i].Substring(0, 7) != "192.168" && temparyip[i].Substring(0, 7) != "172.16.")
//                                {
//                                    return temparyip[i];
//                                }
//                            }
//                        }
//                    }
//                    //代理即是IP格式  
//                    else if (IsIPAddress(result))
//                    {
//                        return result;
//                    }
//                    //代理中的内容非IP  
//                    else
//                    {
//                        result = null;
//                    }
//                }
//            }

//            if (string.IsNullOrWhiteSpace(result))
//            {
//                result = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
//            }

//            if (string.IsNullOrWhiteSpace(result))
//            {
//                result = System.Web.HttpContext.Current.Request.UserHostAddress;
//            }
//            return result;
//        }

//        private bool IsIPAddress(string str)
//        {
//            if (string.IsNullOrWhiteSpace(str) || str.Length < 7 || str.Length > 15)
//                return false;

//            string regformat = @"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})";
//            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
//            return regex.IsMatch(str);
//        }

//    }
//}
