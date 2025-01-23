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
    public partial class frmthoiviec : DevExpress.XtraEditors.XtraForm
    {
        public frmthoiviec()
        {
            InitializeComponent();
        }


        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        ThoiViec _thoiviecclass;
        bool _them;
        //int _id;
        string _chuoi;
       // string _maxchuoi;

      
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
            txtlydo.Text = string.Empty;
            txtnoidung.Text = string.Empty;
            dtngaynopdon.Value = DateTime.Now;
            dtngaynopdon.Value = DateTime.Now;
        }

        void FC_Showcontrols(bool on)
        {
            btnthem.Enabled = on;
            btnsua.Enabled = on;
            btnxoa.Enabled = on;
            btndong.Enabled = on;

            btnhuy.Enabled = !on;
            btnluu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION 



        private void frmthoiviec_Load(object sender, EventArgs e)
        {
            this.tB_NHANVIENTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet.TB_NHANVIEN);
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        void Loaddata()
        {
            _thoiviecclass = new ThoiViec(); // khởi tạo class
         
            _nhanvienclass = new NhanVien();
            gcdanhsach.DataSource = _thoiviecclass.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
       
        }

        void Savedata()
        {
            TB_THOIVIEC data;
            
            if (_them)
            {
                data = new TB_THOIVIEC();

                //00001/2021/QĐKT
                var _maxchuoi = _thoiviecclass.GetMaxChuoi();
                int so = int.Parse(_maxchuoi.Substring(0, 5)) + 1;
                data.IDTV = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐTV";
                data.NGAYNOPDON = dtngaynopdon.Value;
                data.NGAYNGHI = dtngaynghi.Value;
                data.LYDO = txtlydo.Text;
                data.NOIDUNG = txtnoidung.Text;
                data.IDNV = int.Parse(slknhanvien.EditValue.ToString());

                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;
               
                //data.IDBP = _nhanvienclass.getitem(int.Parse(slknhanvien.EditValue.ToString())).IDBP;



                _thoiviecclass.Add(data);
            }
            else
            {
                data = _thoiviecclass.GetItem(_chuoi);
                // không cho phép sửa
                //data.IDTV = so.ToString("00000") + @"/2021/QĐKT";

                data.NGAYNOPDON = dtngaynopdon.Value;
                data.NGAYNGHI = dtngaynghi.Value;
                data.LYDO = txtlydo.Text;
                data.NOIDUNG = txtnoidung.Text;
                data.IDNV = int.Parse(slknhanvien.EditValue.ToString());

                data.UPDATED_BY = 1;
                data.UPDATED_DATE = DateTime.Now;

              
                // không cho sửa
                //data.IDBP = _nhanvienclas.getitem(int.Parse(slknhanvien.EditValue.ToString()).IDNV;

                _thoiviecclass.Update(data);
            }

            var nv = _nhanvienclass.GetItem(data.IDNV.Value);
            nv.STATUS = true;
            _nhanvienclass.Update(nv);
        }


        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _chuoi = gvdanhsach.GetFocusedRowCellValue("IDTV").ToString();
                var data = _thoiviecclass.GetItem(_chuoi);

                txttenkhenthuong.Text = data.IDTV;
                txtlydo.Text = data.LYDO;
                txtnoidung.Text = data.NOIDUNG;
                dtngaynopdon.Value = data.NGAYNOPDON.Value;
                dtngaynghi.Value = data.NGAYNGHI.Value;
                slknhanvien.EditValue = data.IDNV;

               

            }
        }


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
                _thoiviecclass.Delete(_chuoi, 1);
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

        private void dtngaynopdon_ValueChanged(object sender, EventArgs e)
        {
            dtngaynghi.Value = dtngaynopdon.Value.AddDays(45);
        }




        #endregion

        //private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{
        //    if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
        //    {
        //        Image img = Properties.Resources.icondel;
        //        e.Graphics.DrawImage(img, 16, 16);
        //        e.Handled = true;
        //    }
        //}
    }
}