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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace USERMANAGEMENT
{
    public partial class frmnhom : DevExpress.XtraEditors.XtraForm
    {
        public frmnhom()
        {
            InitializeComponent();
        }



        #region Khai báo

        public int _idcty;
        public int _iddvi;
        public int _iduser;

        public bool _them;
        userclass _userclass;
        groupclass _groupclass;
        TB_SYS_USER data;

        // khai báo giữa các form để xài hàm public của nó
        frmquanlynguoidung obfrm = (frmquanlynguoidung)Application.OpenForms["frmquanlynguoidung"];


        useringroupclass _useringroupclass;



        #endregion  






        private void frmnhom_Load(object sender, EventArgs e)
        {
            _groupclass = new groupclass();
            _userclass = new userclass();
            if (!_them)
            {
                var user = _userclass.getitem(_iduser);
                txtfullname.Text = user.FULLNAME;
                txttennhom.Text = user.USERNAME;
                _idcty = (int)user.IDCTY;
                _iddvi = (int)user.IDDVI;
                txttennhom.ReadOnly = true;

                LoadUserInGroup(_iduser);
            }
            else
            {
                txtfullname.Text = "";
                txttennhom.Text = "";
            }

            


        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txttennhom.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttennhom.SelectAll();
                txttennhom.Focus();
                return;
            }
            Savedata();
            this.Close();
        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); 
        }


        void Savedata()
        {
            if (_them)
            {

                bool check = _userclass.checkuser(_idcty, _iddvi, txttennhom.Text.Trim());
                if (check)
                {
                    MessageBox.Show("Nhóm đã tồn tại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttennhom.SelectAll();
                    txttennhom.Focus();
                    return;
                }

                data = new TB_SYS_USER();

                data.USERNAME = txttennhom.Text.Trim();
                data.FULLNAME = txtfullname.Text;

                data.IDCTY = _idcty;
                data.IDDVI = _iddvi;
                //data.LAST_PWD_CHANGED = id.LAST_PWD_CHANGED;
                data.ISGROUP = true;
                data.DISABLE = false;
                _userclass.add(data);
                obfrm.FC_LoadGroup(_idcty, _iddvi, true);
            }
            else
            {


                data = _userclass.getitem(_iduser);

               // data.USERNAME = txttennhom.Text.Trim();
                data.FULLNAME = txtfullname.Text;

                //data.IDCTY = _idcty;
                //data.IDDVI = _iddvi;
                //data.LAST_PWD_CHANGED = id.LAST_PWD_CHANGED;
                //data.ISGROUP = true;
               // data.DISABLE = false;
                _userclass.update(data);
                obfrm.FC_LoadGroup(_idcty, _iddvi, true);
                
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmshowmember frm = new frmshowmember();
            frm._idcty = _idcty;
            frm._iddvi = _iddvi;
            frm._idgroup = _iduser;
            frm.ShowDialog();
        }

        private void btnbot_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.GetFocusedRowCellValue("IDUSER") != null)
            {
               

                var a = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDUSER").ToString());

                _groupclass.delete(a , _iduser);
                LoadUserInGroup(_iduser);
            }
        }


        public void LoadUserInGroup(int idgroup)
        {
            
            _useringroupclass = new useringroupclass();
            gcdanhsach.DataSource = _useringroupclass.getlistuseringroup(_idcty, _iddvi, idgroup);
            gvdanhsach.OptionsBehavior.Editable= false;
        }
    }
}