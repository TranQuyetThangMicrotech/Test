using System;

namespace BLL.DTO
{
    public class NhanVienDTO
    {
        public int IDNV { get; set; }
        public string TENNV { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<int> IDDT { get; set; }
        public Nullable<int> IDTG { get; set; }
        public Nullable<int> IDPB { get; set; }
        public Nullable<int> IDBP { get; set; }
        public Nullable<int> IDTD { get; set; }
        public Nullable<int> IDCV { get; set; }
        public Nullable<int> IDCTY { get; set; }

        // Hiển thị thêm Data tranfer oject
        public string TENCTY { get; set; }

        public string TENBP { get; set; }
        public string TENPB { get; set; }
        public string TENCV { get; set; }
        public string TENTD { get; set; }
        public string TENDT { get; set; }
        public string TENTG { get; set; }

        public bool? STATUS { get; set; } // dấu ? là cho phép null
    }
}