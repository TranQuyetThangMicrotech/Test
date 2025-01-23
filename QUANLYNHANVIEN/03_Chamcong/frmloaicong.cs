using BLL._03_Chamcong;
using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._03_Chamcong
{
    public partial class frmloaicong : DevExpress.XtraEditors.XtraForm
    {
        public frmloaicong()
        {
            InitializeComponent();
        }




        #region Khai báo biến toàn cục

        LoaiCong _loaicongclass;
        bool _them;
        int _id;

        #endregion


        #region FUNCTION 


        void FC_Cleardata()
        {
            txtloaicong.Text = string.Empty; ;
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

        private void frmloaicong_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }


        #region BTN

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
                _loaicongclass.Delete(_id, 1);
                Loaddata();
            }
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

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDLC").ToString());

                var item = _loaicongclass.GetItem(_id);

                txtloaicong.Text = item.TENLC;
                spheso.EditValue = item.HESO;

            }
        }


        #region các hàm tự viết
        void Loaddata()
        {
            _loaicongclass = new LoaiCong();

            gcdanhsach.DataSource = _loaicongclass.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;


        }

        void Savedata()
        {
            TB_LOAICONG data;
            if (_them)
            {
                data = new TB_LOAICONG();
                data.TENLC = txtloaicong.Text;
                data.HESO = double.Parse(spheso.EditValue.ToString());

                _loaicongclass.Add(data);
            }
            else
            {
                data = _loaicongclass.GetItem(_id);

                data.TENLC = txtloaicong.Text;
                data.HESO = double.Parse(spheso.EditValue.ToString());

                _loaicongclass.Update(data);
            }
        
        }

        #endregion

        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.icondel;
                e.Graphics.DrawImage(img, e.Bounds.X,e.Bounds.Y);
                e.Handled= true;
            }
        }
    }
}