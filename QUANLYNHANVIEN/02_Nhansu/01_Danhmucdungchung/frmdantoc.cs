
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


using DAL; // references
using BLL._02_Nhansu._01_Danhmucdungchung; // references


namespace QUANLYNHANVIEN._02_Nhansu.Danhmucdungchung
{
    public partial class frmdantoc : DevExpress.XtraEditors.XtraForm
    {
        public frmdantoc()
        {
            InitializeComponent();
        }

        #region Khai báo biến toàn cục
        // Khai báo tạo 1 biến đại diện cho class
        DanToc _dantocclass;
        bool _them;
        int _id;
        #endregion

        // Các hàm
        #region FUNCTION 
        void FC_Cleardata()
        {
            txtTenDanToc.Text = string.Empty;
        }

        void FC_Showcontrols(bool on)
        {
            btnThem.Enabled = on;
            btnSua.Enabled = on;
            btnXoa.Enabled = on;
            btnDong.Enabled = on;

            btnHuy.Enabled = !on;
            btnLuu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on; //Khi load form "true" sẽ thu gọn panel1
        }

        #endregion FUNCTION 


        private void frmdantoc_Load(object sender, EventArgs e)
        {
          
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
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
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dantocclass.Delete(_id);
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



        void Loaddata()
        {
            _dantocclass = new DanToc(); // khởi tạo class
            gcdanhsach.DataSource = _dantocclass.GetList(); // gắn danh sách cho gridcontrol
            gvdanhsach.OptionsBehavior.Editable = false; // Không cho phép sửa trên gridview

        }

        void Savedata()
        {

            TB_DANTOC data;

            if (_them)
            {
                data = new TB_DANTOC();
                data.TENDT = txtTenDanToc.Text;
                _dantocclass.Add(data);
            }
            else
            {
                data = _dantocclass.GetItem(_id);
                data.TENDT = txtTenDanToc.Text;
                _dantocclass.Update(data);
            }
        }



        // thao tác click vào gridview (lấy được id và gán giá trị cho ô text)
        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDDT").ToString());
                var _item = _dantocclass.GetItem(_id);
                txtTenDanToc.Text = _item.TENDT;
            }
        }

    }
}