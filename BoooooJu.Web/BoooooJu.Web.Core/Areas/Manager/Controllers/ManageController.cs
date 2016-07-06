//using BoooooJu.Web.Core.Areas.Manager.ViewModels;
//using BoooooJu.Web.Core.Clients;
//using BoooooJu.Web.Core.Controllers.Base;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;

//namespace BoooooJu.Web.Core.Areas.Manager.Controllers
//{
//    public class ManageController : BoooooJuController
//    {
//        public ActionResult AgentManage()
//        { 
//            return View();
//        }
//        public JsonResult AgentManagePage(int pageIndex, string orderBy = "Id", int sort = 0, string nickName = null)
//        { 
//            var agentsPage = new KeyValuePair<Page, UserInfo[]>();
//            var page = new Page { PageIndex = pageIndex, PageSize = 5, Sort = sort == 0 ? Sort.Asc : Sort.Desc };
//            int role = (int)BoooooJuPermit.Agent;
//            switch (orderBy)
//            {
//                case "Id":
//                    agentsPage =new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfosByRole(page, role, User_Rank.Id, nickName);
//                    break;
//                case "CreateTime":
//                    agentsPage = new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfosByRole(page, role, User_Rank.CreateTime, nickName);
//                    break;
//                case "NickName":
//                    agentsPage = new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfosByRole(page, role, User_Rank.NickName, nickName);
//                    break;
//                case "Sex":
//                    agentsPage = new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfosByRole(page, role, User_Rank.Sex, nickName);
//                    break;
//                default:
//                    agentsPage = new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfosByRole(page, role, User_Rank.Id, nickName);
//                    break;
//            }
//            KeyValuePair<Page, List<AgentModel>> model = new KeyValuePair<Page, List<AgentModel>>(agentsPage.Key, new List<AgentModel>());
//            if (agentsPage.Value != null)
//            {
//                model.Value.AddRange(agentsPage.Value.Select(x =>
//                {
//                    AgentModel result = null;
//                    if (x == null)
//                        return result;
//                    result = new AgentModel
//                    {
//                        Id = x.UserId,
//                        NickName = x.UserName,
//                        CreateTime = x.CreateTime.ToString("yyyy-MM-dd"),
//                        Sex = x.Sex.ToString()
//                    };
//                    return result;
//                }).ToList());
//            }
//            return Json(model);
//        }
//    }
//}
