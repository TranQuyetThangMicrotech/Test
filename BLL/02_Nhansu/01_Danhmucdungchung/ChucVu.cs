using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class ChucVu
    {

        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_CHUCVU> GetList()
        {
            return db.TB_CHUCVU.ToList();
        }

        public TB_CHUCVU GetItem(int id)
        {
            return db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == id); 
        }

        public TB_CHUCVU Add(TB_CHUCVU item)
        {
            try
            {
                db.TB_CHUCVU.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_CHUCVU Update(TB_CHUCVU id)
        {
            try
            {
                var _item = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == id.IDCV);
                _item.TENCV = id.TENCV;
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
                var _id = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == id);
                db.TB_CHUCVU.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}