using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._03_Chamcong
{
    public class LoaiCa
    {
        // Khởi tạo
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_LOAICA> GetList()
        {
            return db.TB_LOAICA.ToList();
        }

        #endregion Lấy danh sách

        #region Lấy item

        public TB_LOAICA GetItem(int id)
        {
            return db.TB_LOAICA.FirstOrDefault(x => x.IDLCA == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        #endregion Lấy item

        #region Thêm, Sửa, Xóa

        public TB_LOAICA Add(TB_LOAICA data)
        {
            try
            {
                db.TB_LOAICA.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_LOAICA Update(TB_LOAICA id)
        {
            try
            {
                var _item = db.TB_LOAICA.FirstOrDefault(x => x.IDLCA == id.IDLCA);

                _item.IDLCA = id.IDLCA;
                _item.HESO = id.HESO;
                _item.TENLCA = id.TENLCA;

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
                var _id = db.TB_LOAICA.FirstOrDefault(x => x.IDLCA == id);

                //_id.DELETED_BY = iduser;
                //_id.DELETED_DATE = DateTime.Now;
                db.TB_LOAICA.Remove(_id);
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