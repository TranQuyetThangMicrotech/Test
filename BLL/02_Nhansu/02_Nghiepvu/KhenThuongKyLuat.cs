using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._02_Nghiepvu
{
    public class KhenThuongKyLuat
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách theo kiểu khen thưởng hoặc kỷ luật
        public List<TB_KHENTHUONG_KYLUAT> GetList(int loai)
        {
            return db.TB_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
        }

        public List<KhenThuongKyLuatDTO> GetListFull(int loai)
        {
            var lstkhenthuongkyluat = db.TB_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();

            List<KhenThuongKyLuatDTO> lstkhenthuongkyluatdto = new List<KhenThuongKyLuatDTO>();
            KhenThuongKyLuatDTO dto;

            foreach (var item in lstkhenthuongkyluat)
            {
                dto = new KhenThuongKyLuatDTO();
                dto.IDKTKL = item.IDKTKL;
                dto.NGAY = item.NGAY;
                dto.LYDO = item.LYDO;
                dto.NOIDUNG = item.NOIDUNG;
                dto.TUNGAY = item.TUNGAY;
                dto.DENNGAY = item.DENNGAY;
                dto.LOAI = item.LOAI;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;
                lstkhenthuongkyluatdto.Add(dto);
            }
            return lstkhenthuongkyluatdto;
        }

        // Lấy giá trị id
        public TB_KHENTHUONG_KYLUAT GetItem(string id)
        {
            return db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.IDKTKL == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_KHENTHUONG_KYLUAT Add(TB_KHENTHUONG_KYLUAT item)
        {
            try
            {
                db.TB_KHENTHUONG_KYLUAT.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_KHENTHUONG_KYLUAT Update(TB_KHENTHUONG_KYLUAT id)
        {
            try
            {
                var _item = db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.IDKTKL == id.IDKTKL);

                _item.NGAY = id.NGAY;
                _item.LOAI = id.LOAI;
                _item.NOIDUNG = id.NOIDUNG;
                _item.LYDO = id.LYDO;
                _item.TUNGAY = id.TUNGAY;
                _item.DENNGAY = id.DENNGAY;
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
                var _id = db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.IDKTKL == id);
                _id.DELETED_BY = idnv;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_KHENTHUONG_KYLUAT.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string GetMaxChuoi(int loai)
        {
            var _chuoi = db.TB_KHENTHUONG_KYLUAT.Where(b => b.LOAI == loai).OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_chuoi != null)
            {
                return _chuoi.IDKTKL;
            }
            else
            {
                return "00000";
            }
        }
    }
}