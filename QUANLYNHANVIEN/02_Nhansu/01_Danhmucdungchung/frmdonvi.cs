using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmdonvi : DevExpress.XtraEditors.XtraForm
    {
        public frmdonvi()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục

        private DonVi _donVi;
        private CongTy _congtyclass;
        private bool _them;

        private int _id;

        #endregion Khai báo biến toàn cục

        #region FUNCTION

        private void FC_LoadComboBox(System.Windows.Forms.ComboBox comboBox, dynamic dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void FC_Cleardata()
        {
            txtTenDonVi.Text = string.Empty;
        }

        private void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;
            btnPhoto.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion FUNCTION

        private void frmdonvi_Load(object sender, EventArgs e)

        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        #region các hàm tự viết

        private void Loaddata()
        {
            _donVi = new DonVi();

            _congtyclass = new CongTy();

            gcdanhsach.DataSource = _donVi.GetListFull();
            gvdanhsach.OptionsBehavior.Editable = false;

            FC_LoadComboBox(cbTenCongTy, _congtyclass.GetList(), "TENCTY", "IDCTY");
        }

        private void Savedata()
        {
            TB_DONVI data;
            if (_them)
            {
                data = new TB_DONVI();
                data.TENDVI = txtTenDonVi.Text;
                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());

                _donVi.Add(data);
            }
            else
            {
                data = _donVi.GetItem(_id);

                data.TENDVI = txtTenDonVi.Text;
                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());

                _donVi.Update(data);
            }
        }

        #endregion các hàm tự viết

        #region btn

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
                _donVi.Delete(_id, 1);
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

        #endregion btn

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDDVI").ToString());

                var item = _donVi.GetItem(_id);

                txtTenDonVi.Text = item.TENDVI;
                cbTenCongTy.SelectedValue = item.IDCTY;
            }
        }

        private void gvdanhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridView.Instance.CustomDrawIndicator(e);
        }
    }
}