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
                    Account = "lyw2016"+new Random().Next(1000,9999),
                    CellPhone = "13058171032",
                    CellPhoneValidate = false,
                    EmailValidate = false,
                    NickName = "zaizaiyou",
                    Password = "qq123123",
                    PasswordSalt = "0",
                    PasswordSaltType = 0,
                    Signature = "世界那么大",
                    Sex = 2
                };
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
