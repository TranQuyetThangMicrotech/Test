using System;

namespace BLL.DTO
{
    public class DieuChuyenDTO
    {
        public string IDDC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string LYDO { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<int> IDNV { get; set; }
        public Nullable<int> IDBP { get; set; }
        public Nullable<int> IDBP2 { get; set; }

        public string TENNV { get; set; }
        public string TENBP { get; set; }
        public string TENBP2 { get; set; }
    }
}