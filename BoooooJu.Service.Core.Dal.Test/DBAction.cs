using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoooooJu.Service.Core.Dal.Test
{
    [TestClass]
    public class DBAction
    {
        [TestMethod]
        public void DataInsert()
        {
            using (BoooooJuDB db = new BoooooJuDB())
            {
                User user = new User
                {
                    NickName = "zaizaiyou",
                    Signature = "世界那么大",
                    Sex = 2,
                    CreateTime = DateTime.Now,
                    Role = 0
                };
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
