using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Login
{
    public class userclass
    {
        DB_QUANLYNHANSUEntities db =   new DB_QUANLYNHANSUEntities();

        //public object Encryptor { get; private set; }

        public List<TB_SYS_USER> getlist()
        {
            return db.TB_SYS_USER.ToList();
        }

        public List<TB_SYS_USER> getlistuser(int idcty, int iddvi, bool isgroup)
        {
            return db.TB_SYS_USER.Where(x=>x.IDCTY == idcty && x.IDDVI == iddvi && x.ISGROUP == isgroup).ToList();
        }

        public List<TB_SYS_USER> getlistgroup(int idcty, int iddvi, bool isgroup)
        {
            return db.TB_SYS_USER.Where(x => x.IDCTY == idcty && x.IDDVI == iddvi && x.ISGROUP == isgroup).ToList();
        }


        // kiểm tra xem user đó đã tồn tại hay chưa
        public bool checkuser(int idcty, int iddvi, string username)
        {
            var check = db.TB_SYS_USER.FirstOrDefault(x => x.IDCTY == idcty && x.IDDVI == iddvi && x.USERNAME == username);
            if (check != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TB_SYS_USER getitem(int id)
        {
            return db.TB_SYS_USER.FirstOrDefault(x=>x.IDUSER== id);
        }



        #region Thêm, Sửa, Xóa

        public TB_SYS_USER add(TB_SYS_USER data)
        {
            try
            {
                db.TB_SYS_USER.Add(data);
                db.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_SYS_USER update(TB_SYS_USER id)
        {
            try
            {
                var _item = db.TB_SYS_USER.FirstOrDefault(x => x.IDUSER == id.IDUSER);

                _item.IDUSER = id.IDUSER;
                _item.USERNAME = id.USERNAME;
                _item.PASSWORD = id.PASSWORD;          //Encryptor.Encrypt(id.PASSWORD, "fefhthtw", true);
                _item.FULLNAME = id.FULLNAME;
                _item.IDCTY = id.IDCTY;
                _item.IDDVI = id.IDDVI;
                _item.LAST_PWD_CHANGED = DateTime.Now;
                    
                    
                _item.ISGROUP = id.ISGROUP;
                _item.DISABLE = id.DISABLE;


                db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //public void delete(string id, int iduser)
        //{
        //    try
        //    {
        //        var _id = db.TB_SYS_USER.FirstOrDefault(x => x.IDNANGLUONG == id);

        //        _id.DELETED_BY = iduser;
        //        _id.DELETED_DATE = DateTime.Now;
        //        //db.TB_SYS_USER.Remove(_id);
        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi: " + ex.Message);
        //    }
        //}

        public void delete(int id, int iduser)
        {
            try
            {
                var _id = db.TB_SYS_USER.FirstOrDefault(x => x.IDUSER == id);

                //_id.DELETED_BY = iduser;
                //_id.DELETED_DATE = DateTime.Now;
                //db.TB_SYS_USER.Remove(_id);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        #endregion


    }
}
