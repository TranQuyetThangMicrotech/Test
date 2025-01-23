using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL._03_Chamcong;
using BLL.DTO;
using DAL;
using DevExpress.XtraEditors;
using QUANLYNHANVIEN.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._03_Loaica
{
    public partial class frmloaica : DevExpress.XtraEditors.XtraForm
    {
        public frmloaica()
        {
            InitializeComponent();
        }

       

        #region
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
            _them = true;
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            _them = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaicaclass.Delete(_id, 1);
                Loaddata();
            }
            //var hd = _hopdongclass.getitem(slkhopdong.EditValue.ToString());
            //hd.HESOLUONG = double.Parse(sphesoluongcu.EditValue.ToString());
            //_hopdongclass.update(hd);
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            _them = false;
        }

        private void btnphoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region BTN

        #endregion




        #region Khai báo biến toàn cục

        LoaiCa _loaicaclass;
        bool _them;
        int _id;
   
        #endregion


        #region FUNCTION 


        void FC_Cleardata()
        {
            txttenloaica.Text = string.Empty;;
            spheso.EditValue = 0.0;
        }

        void FC_Showcontrols(bool on)
        {
            btnthem.Enabled = on;
            btnsua.Enabled = on;
            btnxoa.Enabled = on;
            btndong.Enabled = on;
            btnphoto.Enabled = on;

            btnhuy.Enabled = !on;
            btnluu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion FUNCTION 



        private void frmloaica_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }


        #region các hàm tự viết
        void Loaddata()
        {
            _loaicaclass = new LoaiCa(); 

            gcdanhsach.DataSource = _loaicaclass.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;


        }

        void Savedata()
        {
            TB_LOAICA data;
            if (_them)
            {
                data = new TB_LOAICA();
                data.TENLCA = txttenloaica.Text;
                data.HESO  = double.Parse(spheso.EditValue.ToString());

                _loaicaclass.Add(data);
            }
            else
            {
                data = _loaicaclass.GetItem(_id);

                data.TENLCA = txttenloaica.Text;
                data.HESO = double.Parse(spheso.EditValue.ToString());

                _loaicaclass.Update(data);
            }
            //var hd = _hopdongclass.getitem(slkhopdong.EditValue.ToString());
            //hd.HESOLUONG = double.Parse(sphesoluongmoi.EditValue.ToString());
            //_hopdongclass.update(hd);
        }
        #endregion


        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDLCA").ToString());

                var item = _loaicaclass.GetItem(_id);

                txttenloaica.Text = item.TENLCA;
                spheso.EditValue = item.HESO;

            }
        }




     


       
    }
}