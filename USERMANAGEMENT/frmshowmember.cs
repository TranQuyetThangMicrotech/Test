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

namespace USERMANAGEMENT
{
    public partial class frmshowmember : DevExpress.XtraEditors.XtraForm
    {
        public frmshowmember()
        {
            InitializeComponent();
        }


        #region Khai báo biến

        public int _idcty;
        public int _iddvi;
        public int _idgroup;

        groupclass _groupclass;
        usernotingroupclass _usernotingroupclass;

        frmnhom objGroup = (frmnhom)Application.OpenForms["frmnhom"];

        #endregion


        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TB_SYS_GROUP gr = new TB_SYS_GROUP();

            gr.GROUP = _idgroup;
            gr.MEMBER=  int.Parse(gvuser.GetFocusedRowCellValue("IDUSER").ToString());
            _groupclass.add(gr);

            objGroup.LoadUserInGroup(_idgroup);

            this.Close();
        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmshowmember_Load(object sender, EventArgs e)
        {
            _groupclass = new groupclass();
            _usernotingroupclass = new usernotingroupclass();
            LoadUsernotinGorup();
        }

        void LoadUsernotinGorup()
        {
            gcuser.DataSource = _usernotingroupclass.getlistusernotingroup(_idcty, _iddvi);
            gvuser.OptionsBehavior.Editable = false;
        }

    }
}