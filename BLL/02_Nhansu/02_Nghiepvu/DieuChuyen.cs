using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._02_Nghiepvu
{
    public class DieuChuyen
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách theo kiểu khen thưởng hoặc kỷ luật
        public List<TB_DIEUCHUYEN> GetList()
        {
            return db.TB_DIEUCHUYEN.ToList();
        }

        public List<DieuChuyenDTO> GetListFull()
        {
            var lstdieuchuyen = db.TB_DIEUCHUYEN.ToList();

            List<DieuChuyenDTO> lstdieuchuyendto = new List<DieuChuyenDTO>();
            DieuChuyenDTO dto;

            foreach (var item in lstdieuchuyen)
            {
                dto = new DieuChuyenDTO();
                dto.IDDC = item.IDDC;
                dto.NGAY = item.NGAY;
                dto.LYDO = item.LYDO;
                dto.NOIDUNG = item.NOIDUNG;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;

                dto.IDBP = item.IDBP;
                var pb = db.TB_BOPHAN.FirstOrDefault(x => x.IDBP == item.IDBP);
                dto.TENBP = pb.TENBP;

                dto.IDBP2 = item.IDBP2;
                var pb2 = db.TB_BOPHAN.FirstOrDefault(y => y.IDBP == item.IDBP2);
                dto.TENBP2 = pb2.TENBP;

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
        public TB_DIEUCHUYEN GetItem(string id)
        {
            return db.TB_DIEUCHUYEN.FirstOrDefault(x => x.IDDC == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_DIEUCHUYEN Add(TB_DIEUCHUYEN item)
        {
            try
            {
                db.TB_DIEUCHUYEN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_DIEUCHUYEN Update(TB_DIEUCHUYEN id)
        {
            try
            {
                var _item = db.TB_DIEUCHUYEN.FirstOrDefault(x => x.IDDC == id.IDDC);

                _item.NGAY = id.NGAY;

                _item.NOIDUNG = id.NOIDUNG;
                _item.LYDO = id.LYDO;

                _item.IDNV = id.IDNV;
                _item.UPDATED_BY = id.UPDATED_BY;
                _item.UPDATED_DATE = id.UPDATED_DATE;

                _item.IDBP2 = id.IDBP2;
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
                var _id = db.TB_DIEUCHUYEN.FirstOrDefault(x => x.IDDC == id);
                _id.DELETED_BY = idnv;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_DIEUCHUYEN.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string GetMaxChuoi()
        {
            var _chuoi = db.TB_DIEUCHUYEN.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_chuoi != null)
            {
                return _chuoi.IDDC;
            }
            else
            {
                return "00000";
            }
        }
    }
}