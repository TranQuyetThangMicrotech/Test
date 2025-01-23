using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL._02_Nhansu._01_Danhmucdungchung
{
    public class DonVi
    {
        // Khởi tạo
        private DB_QUANLYNHANSUEntities db = new DB_QUANLYNHANSUEntities();

        #region Lấy danh sách

        public List<TB_DONVI> GetList(int id)
        {
            return db.TB_DONVI.Where(x => x.IDCTY == id).ToList();
        }

        //public List<TB_DONVI> getlist(int loai)
        //{
        //    return db.TB_DONVI.Where(x => x.IDDVI === loai).ToList();
        //}

        public List<DonViDTO> GetListFull()
        {
            var lst = db.TB_DONVI.ToList();

            List<DonViDTO> lstdto = new List<DonViDTO>();
            DonViDTO dto;

            foreach (var item in lst)
            {
                dto = new DonViDTO();

                dto.IDDVI = item.IDDVI;
                dto.TENDVI = item.TENDVI;

                // Khác với getlist bình thường, hứng thêm các trường mới-
                //var cty = db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == item.IDCTY);
                //dto.TENCTY = cty.TENCTY;

                var cty = db.TB_CONGTY.FirstOrDefault(x => x.IDCTY == item.IDCTY);
                dto.TENCTY = cty.TENCTY;

                lstdto.Add(dto);
            }
            return lstdto;
        }

        #endregion Lấy danh sách

        #region Lấy item

        //public TB_DONVI getitem(int id)
        //{
        //    return db.TB_DONVI.FirstOrDefault(x => x.IDNANGLUONG == id); // lấy giá trị đầu tiên trùng với id được gửi vô

        //}

        public TB_DONVI GetItem(int id)
        {
            return db.TB_DONVI.FirstOrDefault(x => x.IDDVI == id); // lấy giá trị đầu tiên trùng với id được gửi vô
        }

        #endregion Lấy item

        #region Thêm, Sửa, Xóa

        public TB_DONVI Add(TB_DONVI data)
        {
            try
            {
                db.TB_DONVI.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_DONVI Update(TB_DONVI id)
        {
            try
            {
                var _item = db.TB_DONVI.FirstOrDefault(x => x.IDDVI == id.IDDVI);

                _item.IDDVI = id.IDDVI;
                _item.TENDVI = id.TENDVI;
                _item.IDCTY = id.IDCTY;

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
                var _id = db.TB_DONVI.FirstOrDefault(x => x.IDDVI == id);

                //db.TB_DONVI.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        #endregion Thêm, Sửa, Xóa
    }
}