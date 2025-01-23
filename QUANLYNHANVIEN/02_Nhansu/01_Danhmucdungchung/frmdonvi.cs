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
using BLL._02_Nhansu._01_Danhmucdungchung;
using DAL;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmdonvi : DevExpress.XtraEditors.XtraForm
    {
        public frmdonvi()
        {
            InitializeComponent();
        }


        #region Khai báo biến toàn cục

        DonVi _donviclass;
        CongTy _congtyclass;
        bool _them;


        int _id;
        //string _idchuoi;



        #endregion


        #region FUNCTION 




        private void FC_LoadComboBox(System.Windows.Forms.ComboBox comboBox, dynamic dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        void FC_Cleardata()
        {
            txtTenDonVi.Text = string.Empty;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;
            btnPhoto.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion FUNCTION 



        private void frmdonvi_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        #region các hàm tự viết
        void Loaddata()
        {
            _donviclass = new DonVi(); // khởi tạo class

            _congtyclass = new CongTy();
            //_dantocclass = new dantocclass();s


            gcdanhsach.DataSource = _donviclass.GetListFull();
            gvdanhsach.OptionsBehavior.Editable = false;

            FC_LoadComboBox(cbTenCongTy, _congtyclass.GetList(), "TENCTY", "IDCTY");
            //FC_LoadComboBox(cbbophan, _bophanclass.getlist(), "TENBP", "IDBP");


            //_lstnvdto = _donviclass.getlistfull(); // hứng dữ liệu từ form nv để in

            //slkhopdong.Properties.DataSource = _hopdongclass.getlistfull();
            //slkhopdong.Properties.DisplayMember = "IDHD";
            //slkhopdong.Properties.ValueMember = "IDHD";

            //public void InitializeLookupEdit(DevExpress.XtraEditors.LookUpEdit lookupEdit, object dataSource, string displayMember, string valueMember)
            //{
            //    // Gán dữ liệu cho LookUpEdit
            //    lookupEdit.Properties.DataSource = dataSource;

            //    // Gán thuộc tính hiển thị và giá trị
            //    lookupEdit.Properties.DisplayMember = displayMember;
            //    lookupEdit.Properties.ValueMember = valueMember;
            //}

        }

        void Savedata()
        {
            TB_DONVI data;
            if (_them)
            {
                data = new TB_DONVI();
                data.TENDVI = txtTenDonVi.Text;
                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());



                _donviclass.Add(data);
            }
            else
            {
                data = _donviclass.GetItem(_id);

                data.TENDVI = txtTenDonVi.Text;
                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());

                _donviclass.Update(data);
            }
       
        }
        #endregion


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
                //_donviclass.delete(_id, 1);
                Loaddata();
            }
            //var hd = _hopdongclass.getitem(slkhopdong.EditValue.ToString());
            //hd.HESOLUONG = double.Parse(sphesoluongcu.EditValue.ToString());
            //_hopdongclass.update(hd);
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





        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDDVI").ToString());

                var item = _donviclass.GetItem(_id); // Lấy được id nhân viên gán lại vào ô

                txtTenDonVi.Text = item.TENDVI;
                cbTenCongTy.SelectedValue = item.IDCTY;
 

            }
        }
    }
}