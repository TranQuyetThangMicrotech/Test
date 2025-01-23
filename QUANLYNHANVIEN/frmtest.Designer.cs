namespace QUANLYNHANVIEN
{
    partial class frmtest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtest));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.Thêm = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.Sửa = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUCNANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.THEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRICHXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.btn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Thêm
            // 
            this.Thêm.Caption = "treeListBand1";
            this.Thêm.Name = "Thêm";
            this.Thêm.Width = 203;
            // 
            // Sửa
            // 
            this.Sửa.Caption = "treeListBand2";
            this.Sửa.Name = "Sửa";
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "treeListBand1";
            this.treeListBand1.Name = "treeListBand1";
            // 
            // treeListBand2
            // 
            this.treeListBand2.Caption = "treeListBand2";
            this.treeListBand2.Name = "treeListBand2";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "icondel.png");
            this.imageCollection1.Images.SetKeyName(1, "icon-developer-icon.png");
            this.imageCollection1.Images.SetKeyName(2, "pic.png");
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chk,
            this.btn});
            this.gcdanhsach.Size = new System.Drawing.Size(1205, 710);
            this.gcdanhsach.TabIndex = 7;
            this.gcdanhsach.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.gcdanhsach.UseEmbeddedNavigator = true;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CHUCNANG,
            this.NHOM,
            this.XEM,
            this.THEM,
            this.SUA,
            this.XOA,
            this.TRICHXUAT});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.GroupCount = 1;
            this.gvdanhsach.IndicatorWidth = 50;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.OptionsView.ShowViewCaption = true;
            this.gvdanhsach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NHOM, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvdanhsach.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvdanhsach.ViewCaption = "A";
            this.gvdanhsach.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvdanhsach_CustomDrawRowIndicator);
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 50;
            this.ID.MinWidth = 50;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 71;
            // 
            // CHUCNANG
            // 
            this.CHUCNANG.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.CHUCNANG.AppearanceHeader.Options.UseFont = true;
            this.CHUCNANG.Caption = "CHỨC NĂNG";
            this.CHUCNANG.FieldName = "CHUCNANG";
            this.CHUCNANG.MaxWidth = 250;
            this.CHUCNANG.MinWidth = 250;
            this.CHUCNANG.Name = "CHUCNANG";
            this.CHUCNANG.Visible = true;
            this.CHUCNANG.VisibleIndex = 1;
            this.CHUCNANG.Width = 250;
            // 
            // NHOM
            // 
            this.NHOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NHOM.AppearanceHeader.Options.UseFont = true;
            this.NHOM.Caption = "Nhóm";
            this.NHOM.FieldName = "NHOM";
            this.NHOM.MaxWidth = 250;
            this.NHOM.MinWidth = 250;
            this.NHOM.Name = "NHOM";
            this.NHOM.Visible = true;
            this.NHOM.VisibleIndex = 2;
            this.NHOM.Width = 250;
            // 
            // XEM
            // 
            this.XEM.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.XEM.AppearanceHeader.Options.UseFont = true;
            this.XEM.Caption = "XEM";
            this.XEM.ColumnEdit = this.chk;
            this.XEM.FieldName = "XEM";
            this.XEM.MaxWidth = 125;
            this.XEM.MinWidth = 125;
            this.XEM.Name = "XEM";
            this.XEM.Visible = true;
            this.XEM.VisibleIndex = 2;
            this.XEM.Width = 125;
            // 
            // chk
            // 
            this.chk.AutoHeight = false;
            this.chk.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgRadio1;
            this.chk.CheckBoxOptions.SvgColorChecked = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.chk.CheckBoxOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.chk.Name = "chk";
            // 
            // THEM
            // 
            this.THEM.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.THEM.AppearanceHeader.Options.UseFont = true;
            this.THEM.Caption = "THÊM";
            this.THEM.ColumnEdit = this.btn;
            this.THEM.FieldName = "THEM";
            this.THEM.MaxWidth = 125;
            this.THEM.MinWidth = 125;
            this.THEM.Name = "THEM";
            this.THEM.Visible = true;
            this.THEM.VisibleIndex = 3;
            this.THEM.Width = 125;
            // 
            // SUA
            // 
            this.SUA.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.SUA.AppearanceHeader.Options.UseFont = true;
            this.SUA.Caption = "SỬA";
            this.SUA.ColumnEdit = this.chk;
            this.SUA.FieldName = "SUA";
            this.SUA.MaxWidth = 125;
            this.SUA.MinWidth = 125;
            this.SUA.Name = "SUA";
            this.SUA.Visible = true;
            this.SUA.VisibleIndex = 4;
            this.SUA.Width = 125;
            // 
            // XOA
            // 
            this.XOA.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.XOA.AppearanceHeader.Options.UseFont = true;
            this.XOA.Caption = "XÓA";
            this.XOA.ColumnEdit = this.chk;
            this.XOA.FieldName = "XOA";
            this.XOA.MaxWidth = 125;
            this.XOA.MinWidth = 125;
            this.XOA.Name = "XOA";
            this.XOA.Visible = true;
            this.XOA.VisibleIndex = 5;
            this.XOA.Width = 125;
            // 
            // TRICHXUAT
            // 
            this.TRICHXUAT.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TRICHXUAT.AppearanceHeader.Options.UseFont = true;
            this.TRICHXUAT.Caption = "TRÍCH XUẤT";
            this.TRICHXUAT.ColumnEdit = this.chk;
            this.TRICHXUAT.FieldName = "TRICHXUAT";
            this.TRICHXUAT.MaxWidth = 175;
            this.TRICHXUAT.MinWidth = 175;
            this.TRICHXUAT.Name = "TRICHXUAT";
            this.TRICHXUAT.Visible = true;
            this.TRICHXUAT.VisibleIndex = 6;
            this.TRICHXUAT.Width = 175;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gcdanhsach;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcdanhsach);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1205, 710);
            this.gridSplitContainer1.TabIndex = 9;
            // 
            // btn
            // 
            this.btn.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn.Name = "btn";
            this.btn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 710);
            this.Controls.Add(this.gridSplitContainer1);
            this.IsMdiContainer = true;
            this.Name = "frmtest";
            this.Text = "frmtest";
            this.Load += new System.EventHandler(this.frmtest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListBand Thêm;
        private DevExpress.XtraTreeList.Columns.TreeListBand Sửa;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn XEM;
        private DevExpress.XtraGrid.Columns.GridColumn THEM;
        private DevExpress.XtraGrid.Columns.GridColumn SUA;
        private DevExpress.XtraGrid.Columns.GridColumn XOA;
        private DevExpress.XtraGrid.Columns.GridColumn TRICHXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn CHUCNANG;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chk;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn;
    }
}