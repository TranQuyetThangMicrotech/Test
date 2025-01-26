using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu.Danhmucdungchung
{
    public partial class frmdantoc : DevExpress.XtraEditors.XtraForm
    {
        public frmdantoc()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục

        private DanToc _danToc;
        private bool _them;
        private int _id;

        #endregion Khai báo biến toàn cục

        #region FUNCTION

        private void FC_Cleardata()
        {
            txtTenDanToc.Text = string.Empty;
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

        private void frmdantoc_Load(object sender, EventArgs e)

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
                _danToc.Delete(_id);
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

        private void Loaddata()
        {
            _danToc = new DanToc();
            gcdanhsach.DataSource = _danToc.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Savedata()
        {
            TB_DANTOC data;

            if (_them)
            {
                data = new TB_DANTOC();
                data.TENDT = txtTenDanToc.Text;
                _danToc.Add(data);
            }
            else
            {
                data = _danToc.GetItem(_id);
                data.TENDT = txtTenDanToc.Text;
                _danToc.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDDT").ToString());
                var item = _danToc.GetItem(_id);
                txtTenDanToc.Text = item.TENDT;
            }
        }

        private void gvdanhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridView.Instance.CustomDrawIndicator(e);
        }
    }
}