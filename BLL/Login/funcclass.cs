using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Login
{
    public class funcclass
    {
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_SYS_FUNC> getparent()
        {
            return db.TB_SYS_FUNC.Where(x=>x.ISGROUP == true && x.MENU== true).OrderBy(s=>s.SORT).ToList();
        }

        public List<TB_SYS_FUNC> getchild(string parent)
        {
            return db.TB_SYS_FUNC.Where(x => x.ISGROUP == true && x.MENU == false && x.PARENT == parent).OrderBy(s => s.SORT).ToList();
        }
    }
}
