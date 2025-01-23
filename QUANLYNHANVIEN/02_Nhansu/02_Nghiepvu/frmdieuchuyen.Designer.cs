namespace QUANLYNHANVIEN._02_Nhansu._02_Nghiepvu
{
    partial class frmdieuchuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdieuchuyen));
            this.tB_NHANVIENTableAdapter = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENBP2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDBP2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.COLTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLIDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dB_QUANLYNHANSUDataSet = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSet();
            this.tBNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.txtLyDo = new DevExpress.XtraEditors.TextEdit();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhenThuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbChuyenDen = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhenThuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_NHANVIENTableAdapter
            // 
            this.tB_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // IDNV
            // 
            this.IDNV.Caption = "IDNV";
            this.IDNV.FieldName = "LANKI";
            this.IDNV.Name = "IDNV";
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NOIDUNG.AppearanceHeader.Options.UseFont = true;
            this.NOIDUNG.Caption = "NỘI DUNG";
            this.NOIDUNG.FieldName = "NOIDUNG";
            this.NOIDUNG.MaxWidth = 350;
            this.NOIDUNG.MinWidth = 350;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Visible = true;
            this.NOIDUNG.VisibleIndex = 4;
            this.NOIDUNG.Width = 350;
            // 
            // LYDO
            // 
            this.LYDO.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LYDO.AppearanceHeader.Options.UseFont = true;
            this.LYDO.Caption = "LÝ DO";
            this.LYDO.FieldName = "LYDO";
            this.LYDO.MaxWidth = 300;
            this.LYDO.MinWidth = 300;
            this.LYDO.Name = "LYDO";
            this.LYDO.Visible = true;
            this.LYDO.VisibleIndex = 3;
            this.LYDO.Width = 300;
            // 
            // NGAY
            // 
            this.NGAY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NGAY.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAY.AppearanceHeader.Options.UseFont = true;
            this.NGAY.Caption = "NGÀY";
            this.NGAY.FieldName = "NGAY";
            this.NGAY.MaxWidth = 300;
            this.NGAY.MinWidth = 300;
            this.NGAY.Name = "NGAY";
            this.NGAY.Visible = true;
            this.NGAY.VisibleIndex = 2;
            this.NGAY.Width = 300;
            // 
            // IDDC
            // 
            this.IDDC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDDC.AppearanceHeader.Options.UseFont = true;
            this.IDDC.Caption = "SỐ ĐIỀU CHUYỂN";
            this.IDDC.FieldName = "IDDC";
            this.IDDC.MaxWidth = 250;
            this.IDDC.MinWidth = 250;
            this.IDDC.Name = "IDDC";
            this.IDDC.Visible = true;
            this.IDDC.VisibleIndex = 1;
            this.IDDC.Width = 250;
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.IDDC,
            this.NGAY,
            this.LYDO,
            this.NOIDUNG,
            this.IDNV,
            this.TENNV,
            this.TENBP,
            this.TENBP2,
            this.IDBP,
            this.IDBP2});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.Caption = "Del";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 100;
            this.DELETED_BY.MinWidth = 100;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            this.DELETED_BY.Width = 100;
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
            this.TENNV.VisibleIndex = 5;
            this.TENNV.Width = 350;
            // 
            // TENBP
            // 
            this.TENBP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TENBP.AppearanceHeader.Options.UseFont = true;
            this.TENBP.Caption = "BỘ PHẬN CŨ";
            this.TENBP.FieldName = "TENBP";
            this.TENBP.MaxWidth = 300;
            this.TENBP.MinWidth = 300;
            this.TENBP.Name = "TENBP";
            this.TENBP.Visible = true;
            this.TENBP.VisibleIndex = 6;
            this.TENBP.Width = 300;
            // 
            // TENBP2
            // 
            this.TENBP2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TENBP2.AppearanceHeader.Options.UseFont = true;
            this.TENBP2.Caption = "BỘ PHẬN MỚI";
            this.TENBP2.FieldName = "TENBP2";
            this.TENBP2.MaxWidth = 300;
            this.TENBP2.MinWidth = 300;
            this.TENBP2.Name = "TENBP2";
            this.TENBP2.Visible = true;
            this.TENBP2.VisibleIndex = 7;
            this.TENBP2.Width = 300;
            // 
            // IDBP
            // 
            this.IDBP.Caption = "IDPB";
            this.IDBP.FieldName = "IDBP";
            this.IDBP.Name = "IDBP";
            // 
            // IDBP2
            // 
            this.IDBP2.Caption = "IDPB2";
            this.IDBP2.FieldName = "IDBP2";
            this.IDBP2.Name = "IDBP2";
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1886, 882);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnxoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnluu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnhuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuy_ItemClick);
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
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1886, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1060);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1886, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1032);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1886, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1032);
            // 
            // btnin
            // 
            this.btnin.Id = 7;
            this.btnin.Name = "btnin";
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
            // dB_QUANLYNHANSUDataSet
            // 
            this.dB_QUANLYNHANSUDataSet.DataSetName = "DB_QUANLYNHANSUDataSet";
            this.dB_QUANLYNHANSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBNHANVIENBindingSource
            // 
            this.tBNHANVIENBindingSource.DataMember = "TB_NHANVIEN";
            this.tBNHANVIENBindingSource.DataSource = this.dB_QUANLYNHANSUDataSet;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(187, 106);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(553, 26);
            this.txtNoiDung.TabIndex = 15;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(187, 74);
            this.txtLyDo.MenuManager = this.barManager1;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(430, 26);
            this.txtLyDo.TabIndex = 14;
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(514, 7);
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(81, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(417, 11);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Nhân viên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(75, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Nội dung:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(81, 77);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Lý do:";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "mm/dd/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(187, 40);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 27);
            this.dtNgay.TabIndex = 2;
            this.dtNgay.Value = new System.DateTime(2025, 12, 1, 1, 12, 0, 0);
            // 
            // txtTenKhenThuong
            // 
            this.txtTenKhenThuong.Enabled = false;
            this.txtTenKhenThuong.Location = new System.Drawing.Point(187, 8);
            this.txtTenKhenThuong.MenuManager = this.barManager1;
            this.txtTenKhenThuong.Name = "txtTenKhenThuong";
            this.txtTenKhenThuong.Size = new System.Drawing.Size(200, 26);
            this.txtTenKhenThuong.TabIndex = 1;
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
            this.splitContainer1.Panel1.Controls.Add(this.cbChuyenDen);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.txtLyDo);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgay);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKhenThuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1886, 1032);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 7;
            // 
            // cbChuyenDen
            // 
            this.cbChuyenDen.FormattingEnabled = true;
            this.cbChuyenDen.Location = new System.Drawing.Point(514, 37);
            this.cbChuyenDen.Name = "cbChuyenDen";
            this.cbChuyenDen.Size = new System.Drawing.Size(226, 27);
            this.cbChuyenDen.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(417, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 19);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Chuyển đến:";
            // 
            // frmdieuchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1060);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmdieuchuyen";
            this.Text = "Điều chuyển";
            this.Load += new System.EventHandler(this.frmdieuchuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhenThuong.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter tB_NHANVIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn LYDO;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY;
        private DevExpress.XtraGrid.Columns.GridColumn IDDC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPhoto;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txtLyDo;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private System.Windows.Forms.BindingSource tBNHANVIENBindingSource;
        private DB_QUANLYNHANSUDataSet dB_QUANLYNHANSUDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn COLIDNV;
        private DevExpress.XtraGrid.Columns.GridColumn COLTENNV;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private DevExpress.XtraEditors.TextEdit txtTenKhenThuong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private System.Windows.Forms.ComboBox cbChuyenDen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn TENBP;
        private DevExpress.XtraGrid.Columns.GridColumn TENBP2;
        private DevExpress.XtraGrid.Columns.GridColumn IDBP;
        private DevExpress.XtraGrid.Columns.GridColumn IDBP2;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
    }
}