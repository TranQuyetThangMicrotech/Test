using BLL._02_Nhansu._01_Danhmucdungchung;
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
    public partial class frmdieuchuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmdieuchuyen()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        DieuChuyen _dieuchuyenclass;
        bool _them;
        //int _id;
        string _chuoi;
       // string _maxchuoi;

        BoPhan _bophanclass;
        NhanVien _nhanvienclass;
       // nhanvienclass _nhanvienclass;
        #endregion

        // Các hàm
        #region FUNCTION 

        private void FC_LoadComboBox(System.Windows.Forms.ComboBox comboBox, dynamic dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        void FC_Cleardata()
        {
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            dtNgay.Value = DateTime.Now;
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




        private void frmdieuchuyen_Load(object sender, EventArgs e)
        {
            this.tB_NHANVIENTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet.TB_NHANVIEN);
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        void Loaddata()
        {
            _dieuchuyenclass = new DieuChuyen(); // khởi tạo class
            _bophanclass = new BoPhan();
            _nhanvienclass= new NhanVien();
            gcdanhsach.DataSource = _dieuchuyenclass.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
            FC_LoadComboBox(cbChuyenDen, _bophanclass.GetList(), "TENBP", "IDBP");

          
        }

        void Savedata()
        {
            TB_DIEUCHUYEN data;
            if (_them)
            {
                data = new TB_DIEUCHUYEN();

                //00001/2021/QĐKT
                var _maxchuoi = _dieuchuyenclass.GetMaxChuoi();
                int so = int.Parse(_maxchuoi.Substring(0, 5)) + 1;
                data.IDDC = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+ @"/QĐĐC";
                data.NGAY = dtNgay.Value;
                data.LYDO = txtLyDo.Text;
                data.NOIDUNG = txtNoiDung.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());

                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;
                data.IDBP2 = int.Parse(cbChuyenDen.SelectedValue.ToString());
                data.IDBP = _nhanvienclass.GetItem(int.Parse(slkNhanVien.EditValue.ToString())).IDBP;



                _dieuchuyenclass.Add(data);
            }
            else
            {
                data = _dieuchuyenclass.GetItem(_chuoi);
                // không cho phép sửa
                //data.IDDC = so.ToString("00000") + @"/2021/QĐKT";

                data.NGAY = dtNgay.Value;
                data.LYDO = txtLyDo.Text;
                data.NOIDUNG = txtNoiDung.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());

                data.UPDATED_BY = 1;
                data.UPDATED_DATE = DateTime.Now;

                data.IDBP2 = int.Parse(cbChuyenDen.SelectedValue.ToString());
                // không cho sửa
                //data.IDBP = _nhanvienclas.getitem(int.Parse(slknhanvien.EditValue.ToString()).IDNV;

                _dieuchuyenclass.Update(data);
            }

            var nv = _nhanvienclass.GetItem(data.IDNV.Value);
            nv.IDBP = data.IDBP2;
            _nhanvienclass.Update(nv);
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _chuoi = gvdanhsach.GetFocusedRowCellValue("IDDC").ToString();
                var data = _dieuchuyenclass.GetItem(_chuoi);

                txtTenKhenThuong.Text = data.IDDC;
                txtLyDo.Text = data.LYDO;
                txtNoiDung.Text = data.NOIDUNG;
                dtNgay.Value = data.NGAY.Value;
                slkNhanVien.EditValue = data.IDNV;

                cbChuyenDen.SelectedValue= data.IDBP2;

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
                _dieuchuyenclass.Delete(_chuoi, 1);
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




        #endregion

        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.icondel;
                e.Graphics.DrawImage(img, 16, 16);
                e.Handled = true;
            }
        }
    }
}