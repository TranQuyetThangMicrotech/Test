using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Login
{
    public class usernotingroupclass
    {
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();


        //public List<USER_NOTIN_GROUP> getlistgroupnotinuser(int idcty, int iddvi)
        //{
        //    return db.USER_NOTIN_GROUP.Where(x => x.IDCTY == idcty && x.IDDVI == iddvi && x.ISGROUP == true).ToList();
        //}


        public List<USER_NOTIN_GROUP> getlistusernotingroup(int idcty, int iddvi)
        {
            return db.USER_NOTIN_GROUP.Where(x=> x.IDCTY == idcty && x.IDDVI == iddvi && x.ISGROUP == false ).ToList();
        }

        //&& x.DISABLE == false
    }
}
