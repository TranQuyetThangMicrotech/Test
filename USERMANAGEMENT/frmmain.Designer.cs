namespace USERMANAGEMENT
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuthongtin = new DevExpress.XtraBars.BarButtonItem();
            this.mnudoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.mnuquanlynguoidung = new DevExpress.XtraBars.BarButtonItem();
            this.mnuthoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.mnuthongtin,
            this.mnudoimatkhau,
            this.mnuquanlynguoidung,
            this.mnuthoat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1503, 179);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // mnuthongtin
            // 
            this.mnuthongtin.Caption = "Thông tin";
            this.mnuthongtin.Id = 1;
            this.mnuthongtin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.mnuthongtin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.mnuthongtin.Name = "mnuthongtin";
            // 
            // mnudoimatkhau
            // 
            this.mnudoimatkhau.Caption = "Đổi mật khẩu";
            this.mnudoimatkhau.Id = 2;
            this.mnudoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.mnudoimatkhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.mnudoimatkhau.Name = "mnudoimatkhau";
            // 
            // mnuquanlynguoidung
            // 
            this.mnuquanlynguoidung.Caption = "Quản lý người dùng";
            this.mnuquanlynguoidung.Id = 3;
            this.mnuquanlynguoidung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.mnuquanlynguoidung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.mnuquanlynguoidung.Name = "mnuquanlynguoidung";
            this.mnuquanlynguoidung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuquanlynguoidung_ItemClick);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Caption = "Thoát";
            this.mnuthoat.Id = 4;
            this.mnuthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.mnuthoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuthoat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuthongtin);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnudoimatkhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuquanlynguoidung);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuthoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 911);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1503, 27);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 938);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmmain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem mnuthongtin;
        private DevExpress.XtraBars.BarButtonItem mnudoimatkhau;
        private DevExpress.XtraBars.BarButtonItem mnuquanlynguoidung;
        private DevExpress.XtraBars.BarButtonItem mnuthoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}