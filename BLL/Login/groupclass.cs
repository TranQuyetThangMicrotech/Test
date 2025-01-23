using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Login
{
    public class groupclass
    {
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();


        public TB_SYS_GROUP add(TB_SYS_GROUP item)
        {
            try
            {
                db.TB_SYS_GROUP.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void delete(int user, int group)
        {

            var _id = db.TB_SYS_GROUP.FirstOrDefault(x => x.MEMBER == user && x.GROUP == group);
            if (_id != null)
            {
                try
                {
                    db.TB_SYS_GROUP.Remove(_id);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }

           
        }

    }
}
