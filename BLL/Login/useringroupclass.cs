using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Login;
using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL._02_Nhansu._02_Nghiepvu;
using BLL._03_Chamcong;

namespace BLL.Login
{
    public class useringroupclass
    {
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();


        public List<TB_SYS_USER> getlistgroupinuser(int idcty, int iddvi, int iduser)
        {

            List<USER_IN_GROUP> lst = db.USER_IN_GROUP.Where(X => X.MEMBER == iduser && X.IDCTY == idcty && X.IDDVI == iddvi).ToList();
            List<TB_SYS_USER> lstdto = new List<TB_SYS_USER>();
            TB_SYS_USER dto;

            foreach (var item in lst)
            {
                dto = new TB_SYS_USER();
                dto = db.TB_SYS_USER.FirstOrDefault(x => x.IDUSER == item.GROUP);
                lstdto.Add(dto);
            }

            return lstdto;
        }
        


        public List<USER_IN_GROUP> getlistuseringroup(int idcty, int iddvi, int group)
        {
            return db.USER_IN_GROUP.Where(x => x.IDCTY == idcty && x.IDDVI == iddvi && x.GROUP == group && x.ISGROUP == false ).ToList();
        }


        public List<TB_SYS_USER> getgroupall(int idcty, int iddvi)
        {
            return db.TB_SYS_USER.Where(x => x.IDCTY == idcty && x.IDDVI == iddvi  && x.ISGROUP == true).ToList();
        }

        public bool checkgroupinuser(int iduser, int idgroup)
        {
            var gr = db.TB_SYS_GROUP.FirstOrDefault(x=>x.MEMBER == iduser && x.GROUP == idgroup);
            if(gr !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
