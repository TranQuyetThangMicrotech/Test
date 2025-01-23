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


        private ChucVu _chucvuclass;

        private bool _them;
        private int _id;

        #endregion Khai báo biến toàn cục

        // Các hàm

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

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION

        private void Loaddata()

        {
            _chucvuclass = new ChucVu(); // khởi tạo class
            gcdanhsach.DataSource = _chucvuclass.GetList(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
        }

        private void Savedata()
        {
            //Kiểm tra xem ô nhập có trống không
            if (string.IsNullOrWhiteSpace(txtTenChucVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_them)
            {
                TB_CHUCVU data = new TB_CHUCVU();
                data.TENCV = txtTenChucVu.Text;
                _chucvuclass.Add(data);
            }
            else
            {
                var data = _chucvuclass.GetItem(_id);
                data.TENCV = txtTenChucVu.Text;
                _chucvuclass.Update(data);
            }
        }

        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDCV").ToString()); // Lấy giá trị tại cột có tên là "IDDT" chuyển đổi giá trị thành kiểu int
                txtTenChucVu.Text = gvdanhsach.GetFocusedRowCellValue("TENCV").ToString(); // Lấy giá trị cột "TENDT" và chuyển thành chuỗi gán cho textedit
            }
        }

        #region BTN

        private void btnthem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
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
                _chucvuclass.Delete(_id);
                Loaddata();
            }
        }

        private void btnluu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            //FC_Showgridview(true);
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            //FC_Showgridview(true);
            _them = false;
        }

        private void btndong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion BTN
    }
}