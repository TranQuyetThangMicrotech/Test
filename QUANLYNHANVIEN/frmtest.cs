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
using System.Data.Entity;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL.DTO;
using DAL;
using QUANLYNHANVIEN.Report;
using System.IO;
using BLL;
using BLL._00_Custom;

namespace QUANLYNHANVIEN
{
    public partial class frmtest : DevExpress.XtraEditors.XtraForm
    {
        public frmtest()
        {
            InitializeComponent();

        }

        private void frmtest_Load(object sender, EventArgs e)
        {
            Loaddata();
            _them = false;
        }



        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        testclass _testclass;
        bool _them;
        int _id;



        #endregion

        // Các hàm
        #region FUNCTION 





        //void FC_Cleardata()
        //{
        //    txtdiachi.Text = string.Empty;
        //    txtcccd.Text = string.Empty;
        //    txtsodienthoai.Text = string.Empty;
        //    txttennhanvien.Text = string.Empty;

        //    chkgioitinh.TabIndex = 0;

        //}

        //void FC_Showcontrols(bool on)
        //{
        //    btnthem.Enabled = on;
        //    btnsua.Enabled = on;
        //    btnxoa.Enabled = on;
        //    btndong.Enabled = on;
        //    btnphoto.Enabled = on;

        //    btnhuy.Enabled = !on;
        //    btnluu.Enabled = !on;

        //    splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        //}

        #endregion FUNCTION 

        void Loaddata()
        {

            //gvdanhsach.OptionsView.ShowIndicator = true;
            _testclass = new testclass(); // khởi tạo class
            //gvdanhsach.IndicatorWidth = 50; // Đặt chiều rộng (tuỳ chỉnh)


            gcdanhsach.DataSource = _testclass.getlist(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = true; // Không cho phép sửa trên gridview

            //gvdanhsach.Columns["ID"].OptionsColumn.ReadOnly = true;
            //gvdanhsach.Columns["CHUCNANG"].OptionsColumn.ReadOnly = true;
            //gvdanhsach.Columns["NHOM"].OptionsColumn.ReadOnly = true;
            //gvdanhsach.Columns["XEM"].OptionsColumn.ReadOnly = true;
            //gvdanhsach.OptionsView.ShowGroupPanel = false;


            //gvdanhsach.Columns["TENNV"].GroupIndex = 0;

            // Tùy chọn: Mở rộng tất cả nhóm
            gvdanhsach.ExpandAllGroups();
            btn.Click += Btn_Click;


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Kích hoạt giao diện skin
            //SkinManager.EnableFormSkins();

            // Cho phép sử dụng HTML trong thông báo
            //XtraMessageBox.AllowHtmlText = true;

            // Hiển thị thông báo với giao diện tùy chỉnh
            //XtraMessageBox.Show("Xin chào! Tôi là <color=red><b><size=30>MessageBox</size></b></color>.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Savedata()
        {

            ////Kiểm tra xem ô nhập có trống không
            //if (string.IsNullOrWhiteSpace(txttendantoc.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệu vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (_them)
            {
                TB_TEST data = new TB_TEST();
                //data.TENNV = txttennhanvien.Text;
                // data.GIOITINH = chkgioitinh.Checked;
                //data.NGAYSINH = datengaysinh.Value;

                //data.DIENTHOAI = txtsodienthoai.Text;
                //data.CCCD = txtcccd.Text;
                //data.DIACHI = txtdiachi.Text;

                //// image
                //data.HINHANH = FC_ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);


                //data.IDCTY = int.Parse(cbcongty.SelectedValue.ToString());
                //data.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                //data.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                //data.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                //data.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                //data.IDTG = int.Parse(cbtongiao.SelectedValue.ToString());
                //data.IDDT = int.Parse(cbdantoc.SelectedValue.ToString());

                _testclass.add(data);
            }
            else
            {
                TB_TEST data = _testclass.getitem(_id);

                //data.TENNV = txttennhanvien.Text;
                //data.GIOITINH = chkgioitinh.Checked;
                //data.NGAYSINH = datengaysinh.Value;

                //data.DIENTHOAI = txtsodienthoai.Text;
                //data.CCCD = txtcccd.Text;
                //data.DIACHI = txtdiachi.Text;

                //// image
                //data.HINHANH = FC_ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);


                //data.IDCTY = int.Parse(cbcongty.SelectedValue.ToString());
                //data.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                //data.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                //data.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                //data.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                //data.IDTG = int.Parse(cbtongiao.SelectedValue.ToString());
                //data.IDDT = int.Parse(cbdantoc.SelectedValue.ToString());

                _testclass.update(data);
            }
        }


        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                //_id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDNV").ToString());

                //var nv = _testclass.getitem(_id); // Lấy được id nhân viên gán lại vào ô

                //txttennhanvien.Text = nv.TENNV;
                //txtdiachi.Text = nv.DIACHI;
                //txtcccd.Text = nv.CCCD;
                //txtsodienthoai.Text = nv.DIENTHOAI;

                //pichinhanh.Image = FC_Base64ToImage(nv.HINHANH);

                //chkgioitinh.Checked = nv.GIOITINH.Value; //? tránh trường hợp null
                //datengaysinh.Value = nv.NGAYSINH.Value; //? tránh trường hợp null


                //cbcongty.SelectedValue = nv.IDCTY;
                //cbbophan.SelectedValue = nv.IDBP;
                //cbphongban.SelectedValue = nv.IDPB;
                //cbchucvu.SelectedValue = nv.IDCV;
                //cbtrinhdo.SelectedValue = nv.IDTD;
                //cbtongiao.SelectedValue = nv.IDTG;
                //cbdantoc.SelectedValue = nv.IDDT;

            }
        }

        private void gvdanhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
          CustomGridView.Instance.CustomDrawIndicator(e);
        }


        



}
}