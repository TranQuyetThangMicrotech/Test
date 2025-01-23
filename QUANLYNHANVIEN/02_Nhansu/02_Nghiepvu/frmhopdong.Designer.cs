namespace QUANLYNHANVIEN._02_Nhansu._02_Nghiepvu
{
    partial class frmhopdong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhopdong));
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhoto = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.txtTenHopDong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtngayky = new System.Windows.Forms.DateTimePicker();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.richNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tBNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QUANLYNHANSUDataSet = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSet();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COLIDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.tB_NHANVIENTableAdapter = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NGAYBATDAU.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYBATDAU.AppearanceHeader.Options.UseFont = true;
            this.NGAYBATDAU.Caption = "NGÀY BẮT ĐẦU";
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 300;
            this.NGAYBATDAU.MinWidth = 300;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 1;
            this.NGAYBATDAU.Width = 300;
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHD,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.THOIHAN,
            this.HESOLUONG,
            this.LANKY,
            this.IDNV,
            this.TENNV});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click_1);
            // 
            // IDHD
            // 
            this.IDHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDHD.AppearanceHeader.Options.UseFont = true;
            this.IDHD.Caption = "SỐ HỢP ĐỒNG";
            this.IDHD.FieldName = "IDHD";
            this.IDHD.MaxWidth = 150;
            this.IDHD.MinWidth = 150;
            this.IDHD.Name = "IDHD";
            this.IDHD.Visible = true;
            this.IDHD.VisibleIndex = 0;
            this.IDHD.Width = 150;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYKETTHUC.AppearanceHeader.Options.UseFont = true;
            this.NGAYKETTHUC.Caption = "NGÀY KẾT THÚC";
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 300;
            this.NGAYKETTHUC.MinWidth = 300;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 2;
            this.NGAYKETTHUC.Width = 300;
            // 
            // THOIHAN
            // 
            this.THOIHAN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.THOIHAN.AppearanceHeader.Options.UseFont = true;
            this.THOIHAN.Caption = "THỜI HẠN";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 300;
            this.THOIHAN.MinWidth = 300;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 3;
            this.THOIHAN.Width = 300;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HESOLUONG.AppearanceHeader.Options.UseFont = true;
            this.HESOLUONG.Caption = "HỆ SỐ LƯƠNG";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 150;
            this.HESOLUONG.MinWidth = 150;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 4;
            this.HESOLUONG.Width = 150;
            // 
            // LANKY
            // 
            this.LANKY.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LANKY.AppearanceHeader.Options.UseFont = true;
            this.LANKY.Caption = "LẦN KÍ";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 150;
            this.LANKY.MinWidth = 150;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 5;
            this.LANKY.Width = 150;
            // 
            // IDNV
            // 
            this.IDNV.Caption = "IDNV";
            this.IDNV.FieldName = "LANKI";
            this.IDNV.Name = "IDNV";
            // 
            // TENNV
            // 
            this.TENNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TENNV.AppearanceHeader.Options.UseFont = true;
            this.TENNV.Caption = "NHÂN VIÊN";
            this.TENNV.FieldName = "TENNV";
            this.TENNV.MaxWidth = 350;
            this.TENNV.MinWidth = 350;
            this.TENNV.Name = "TENNV";
            this.TENNV.Visible = true;
            this.TENNV.VisibleIndex = 6;
            this.TENNV.Width = 350;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1542, 298);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnin,
            this.btnPhoto});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(-126, 138);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhoto, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnthem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick_1);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnxoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnluu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnhuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuy_ItemClick_1);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Caption = "In";
            this.btnPhoto.Id = 8;
            this.btnPhoto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnphoto.ImageOptions.SvgImage")));
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphoto_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndong_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1542, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 732);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1542, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 704);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1542, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 704);
            // 
            // btnin
            // 
            this.btnin.Id = 7;
            this.btnin.Name = "btnin";
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Enabled = false;
            this.txtTenHopDong.Location = new System.Drawing.Point(187, 8);
            this.txtTenHopDong.MenuManager = this.barManager1;
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(200, 26);
            this.txtTenHopDong.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên hợp đồng:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.dtngayky);
            this.splitContainer1.Panel1.Controls.Add(this.cbThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.richNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtngayketthuc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtngaybatdau);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenHopDong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1542, 704);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(735, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 19);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Ngày kí:";
            // 
            // dtngayky
            // 
            this.dtngayky.CustomFormat = "mm/dd/yyyy";
            this.dtngayky.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngayky.Location = new System.Drawing.Point(847, 3);
            this.dtngayky.Name = "dtngayky";
            this.dtngayky.Size = new System.Drawing.Size(200, 27);
            this.dtngayky.TabIndex = 17;
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "3 tháng",
            "6 t háng",
            "12 tháng"});
            this.cbThoiHan.Location = new System.Drawing.Point(847, 40);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(186, 27);
            this.cbThoiHan.TabIndex = 16;
            // 
            // richNoiDung
            // 
            this.richNoiDung.Location = new System.Drawing.Point(187, 108);
            this.richNoiDung.MenuManager = this.barManager1;
            this.richNoiDung.Name = "richNoiDung";
            this.richNoiDung.Size = new System.Drawing.Size(923, 257);
            this.richNoiDung.TabIndex = 15;
            this.richNoiDung.Text = "richEditControl1";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(75, 108);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 19);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Nội dung:";
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(545, 76);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.DataSource = this.tBNHANVIENBindingSource;
            this.slkNhanVien.Properties.DisplayMember = "TENNV";
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Properties.ValueMember = "IDNV";
            this.slkNhanVien.Size = new System.Drawing.Size(228, 26);
            this.slkNhanVien.TabIndex = 13;
            // 
            // tBNHANVIENBindingSource
            // 
            this.tBNHANVIENBindingSource.DataMember = "TB_NHANVIEN";
            this.tBNHANVIENBindingSource.DataSource = this.dB_QUANLYNHANSUDataSet;
            // 
            // dB_QUANLYNHANSUDataSet
            // 
            this.dB_QUANLYNHANSUDataSet.DataSetName = "DB_QUANLYNHANSUDataSet";
            this.dB_QUANLYNHANSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COLIDNV,
            this.COLTENNV});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // COLIDNV
            // 
            this.COLIDNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.COLIDNV.AppearanceHeader.Options.UseFont = true;
            this.COLIDNV.Caption = "ID";
            this.COLIDNV.FieldName = "IDNV";
            this.COLIDNV.MaxWidth = 100;
            this.COLIDNV.MinWidth = 100;
            this.COLIDNV.Name = "COLIDNV";
            this.COLIDNV.Visible = true;
            this.COLIDNV.VisibleIndex = 0;
            this.COLIDNV.Width = 100;
            // 
            // COLTENNV
            // 
            this.COLTENNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.COLTENNV.AppearanceHeader.Options.UseFont = true;
            this.COLTENNV.Caption = "TÊN NHÂN VIÊN";
            this.COLTENNV.FieldName = "TENNV";
            this.COLTENNV.MaxWidth = 350;
            this.COLTENNV.MinWidth = 350;
            this.COLTENNV.Name = "COLTENNV";
            this.COLTENNV.Visible = true;
            this.COLTENNV.VisibleIndex = 1;
            this.COLTENNV.Width = 350;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(450, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Nhân viên:";
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(545, 43);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(118, 26);
            this.spHeSoLuong.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(450, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Hệ số lương:";
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(545, 8);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.MaskSettings.Set("mask", "N00");
            this.spLanKy.Size = new System.Drawing.Size(118, 26);
            this.spLanKy.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(450, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Lần kí:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(772, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Thời hạn:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(75, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ngày kết thúc:";
            // 
            // dtngayketthuc
            // 
            this.dtngayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngayketthuc.Location = new System.Drawing.Point(187, 73);
            this.dtngayketthuc.Name = "dtngayketthuc";
            this.dtngayketthuc.Size = new System.Drawing.Size(200, 27);
            this.dtngayketthuc.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(75, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày bắt đầu:";
            // 
            // dtngaybatdau
            // 
            this.dtngaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dtngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaybatdau.Location = new System.Drawing.Point(187, 40);
            this.dtngaybatdau.Name = "dtngaybatdau";
            this.dtngaybatdau.Size = new System.Drawing.Size(200, 27);
            this.dtngaybatdau.TabIndex = 2;
            this.dtngaybatdau.Value = new System.DateTime(2025, 12, 1, 1, 12, 0, 0);
            // 
            // tB_NHANVIENTableAdapter
            // 
            this.tB_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmhopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 732);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmhopdong";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmhopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHopDong.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn IDHD;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtngaybatdau;
        private DevExpress.XtraEditors.TextEdit txtTenHopDong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtngayketthuc;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraBars.BarButtonItem btnPhoto;
        private System.Windows.Forms.ComboBox cbThoiHan;
        private DevExpress.XtraRichEdit.RichEditControl richNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn COLIDNV;
        private DevExpress.XtraGrid.Columns.GridColumn COLTENNV;
        private DB_QUANLYNHANSUDataSet dB_QUANLYNHANSUDataSet;
        private System.Windows.Forms.BindingSource tBNHANVIENBindingSource;
        private DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter tB_NHANVIENTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dtngayky;
    }
}