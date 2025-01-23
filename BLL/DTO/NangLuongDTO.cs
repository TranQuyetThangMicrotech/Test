using System;

namespace BLL.DTO
{
    public class NangLuongDTO
    {
        public string IDNANGLUONG { get; set; }
        public string IDHD { get; set; }
        public Nullable<double> HESOLUONGCU { get; set; }
        public Nullable<double> HESOLUONGMOI { get; set; }
        public Nullable<System.DateTime> NGAYLENLUONG { get; set; }
        public Nullable<System.DateTime> NGAYKY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> IDNV { get; set; }

        public string TENNV { get; set; }
    }
}