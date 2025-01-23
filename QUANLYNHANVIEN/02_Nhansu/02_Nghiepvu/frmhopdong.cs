using BLL._02_Nhansu._02_Nghiepvu;
using DAL;
using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmhopdong : DevExpress.XtraEditors.XtraForm
    {
        public frmhopdong()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        HopDong _hopdongclass;
        bool _them;
        //int _id;
        string _sohd;
       // string _maxsohd;
        #endregion

        // Các hàm
        #region FUNCTION 
        void FC_Cleardata()
        {
            txtTenHopDong.Text = string.Empty;
            dtngaybatdau.Value = DateTime.Now;
            dtngayketthuc.Value = dtngaybatdau.Value.AddMonths(6);
            //datengayki.Value = DateTime.Now;
            spHeSoLuong.Value = 1;
            spLanKy.Value = 1;
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

        private void frmhopdong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QUANLYNHANSUDataSet.TB_NHANVIEN' table. You can move, or remove it, as needed.
            this.tB_NHANVIENTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet.TB_NHANVIEN);
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        void Loaddata()
        {
            _hopdongclass = new HopDong(); // khởi tạo class
            gcdanhsach.DataSource = _hopdongclass.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
        }

        void Savedata()
        {

            ////Kiểm tra xem ô nhập có trống không
            //if (string.IsNullOrWhiteSpace(txttenhopdong.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (_them)
            {
                //00001/2021/HĐLĐ
                var _maxsohd = _hopdongclass.GetMaxChuoi();
                int so = int.Parse(_maxsohd.Substring(0, 5)) + 1;
                TB_HOPDONG data = new TB_HOPDONG();
                data.IDHD = so.ToString("00000") + @"/2021/HĐLĐ";


                data.NGAYBATDAU = dtngaybatdau.Value;
                data.NGAYKETTHUC = dtngayketthuc.Value;

                data.LANKY = int.Parse(spLanKy.Text);
                data.HESOLUONG = double.Parse(spHeSoLuong.Text);
                data.NGAYKY = dtngayky.Value;
                data.THOIHAN = cbThoiHan.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                data.IDCTY = 1;
                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;
                _hopdongclass.Add(data);
            }
            else
            {
                TB_HOPDONG data = _hopdongclass.GetItem(_sohd);

                data.NGAYBATDAU = dtngaybatdau.Value;
                data.NGAYKETTHUC = dtngayketthuc.Value;

                data.LANKY = int.Parse(spLanKy.Text);
                data.HESOLUONG = double.Parse(spHeSoLuong.Text);
                data.NGAYKY = dtngayky.Value;
                data.THOIHAN = cbThoiHan.Text;
                data.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                data.IDCTY = 1;
                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;

                data.NOIDUNG = richNoiDung.RtfText;

                data.NOIDUNG = richNoiDung.RtfText;



                _hopdongclass.Update(data);
            }

        }

        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _sohd = gvdanhsach.GetFocusedRowCellValue("IDHD").ToString();
                var hd = _hopdongclass.GetItem(_sohd);

                txtTenHopDong.Text = hd.IDHD;
                dtngayketthuc.Value  = hd.NGAYKETTHUC.Value;
                dtngaybatdau.Value = hd.NGAYBATDAU.Value;
                dtngayky.Value = hd.NGAYKY.Value;


                spLanKy.Text = hd.LANKY.ToString();
                spHeSoLuong.Text = hd.HESOLUONG.ToString();
                

                cbThoiHan.Text = hd.THOIHAN;

                slkNhanVien.EditValue = hd.IDNV;

                richNoiDung.RtfText = hd.NOIDUNG;

                //txttenhopdong.Text = gvdanhsach.GetFocusedRowCellValue("IDHD").ToString();
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
                _hopdongclass.Delete(_sohd,1);
                Loaddata();
            }
        }

        private void btnluu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            _them = false;
        }

        private void btnphoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btndong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        #endregion
    }
}