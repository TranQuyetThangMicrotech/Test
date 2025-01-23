using BLL._02_Nhansu._02_Nghiepvu;
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

namespace QUANLYNHANVIEN._02_Nhansu._02_Nghiepvu
{
    public partial class frmkyluat : DevExpress.XtraEditors.XtraForm
    {
        public frmkyluat()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        KhenThuongKyLuat _khenthuong_kyluatclass;
        bool _them;
       // int _id;
        string _chuoi;
        //string _maxchuoi;
        #endregion

        // Các hàm
        #region FUNCTION 
        void FC_Cleardata()
        {
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            dtTuNgay.Value = DateTime.Now;
            dtDenNgay.Value = DateTime.Now;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            brnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION 

        private void frmkyluat_Load(object sender, EventArgs e)
        {
            this.tB_NHANVIENTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet.TB_NHANVIEN);
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }



        void Loaddata()
        {
            _khenthuong_kyluatclass = new KhenThuongKyLuat(); // khởi tạo class
            gcdanhsach.DataSource = _khenthuong_kyluatclass.GetListFull(2); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
        }

        void Savedata()
        {
            if (_them)
            {
                TB_KHENTHUONG_KYLUAT data = new TB_KHENTHUONG_KYLUAT();

                //00001/2021/QĐKL
                var _maxchuoi = _khenthuong_kyluatclass.GetMaxChuoi(2);
                int so = int.Parse(_maxchuoi.Substring(0, 5)) + 1;
                data.IDKTKL = so.ToString("00000") + @"/2021/QĐKL";
                data.TUNGAY = dtTuNgay.Value;
                data.DENNGAY = dtDenNgay.Value;
                data.LYDO = txtLyDo.Text;
                data.NOIDUNG = txtNoiDung.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;


                data.LOAI = 2;// phân biệt với khen thưởng kỷ luật
                _khenthuong_kyluatclass.Add(data);
            }
            else
            {
                TB_KHENTHUONG_KYLUAT data = _khenthuong_kyluatclass.GetItem(_chuoi);
                // không cho phép sửa
                //data.IDKTKL = so.ToString("00000") + @"/2021/QĐKT";

                data.TUNGAY = dtTuNgay.Value;
                data.DENNGAY = dtDenNgay.Value;
                data.LYDO = txtLyDo.Text;
                data.NOIDUNG = txtNoiDung.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;


                data.LOAI = 2; // phân biệt với khen thưởng kỷ luật
                _khenthuong_kyluatclass.Update(data);
            }
        }


        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _chuoi = gvdanhsach.GetFocusedRowCellValue("IDKTKL").ToString();
                var data = _khenthuong_kyluatclass.GetItem(_chuoi);

                txtKyLuat.Text = data.IDKTKL;
                txtLyDo.Text = data.LYDO;
                txtNoiDung.Text = data.NOIDUNG;
                dtTuNgay.Value = data.TUNGAY.Value;
                dtDenNgay.Value = data.DENNGAY.Value;
                slkNhanVien.EditValue = data.IDNV;
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
                _khenthuong_kyluatclass.Delete(_chuoi, 1);
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

        private void btnphoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }



        #endregion

    }
}