using System;

namespace BLL.DTO
{
    public class KhenThuongKyLuatDTO
    {
        public string IDKTKL { get; set; }
        public string LYDO { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> LOAI { get; set; }
        public Nullable<System.DateTime> TUNGAY { get; set; }
        public Nullable<System.DateTime> DENNGAY { get; set; }
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