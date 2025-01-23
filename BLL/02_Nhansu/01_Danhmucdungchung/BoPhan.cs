using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class BoPhan
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_BOPHAN> GetList()
        {
            return db.TB_BOPHAN.ToList();
        }

        public TB_BOPHAN GetItem(int id)
        {
            return db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == id); 
        }

        public TB_BOPHAN Add(TB_BOPHAN item)
        {
            try
            {
                db.TB_BOPHAN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_BOPHAN Update(TB_BOPHAN id)
        {
            try
            {
                var _item = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == id.IDBP);
                _item.TENBP = id.TENBP;
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
                var _id = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == id);
                db.TB_BOPHAN.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}