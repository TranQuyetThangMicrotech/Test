using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class TonGiao
   
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_TONGIAO> GetList()
        {
            return db.TB_TONGIAO.ToList();
        }

        public TB_TONGIAO GetItem(int id)
        {
            return db.TB_TONGIAO.FirstOrDefault(x => x.IDTG == id);
        }

        public TB_TONGIAO Add(TB_TONGIAO item)
        {
            try
            {
                db.TB_TONGIAO.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public TB_TONGIAO Update(TB_TONGIAO item)
        {
            try
            {
                var _item = db.TB_TONGIAO.FirstOrDefault(x => x.IDTG == item.IDTG);
                _item.TENTG = item.TENTG;
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
                var _id = db.TB_TONGIAO.FirstOrDefault(x => x.IDTG == id);
                db.TB_TONGIAO.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}