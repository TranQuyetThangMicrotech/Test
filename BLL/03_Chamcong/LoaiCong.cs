using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._03_Chamcong
{
    public class LoaiCong
    {
        // Khởi tạo
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_LOAICONG> GetList()
        {
            return db.TB_LOAICONG.ToList();
        }

        #endregion Lấy danh sách

        #region Lấy item

        public TB_LOAICONG GetItem(int id)
        {
            return db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        #endregion Lấy item

        #region Thêm, Sửa, Xóa

        public TB_LOAICONG Add(TB_LOAICONG data)
        {
            try
            {
                db.TB_LOAICONG.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_LOAICONG Update(TB_LOAICONG id)
        {
            try
            {
                var _item = db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == id.IDLC);

                _item.IDLC = id.IDLC;
                _item.HESO = id.HESO;
                _item.TENLC = id.TENLC;

                //_item.UPDATED_BY = id.UPDATED_BY;
                //_item.UPDATED_DATE = id.UPDATED_DATE;

                db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id, int iduser)
        {
            try
            {
                var _id = db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == id);

                //_id.DELETED_BY = iduser;
                //_id.DELETED_DATE = DateTime.Now;
                //db.TB_LOAICONG.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        #endregion Thêm, Sửa, Xóa
    }
}