using BLL._02_Nhansu._01_Danhmucdungchung;
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

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmcongty : DevExpress.XtraEditors.XtraForm
    {
        public frmcongty()
        {
            InitializeComponent();
        }


        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        CongTy _congtyclass;
        bool _them;
        int _id;
        #endregion

        // Các hàm
        #region FUNCTION 
        void FC_Cleardata()
        {
            txtTenCongTy.Text = string.Empty;
            txtSodienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        void FC_Showcontrols(bool on)
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

        void Loaddata()
        {
            _congtyclass = new CongTy(); // khởi tạo class
            gcdanhsach.DataSource = _congtyclass.GetList(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview

        }

        void Savedata()
        {

            //Kiểm tra xem ô nhập có trống không
            if (string.IsNullOrWhiteSpace(txtTenCongTy.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_them)
            {
                TB_CONGTY data = new TB_CONGTY();
                data.TENCTY = txtTenCongTy.Text;
                data.EMAIL = txtEmail.Text;
                data.DIENTHOAI = txtSodienThoai.Text;
                data.DIACHI = txtDiaChi.Text;
                _congtyclass.Add(data);
            }
            else
            {
                TB_CONGTY data = _congtyclass.GetItem(_id);
                data.TENCTY = txtTenCongTy.Text;
                data.EMAIL = txtEmail.Text;
                data.DIENTHOAI = txtSodienThoai.Text;
                data.DIACHI = txtDiaChi.Text;
                _congtyclass.Update(data);
            }
        }



        // thao tác click vào gridview (lấy được id và gán giá trị cho ô text)
        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDCTY").ToString()); // Lấy giá trị tại cột có tên là "IDCTY" chuyển đổi giá trị thành kiểu int
                txtTenCongTy.Text = gvdanhsach.GetFocusedRowCellValue("TENCTY").ToString(); // Lấy giá trị cột "TENCTY" và chuyển thành chuỗi gán cho textedit
                txtEmail.Text = gvdanhsach.GetFocusedRowCellValue("EMAIL").ToString();
                txtSodienThoai.Text = gvdanhsach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtDiaChi.Text = gvdanhsach.GetFocusedRowCellValue("DIACHI").ToString();
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
                _congtyclass.Delete(_id);
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