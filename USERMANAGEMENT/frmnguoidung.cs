using BLL.Login;
using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace USERMANAGEMENT
{
    public partial class frmnguoidung : DevExpress.XtraEditors.XtraForm
    {
        public frmnguoidung()
        {
            InitializeComponent();
        }


        #region Khai báo

        public int _idcty;
        public int _iddvi;
        public int _iduser;
        public bool _them;

        //encryptorclass _pass;
        userclass _userclass;
        groupclass _groupclass;
        TB_SYS_USER data;

        // khai báo giữa các form để xài hàm public của nó
        frmquanlynguoidung obfrm = (frmquanlynguoidung)Application.OpenForms["frmquanlynguoidung"];
        frmnhom obfrmnhom = (frmnhom)Application.OpenForms["frmnhom"];

        useringroupclass _useringroupclass;


        #endregion








        private void frmnguoidung_Load(object sender, EventArgs e)
        {
            _userclass = new userclass();
            if (!_them)
            {
                var user = _userclass.getitem(_iduser);
                txthoten.Text = user.FULLNAME;
                txtuser.Text = user.USERNAME;
                _idcty = (int)user.IDCTY;
                _iddvi = (int)user.IDDVI;

                chkkichhoat.Checked = (bool)user.DISABLE;
                txtpass.Text = encryptorclass.Decrypt(user.PASSWORD, "qwert@123!poiuy", true);
                txtpassfor.Text = encryptorclass.Decrypt(user.PASSWORD, "qwert@123!poiuy", true);


                txtuser.ReadOnly = true;
                LoadGroupInUser(_iduser);
            }
            else
            {
                txthoten.Text = "";
                txtuser.Text = "";
                txtpass.Text = "";
                txtpassfor.Text = "";
                chkkichhoat.Checked = false;
            }


            _userclass = new userclass();
            _groupclass = new groupclass();
            _useringroupclass = new useringroupclass();



        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.SelectAll();
                txtuser.Focus();
                return;
            }

            if (!txtpass.Text.Equals(txtpassfor.Text))

            {
                MessageBox.Show("Mật khẩu không trùng khớp, Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.SelectAll();
                txtuser.Focus();
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

                bool check = _userclass.checkuser(_idcty, _iddvi, txtuser.Text.Trim());
                if (check)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.SelectAll();
                    txtuser.Focus();
                    return;
                }

                data = new TB_SYS_USER();

                data.USERNAME = txtuser.Text.Trim();
                data.FULLNAME = txthoten.Text;

                data.IDCTY = _idcty;
                data.IDDVI = _iddvi;
                data.LAST_PWD_CHANGED = DateTime.Now;
                data.ISGROUP = false;
                data.DISABLE = chkkichhoat.Checked;
              
                data.PASSWORD = encryptorclass.Encrypt(txtpass.Text.Trim(), "qwert@123!poiuy", true);

                _userclass.add(data);
                obfrm.FC_LoadUser(_idcty, _iddvi, false);
            }
            else
            {
                data = _userclass.getitem(_iduser);

                data.USERNAME = txtuser.Text.Trim();
                data.FULLNAME = txthoten.Text;

                data.IDCTY = _idcty;
                data.IDDVI = _iddvi;
                data.LAST_PWD_CHANGED = DateTime.Now;
                data.ISGROUP = false;
                data.DISABLE = chkkichhoat.Checked;
                data.PASSWORD = encryptorclass.Encrypt(txtpass.Text.Trim(), "qwert@123!poiuy", true);

                _userclass.update(data);
                obfrm.FC_LoadUser(_idcty, _iddvi, false);

            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmshowgroup frm = new frmshowgroup();
            frm._idcty = _idcty;
            frm._iddvi = _iddvi;
            frm._iduser = _iduser;
            frm.ShowDialog();
        }

        private void btnbot_Click(object sender, EventArgs e)
        {
            if (gvgroup.GetFocusedRowCellValue("IDUSER") != null)
            {

                //_groupclass = new groupclass();

                var a = int.Parse(gvgroup.GetFocusedRowCellValue("IDUSER").ToString());

                _groupclass.delete(_iduser, a);
                LoadGroupInUser(_iduser);
                //obfrmnhom.LoadUserInGroup(_iduser);
            }
        }


        public void LoadGroupInUser(int iduser)
        {
            _useringroupclass = new useringroupclass();
            gcgroup.DataSource = _useringroupclass.getlistgroupinuser(_idcty, _iddvi, iduser);
            gvgroup.OptionsBehavior.Editable = false;   
        }



    }
}