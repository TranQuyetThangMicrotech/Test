using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class PhongBan
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_PHONGBAN> GetList()
        {
            return db.TB_PHONGBAN.ToList();
        }

        public TB_PHONGBAN GetItem(int id)
        {
            return db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }

        public TB_PHONGBAN Add(TB_PHONGBAN item)
        {
            try
            {
                db.TB_PHONGBAN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_PHONGBAN Update(TB_PHONGBAN item)
        {
            try
            {
                var _item = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == item.IDPB);
                _item.TENPB = item.TENPB;
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _id = db.TB_PHONGBAN.First(x => x.IDPB == id);
                db.TB_PHONGBAN.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}