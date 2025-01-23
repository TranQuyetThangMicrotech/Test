namespace QUANLYNHANVIEN._03_Chamcong
{
    partial class frmloaicong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloaicong));
            this.spheso = new DevExpress.XtraEditors.SpinEdit();
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
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtloaicong = new DevExpress.XtraEditors.TextEdit();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DETELED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spheso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtloaicong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // spheso
            // 
            this.spheso.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spheso.Location = new System.Drawing.Point(471, 40);
            this.spheso.MenuManager = this.barManager1;
            this.spheso.Name = "spheso";
            this.spheso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spheso.Size = new System.Drawing.Size(100, 26);
            this.spheso.TabIndex = 3;
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
            this.btnphoto});
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
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.LargeImage")));
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
            this.btnphoto.Id = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1170, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 660);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1170, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1170, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(408, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hệ số:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên loại công:";
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
            this.splitContainer1.Panel1.Controls.Add(this.spheso);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtloaicong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1170, 634);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 8;
            // 
            // txtloaicong
            // 
            this.txtloaicong.Location = new System.Drawing.Point(126, 40);
            this.txtloaicong.MenuManager = this.barManager1;
            this.txtloaicong.Name = "txtloaicong";
            this.txtloaicong.Size = new System.Drawing.Size(250, 26);
            this.txtloaicong.TabIndex = 1;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1170, 519);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DETELED_BY,
            this.IDLC,
            this.TENLC,
            this.HESO});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // IDLC
            // 
            this.IDLC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDLC.AppearanceHeader.Options.UseFont = true;
            this.IDLC.Caption = "ID";
            this.IDLC.FieldName = "IDLC";
            this.IDLC.MaxWidth = 50;
            this.IDLC.MinWidth = 50;
            this.IDLC.Name = "IDLC";
            this.IDLC.Visible = true;
            this.IDLC.VisibleIndex = 1;
            this.IDLC.Width = 50;
            // 
            // TENLC
            // 
            this.TENLC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TENLC.AppearanceHeader.Options.UseFont = true;
            this.TENLC.Caption = "TÊN LOẠI CÔNG";
            this.TENLC.FieldName = "TENLC";
            this.TENLC.MaxWidth = 250;
            this.TENLC.MinWidth = 250;
            this.TENLC.Name = "TENLC";
            this.TENLC.Visible = true;
            this.TENLC.VisibleIndex = 2;
            this.TENLC.Width = 250;
            // 
            // HESO
            // 
            this.HESO.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HESO.AppearanceHeader.Options.UseFont = true;
            this.HESO.Caption = "HỆ SỐ";
            this.HESO.FieldName = "HESO";
            this.HESO.MaxWidth = 125;
            this.HESO.MinWidth = 125;
            this.HESO.Name = "HESO";
            this.HESO.Visible = true;
            this.HESO.VisibleIndex = 3;
            this.HESO.Width = 125;
            // 
            // DETELED_BY
            // 
            this.DETELED_BY.Caption = " ";
            this.DETELED_BY.FieldName = "DETELED_BY";
            this.DETELED_BY.MaxWidth = 50;
            this.DETELED_BY.MinWidth = 50;
            this.DETELED_BY.Name = "DETELED_BY";
            this.DETELED_BY.Visible = true;
            this.DETELED_BY.VisibleIndex = 0;
            this.DETELED_BY.Width = 50;
            // 
            // frmloaicong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 680);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmloaicong";
            this.Text = "Loại công";
            this.Load += new System.EventHandler(this.frmloaicong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spheso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtloaicong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spheso;
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
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtloaicong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn IDLC;
        private DevExpress.XtraGrid.Columns.GridColumn TENLC;
        private DevExpress.XtraGrid.Columns.GridColumn HESO;
        private DevExpress.XtraBars.BarButtonItem btnin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn DETELED_BY;
    }
}