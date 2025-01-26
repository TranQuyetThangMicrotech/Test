using BLL._00_Custom;
using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL.DTO;
using DAL;
using DevExpress.XtraReports.UI; // khai báo thư viện để cho in
using QUANLYNHANVIEN.Report;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO; // thư viện cho hình ảnh
using System.Windows.Forms;

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục

        private NhanVien _nhanVien;
        private bool _them;
        private int _id;

        private DanToc _danToc;
        private TonGiao _tonGiao;
        private BoPhan _boPhan;
        private PhongBan _phongBan;
        private ChucVu _chucVu;
        private TrinhDo _trinhDo;
        private CongTy _congTy;

        // khai báo list để truyền vào form in
        private List<NhanVienDTO> _lstnvdto;

        #endregion Khai báo biến toàn cục

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

        private void FC_Cleardata()
        {
            txtDiaChi.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;

            chkGioiTinh.TabIndex = 0;
        }

        private void FC_Showcontrols(bool on)
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

        private void Loaddata()
        {
            _nhanVien = new NhanVien();
            _tonGiao = new TonGiao();
            _danToc = new DanToc();
            _boPhan = new BoPhan();
            _phongBan = new PhongBan();
            _chucVu = new ChucVu();
            _trinhDo = new TrinhDo();
            _congTy = new CongTy();

            gcdanhsach.DataSource = _nhanVien.GetListFull(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = true; // Không cho phép sửa trên gridview

            FC_LoadComboBox(cbTenCongTy, _congTy.GetList(), "TENCTY", "IDCTY");
            FC_LoadComboBox(cbTenBoPhan, _boPhan.GetList(), "TENBP", "IDBP");
            FC_LoadComboBox(cbTenPhongBan, _phongBan.GetList(), "TENPB", "IDPB");
            FC_LoadComboBox(cbTenChucVu, _chucVu.GetList(), "TENCV", "IDCV");
            FC_LoadComboBox(cbTenTrinhDo, _trinhDo.GetList(), "TENTD", "IDTD");
            FC_LoadComboBox(cbTenDanToc, _danToc.GetList(), "TENDT", "IDDT");
            FC_LoadComboBox(cbTenTonGiao, _tonGiao.GetList(), "TENTG", "IDTG");

            _lstnvdto = _nhanVien.GetListFull(); // hứng dữ liệu từ form nv vào danh sách
                                                 //gvdanhsach.OptionsView.ShowGroupPanel = false;

            //gvdanhsach.Columns["TENNV"].GroupIndex = 0;

            // Tùy chọn: Mở rộng tất cả nhóm
            //gvdanhsach.ExpandAllGroups();
            //gvdanhsach.OptionsView.ShowIndicator = true;
            //_testclass = new testclass(); // khởi tạo class
            //gvdanhsach.IndicatorWidth = 50; // Đặt chiều rộng (tuỳ chỉnh)
        }

        private void Savedata()
        {
            TB_NHANVIEN data;
            if (_them)
            {
                data = new TB_NHANVIEN();
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

                _nhanVien.Add(data);
            }
            else
            {
                data = _nhanVien.GetItem(_id);

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

                _nhanVien.Update(data);
            }
        }

        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDNV").ToString());

                var nv = _nhanVien.GetItem(_id);

                txtTenNhanVien.Text = nv.TENNV;
                txtDiaChi.Text = nv.DIACHI;
                txtCCCD.Text = nv.CCCD;
                txtSoDienThoai.Text = nv.DIENTHOAI;

                picHinhAnh.Image = FC_Base64ToImage(nv.HINHANH);

                chkGioiTinh.Checked = nv.GIOITINH.Value; //? tránh trường hợp null
                dtNgaySinh.Value = nv.NGAYSINH.Value; //? tránh trường hợp null

                cbTenCongTy.SelectedValue = nv.IDCTY;
                cbTenBoPhan.SelectedValue = nv.IDBP;
                cbTenPhongBan.SelectedValue = nv.IDPB;
                cbTenChucVu.SelectedValue = nv.IDCV;
                cbTenTrinhDo.SelectedValue = nv.IDTD;
                cbTenTonGiao.SelectedValue = nv.IDTG;
                cbTenDanToc.SelectedValue = nv.IDDT;
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
                _nhanVien.Delete(_id);
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

        #endregion BTN

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
        }

        private void gvdanhsach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridView.Instance.CustomDrawIndicator(e);
        }

       
    }
}