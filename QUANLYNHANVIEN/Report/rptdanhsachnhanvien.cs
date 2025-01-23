using BLL.DTO;
using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYNHANVIEN.Report
{
    public partial class rptdanhsachnhanvien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptdanhsachnhanvien()
        {
            InitializeComponent();
        }

        // tạo ra một list để hứng dữ liệu form nhân viên
        List<NhanVienDTO> _lstnhanviendto;


        public rptdanhsachnhanvien(List<NhanVienDTO> lstnv)
        {
            InitializeComponent();
            this._lstnhanviendto = lstnv; // hứng từ form nhân viên truyền qua
            this.DataSource = _lstnhanviendto; // gán dữ liệu
            Loaddata();
        }

        void Loaddata()
        {
            lblid.DataBindings.Add("Text", _lstnhanviendto, "IDNV");
            lbltennhanvien.DataBindings.Add("Text", _lstnhanviendto, "TENNV");
            lblgioitinh.DataBindings.Add("Text", _lstnhanviendto, "GIOITINH");
            lblchucvu.DataBindings.Add("Text", _lstnhanviendto, "TENCV");
            lblsodienthoai.DataBindings.Add("Text", _lstnhanviendto, "DIENTHOAI");
            lblngaysinh.DataBindings.Add("Text", _lstnhanviendto, "NGAYSINH");
        }

    }
}
