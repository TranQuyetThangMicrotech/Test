using BLL._02_Nhansu._01_Danhmucdungchung;// thư viện clas
using BLL._02_Nhansu._02_Nghiepvu;
using BLL.DTO;// thư viện clas
using DAL; // thư viện clas
using DevExpress.XtraEditors;
using QUANLYNHANVIEN.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // thư viện cho rpt
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN
{
    public partial class templatefrm : DevExpress.XtraEditors.XtraForm
    {
        public templatefrm()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục
        
        NhanVien _nhanvienclass;
        bool _them;


        int _id;
       // string _idchuoi;

        // khai báo list để truyền vào form in
        List<NhanVienDTO> _lstnvdto;

        #endregion


        #region FUNCTION 

        public byte[] FC_ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream()) // khởi tạo
            {
                image.Save(ms, format);   // lưu hình ảnh vào ms
                byte[] imageByte = ms.ToArray(); // chuyển sang dạng mảng byte
                return imageByte; // trả về kiểu mảng byte
            }
        }

        public Image FC_Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length); // mảng byte cần đổi, vị trí đọc byte từ vị trí 0 và số byte cần đọc
            Image image = Image.FromStream(ms, true); // gán vào hình ảnh
            return image; // trả về hình ảnh
        }


        private void FC_LoadComboBox(System.Windows.Forms.ComboBox comboBox, dynamic dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        void FC_Cleardata()
        {
            txtdiachi.Text = string.Empty;
            txtcccd.Text = string.Empty;
            txtsodienthoai.Text = string.Empty;
            txttennhanvien.Text = string.Empty;

            //dtngay.Value = DateTime.Now;
            //chkgioitinh.TabIndex = 0;
            //dtngay.Value = DateTime.Now.Add.Day(10);
            //sphesoluong.EditValue = 0;

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



        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }

        #region các hàm tự viết
        void Loaddata()
        {
            _nhanvienclass = new NhanVien(); // khởi tạo class

            //_tongiaoclass = new tongiaoclass();
            //_dantocclass = new dantocclass();


            gcdanhsach.DataSource = _nhanvienclass.GetListFull(); 
            gvdanhsach.OptionsBehavior.Editable = false; 

            //FC_LoadComboBox(cbcongty, _congtyclass.getlist(), "TENCTY", "IDCTY");
            //FC_LoadComboBox(cbbophan, _bophanclass.getlist(), "TENBP", "IDBP");


            _lstnvdto = _nhanvienclass.GetListFull(); // hứng dữ liệu từ form nv để in

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
            TB_NHANVIEN data;
            if (_them)
            {
                data = new TB_NHANVIEN();
                data.TENNV = txttennhanvien.Text;
                data.GIOITINH = chkgioitinh.Checked;
                data.NGAYSINH = datengaysinh.Value;

                data.DIENTHOAI = txtsodienthoai.Text;
                data.CCCD = txtcccd.Text;
                data.DIACHI = txtdiachi.Text;

            
                data.HINHANH = FC_ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);


                data.IDCTY = int.Parse(cbcongty.SelectedValue.ToString());
                data.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                data.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                data.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                data.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                data.IDTG = int.Parse(cbtongiao.SelectedValue.ToString());
                data.IDDT = int.Parse(cbdantoc.SelectedValue.ToString());

                _nhanvienclass.Add(data);
            }
            else
            {
                data = _nhanvienclass.GetItem(_id);

                data.TENNV = txttennhanvien.Text;
                data.GIOITINH = chkgioitinh.Checked;
                data.NGAYSINH = datengaysinh.Value;

                data.DIENTHOAI = txtsodienthoai.Text;
                data.CCCD = txtcccd.Text;
                data.DIACHI = txtdiachi.Text;

            
                data.HINHANH = FC_ImageToBase64(pichinhanh.Image, pichinhanh.Image.RawFormat);


                data.IDCTY = int.Parse(cbcongty.SelectedValue.ToString());
                data.IDBP = int.Parse(cbbophan.SelectedValue.ToString());
                data.IDPB = int.Parse(cbphongban.SelectedValue.ToString());
                data.IDCV = int.Parse(cbchucvu.SelectedValue.ToString());
                data.IDTD = int.Parse(cbtrinhdo.SelectedValue.ToString());
                data.IDTG = int.Parse(cbtongiao.SelectedValue.ToString());
                data.IDDT = int.Parse(cbdantoc.SelectedValue.ToString());

                _nhanvienclass.Update(data);
            }
            //var hd = _hopdongclass.getitem(slkhopdong.EditValue.ToString());
            //hd.HESOLUONG = double.Parse(sphesoluongmoi.EditValue.ToString());
            //_hopdongclass.update(hd);
        }
        #endregion



        private void gvdanhsach_Click_1(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDNV").ToString());

                var item = _nhanvienclass.GetItem(_id); // Lấy được id nhân viên gán lại vào ô

                txttennhanvien.Text = item.TENNV;
                txtdiachi.Text = item.DIACHI;
                txtcccd.Text = item.CCCD;
                txtsodienthoai.Text = item.DIENTHOAI;

                pichinhanh.Image = FC_Base64ToImage(item.HINHANH);

                chkgioitinh.Checked = item.GIOITINH.Value; //? tránh trường hợp null
                //dtngaysinh.Value = item.NGAYSINH.Value; //? tránh trường hợp null

                cbcongty.SelectedValue = item.IDCTY;
                cbbophan.SelectedValue = item.IDBP;


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
                //_nhanvienclass.delete(_id, 1);
                Loaddata();
            }
            //var hd = _hopdongclass.getitem(slkhopdong.EditValue.ToString());
            //hd.HESOLUONG = double.Parse(sphesoluongcu.EditValue.ToString());
            //_hopdongclass.update(hd);
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
            //rpt.ShowRibbonPreview();
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
                pichinhanh.Image = Image.FromFile(openFile.FileName); // chọn file hình 
                pichinhanh.SizeMode = PictureBoxSizeMode.StretchImage; // chế độ hiển thị
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

        private void templatefrm_Load(object sender, EventArgs e)
        {

        }
    }
}
