using BLL._02_Nhansu._01_Danhmucdungchung;
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

namespace QUANLYNHANVIEN._02_Nhansu._01_Danhmucdungchung
{
    public partial class frmtrinhdo : DevExpress.XtraEditors.XtraForm
    {
        public frmtrinhdo()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        TrinhDo _trinhdoclass;
        bool _them;
        int _id;
        #endregion

        #region Function

        void FC_Cleardata()
        {
            txtTenTrinhDo.Text= string.Empty;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;
            splitContainer1.Panel1Collapsed = on;

            btnLuu.Enabled = !on;
            btnHuy.Enabled = !on;  
        }
        #endregion


        private void frmtrinhdo_Load(object sender, EventArgs e)
        {
            //_trinhdoclass = new trinhdoclass();
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }


        void Loaddata()
        {
            _trinhdoclass= new TrinhDo();
            gcdanhsach.DataSource = _trinhdoclass.GetList();
            gvdanhsach.OptionsBehavior.Editable= false;
        }

        void Savedata()
        {
            if(string.IsNullOrWhiteSpace(txtTenTrinhDo.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin vào ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_them)
            {
                TB_TRINHDO data = new TB_TRINHDO();
                data.TENTD = txtTenTrinhDo.Text;
                _trinhdoclass.Add(data);
            }
            else
            {
                var data = _trinhdoclass.GetItem(_id);
                data.TENTD = txtTenTrinhDo.Text;
                _trinhdoclass.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if(gvdanhsach.RowCount >0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDTD").ToString());
                txtTenTrinhDo.Text = gvdanhsach.GetFocusedRowCellValue("TENTD").ToString();
            }
        }

        #region BTN
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
            _them= true;
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            _them = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _trinhdoclass.Delete(_id);
                Loaddata();
            }
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            Savedata();
            Loaddata();
            _them = false;
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(true);
            _them = false;
        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

       
    }
}