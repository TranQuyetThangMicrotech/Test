using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL.Login;
using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USERMANAGEMENT.Mycomponents;

namespace USERMANAGEMENT
{
    public partial class frmquanlynguoidung : DevExpress.XtraEditors.XtraForm
    {
        public frmquanlynguoidung()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {






        }



        #region Khai báo

        MyTreeViewCombo _mytreeviewcombobox;
        CongTy _congtyclass;
        DonVi _donviclass;
        userclass _userclass;
        bool _isRoot;
        string _macty;
        string _madvi;

        public int macty;
        public int madvi;
        
        //public 



        #endregion



        public void FC_LoadUser(int macty, int madonvi, bool isgroup)
        {
            _userclass = new userclass();
            gcdanhsachuser.DataSource = _userclass.getlistuser(macty, madonvi, isgroup);
            gvdanhsachuser.OptionsBehavior.Editable= false;
        }

        public void FC_LoadGroup(int macty, int madonvi, bool isgroup)
        {
            _userclass = new userclass();
            gcdanhsachnhom.DataSource = _userclass.getlistgroup(macty, madonvi, isgroup);
            gvdanhsachnhom.OptionsBehavior.Editable = false;
        }



        void FC_LoadTreeView()
        {
            _mytreeviewcombobox = new MyTreeViewCombo(panel1.Width, 250);
            _mytreeviewcombobox.Font = new Font("Tahoma", 10, FontStyle.Bold);

            var lstCTY = _congtyclass.GetList();
            foreach (var item in lstCTY)
            {
                TreeNode parentNode = new TreeNode();
                parentNode.Text = item.IDCTY + " - " + item.TENCTY;
                parentNode.Tag = item.IDCTY;
                parentNode.Name = item.IDCTY.ToString();

                _mytreeviewcombobox.TreeView.Nodes.Add(parentNode);

                foreach (var dv in _donviclass.GetList(item.IDCTY))
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = dv.IDDVI + "-" + dv.TENDVI;
                    childNode.Tag = dv.IDCTY + "." +dv.IDDVI; 
                    childNode.Name = dv.IDCTY + "." + dv.IDDVI; 
                    parentNode.Nodes.Add(childNode);
                }
            }

            _mytreeviewcombobox.TreeView.ExpandAll();
            panel1.Controls.Add(_mytreeviewcombobox);
            _mytreeviewcombobox.Width = panel1.Width;
            _mytreeviewcombobox.Height= panel1.Height;
            _mytreeviewcombobox.TreeView.AfterSelect += TreeView_AfterSelect; ;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _mytreeviewcombobox.Text = _mytreeviewcombobox.TreeView.SelectedNode.Text;
            if(_mytreeviewcombobox.TreeView.SelectedNode.Parent == null)
            {
                _isRoot = true;
                _macty = _mytreeviewcombobox.TreeView.SelectedNode.Tag.ToString();
                _madvi = "99";
            }

            else
            {
                _isRoot = false;
                //_macty = _mytreeviewcombobox.TreeView.SelectedNode.Name.Substring(0, 1);
                //_madvi = _mytreeviewcombobox.TreeView.SelectedNode.Name.Substring(2);


                // Tách chuỗi bằng ký tự '.'
                var parts = _mytreeviewcombobox.TreeView.SelectedNode.Name.Split('.');
                if (parts.Length == 2)
                {
                    _macty = parts[0];
                    _madvi = parts[1];
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể tách chuỗi IDCTY và IDDVI.");
                    return;
                }


            }
                _mytreeviewcombobox.dropDown.Close();
            //MessageBox.Show(_macty + "-" + _madvi);

            macty = int.Parse(_macty);
            madvi = int.Parse(_madvi);  

            FC_LoadUser(macty, madvi, false);
            FC_LoadGroup(macty, madvi, true);


        }

        private void frmquanlynguoidung_Load(object sender, EventArgs e)
        {
            _congtyclass = new CongTy();
            _donviclass= new DonVi();
            _userclass = new userclass();
            FC_LoadTreeView();
            FC_LoadUser(1, 1, false);
            FC_LoadGroup(1, 1, true);
        }

        

        private void btnthemnguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_mytreeviewcombobox.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmnguoidung frm = new frmnguoidung();
            frm._them = true;
            frm._idcty = macty;
            frm._iddvi = madvi;
            frm.ShowDialog();
        }

        private void btnthemnhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_mytreeviewcombobox.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmnhom frm = new frmnhom();
            frm._them = true;
            frm._idcty = macty;
            frm._iddvi = madvi;
            frm.ShowDialog();
        }

        

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btncapnhatquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvdanhsachnhom_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0) // Hàng nhóm (Group Row)
                {
                    // Gán số thứ tự cho hàng nhóm
                    e.Info.DisplayText = $"[{Math.Abs(e.RowHandle)}]"; // STT cho nhóm (tự tính toán)
                }
                else if (e.RowHandle >= 0) // Hàng dữ liệu
                {
                    // Gán số thứ tự cho hàng dữ liệu
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }

                // Căn giữa số
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        private void gvdanhsachuser_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0) // Hàng nhóm (Group Row)
                {
                    // Gán số thứ tự cho hàng nhóm
                    e.Info.DisplayText = $"[{Math.Abs(e.RowHandle)}]"; // STT cho nhóm (tự tính toán)
                }
                else if (e.RowHandle >= 0) // Hàng dữ liệu
                {
                    // Gán số thứ tự cho hàng dữ liệu
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }

                // Căn giữa số
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        private void gvdanhsachnhom_DoubleClick(object sender, EventArgs e)
        {
            if (gvdanhsachnhom.RowCount >0 && gvdanhsachnhom.GetFocusedRowCellValue("ISGROUP").Equals(true))
            {
                frmnhom frm = new frmnhom();
                frm._them = false;
                frm._iduser = int.Parse(gvdanhsachnhom.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
            
        }

        private void gvdanhsachnhom_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == true)
            //{
            //    Image img = Properties.Resources.;
            //    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
            //    e.Handled = true;
            //}
        }

        private void gvdanhsachuser_DoubleClick(object sender, EventArgs e)
        {
            if (gvdanhsachuser.RowCount > 0 && gvdanhsachuser.GetFocusedRowCellValue("ISGROUP").Equals(false))
            {
                frmnguoidung frm = new frmnguoidung();
                frm._them = false;
                frm._iduser = int.Parse(gvdanhsachuser.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
        }

        private void btncapnhatnguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvdanhsachuser.RowCount > 0 && gvdanhsachuser.GetFocusedRowCellValue("ISGROUP").Equals(false))
            {
                frmnguoidung frm = new frmnguoidung();
                frm._them = false;
                frm._iduser = int.Parse(gvdanhsachuser.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
        }

        private void btncapnhatnhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvdanhsachnhom.RowCount > 0 && gvdanhsachnhom.GetFocusedRowCellValue("ISGROUP").Equals(true))
            {
                frmnhom frm = new frmnhom();
                frm._them = false;
                frm._iduser = int.Parse(gvdanhsachnhom.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
        }
    }
}