using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class CongTy
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách
        public List<TB_CONGTY> GetList()
        {
            return db.TB_CONGTY.ToList();
        }

        // Lấy giá trị id
        public TB_CONGTY GetItem(int id)
        {
            return db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_CONGTY Add(TB_CONGTY item)
        {
            try
            {
                db.TB_CONGTY.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_CONGTY Update(TB_CONGTY id)
        {
            try
            {
                var _item = db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == id.IDCTY);
                _item.TENCTY = id.TENCTY;
                _item.DIACHI = id.DIACHI;
                _item.EMAIL = id.EMAIL;
                _item.DIENTHOAI = id.DIENTHOAI;
                db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa
        public void Delete(int id)
        {
            try
            {
                var _id = db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == id);
                db.TB_CONGTY.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}