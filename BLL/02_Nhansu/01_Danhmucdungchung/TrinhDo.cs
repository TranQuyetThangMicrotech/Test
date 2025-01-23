using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class TrinhDo
    {
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        public List<TB_TRINHDO> GetList()
        {
            return db.TB_TRINHDO.ToList();
        }

        public TB_TRINHDO GetItem(int id)
        {
            return db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == id);
        }

        public TB_TRINHDO Add(TB_TRINHDO item)
        {
            try
            {
                db.TB_TRINHDO.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_TRINHDO Update(TB_TRINHDO item)
        {
            try
            {
                var _item = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == item.IDTD);
                _item.TENTD = item.TENTD;
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
                var _id = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == id);
                db.TB_TRINHDO.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}