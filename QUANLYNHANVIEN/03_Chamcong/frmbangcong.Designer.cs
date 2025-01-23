namespace QUANLYNHANVIEN._03_Chamcong
{
    partial class frmbangcong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbangcong));
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDKC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTINHCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnxem = new DevExpress.XtraBars.BarButtonItem();
            this.btndong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chktrangthai = new System.Windows.Forms.CheckBox();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkkhoa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1167, 485);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.IDKC,
            this.TENKC,
            this.NAM,
            this.THANG,
            this.NGAYTINHCONG,
            this.NGAYCONGTRONGTHANG,
            this.KHOA,
            this.TRANGTHAI,
            this.TENCTY});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell_1);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.Caption = " ";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            // 
            // IDKC
            // 
            this.IDKC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDKC.AppearanceHeader.Options.UseFont = true;
            this.IDKC.Caption = "ID";
            this.IDKC.FieldName = "IDKC";
            this.IDKC.MaxWidth = 50;
            this.IDKC.MinWidth = 50;
            this.IDKC.Name = "IDKC";
            this.IDKC.Visible = true;
            this.IDKC.VisibleIndex = 1;
            this.IDKC.Width = 50;
            // 
            // TENKC
            // 
            this.TENKC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TENKC.AppearanceHeader.Options.UseFont = true;
            this.TENKC.Caption = "TÊN KỲ CÔNG";
            this.TENKC.FieldName = "TENKC";
            this.TENKC.MaxWidth = 250;
            this.TENKC.MinWidth = 250;
            this.TENKC.Name = "TENKC";
            this.TENKC.Visible = true;
            this.TENKC.VisibleIndex = 2;
            this.TENKC.Width = 250;
            // 
            // NAM
            // 
            this.NAM.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NAM.AppearanceHeader.Options.UseFont = true;
            this.NAM.Caption = "NĂM";
            this.NAM.FieldName = "NAM";
            this.NAM.MaxWidth = 125;
            this.NAM.MinWidth = 125;
            this.NAM.Name = "NAM";
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 3;
            this.NAM.Width = 125;
            // 
            // THANG
            // 
            this.THANG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.THANG.AppearanceHeader.Options.UseFont = true;
            this.THANG.Caption = "THÁNG";
            this.THANG.FieldName = "THANG";
            this.THANG.MaxWidth = 200;
            this.THANG.MinWidth = 200;
            this.THANG.Name = "THANG";
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 4;
            this.THANG.Width = 200;
            // 
            // NGAYTINHCONG
            // 
            this.NGAYTINHCONG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYTINHCONG.AppearanceHeader.Options.UseFont = true;
            this.NGAYTINHCONG.Caption = "NGÀY BẮT ĐẦU TÍNH CÔNG";
            this.NGAYTINHCONG.FieldName = "NGAYTINHCONG";
            this.NGAYTINHCONG.MaxWidth = 250;
            this.NGAYTINHCONG.MinWidth = 250;
            this.NGAYTINHCONG.Name = "NGAYTINHCONG";
            this.NGAYTINHCONG.Visible = true;
            this.NGAYTINHCONG.VisibleIndex = 5;
            this.NGAYTINHCONG.Width = 250;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG TRONG THANG";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 300;
            this.NGAYCONGTRONGTHANG.MinWidth = 300;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 6;
            this.NGAYCONGTRONGTHANG.Width = 300;
            // 
            // KHOA
            // 
            this.KHOA.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.KHOA.AppearanceHeader.Options.UseFont = true;
            this.KHOA.Caption = "KHÓA KỲ CÔNG";
            this.KHOA.FieldName = "KHOA";
            this.KHOA.MaxWidth = 150;
            this.KHOA.MinWidth = 150;
            this.KHOA.Name = "KHOA";
            this.KHOA.Visible = true;
            this.KHOA.VisibleIndex = 7;
            this.KHOA.Width = 150;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TRANGTHAI.AppearanceHeader.Options.UseFont = true;
            this.TRANGTHAI.Caption = "TRẠNG THÁI";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MaxWidth = 250;
            this.TRANGTHAI.MinWidth = 250;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 8;
            this.TRANGTHAI.Width = 250;
            // 
            // TENCTY
            // 
            this.TENCTY.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TENCTY.AppearanceHeader.Options.UseFont = true;
            this.TENCTY.Caption = "CÔNG TY";
            this.TENCTY.FieldName = "TENCTY";
            this.TENCTY.MaxWidth = 250;
            this.TENCTY.MinWidth = 250;
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.Visible = true;
            this.TENCTY.VisibleIndex = 9;
            this.TENCTY.Width = 250;
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
            this.barButtonItem1,
            this.btnxem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick_1);
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
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.LargeImage")));
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuy_ItemClick);
            // 
            // btnxem
            // 
            this.btnxem.Caption = "Xem bảng công";
            this.btnxem.Id = 9;
            this.btnxem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnxem.ImageOptions.SvgImage")));
            this.btnxem.Name = "btnxem";
            this.btnxem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxem_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // btnin
            // 
            this.btnin.Id = 7;
            this.btnin.Name = "btnin";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // cbnam
            // 
            this.cbnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbnam.Location = new System.Drawing.Point(119, 27);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(135, 27);
            this.cbnam.TabIndex = 21;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(61, 30);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(39, 19);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Năm:";
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
            this.splitContainer1.Panel1.Controls.Add(this.chktrangthai);
            this.splitContainer1.Panel1.Controls.Add(this.cbthang);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cbnam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainer1.Panel1.Controls.Add(this.chkkhoa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 606);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 7;
            // 
            // chktrangthai
            // 
            this.chktrangthai.AutoSize = true;
            this.chktrangthai.Location = new System.Drawing.Point(301, 75);
            this.chktrangthai.Name = "chktrangthai";
            this.chktrangthai.Size = new System.Drawing.Size(161, 23);
            this.chktrangthai.TabIndex = 24;
            this.chktrangthai.Text = "Trạng thái kỳ công";
            this.chktrangthai.UseVisualStyleBackColor = true;
            // 
            // cbthang
            // 
            this.cbthang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbthang.Location = new System.Drawing.Point(119, 71);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(135, 27);
            this.cbthang.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 19);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Tháng:";
            // 
            // chkkhoa
            // 
            this.chkkhoa.AutoSize = true;
            this.chkkhoa.Location = new System.Drawing.Point(301, 31);
            this.chkkhoa.Name = "chkkhoa";
            this.chkkhoa.Size = new System.Drawing.Size(123, 23);
            this.chkkhoa.TabIndex = 8;
            this.chkkhoa.Text = "Khóa kỳ công";
            this.chkkhoa.UseVisualStyleBackColor = true;
            // 
            // frmbangcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 652);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmbangcong";
            this.Text = "Bảng công";
            this.Load += new System.EventHandler(this.frmbangcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn IDKC;
        private DevExpress.XtraGrid.Columns.GridColumn TENKC;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraGrid.Columns.GridColumn KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTINHCONG;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.BarButtonItem btnhuy;
        private DevExpress.XtraBars.BarButtonItem btnxem;
        private DevExpress.XtraBars.BarButtonItem btndong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbnam;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.CheckBox chkkhoa;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.CheckBox chktrangthai;
        private System.Windows.Forms.ComboBox cbthang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
    }
}