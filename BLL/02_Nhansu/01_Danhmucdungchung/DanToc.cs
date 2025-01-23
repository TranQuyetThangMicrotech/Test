using DAL; // references
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class DanToc
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_DANTOC> GetList()
        {
            return db.TB_DANTOC.ToList();
        }

        public TB_DANTOC GetItem(int id)
        {
            return db.TB_DANTOC.FirstOrDefault(x => x.IDDT == id);
        }

        public TB_DANTOC Add(TB_DANTOC item)
        {
            try
            {
                db.TB_DANTOC.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_DANTOC Update(TB_DANTOC id)
        {
            try
            {
                var _item = db.TB_DANTOC.FirstOrDefault(x => x.IDDT == id.IDDT);
                _item.TENDT = id.TENDT;
                db.SaveChanges();
                return id;
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
                var _id = db.TB_DANTOC.FirstOrDefault(x => x.IDDT == id);
                db.TB_DANTOC.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}