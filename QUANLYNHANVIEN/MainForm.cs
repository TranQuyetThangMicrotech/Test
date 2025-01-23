using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL._02_Nhansu._02_Nghiepvu;
using QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung;
using QUANLYNHANVIEN._02_Nhansu._02_Nghiepvu;
using QUANLYNHANVIEN._02_Nhansu.Danhmucdungchung;
using QUANLYNHANVIEN._03_Chamcong;
using QUANLYNHANVIEN._03_Loaica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANVIEN
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        NhanVien _nhanvienclass;
        HopDong _hopdongclass;
        private void MainForm_Load(object sender, EventArgs e)
        {
            _nhanvienclass = new NhanVien();
            _hopdongclass= new HopDong();
            Loadsinhnhat();
            Loadlenlluong();
            ribbonPage3.Ribbon.Visible = true;
        }

        void Loadsinhnhat()
        {
            lstsinhnhat.DataSource = _nhanvienclass.GetSinhNhat();
            lstsinhnhat.DisplayMember = "TENNV";
            lstsinhnhat.ValueMember = "IDNV";
        }
        void Loadlenlluong()
        {
            lstlenluong.DataSource = _hopdongclass.GetLenLuong();
            lstlenluong.DisplayMember = "TENNV";
            lstlenluong.ValueMember = "IDNV";
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

        private void mnudantoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmdantoc));
        }

        private void mnutongiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmtongiao));
        }

        private void mnutrinhdo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmtrinhdo));
        }

        private void mnuphongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmphongban));
        }

        private void mnuchucvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmchucvu));
        }

        private void mnubophan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmbophan));
        }

        private void mnucongty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmcongty));
        }

        private void mnunhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmnhanvien));
        }

        private void mnuhopdong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmhopdong));
        }

        private void mnukhenthuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmkhenthuong));
        }

        private void mnukyluat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmkyluat));
        }

        private void mnudieuchuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmdieuchuyen));
        }

        private void mnuthoiviec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmthoiviec));
        }

        private void mnunangluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmnangluong));
        }

        private void lstlenluong_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(2, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void lstsinhnhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(2, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void mnuloaica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmloaica));
        }

        private void mnuloaicong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmloaicong));
        }

        private void mnubangcong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmbangcong));
        }

        private void mudonvi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FB_OpenForm(typeof(frmdonvi));
        }
    }
}
