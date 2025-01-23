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
using BLL;
using DAL;
using USERMANAGEMENT.Mycomponents;
using BLL._02_Nhansu._01_Danhmucdungchung;

namespace USERMANAGEMENT
{
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmmain()
        {


            InitializeComponent();
        }



       



        #region Function Block form con hiển thị trong form cha
        void FB_OpenForm(Type typefrm) // truyền vào form 
        {
            // Duyệt qua các form con đã mở
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typefrm)
                {
                    frm.Activate();
                    return;
                }
            }
            // Tạo và hiển thị form con nếu chưa mở
            Form f = (Form)Activator.CreateInstance(typefrm);
            f.MdiParent = this;
            f.Show();
        }

      


        #endregion

        private void frmmain_Load(object sender, EventArgs e)
        {

            
        }

        private void mnuthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void mnuquanlynguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmquanlynguoidung));
        }
    }
}