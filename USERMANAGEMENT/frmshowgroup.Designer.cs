namespace USERMANAGEMENT
{
    partial class frmshowgroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmshowgroup));
            this.FULLNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDUSER1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvgroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.USERNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcgroup = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btndong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            this.SuspendLayout();
            // 
            // FULLNAME1
            // 
            this.FULLNAME1.Caption = "FULLNAME";
            this.FULLNAME1.FieldName = "FULLNAME";
            this.FULLNAME1.Name = "FULLNAME1";
            this.FULLNAME1.Visible = true;
            this.FULLNAME1.VisibleIndex = 1;
            // 
            // IDUSER1
            // 
            this.IDUSER1.Caption = "gridColumn1";
            this.IDUSER1.FieldName = "IDUSER";
            this.IDUSER1.Name = "IDUSER1";
            // 
            // gvgroup
            // 
            this.gvgroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER1,
            this.USERNAME1,
            this.FULLNAME1});
            this.gvgroup.GridControl = this.gcgroup;
            this.gvgroup.Name = "gvgroup";
            this.gvgroup.OptionsView.ShowGroupPanel = false;
            // 
            // USERNAME1
            // 
            this.USERNAME1.Caption = "USERNAME";
            this.USERNAME1.FieldName = "USERNAME";
            this.USERNAME1.Name = "USERNAME1";
            this.USERNAME1.Visible = true;
            this.USERNAME1.VisibleIndex = 0;
            // 
            // gcgroup
            // 
            this.gcgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcgroup.Location = new System.Drawing.Point(0, 28);
            this.gcgroup.MainView = this.gvgroup;
            this.gcgroup.MenuManager = this.barManager1;
            this.gcgroup.Name = "gcgroup";
            this.gcgroup.Size = new System.Drawing.Size(552, 365);
            this.gcgroup.TabIndex = 13;
            this.gcgroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvgroup});
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
            this.btnluu,
            this.btndong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnluu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnluu
            // 
            this.btnluu.Caption = "Lưu";
            this.btnluu.Id = 0;
            this.btnluu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnluu.ImageOptions.SvgImage")));
            this.btnluu.Name = "btnluu";
            this.btnluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick);
            // 
            // btndong
            // 
            this.btndong.Caption = "Đóng";
            this.btndong.Id = 1;
            this.btndong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndong.ImageOptions.SvgImage")));
            this.btndong.Name = "btndong";
            this.btndong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(552, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 393);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(552, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 365);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(552, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 365);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(552, 365);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FULLNAME
            // 
            this.FULLNAME.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.FULLNAME.AppearanceHeader.Options.UseFont = true;
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MaxWidth = 200;
            this.FULLNAME.MinWidth = 200;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 1;
            this.FULLNAME.Width = 200;
            // 
            // USERNAME
            // 
            this.USERNAME.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.USERNAME.AppearanceHeader.Options.UseFont = true;
            this.USERNAME.Caption = "TÊN NGƯỜI DÙNG";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MaxWidth = 200;
            this.USERNAME.MinWidth = 200;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
            this.USERNAME.Width = 200;
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "IDUSER";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.Name = "IDUSER";
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsView.ShowGroupPanel = false;
            // 
            // gc
            // 
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.Location = new System.Drawing.Point(0, 28);
            this.gc.MainView = this.gv;
            this.gc.MenuManager = this.barManager1;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(552, 365);
            this.gc.TabIndex = 12;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // frmshowgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 393);
            this.Controls.Add(this.gcgroup);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmshowgroup";
            this.Text = "Danh sách nhóm";
            this.Load += new System.EventHandler(this.frmshowgroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvgroup;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME1;
        private DevExpress.XtraGrid.GridControl gcgroup;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.BarButtonItem btndong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
    }
}