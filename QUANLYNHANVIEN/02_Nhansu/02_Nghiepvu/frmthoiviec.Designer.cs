namespace QUANLYNHANVIEN._02_Nhansu._02_Nghiepvu
{
    partial class frmthoiviec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthoiviec));
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnphoto = new DevExpress.XtraBars.BarButtonItem();
            this.btndong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.COLTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLIDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dB_QUANLYNHANSUDataSet = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSet();
            this.tBNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slknhanvien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtngaynopdon = new System.Windows.Forms.DateTimePicker();
            this.txttenkhenthuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtngaynghi = new System.Windows.Forms.DateTimePicker();
            this.txtnoidung = new DevExpress.XtraEditors.TextEdit();
            this.txtlydo = new DevExpress.XtraEditors.TextEdit();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYNOPDON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYNGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tB_NHANVIENTableAdapter = new QUANLYNHANVIEN.DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slknhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhenthuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlydo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 767);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnluu,
            this.btnhuy,
            this.btndong,
            this.btnin,
            this.btnphoto});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(-126, 138);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnluu, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnhuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnphoto, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnthem.ImageOptions.SvgImage")));
            this.btnthem.Name = "btnthem";
            this.btnthem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Id = 1;
            this.btnsua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsua.ImageOptions.SvgImage")));
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa";
            this.btnxoa.Id = 2;
            this.btnxoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnxoa.ImageOptions.SvgImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnluu
            // 
            this.btnluu.Caption = "Lưu";
            this.btnluu.Id = 3;
            this.btnluu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnluu.ImageOptions.SvgImage")));
            this.btnluu.Name = "btnluu";
            this.btnluu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick);
            // 
            // btnhuy
            // 
            this.btnhuy.Caption = "Hủy";
            this.btnhuy.Id = 4;
            this.btnhuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnhuy.ImageOptions.SvgImage")));
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuy_ItemClick);
            // 
            // btnphoto
            // 
            this.btnphoto.Caption = "In";
            this.btnphoto.Id = 8;
            this.btnphoto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnphoto.ImageOptions.SvgImage")));
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphoto_ItemClick);
            // 
            // btndong
            // 
            this.btndong.Caption = "Đóng";
            this.btndong.Id = 5;
            this.btndong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndong.ImageOptions.SvgImage")));
            this.btndong.Name = "btndong";
            this.btndong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1328, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 793);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1328, 20);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1328, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 767);
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
            // slknhanvien
            // 
            this.slknhanvien.Location = new System.Drawing.Point(514, 7);
            this.slknhanvien.MenuManager = this.barManager1;
            this.slknhanvien.Name = "slknhanvien";
            this.slknhanvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slknhanvien.Properties.DataSource = this.tBNHANVIENBindingSource;
            this.slknhanvien.Properties.DisplayMember = "TENNV";
            this.slknhanvien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slknhanvien.Properties.ValueMember = "IDNV";
            this.slknhanvien.Size = new System.Drawing.Size(228, 26);
            this.slknhanvien.TabIndex = 13;
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(81, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày nộp đơn:";
            // 
            // dtngaynopdon
            // 
            this.dtngaynopdon.CustomFormat = "dd/MM/yyyy";
            this.dtngaynopdon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaynopdon.Location = new System.Drawing.Point(193, 40);
            this.dtngaynopdon.Name = "dtngaynopdon";
            this.dtngaynopdon.Size = new System.Drawing.Size(200, 27);
            this.dtngaynopdon.TabIndex = 2;
            this.dtngaynopdon.Value = new System.DateTime(2025, 12, 1, 1, 12, 0, 0);
            this.dtngaynopdon.ValueChanged += new System.EventHandler(this.dtngaynopdon_ValueChanged);
            // 
            // txttenkhenthuong
            // 
            this.txttenkhenthuong.Enabled = false;
            this.txttenkhenthuong.Location = new System.Drawing.Point(193, 7);
            this.txttenkhenthuong.MenuManager = this.barManager1;
            this.txttenkhenthuong.Name = "txttenkhenthuong";
            this.txttenkhenthuong.Size = new System.Drawing.Size(200, 26);
            this.txttenkhenthuong.TabIndex = 1;
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.dtngaynghi);
            this.splitContainer1.Panel1.Controls.Add(this.txtnoidung);
            this.splitContainer1.Panel1.Controls.Add(this.txtlydo);
            this.splitContainer1.Panel1.Controls.Add(this.slknhanvien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtngaynopdon);
            this.splitContainer1.Panel1.Controls.Add(this.txttenkhenthuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1328, 767);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(402, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 19);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Ngày nghỉ:";
            // 
            // dtngaynghi
            // 
            this.dtngaynghi.CustomFormat = "dd/MM/yyyy";
            this.dtngaynghi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaynghi.Location = new System.Drawing.Point(514, 38);
            this.dtngaynghi.Name = "dtngaynghi";
            this.dtngaynghi.Size = new System.Drawing.Size(228, 27);
            this.dtngaynghi.TabIndex = 18;
            this.dtngaynghi.Value = new System.DateTime(2025, 12, 1, 1, 12, 0, 0);
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(187, 106);
            this.txtnoidung.MenuManager = this.barManager1;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(553, 26);
            this.txtnoidung.TabIndex = 15;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(187, 74);
            this.txtlydo.MenuManager = this.barManager1;
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(430, 26);
            this.txtlydo.TabIndex = 14;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1328, 617);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.IDTV,
            this.NGAYNOPDON,
            this.NGAYNGHI,
            this.LYDO,
            this.NOIDUNG,
            this.IDNV,
            this.TENNV});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.Caption = " ";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 100;
            this.DELETED_BY.MinWidth = 100;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            this.DELETED_BY.Width = 100;
            // 
            // IDTV
            // 
            this.IDTV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDTV.AppearanceHeader.Options.UseFont = true;
            this.IDTV.Caption = "SỐ THÔI VIỆC";
            this.IDTV.FieldName = "IDTV";
            this.IDTV.MaxWidth = 250;
            this.IDTV.MinWidth = 250;
            this.IDTV.Name = "IDTV";
            this.IDTV.Visible = true;
            this.IDTV.VisibleIndex = 1;
            this.IDTV.Width = 250;
            // 
            // NGAYNOPDON
            // 
            this.NGAYNOPDON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NGAYNOPDON.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYNOPDON.AppearanceHeader.Options.UseFont = true;
            this.NGAYNOPDON.Caption = "NGÀY NỘP ĐƠN";
            this.NGAYNOPDON.FieldName = "NGAYNOPDON";
            this.NGAYNOPDON.MaxWidth = 300;
            this.NGAYNOPDON.MinWidth = 300;
            this.NGAYNOPDON.Name = "NGAYNOPDON";
            this.NGAYNOPDON.Visible = true;
            this.NGAYNOPDON.VisibleIndex = 2;
            this.NGAYNOPDON.Width = 300;
            // 
            // NGAYNGHI
            // 
            this.NGAYNGHI.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYNGHI.AppearanceHeader.Options.UseFont = true;
            this.NGAYNGHI.Caption = "NGÀY NGHỈ";
            this.NGAYNGHI.FieldName = "NGAYNGHI";
            this.NGAYNGHI.MaxWidth = 150;
            this.NGAYNGHI.MinWidth = 150;
            this.NGAYNGHI.Name = "NGAYNGHI";
            this.NGAYNGHI.Visible = true;
            this.NGAYNGHI.VisibleIndex = 3;
            this.NGAYNGHI.Width = 150;
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
            this.LYDO.VisibleIndex = 4;
            this.LYDO.Width = 300;
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
            this.NOIDUNG.VisibleIndex = 5;
            this.NOIDUNG.Width = 350;
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
            // tB_NHANVIENTableAdapter
            // 
            this.tB_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmthoiviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 813);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmthoiviec";
            this.Text = "Thôi việc";
            this.Load += new System.EventHandler(this.frmthoiviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QUANLYNHANSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slknhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhenthuong.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlydo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.BarButtonItem btnhuy;
        private DevExpress.XtraBars.BarButtonItem btnphoto;
        private DevExpress.XtraBars.BarButtonItem btndong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtnoidung;
        private DevExpress.XtraEditors.TextEdit txtlydo;
        private DevExpress.XtraEditors.SearchLookUpEdit slknhanvien;
        private System.Windows.Forms.BindingSource tBNHANVIENBindingSource;
        private DB_QUANLYNHANSUDataSet dB_QUANLYNHANSUDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn COLIDNV;
        private DevExpress.XtraGrid.Columns.GridColumn COLTENNV;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtngaynopdon;
        private DevExpress.XtraEditors.TextEdit txttenkhenthuong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn IDTV;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNOPDON;
        private DevExpress.XtraGrid.Columns.GridColumn LYDO;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DB_QUANLYNHANSUDataSetTableAdapters.TB_NHANVIENTableAdapter tB_NHANVIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNGHI;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtngaynghi;
    }
}