using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string PhanLoaiKh { get; set; } = null!;
        public DateTime Ngaysinh { get; set; }
        public string Dchi { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
