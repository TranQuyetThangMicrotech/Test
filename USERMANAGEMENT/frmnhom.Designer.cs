namespace USERMANAGEMENT
{
    partial class frmnhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnhom));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btndong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtfullname = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhom = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnbot = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennhom.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(568, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(568, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(568, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 28);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(568, 381);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtfullname);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txttennhom);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(562, 347);
            this.xtraTabPage1.Text = "Nhóm";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(196, 165);
            this.txtfullname.MenuManager = this.barManager1;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(214, 26);
            this.txtfullname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả:";
            // 
            // txttennhom
            // 
            this.txttennhom.Location = new System.Drawing.Point(196, 123);
            this.txttennhom.MenuManager = this.barManager1;
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txttennhom.Properties.Appearance.Options.UseFont = true;
            this.txttennhom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttennhom.Size = new System.Drawing.Size(214, 26);
            this.txttennhom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhóm:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.splitContainer1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(562, 347);
            this.xtraTabPage2.Text = "Người dùng trong nhóm";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcdanhsach);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnbot);
            this.splitContainer1.Panel2.Controls.Add(this.btnthem);
            this.splitContainer1.Size = new System.Drawing.Size(562, 347);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.MenuManager = this.barManager1;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(562, 284);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME4});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            // 
            // IDUSER
            // 
            this.IDUSER.Caption = "ID";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.Name = "IDUSER";
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "TÊN ĐĂNG NHẬP";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
            // 
            // FULLNAME4
            // 
            this.FULLNAME4.Caption = "FULLNAME";
            this.FULLNAME4.FieldName = "FULLNAME";
            this.FULLNAME4.Name = "FULLNAME4";
            this.FULLNAME4.Visible = true;
            this.FULLNAME4.VisibleIndex = 1;
            // 
            // btnbot
            // 
            this.btnbot.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnbot.ImageOptions.SvgImage")));
            this.btnbot.Location = new System.Drawing.Point(459, 13);
            this.btnbot.Name = "btnbot";
            this.btnbot.Size = new System.Drawing.Size(81, 29);
            this.btnbot.TabIndex = 1;
            this.btnbot.Text = "Bớt";
            this.btnbot.Click += new System.EventHandler(this.btnbot_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnthem.ImageOptions.SvgImage")));
            this.btnthem.Location = new System.Drawing.Point(372, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 29);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmnhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 409);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmnhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhóm";
            this.Load += new System.EventHandler(this.frmnhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennhom.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.BarButtonItem btndong;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtfullname;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txttennhom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME4;
        private DevExpress.XtraEditors.SimpleButton btnbot;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
    }
}