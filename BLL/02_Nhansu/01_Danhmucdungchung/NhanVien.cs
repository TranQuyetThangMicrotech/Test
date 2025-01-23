using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class NhanVien
    {
        // Khởi tạo entity
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        // Lấy toàn bộ danh sách
        public List<TB_NHANVIEN> GetList()
        {
            return db.TB_NHANVIEN.ToList();
        }

        public List<NhanVienDTO> GetListFull()
        {
            var danhsach = db.TB_NHANVIEN.ToList();
            List<NhanVienDTO> danhsachdto = new List<NhanVienDTO>();
            // khởi tạo biến
            NhanVienDTO nvdto;

            foreach (var item in danhsach)
            {
                nvdto = new NhanVienDTO(); // tạo đối tượng

                nvdto.IDNV = item.IDNV;
                nvdto.TENNV = item.TENNV;
                nvdto.GIOITINH = item.GIOITINH;
                nvdto.NGAYSINH = item.NGAYSINH;
                nvdto.CCCD = item.CCCD;
                nvdto.DIENTHOAI = item.DIENTHOAI;
                nvdto.DIACHI = item.DIACHI;
                nvdto.HINHANH = item.HINHANH;

                nvdto.IDCTY = item.IDCTY;
                nvdto.IDBP = item.IDBP;
                nvdto.IDPB = item.IDPB;
                nvdto.IDCV = item.IDCV;
                nvdto.IDTD = item.IDTD;
                nvdto.IDTG = item.IDTG;
                nvdto.IDDT = item.IDDT;
                nvdto.STATUS = item.STATUS;

                // KHAI BÁO THÊM ĐỂ HIỂN THỊ

                var cty = db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == item.IDCTY);
                nvdto.TENCTY = cty.TENCTY;

                var bp = db.TB_BOPHAN.FirstOrDefault(z => z.IDBP == item.IDBP);
                nvdto.TENBP = bp.TENBP;

                var pb = db.TB_PHONGBAN.FirstOrDefault(c => c.IDPB == item.IDPB);
                nvdto.TENPB = pb.TENPB;

                var cv = db.TB_CHUCVU.FirstOrDefault(v => v.IDCV == item.IDCV);
                nvdto.TENCV = cv.TENCV;

                var td = db.TB_TRINHDO.FirstOrDefault(b => b.IDTD == item.IDTD);
                nvdto.TENTD = td.TENTD;

                var dt = db.TB_DANTOC.FirstOrDefault(n => n.IDDT == item.IDDT);
                nvdto.TENDT = dt.TENDT;

                var tg = db.TB_TONGIAO.FirstOrDefault(m => m.IDTG == item.IDTG);
                nvdto.TENTG = tg.TENTG;

                danhsachdto.Add(nvdto);
            }
            return danhsachdto;
        }

        // Lấy giá trị id
        public TB_NHANVIEN GetItem(int id)
        {
            return db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        // Thêm
        public TB_NHANVIEN Add(TB_NHANVIEN item)
        {
            try
            {
                db.TB_NHANVIEN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Sửa
        public TB_NHANVIEN Update(TB_NHANVIEN id)
        {
            try
            {
                var _item = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == id.IDNV);

                _item.TENNV = id.TENNV;
                _item.GIOITINH = id.GIOITINH;
                _item.NGAYSINH = id.NGAYSINH;

                _item.DIENTHOAI = id.DIENTHOAI;
                _item.CCCD = id.CCCD;
                _item.DIACHI = id.DIACHI;

                // image
                _item.HINHANH = id.HINHANH;

                _item.IDCTY = id.IDCTY;
                _item.IDBP = id.IDBP;
                _item.IDPB = id.IDPB;
                _item.IDCV = id.IDCV;
                _item.IDTD = id.IDTD;
                _item.IDTG = id.IDTG;
                _item.IDDT = id.IDDT;

                _item.STATUS = id.STATUS;
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
                var _id = db.TB_NHANVIEN.FirstOrDefault(x => x.IDNV == id);
                db.TB_NHANVIEN.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public List<TB_NHANVIEN> GetSinhNhat()
        {
            return db.TB_NHANVIEN.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
        }
    }
}