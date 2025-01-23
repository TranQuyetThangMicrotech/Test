using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._02_Nghiepvu
{
    public class ThoiViec
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách theo kiểu khen thưởng hoặc kỷ luật
        public List<TB_THOIVIEC> GetList()
        {
            return db.TB_THOIVIEC.ToList();
        }

        public List<ThoiViecDTO> GetListFull()
        {
            var lstthoiviec = db.TB_THOIVIEC.ToList();

            List<ThoiViecDTO> lstthoiviecdto = new List<ThoiViecDTO>();
            ThoiViecDTO dto;

            foreach (var item in lstthoiviec)
            {
                dto = new ThoiViecDTO();
                dto.IDTV = item.IDTV;
                dto.NGAYNGHI = item.NGAYNGHI;
                dto.NGAYNOPDON = item.NGAYNOPDON;
                dto.LYDO = item.LYDO;
                dto.NOIDUNG = item.NOIDUNG;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;

                ;

                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;

                lstthoiviecdto.Add(dto);
            }
            return lstthoiviecdto;
        }

        // Lấy giá trị id

        public TB_THOIVIEC GetItem(string id)
        {
            return db.TB_THOIVIEC.FirstOrDefault(x => x.IDTV == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_THOIVIEC Add(TB_THOIVIEC item)
        {
            try
            {
                db.TB_THOIVIEC.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_THOIVIEC Update(TB_THOIVIEC id)
        {
            try
            {
                var _item = db.TB_THOIVIEC.FirstOrDefault(x => x.IDTV == id.IDTV);

                _item.NGAYNGHI = id.NGAYNGHI;
                _item.NGAYNOPDON = id.NGAYNOPDON;

                _item.NOIDUNG = id.NOIDUNG;
                _item.LYDO = id.LYDO;

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

        // Xóa
        public void Delete(string id, int idnv)
        {
            try
            {
                var _id = db.TB_THOIVIEC.FirstOrDefault(x => x.IDTV == id);
                _id.DELETED_BY = idnv;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_THOIVIEC.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string GetMaxChuoi()
        {
            var _chuoi = db.TB_THOIVIEC.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_chuoi != null)
            {
                return _chuoi.IDTV;
            }
            else
            {
                return "00000";
            }
        }
    }
}