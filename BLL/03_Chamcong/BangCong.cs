using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._03_Chamcong
{
    public class BangCong
    {
        // Khởi tạo
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_KYCONG> GetList()
        {
            return db.TB_KYCONG.ToList();
        }

        #endregion Lấy danh sách

        #region Lấy item

        public TB_KYCONG GetItem(int id)
        {
            return db.TB_KYCONG.FirstOrDefault(x => x.IDKC == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        #endregion Lấy item

        #region Thêm, Sửa, Xóa

        public TB_KYCONG Add(TB_KYCONG data)
        {
            try
            {
                db.TB_KYCONG.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_KYCONG Update(TB_KYCONG id)
        {
            try
            {
                var _item = db.TB_KYCONG.FirstOrDefault(x => x.IDKC == id.IDKC);

                _item.IDKC = id.IDKC;
                _item.TENKC = id.TENKC;

                _item.NGAYTINHCONG = id.NGAYTINHCONG;
                _item.NGAYCONGTRONGTHANG = id.NGAYCONGTRONGTHANG;

                _item.KHOA = id.KHOA;
                _item.TRANGTHAI = id.TRANGTHAI;

                _item.NAM = id.NAM;
                _item.THANG = id.THANG;

                _item.IDCTY = id.IDCTY;
                _item.IDNV = id.IDNV;

                _item.UPDATED_BY = id.UPDATED_BY;
                _item.UPDATED_DATE = id.UPDATED_DATE;

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
                var _id = db.TB_KYCONG.FirstOrDefault(x => x.IDKC == id);

                _id.DELETED_BY = iduser;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_KYCONG.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        #endregion Thêm, Sửa, Xóa

        #region Các hàm ngoài lề lấy chuỗi, sinh nhật, lương,..........

        public int GetMaxChuoi()
        {
            var _chuoi = db.TB_KYCONG.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_chuoi != null)
            {
                return _chuoi.IDKC;
            }
            else
            {
                return 00000;
            }
        }

        #endregion Các hàm ngoài lề lấy chuỗi, sinh nhật, lương,..........
    }
}