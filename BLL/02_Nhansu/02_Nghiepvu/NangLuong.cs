using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._02_Nghiepvu
{
    public class NangLuong
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách theo kiểu khen thưởng hoặc kỷ luật
        public List<TB_NANGLUONG> GetList()
        {
            return db.TB_NANGLUONG.ToList();
        }

        public List<NangLuongDTO> GetListFull()
        {
            var lstdieuchuyen = db.TB_NANGLUONG.ToList();

            List<NangLuongDTO> lstdieuchuyendto = new List<NangLuongDTO>();
            NangLuongDTO dto;

            foreach (var item in lstdieuchuyen)
            {
                dto = new NangLuongDTO();
                dto.IDNANGLUONG = item.IDNANGLUONG;
                dto.NGAYKY = item.NGAYKY;
                dto.NGAYLENLUONG = item.NGAYLENLUONG;
                dto.NOIDUNG = item.NOIDUNG;
                dto.HESOLUONGMOI = item.HESOLUONGMOI;
                dto.HESOLUONGCU = item.HESOLUONGCU;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;

                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;

                lstdieuchuyendto.Add(dto);
            }
            return lstdieuchuyendto;
        }

        // Lấy giá trị id
        public TB_NANGLUONG GetItem(string id)
        {
            return db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_NANGLUONG Add(TB_NANGLUONG item)
        {
            try
            {
                db.TB_NANGLUONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_NANGLUONG Update(TB_NANGLUONG id)
        {
            try
            {
                var _item = db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id.IDNANGLUONG);

                _item.IDHD = id.IDHD;

                _item.HESOLUONGCU = id.HESOLUONGCU;
                _item.HESOLUONGMOI = id.HESOLUONGMOI;

                _item.NGAYKY = id.NGAYKY;
                _item.NGAYLENLUONG = id.NGAYLENLUONG;
                _item.NOIDUNG = id.NOIDUNG;

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
                var _id = db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id);
                _id.DELETED_BY = idnv;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_NANGLUONG.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string GetMaxChuoi()
        {
            var _chuoi = db.TB_NANGLUONG.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_chuoi != null)
            {
                return _chuoi.IDNANGLUONG;
            }
            else
            {
                return "00000";
            }
        }
    }
}