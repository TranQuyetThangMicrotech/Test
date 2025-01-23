﻿using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL.DTO;
using DAL;
using DevExpress.XtraEditors;
using QUANLYNHANVIEN.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // thư viện cho hình ảnh
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraReports;
using DevExpress.XtraReports.UI; // khai báo thư viện để cho in
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;
using BLL;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

 
        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        NhanVien _nhanvienclass;
        bool _them;
        int _id;

        DanToc _dantocclass;
        TonGiao _tongiaoclass;
        BoPhan _bophanclass;
        PhongBan _phongbanclass;
        ChucVu _chucvuclass;
        TrinhDo _trinhdoclass;
        CongTy _congtyclass;


        // khai báo list để truyền vào form in
        List<NhanVienDTO> _lstnvdto;

        #endregion

        // Các hàm
        #region FUNCTION 

        // image sang dạng byte để lưu trữ và truyền đi
        public byte[] FC_ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream()) // khởi tạo
            {
                image.Save(ms, format);   // lưu hình ảnh vào ms
                byte[] imageByte = ms.ToArray(); // chuyển sang dạng mảng byte
                return imageByte; // trả về kiểu mảng byte
            }
        }

        // byte sang dạng image để hiển thị lên gridview
        public Image FC_Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length); 
            ms.Write(imageBytes, 0, imageBytes.Length); // mảng byte cần đổi, vị trí đọc byte từ vị trí 0 và số byte cần đọc
            Image image = Image.FromStream(ms, true); // gán vào hình ảnh
            return image; // trả về hình ảnh
        }
    

 
        // Đây là hàm Load dữ liệu lên combobox
        private void FC_LoadComboBox(System.Windows.Forms.ComboBox comboBox, dynamic dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
       
        void FC_Cleardata()
        {
            txtDiaChi.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;

            chkGioiTinh.TabIndex = 0;

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

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION 



        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        void Loaddata()
        {
            _nhanvienclass = new NhanVien(); // khởi tạo class

            _tongiaoclass = new TonGiao(); 
            _dantocclass = new DanToc();
            _bophanclass = new BoPhan(); 
            _phongbanclass = new PhongBan(); 
            _chucvuclass = new ChucVu(); 
            _trinhdoclass = new TrinhDo();
            _congtyclass = new CongTy();

            gcdanhsach.DataSource = _nhanvienclass.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = true; // Không cho phép sửa trên gridview

            FC_LoadComboBox(cbTenCongTy, _congtyclass.GetList(), "TENCTY", "IDCTY");
            FC_LoadComboBox(cbTenBoPhan, _bophanclass.GetList(), "TENBP", "IDBP");
            FC_LoadComboBox(cbTenPhongBan, _phongbanclass.GetList(), "TENPB", "IDPB");
            FC_LoadComboBox(cbTenChucVu, _chucvuclass.GetList(), "TENCV", "IDCV");
            FC_LoadComboBox(cbTenTrinhDo, _trinhdoclass.GetList(), "TENTD", "IDTD");
            FC_LoadComboBox(cbTenDanToc, _dantocclass.GetList(), "TENDT", "IDDT");
            FC_LoadComboBox(cbTenTonGiao, _tongiaoclass.GetList(), "TENTG", "IDTG");

            _lstnvdto = _nhanvienclass.GetListFull(); // hứng dữ liệu từ form nv vào danh sách
                                                      //gvdanhsach.OptionsView.ShowGroupPanel = false;


            gvdanhsach.Columns["TENNV"].GroupIndex = 0;

            // Tùy chọn: Mở rộng tất cả nhóm
            gvdanhsach.ExpandAllGroups();
            gvdanhsach.OptionsView.ShowIndicator = true;
            //_testclass = new testclass(); // khởi tạo class
            gvdanhsach.IndicatorWidth = 50; // Đặt chiều rộng (tuỳ chỉnh)

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
                TB_NHANVIEN data = new TB_NHANVIEN();
                data.TENNV = txtTenNhanVien.Text;
                data.GIOITINH = chkGioiTinh.Checked;
                data.NGAYSINH = dtNgaySinh.Value;

                data.DIENTHOAI = txtSoDienThoai.Text;
                data.CCCD = txtCCCD.Text;
                data.DIACHI = txtDiaChi.Text;

                // image
                data.HINHANH = FC_ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                    
                
                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());
                data.IDBP = int.Parse(cbTenBoPhan.SelectedValue.ToString());
                data.IDPB = int.Parse(cbTenPhongBan.SelectedValue.ToString());
                data.IDCV = int.Parse(cbTenChucVu.SelectedValue.ToString());
                data.IDTD = int.Parse(cbTenTrinhDo.SelectedValue.ToString());
                data.IDTG = int.Parse(cbTenTonGiao.SelectedValue.ToString());
                data.IDDT = int.Parse(cbTenDanToc.SelectedValue.ToString());

                _nhanvienclass.Add(data);
            }
            else
            {
                TB_NHANVIEN data = _nhanvienclass.GetItem(_id);

                data.TENNV = txtTenNhanVien.Text;
                data.GIOITINH = chkGioiTinh.Checked;
                data.NGAYSINH = dtNgaySinh.Value;

                data.DIENTHOAI = txtSoDienThoai.Text;
                data.CCCD = txtCCCD.Text;
                data.DIACHI = txtDiaChi.Text;

                // image
                data.HINHANH = FC_ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);


                data.IDCTY = int.Parse(cbTenCongTy.SelectedValue.ToString());
                data.IDBP = int.Parse(cbTenBoPhan.SelectedValue.ToString());
                data.IDPB = int.Parse(cbTenPhongBan.SelectedValue.ToString());
                data.IDCV = int.Parse(cbTenChucVu.SelectedValue.ToString());
                data.IDTD = int.Parse(cbTenTrinhDo.SelectedValue.ToString());
                data.IDTG = int.Parse(cbTenTonGiao.SelectedValue.ToString());
                data.IDDT = int.Parse(cbTenDanToc.SelectedValue.ToString());

                _nhanvienclass.Update(data);
            }
        }


        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                //_id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDNV").ToString());

                //var nv = _nhanvienclass.getitem(_id); // Lấy được id nhân viên gán lại vào ô

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
                _nhanvienclass.Delete(_id);
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
            rptdanhsachnhanvien rpt = new rptdanhsachnhanvien(_lstnvdto);
            rpt.ShowRibbonPreview();
        }

        private void btndong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void btnhinhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg) | *.png;*.jpg";
            openFile.Title = "Chọn hỉnh ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName); // chọn file hình 
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage; // chế độ hiển thị
            }
        }


        #endregion

        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if(e.Column.Name == "GIOITINH")
            //{
            //    if (int.Parse(e.CellValue.ToString()) == 0)
            //        e.DisplayText = "Nam";
            //    else
            //        e.DisplayText = "Nữ";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nhóm theo cột TENNV
          
        }

        private void gvdanhsach_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "gridColumn1")
            //{
            //    gvdanhsach.PostEditor(); // Kết thúc chỉnh sửa và lưu giá trị vào DataSource
            //    gvdanhsach.UpdateCurrentRow(); // Cập nhật hàng hiện tại
            //}
            //gvdanhsach.CellValueChanged += gvdanhsach_CellValueChanged;
        }
    } 
}