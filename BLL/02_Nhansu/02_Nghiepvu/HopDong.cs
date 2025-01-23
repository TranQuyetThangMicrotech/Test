using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._02_Nghiepvu
{
    public class HopDong
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách
        public List<TB_HOPDONG> GetList()
        {
            return db.TB_HOPDONG.ToList();
        }

        public List<HopDongDTO> GetListFull()
        {
            var lsthopdong = db.TB_HOPDONG.ToList();

            List<HopDongDTO> lsthopdongdto = new List<HopDongDTO>();
            HopDongDTO hd;

            foreach (var item in lsthopdong)
            {
                hd = new HopDongDTO();
                hd.IDHD = item.IDHD;
                hd.NGAYBATDAU = item.NGAYBATDAU;
                hd.NGAYKETTHUC = item.NGAYKETTHUC;
                hd.NGAYKY = item.NGAYKY;
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.IDNV = item.IDNV;
                hd.IDCTY = item.IDCTY;
                hd.NOIDUNG = item.NOIDUNG;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.THOIHAN = item.THOIHAN;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                hd.TENNV = nv.TENNV;
                lsthopdongdto.Add(hd);
            }
            return lsthopdongdto;
        }

        // Lấy giá trị id
        public TB_HOPDONG GetItem(string id)
        {
            return db.TB_HOPDONG.FirstOrDefault(x => x.IDHD == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        public List<HopDongDTO> GetItemFull(string id)
        {
            List<TB_HOPDONG> lsthd = db.TB_HOPDONG.Where(x => x.IDHD == id).ToList();
            List<HopDongDTO> lsthddto = new List<HopDongDTO>();

            HopDongDTO hd;

            foreach (var item in lsthd)
            {
                hd = new HopDongDTO();
                hd.IDHD = item.IDHD;
                hd.NGAYBATDAU = item.NGAYBATDAU;
                hd.NGAYKETTHUC = item.NGAYKETTHUC;
                hd.NGAYKY = item.NGAYKY;
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.IDNV = item.IDNV;
                hd.IDCTY = item.IDCTY;
                hd.NOIDUNG = item.NOIDUNG;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.THOIHAN = item.THOIHAN;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                hd.TENNV = nv.TENNV;
                lsthddto.Add(hd);
            }
            return lsthddto;
        }

        // Thêm
        public TB_HOPDONG Add(TB_HOPDONG item)
        {
            try
            {
                db.TB_HOPDONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_HOPDONG Update(TB_HOPDONG id)
        {
            try
            {
                var _item = db.TB_HOPDONG.FirstOrDefault(x => x.IDHD == id.IDHD);
                _item.NGAYBATDAU = id.NGAYBATDAU;
                _item.NGAYKETTHUC = id.NGAYKETTHUC;
                _item.NOIDUNG = id.NOIDUNG;
                _item.LANKY = id.LANKY;
                _item.THOIHAN = id.THOIHAN;
                _item.HESOLUONG = id.HESOLUONG;
                _item.UPDATED_BY = id.UPDATED_BY;
                _item.UPDATED_DATE = id.UPDATED_DATE;
                _item.NGAYKY = id.NGAYKY;

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
                var _id = db.TB_HOPDONG.FirstOrDefault(x => x.IDHD == id);
                _id.DELETED_BY = idnv;
                _id.UPDATED_DATE = DateTime.Now;
                //db.TB_HOPDONG.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string GetMaxChuoi()
        {
            var _hd = db.TB_HOPDONG.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.IDHD;
            }
            else
            {
                return "00000";
            }
        }

        public List<HopDongDTO> GetLenLuong()
        {
            var lsthopdong = db.TB_HOPDONG.Where(x => (x.NGAYBATDAU.Value.Month - DateTime.Now.Month) == 0 && (DateTime.Now.Year - x.NGAYBATDAU.Value.Year) == 2).ToList();

            List<HopDongDTO> lsthopdongdto = new List<HopDongDTO>();
            HopDongDTO hd;

            foreach (var item in lsthopdong)
            {
                hd = new HopDongDTO();
                hd.IDHD = item.IDHD;
                hd.NGAYBATDAU = item.NGAYBATDAU;
                hd.NGAYKETTHUC = item.NGAYKETTHUC;
                hd.NGAYKY = item.NGAYKY;
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.IDNV = item.IDNV;
                hd.IDCTY = item.IDCTY;
                hd.NOIDUNG = item.NOIDUNG;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.THOIHAN = item.THOIHAN;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                hd.TENNV = nv.TENNV;
                lsthopdongdto.Add(hd);
            }
            return lsthopdongdto;
        }
    }
}