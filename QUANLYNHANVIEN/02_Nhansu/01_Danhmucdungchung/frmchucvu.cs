using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmchucvu : DevExpress.XtraEditors.XtraForm
    {
        public frmchucvu()
        {
            InitializeComponent();
        }

        private void frmchucvu_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        #region Khai báo biến toàn cục

        private ChucVu _chuvVu;

        private bool _them;
        private int _id;

        #endregion Khai báo biến toàn cục

        #region FUNCTION

        private void FC_Cleardata()
        {
            txtTenChucVu.Text = string.Empty;
        }

        private void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion FUNCTION

        private void Loaddata()

        {
            _chuvVu = new ChucVu();
            gcdanhsach.DataSource = _chuvVu.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Savedata()
        {
            TB_CHUCVU data;
            if (_them)
            {
                data = new TB_CHUCVU();
                data.TENCV = txtTenChucVu.Text;
                _chuvVu.Add(data);
            }
            else
            {
                data = _chuvVu.GetItem(_id);
                data.TENCV = txtTenChucVu.Text;
                _chuvVu.Update(data);
            }
        }

        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDCV").ToString());
                var item = _chuvVu.GetItem(_id);
                txtTenChucVu.Text = item.TENCV;
            }
        }

        #region BTN

        private void btnthem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
            gcdanhsach.Enabled = false;
            _them = true;
        }

        private void btnsua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            _them = false;
        }

        private void btnxoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _chuvVu.Delete(_id);
                Loaddata();
            }
        }

        private void btnluu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            gcdanhsach.Enabled = true;
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            gcdanhsach.Enabled = true;
            _them = false;
        }

        private void btndong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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