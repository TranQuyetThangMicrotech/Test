using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmtongiao : DevExpress.XtraEditors.XtraForm
    {
        #region Khai báo biến

        private TonGiao _tonGiao;
        private bool _them;
        private int _id;

        #endregion Khai báo biến

        #region Function

        private void FC_Cleardata()
        {
            txtTenTonGiao.Text = string.Empty;
        }

        private void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            brnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;

            btnLuu.Enabled = !on;
            btnHuy.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion Function

        public frmtongiao()
        {
            InitializeComponent();
        }

        private void frmtongiao_Load(object sender, EventArgs e)
        {
            //_tongiaoclass= new tongiaoclass();
            Loaddata();
            FC_Showcontrols(true);
            _them = false;
        }

        private void Loaddata()
        {
            _tonGiao = new TonGiao();
            gcdanhsach.DataSource = _tonGiao.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Savedata()
        {

            TB_TONGIAO data;
            if (_them)
            {
                data = new TB_TONGIAO();
                data.TENTG = txtTenTonGiao.Text;
                _tonGiao.Add(data);
            }
            else
            {
                data = _tonGiao.GetItem(_id);
                data.TENTG = txtTenTonGiao.Text;
                _tonGiao.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDTG").ToString());
                var item = _tonGiao.GetItem(_id);
                txtTenTonGiao.Text = item.TENTG;
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
            if (MessageBox.Show("Bạn có chắc chắn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tonGiao.Delete(_id);
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
    }
}