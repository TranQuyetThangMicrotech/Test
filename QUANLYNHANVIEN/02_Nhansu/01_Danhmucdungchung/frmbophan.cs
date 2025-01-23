using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;
using System;
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmbophan : DevExpress.XtraEditors.XtraForm
    {
        public frmbophan()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục

        // Khai báo tạo 1 biến đại diện cho class
        private BoPhan _bophanclass;

        private bool _them;
        private int _id;

        #endregion Khai báo biến toàn cục

        // Các hàm

        #region FUNCTION

        private void FC_Cleardata()
        {
            txtTenBoPhan.Text = string.Empty;
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

        private void frmbophan_Load(object sender, EventArgs e)

        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        private void Loaddata()
        {
            _bophanclass = new BoPhan(); // khởi tạo class
            gcdanhsach.DataSource = _bophanclass.GetList(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
        }

        private void Savedata()
        {
            //Kiểm tra xem ô nhập có trống không
            if (string.IsNullOrWhiteSpace(txtTenBoPhan.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_them)
            {
                TB_BOPHAN data = new TB_BOPHAN();
                data.TENBP = txtTenBoPhan.Text;
                _bophanclass.Add(data);
            }
            else
            {
                var data = _bophanclass.GetItem(_id);
                data.TENBP = txtTenBoPhan.Text;
                _bophanclass.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDBP").ToString()); // Lấy giá trị tại cột có tên là "IDDT" chuyển đổi giá trị thành kiểu int
                txtTenBoPhan.Text = gvdanhsach.GetFocusedRowCellValue("TENBP").ToString(); // Lấy giá trị cột "TENDT" và chuyển thành chuỗi gán cho textedit
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
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bophanclass.Delete(_id);
                Loaddata();
            }
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            //FC_Showgridview(true);
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            //FC_Showgridview(true);
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