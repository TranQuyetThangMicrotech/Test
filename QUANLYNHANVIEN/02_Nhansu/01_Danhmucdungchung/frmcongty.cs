using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmcongty : DevExpress.XtraEditors.XtraForm
    {
        public frmcongty()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục

        private CongTy _congTy;
        private bool _them;
        private int _id;

        #endregion Khai báo biến toàn cục

        #region FUNCTION

        private void FC_Cleardata()
        {
            txtTenCongTy.Text = string.Empty;
            txtSodienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION

        private void frmcongty_Load(object sender, EventArgs e)

        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        private void Loaddata()
        {
            _congTy = new CongTy();
            gcdanhsach.DataSource = _congTy.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Savedata()
        {
            TB_CONGTY data;
            if (_them)
            {
                data = new TB_CONGTY();
                data.TENCTY = txtTenCongTy.Text;
                data.EMAIL = txtEmail.Text;
                data.DIENTHOAI = txtSodienThoai.Text;
                data.DIACHI = txtDiaChi.Text;
                _congTy.Add(data);
            }
            else
            {
                data = _congTy.GetItem(_id);
                data.TENCTY = txtTenCongTy.Text;
                data.EMAIL = txtEmail.Text;
                data.DIENTHOAI = txtSodienThoai.Text;
                data.DIACHI = txtDiaChi.Text;
                _congTy.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDCTY").ToString());
                var item = _congTy.GetItem(_id);
                txtTenCongTy.Text = item.TENCTY;
                txtEmail.Text = item.EMAIL;
                txtSodienThoai.Text = item.DIENTHOAI;
                txtDiaChi.Text = item.DIACHI;
            }
        }

        #region BTN

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
            gcdanhsach.Enabled = false;
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
                _congTy.Delete(_id);
                Loaddata();
            }
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            Savedata();
            Loaddata();
            gcdanhsach.Enabled = true;
            _them = false;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            gcdanhsach.Enabled = true;
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