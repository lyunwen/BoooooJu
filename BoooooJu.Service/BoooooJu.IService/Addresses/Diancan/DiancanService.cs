using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.Core.Dal.Rank;
using BoooooJu.Service.Core.QueryParameter.Base;
using BoooooJu.Service.Core.Dal.OBModels;
using System.Data.Entity;
using BoooooJu.Service.Core.Contracts.Diancan;

namespace BoooooJu.Service.Core.Addresses.Diancan
{
    public class DiancanService : IDiancanService
    {

        DC_User IDiancanService.AddUser(DC_User user)
        {
            DC_User result = null;
            if (user == null)
                return null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.DC_User.Add(user);
                result.Id = db.SaveChanges();
            }
            return result;
        }


        DC_User IDiancanService.UpdateUser(DC_User user)
        {
            DC_User result = null;
            if (user == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                db.Entry(user).State = EntityState.Modified;
                result.Id = db.SaveChanges();
            }
            return result;
        }

        DC_User IDiancanService.FindUserByIp(string ip)
        {
            DC_User result = null;
            if (string.IsNullOrEmpty(ip))
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.DC_User.FirstOrDefault(x => x.PCAddress == ip);
            }
            return result;
        }

        DC_User IDiancanService.FindUserByName(string name)
        {
            DC_User result = null;
            if (string.IsNullOrEmpty(name))
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.DC_User.FirstOrDefault(x => x.Name == name);
            }
            return result;
        }


        public KeyValuePair<Page, List<OBDC_Order>> GetOrders(Page page, DC_OBOrder_Rank rank)
        {
            KeyValuePair<Page, List<OBDC_Order>> result = new KeyValuePair<Page, List<OBDC_Order>>(page, new List<OBDC_Order>());
            if (page == null)
            {
                return result;
            }
            using (BoooooJuDB db = new BoooooJuDB())
            {
                IQueryable<DC_Order> query = db.DC_Order.Where(x =>true);
                List<DC_Order> oders = null;
                if (page.Sort == Sort.Asc)
                {
                    switch (rank)
                    {
                        case DC_OBOrder_Rank.FoodId: query = query.OrderBy(x => x.FoodId); break;
                        case DC_OBOrder_Rank.FoodName: query = query.OrderBy(x => x.FoodId); break;
                        case DC_OBOrder_Rank.OrderId: query = query.OrderBy(x => x.Id); break;
                        case DC_OBOrder_Rank.OrderTime: query = query.OrderBy(x => x.OrderTime); break;
                        case DC_OBOrder_Rank.UpdateTime: query = query.OrderBy(x => x.UpdateTime); break;
                        case DC_OBOrder_Rank.UserId: query = query.OrderBy(x => x.UserId); break;
                        case DC_OBOrder_Rank.UserName: query = query.OrderBy(x => x.UserId); break;
                        default: query = query.OrderBy(x => x.Id); break;
                    }
                }
                else
                {
                    switch (rank)
                    {
                        case DC_OBOrder_Rank.FoodId: query = query.OrderByDescending(x => x.FoodId); break;
                        case DC_OBOrder_Rank.FoodName: query = query.OrderByDescending(x => x.FoodId); break;
                        case DC_OBOrder_Rank.OrderId: query = query.OrderByDescending(x => x.Id); break;
                        case DC_OBOrder_Rank.OrderTime: query = query.OrderByDescending(x => x.OrderTime); break;
                        case DC_OBOrder_Rank.UpdateTime: query = query.OrderByDescending(x => x.UpdateTime); break;
                        case DC_OBOrder_Rank.UserId: query = query.OrderByDescending(x => x.UserId); break;
                        case DC_OBOrder_Rank.UserName: query = query.OrderByDescending(x => x.UserId); break;
                        default: query = query.OrderByDescending(x => x.Id); break;
                    }
                }
                var datas = query.ToList();
                if (datas != null)
                {
                    result.Key.TotalCounts = datas.Count;
                    if (page.PageSize > 0)
                    {
                        result.Key.TotalPages = result.Key.TotalCounts / page.PageSize + (result.Key.TotalCounts % page.PageSize > 0 ? 1 : 0);
                    }
                    var value = datas.Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
                    oders = new List<DC_Order>(value);
                    if (oders != null)
                        foreach (var foo in oders)
                        {
                            result.Value.Add(new OBDC_Order
                            {
                                OrderId = foo.Id,
                                OrderTime = foo.OrderTime,
                                UpdateTime = foo.UpdateTime,
                                FoodId = foo.FoodId,
                                FoodName = db.DC_Food.FirstOrDefault(x => x.Id == foo.FoodId).Name,
                                UserId = foo.UserId,
                                UserName = db.DC_User.FirstOrDefault(x => x.Id == foo.UserId).Name
                            });
                        }
                }
            }
            return result;
        }

        DC_Order IDiancanService.PlaceOrder(DC_Order order)
        {
            DC_Order result = null;
            if (order == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var todayPreOrders = db.DC_Order.Where(x => x.UpdateTime > DateTime.Today).ToList();
                if (todayPreOrders != null)
                {
                    foreach (var foo in todayPreOrders)
                    {
                        db.Entry(foo).State = EntityState.Deleted;
                    }
                }
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
                result = order;
            }
            return result;
        }

        DC_Order IDiancanService.UpdateOrder(DC_Order order)
        {
            DC_Order result = null;
            if (order == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                result = order;
            }
            return result;
        }

        List<DC_Food> IDiancanService.FindEnableFoods()
        {
            List<DC_Food> result = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.DC_Food.Where(x => x.Enable == true&&x.IsDeleted==false).ToList();
            }
            return result;
        }

        DC_Order IDiancanService.GetTodayOrder(int userId)
        {
            DC_Order result = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var nextDay = DateTime.Today.AddDays(1);
                result = db.DC_Order.FirstOrDefault(x => x.UserId == userId && x.UpdateTime > DateTime.Today && x.UpdateTime < nextDay);
            }
            return result;
        }

        bool IDiancanService.CancelOrder(int orderId)
        {
            bool result = false;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                DC_Order order = db.DC_Order.FirstOrDefault(x => x.Id == orderId);
                if (order != null)
                { 
                    db.Entry(order).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                result = true;
            }
            return result;
        }
    }
}
