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
    public partial class frmtongiao : DevExpress.XtraEditors.XtraForm
    {



        #region Khai báo biến

        TonGiao _tongiaoclass;
        bool _them;
        int _id;

        #endregion

        #region Function

        void FC_Cleardata()
        {
            txtTenTonGiao.Text = string.Empty;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled= on;
            brnSua.Enabled= on;
            btnXoa.Enabled= on;
            btnDong.Enabled= on;

            btnLuu.Enabled= !on;
            btnHuy.Enabled= !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion



        public frmtongiao()
        {
            InitializeComponent();

        }


        private void frmtongiao_Load(object sender, EventArgs e)
        {
            //_tongiaoclass= new tongiaoclass();  
            Loaddata();
            FC_Showcontrols(true);
            _them = false;
        }

        void Loaddata()
        {
            _tongiaoclass= new TonGiao();
            gcdanhsach.DataSource = _tongiaoclass.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        void Savedata()
        {
            if(string.IsNullOrWhiteSpace(txtTenTonGiao.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin vào ô", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_them)
            {
                TB_TONGIAO data = new TB_TONGIAO();
                data.TENTG = txtTenTonGiao.Text;
                _tongiaoclass.Add(data);
            }
            else
            {
                TB_TONGIAO data = _tongiaoclass.GetItem(_id);
                data.TENTG = txtTenTonGiao.Text;
                _tongiaoclass.Update(data);
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if(gvdanhsach.RowCount >0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDTG").ToString());
                txtTenTonGiao.Text = gvdanhsach.GetFocusedRowCellValue("TENTG").ToString(); 
            }             
        }


        #region BTN
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            FC_Cleardata();
            _them = true;
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FC_Showcontrols(false);
            _them = false;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tongiaoclass.Delete(_id);
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