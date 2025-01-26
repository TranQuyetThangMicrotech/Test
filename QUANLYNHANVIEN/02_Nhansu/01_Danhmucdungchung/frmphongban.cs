using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmphongban : DevExpress.XtraEditors.XtraForm
    {
        public frmphongban()
        {
            InitializeComponent();
        }

        #region Khai báo biến

        private PhongBan _phongBan;
        private bool _them;
        private int _id;

        #endregion Khai báo biến

        #region Function

        private void FC_Cleardata()
        {
            txtTenPhongBan.Text = string.Empty;
        }

        private void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;
            splitContainer1.Panel1Collapsed = on;

            btnLuu.Enabled = !on;
            btnHuy.Enabled = !on;
        }

        #endregion Function

        private void frmphongban_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        private void Loaddata()
        {
            _phongBan = new PhongBan();
            gcdanhsach.DataSource = _phongBan.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Savedata()
        {
            TB_PHONGBAN data;
            if (_them)
            {
                data = new TB_PHONGBAN();
                data.TENPB = txtTenPhongBan.Text;
                _phongBan.Add(data);
            }
            else
            {
                data = _phongBan.GetItem(_id);
                data.TENPB = txtTenPhongBan.Text;
                _phongBan.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDPB").ToString());
                var item = _phongBan.GetItem(_id);
                txtTenPhongBan.Text = item.TENPB;
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _phongBan.Delete(_id);
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

        #endregion BTN

        private void gvdanhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridView.Instance.CustomDrawIndicator(e);
        }
    }
}