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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace USERMANAGEMENT
{
    public partial class frmshowgroup : DevExpress.XtraEditors.XtraForm
    {
        public frmshowgroup()
        {
            InitializeComponent();
        }


        #region Khai báo biến

        public int _idcty;
        public int _iddvi;
        public int _iduser;

        groupclass _groupclass;
        useringroupclass _useringroupclass;
        frmnguoidung objUser = (frmnguoidung)Application.OpenForms["frmnguoidung"];

        #endregion




        private void frmshowgroup_Load(object sender, EventArgs e)
        {
            _groupclass = new groupclass();
            _useringroupclass = new useringroupclass();
            LoadGroup();
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            var a = int.Parse(gvgroup.GetFocusedRowCellValue("IDUSER").ToString());

            bool chk = _useringroupclass.checkgroupinuser(_iduser, a);
            if (chk)
            {
                MessageBox.Show("Tên nhóm đã được Add trước đó, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TB_SYS_GROUP gr = new TB_SYS_GROUP();

                gr.GROUP = int.Parse(gvgroup.GetFocusedRowCellValue("IDUSER").ToString()); 
                gr.MEMBER = _iduser;
                _groupclass.add(gr);

                //LoadGroup()
                objUser.LoadGroupInUser(_iduser);

                this.Close();
            }

            
        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        //void LoadGroupNotInUser()
        //{
        //   gcgroup.DataSource = _usernotingroupclass.getlistusernotingroup(_idcty, _iddvi);
        //    gvgroup.OptionsBehavior.Editable = false;
        //}

        void LoadGroup()
        {
            gcgroup.DataSource = _useringroupclass.getgroupall(_idcty, _iddvi);
            gvgroup.OptionsBehavior.Editable = false;
        }

        

    }
}