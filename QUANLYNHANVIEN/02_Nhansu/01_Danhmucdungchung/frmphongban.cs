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
using BLL._02_Nhansu._01_Danhmucdungchung;
namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmphongban : DevExpress.XtraEditors.XtraForm
    {
        public frmphongban()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        PhongBan _phongbanclass;
        bool _them;
        int _id;
        #endregion


        #region Function

        void FC_Cleardata()
        {
            txtTenPhongBan.Text= string.Empty;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled= on;
            btnSua  .Enabled= on;
            btnXoa.Enabled= on;
            btnDong.Enabled= on;
            splitContainer1.Panel1Collapsed= on;

            btnLuu.Enabled= !on;
            btnHuy.Enabled= !on;
        }
        #endregion

        private void frmphongban_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        void Loaddata()
        {
            _phongbanclass = new PhongBan();
            gcdanhsach.DataSource = _phongbanclass.GetList();
            gvdanhsach.OptionsBehavior.Editable= false;
        }

        void Savedata()
        {
            if(string.IsNullOrEmpty(txtTenPhongBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_them)
            {
                TB_PHONGBAN data = new TB_PHONGBAN();
                data.TENPB= txtTenPhongBan.Text;
                _phongbanclass.Add(data);
            }
            else
            {
                var data = _phongbanclass.GetItem(_id);
                data.TENPB = txtTenPhongBan.Text;
                _phongbanclass.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if(gvdanhsach.RowCount >0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDPB").ToString());
                txtTenPhongBan.Text = gvdanhsach.GetFocusedRowCellValue("TENPB").ToString();
            }
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
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _phongbanclass.Delete(_id);
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

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}