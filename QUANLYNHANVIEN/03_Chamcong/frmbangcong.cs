using BLL._02_Nhansu._01_Danhmucdungchung;
using BLL.DTO;
using DAL;
using DevExpress.XtraEditors;
using QUANLYNHANVIEN.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL._03_Chamcong;
//using DevExpress.XtraEditors.Filtering.Templates;

namespace QUANLYNHANVIEN._03_Chamcong
{
    public partial class frmbangcong : DevExpress.XtraEditors.XtraForm
    {
        public frmbangcong()
        {
            InitializeComponent();
        }


        #region Khai báo biến toàn cục

        BangCong _bangcongclass;
        bool _them;
        int _id;

        #endregion


        #region FUNCTION 


        void FC_Cleardata()
        {
            cbnam.Text = DateTime.Now.Year.ToString();
            cbthang.Text = DateTime.Now.Month.ToString();
            chkkhoa.Checked = false;
            chkkhoa.Checked = false;

        }

        void FC_Showcontrols(bool on)
        {
            btnthem.Enabled = on;
            btnsua.Enabled = on;
            btnxoa.Enabled = on;
            btndong.Enabled = on;
            //btnxem.Enabled = on;

            btnhuy.Enabled = !on;
            btnluu.Enabled = !on;

            splitContainer1.Panel1Collapsed = on;
        }

        #endregion FUNCTION 


        private void frmbangcong_Load(object sender, EventArgs e)
        {
            FC_Showcontrols(true);
            Loaddata();
            _them = false;
        }



        #region BTN


        private void btnthem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                _bangcongclass.Delete(_id, 1);
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

        private void btnxem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmbangcongchitiet frm = new frmbangcongchitiet();
            frm.ShowDialog();
        }

        private void btndong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }









        #endregion


        #region các hàm tự viết
        void Loaddata()
        {
            _bangcongclass = new BangCong();

            gcdanhsach.DataSource = _bangcongclass.GetList();
            gvdanhsach.OptionsBehavior.Editable = false;


        }

        void Savedata()
        {
            TB_KYCONG data;
            if (_them)
            {
                data = new TB_KYCONG();
                
                data.NAM = int.Parse(cbnam.Text);
                data.THANG = int.Parse(cbthang.Text);

                data.KHOA = chkkhoa.Checked;
                data.TRANGTHAI = chktrangthai.Checked;

        
                data.TENKC = int.Parse(cbnam.Text) * 100 + int.Parse(cbthang.Text);
                data.NGAYTINHCONG = DateTime.Now;
                data.NGAYCONGTRONGTHANG = thangfunctions.demsongaylamviectrongthang(int.Parse(cbthang.Text), int.Parse(cbnam.Text));

                //data.IDCTY = 1;
                //data.IDNV = 1;

                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;
                _bangcongclass.Add(data);
            }
            else
            {
                data = _bangcongclass.GetItem(_id);

                data.NAM = int.Parse(cbnam.Text);
                data.THANG = int.Parse(cbthang.Text);

                data.KHOA = chkkhoa.Checked;
                data.TRANGTHAI = chktrangthai.Checked;

                data.TENKC = int.Parse(cbnam.Text) * 100 + int.Parse(cbthang.Text);
                data.NGAYTINHCONG = DateTime.Now;
                data.NGAYCONGTRONGTHANG = thangfunctions.demsongaylamviectrongthang(int.Parse(cbthang.Text), int.Parse(cbnam.Text));


                //data.IDCTY = 1;
                // data.IDNV = 1;

                data.CREATED_BY = 1;
                data.CREATED_DATE = DateTime.Now;

                _bangcongclass.Update(data);
            }
        }
        #endregion

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _id = int.Parse(gvdanhsach.GetFocusedRowCellValue("IDKC").ToString());

                var item = _bangcongclass.GetItem(_id);



                chkkhoa.Checked = item.KHOA.Value;
                chktrangthai.Checked = item.TRANGTHAI.Value;


                cbnam.SelectedValue = item.NAM;
                cbthang.SelectedValue = item.THANG;


            }
        }





        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if(e.Column.Name == "GIOITINH")
            //{
            //    if (int.Parse(e.CellValue.ToString()) == 0)
            //        e.DisplayText = "Nam";
            //    else
            //        e.DisplayText = "Nữ";
            //}
        }

        private void gvdanhsach_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.icondel;
                e.Graphics.DrawImage(img, e.Bounds.X,e.Bounds.Y);
                e.Handled= true;
            }
        }
    }




}
