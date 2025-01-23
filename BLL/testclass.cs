using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class testclass
    {
        // Khởi tạo
        DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_TEST> getlist()
        {
            return db.TB_TEST.ToList();
        }



        #endregion


        #region Lấy item

        public TB_TEST getitem(int id)
        {
            return db.TB_TEST.FirstOrDefault(x => x.ID == id); // lấy giá trị đầu tiên trùng với id được gửi vô

        }

    

        #endregion


        #region Thêm, Sửa, Xóa

        public TB_TEST add(TB_TEST data)
        {
            try
            {
                db.TB_TEST.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_TEST update(TB_TEST id)
        {
            try
            {
                var _item = db.TB_TEST.FirstOrDefault(x => x.ID == id.ID);

                _item.NHOM = id.NHOM;
                _item.CHUCNANG = id.CHUCNANG;
                _item.XEM = id.XEM;
                _item.THEM = id.THEM;
                _item.SUA = id.SUA;
                _item.XOA = id.XOA;
                _item.TRICHXUAT = id.TRICHXUAT;


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

        public void delete(string id, int iduser)
        {
            try
            {
                //var _id = db.TB_TEST.FirstOrDefault(x => x.ID == id);

                //_id.DELETED_BY = iduser;
                //_id.DELETED_DATE = DateTime.Now;
                //db.TB_TEST.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //public void delete(int id, int iduser)
        //{
        //    try
        //    {
        //        var _id = db.TB_TEST.FirstOrDefault(x => x.ID == id);

        //        _id.DELETED_BY = iduser;
        //        _id.DELETED_DATE = DateTime.Now;
        //        //db.TB_TEST.Remove(_id);
        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi: " + ex.Message);
        //    }
        //}
        #endregion


        #region Các hàm ngoài lề lấy chuỗi, sinh nhật, lương,..........
        //public string getmaxchuoi()
        //{
        //    var _chuoi = db.TB_TEST.OrderByDescending(x => x.CREATED_BY).FirstOrDefault();
        //    if (_chuoi != null)
        //    {
        //        return _chuoi.ID;
        //    }
        //    else
        //    {
        //        return "00000";
        //    }
        //}


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
