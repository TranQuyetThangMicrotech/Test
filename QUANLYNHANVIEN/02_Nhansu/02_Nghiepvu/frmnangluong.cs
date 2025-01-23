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
    public partial class frmnangluong : DevExpress.XtraEditors.XtraForm
    {
        public frmnangluong()
        {
            InitializeComponent();
        }



        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        NangLuong _nangluongclass;
        bool _them;
        //int _id;
        string _chuoi;
       // string _maxchuoi;

        NhanVien _nhanvienclass;
        HopDong _hopdongclass;
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
          //  txtlydo.Text = string.Empty;
            txtnoidung.Text = string.Empty;
            dtngayky.Value = DateTime.Now;
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


        private void frmnangluong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QUANLYNHANSUDataSet1.TB_HOPDONG' table. You can move, or remove it, as needed.
            //this.tB_HOPDONGTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet1.TB_HOPDONG);
            //this.tB_NHANVIENTableAdapter.Fill(this.dB_QUANLYNHANSUDataSet.TB_NHANVIEN);
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }


        void Loaddata()
        {
            _nangluongclass = new NangLuong(); // khởi tạo class
            _hopdongclass = new HopDong();
            _nhanvienclass = new NhanVien();
            gcdanhsach.DataSource = _nangluongclass.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview
            //FC_LoadComboBox(cbchuyenden, _bophanclass.getlist(), "TENBP", "IDBP");
            slkhopdong.Properties.DataSource = _hopdongclass.GetListFull();
            slkhopdong.Properties.DisplayMember = "IDHD";
            slkhopdong.Properties.ValueMember = "IDHD";
        }

        void Savedata()
        {
            TB_NANGLUONG data;
            if (_them)
            {
                data = new TB_NANGLUONG();

                //00001/2021/QĐKT
                var _maxchuoi = _nangluongclass.GetMaxChuoi();
                int so = int.Parse(_maxchuoi.Substring(0, 5)) + 1;
                data.IDNANGLUONG = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐNL";
                data.NGAYKY = dtngayky.Value;
                data.NGAYLENLUONG = dtngaylenluong.Value;
                data.IDNV = _hopdongclass.GetItem(slkhopdong.EditValue.ToString()).IDNV;

                data.NOIDUNG = txtnoidung.Text;
                data.IDHD = slkhopdong.EditValue.ToString();

                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;
                

                data.HESOLUONGCU = _hopdongclass.GetItem(slkhopdong.EditValue.ToString()).HESOLUONG;
                //int.Parse(sphesoluongcu.EditValue.ToString());
                data.HESOLUONGMOI = double.Parse(sphesoluongmoi.EditValue.ToString());

                _nangluongclass.Add(data);
            }
            else
            {
                data = _nangluongclass.GetItem(_chuoi);
                // không cho phép sửa
                //data.IDDC = so.ToString("00000") + @"/2021/QĐKT";

                data.NGAYKY = dtngayky.Value;
                data.NGAYLENLUONG = dtngaylenluong.Value;
                data.NOIDUNG = txtnoidung.Text;
                data.IDHD = slkhopdong.EditValue.ToString();
                data.HESOLUONGCU = int.Parse(sphesoluongcu.EditValue.ToString());
                data.HESOLUONGMOI = int.Parse(sphesoluongmoi.EditValue.ToString());
                data.UPDATED_BY = 1;
                data.UPDATED_DATE = DateTime.Now;

            

                _nangluongclass.Update(data);
            }

            var hd = _hopdongclass.GetItem(slkhopdong.EditValue.ToString());
            hd.HESOLUONG = double.Parse(sphesoluongmoi.EditValue.ToString());
            _hopdongclass.Update(hd);
        }


        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _chuoi = gvdanhsach.GetFocusedRowCellValue("IDNANGLUONG").ToString();
                var data = _nangluongclass.GetItem(_chuoi);

                //txtnhanvien.Text = data.IDNV;
                txtnoidung.Text = data.NOIDUNG;
                txtnoidung.Text = data.NOIDUNG;
                dtngayky.Value = data.NGAYKY.Value;
                dtngaylenluong.Value = data.NGAYLENLUONG.Value;

                slkhopdong.EditValue = data.IDHD;

                sphesoluongcu.EditValue = data.HESOLUONGCU;
                sphesoluongmoi.EditValue = data.HESOLUONGMOI;

            }

        }




        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.icondel;
                e.Graphics.DrawImage(img, 16, 16);
                e.Handled = true;
            }
        }








        #region BTN



        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                _nangluongclass.Delete(_chuoi, 1);
                
                Loaddata();
            }
            var hd = _hopdongclass.GetItem(slkhopdong.EditValue.ToString());
            hd.HESOLUONG = double.Parse(sphesoluongcu.EditValue.ToString());
            _hopdongclass.Update(hd);
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

        private void btnphoto_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btndong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        #endregion

        private void slkhopdong_EditValueChanged(object sender, EventArgs e)
        {
            var hienthi = _hopdongclass.GetItemFull(slkhopdong.EditValue.ToString());
            if (hienthi.Count != 0)
            {
                txtnhanvien.Text = hienthi[0].IDNV + "-" + hienthi[0].TENNV;
                sphesoluongcu.EditValue = hienthi[0].HESOLUONG;
            }
        }
    }
}