using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; // phải using tầng data access layer
using BLL.DTO; // phải using thư viện chưa DTO
namespace BLL // using
{
    public class templateclass
    {
        // Khởi tạo
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_NANGLUONG> GetList()
        {
            return db.TB_NANGLUONG.ToList();
        }

        //public List<TB_NANGLUONG> GetList(int loai)
        //{
        //    return db.TB_NANGLUONG.Where(x=>x.LOAI === loai).ToList();
        //}

        public List<NangLuongDTO> GetListFull()
        {
            var lst = db.TB_NANGLUONG.ToList();

            List<NangLuongDTO> lstdto = new List<NangLuongDTO>();
            NangLuongDTO dto;

            foreach (var item in lst)
            {
                dto = new NangLuongDTO();
                
                dto.IDNANGLUONG = item.IDNANGLUONG;
                dto.NGAYKY = item.NGAYKY;
                dto.NGAYLENLUONG = item.NGAYLENLUONG;
                dto.NOIDUNG = item.NOIDUNG;
                dto.HESOLUONGMOI = item.HESOLUONGMOI;
                dto.HESOLUONGCU = item.HESOLUONGCU;

                // Khác với getlist bình thường, hứng thêm các trường mới-
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;



                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;

                lstdto.Add(dto);
            }
            return lstdto;
        }


        #endregion


        #region Lấy item

        //public TB_NANGLUONG GetItem(int id)
        //{
        //    return db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id); // lấy giá trị đầu tiên trùng với id được gửi vô

        //}

        public TB_NANGLUONG GetItem(string id)
        {
            return db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id); // lấy giá trị đầu tiên trùng với id được gửi vô

        }

        public List<HopDongDTO> GetItemFull(string id)
        {

            var lst = db.TB_HOPDONG.Where(x => x.IDHD == id).ToList();

            List<HopDongDTO> lstdto = new List<HopDongDTO>();
            HopDongDTO dto;

            foreach (var item in lst)
            {
                dto = new HopDongDTO();
                dto.IDHD = item.IDHD;
                dto.NGAYBATDAU = item.NGAYBATDAU;
                dto.NGAYKETTHUC = item.NGAYKETTHUC;
                dto.NGAYKY = item.NGAYKY;
                dto.LANKY = item.LANKY;
                dto.HESOLUONG = item.HESOLUONG;
                dto.IDNV = item.IDNV;
                dto.IDCTY = item.IDCTY;
                dto.NOIDUNG = item.NOIDUNG;


                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;
                dto.THOIHAN = item.THOIHAN;

                // full
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
                dto.TENNV = nv.TENNV;

                lstdto.Add(dto);
            }
            return lstdto;
        }

        #endregion


        #region Thêm, Sửa, Xóa

        public TB_NANGLUONG Add(TB_NANGLUONG data)
        {
            try
            {
                db.TB_NANGLUONG.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

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

        public void Delete(string id, int iduser)
        {
            try
            {
                var _id = db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id);

                _id.DELETED_BY = iduser;
                _id.DELETED_DATE = DateTime.Now;
                //db.TB_NANGLUONG.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //public void Delete(int id, int iduser)
        //{
        //    try
        //    {
        //        var _id = db.TB_NANGLUONG.FirstOrDefault(x => x.IDNANGLUONG == id);

        //        _id.DELETED_BY = iduser;
        //        _id.DELETED_DATE = DateTime.Now;
        //        //db.TB_NANGLUONG.Remove(_id);
        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi: " + ex.Message);
        //    }
        //}
        #endregion


        #region Các hàm ngoài lề lấy chuỗi, sinh nhật, lương,..........
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


        //public List<TB_NHANVIEN> getsinhnhat()
        //{
        //    return db.TB_NHANVIEN.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
        //}

        //public List<hopdongdto> getlenluong()
        //{
        //    var lsthopdong = db.TB_HOPDONG.Where(x => (x.NGAYBATDAU.Value.Month - DateTime.Now.Month) == 0 && (DateTime.Now.Year - x.NGAYBATDAU.Value.Year) == 2).ToList();


        //    List<hopdongdto> lsthopdongdto = new List<hopdongdto>();
        //    hopdongdto hd;


        //    foreach (var item in lsthopdong)
        //    {
        //        hd = new hopdongdto();
        //        hd.IDHD = item.IDHD;
        //        hd.NGAYBATDAU = item.NGAYBATDAU;
        //        hd.NGAYKETTHUC = item.NGAYKETTHUC;
        //        hd.NGAYKY = item.NGAYKY;
        //        hd.LANKY = item.LANKY;
        //        hd.HESOLUONG = item.HESOLUONG;
        //        hd.IDNV = item.IDNV;
        //        hd.IDCTY = item.IDCTY;
        //        hd.NOIDUNG = item.NOIDUNG;
        //        hd.CREATED_BY = item.CREATED_BY;
        //        hd.CREATED_DATE = item.CREATED_DATE;
        //        hd.UPDATED_BY = item.UPDATED_BY;
        //        hd.UPDATED_DATE = item.UPDATED_DATE;
        //        hd.DELETED_BY = item.DELETED_BY;
        //        hd.DELETED_DATE = item.DELETED_DATE;
        //        hd.THOIHAN = item.THOIHAN;

        //        var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV);
        //        hd.TENNV = nv.TENNV;
        //        lsthopdongdto.Add(hd);
        //    }
        //    return lsthopdongdto;
        //}

        #endregion

    }
}
