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
                    Name = "世界好大",
                    Signature = "世界那么大",
                    Sex = 2,
                    CreateTime = DateTime.Now
                };
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
