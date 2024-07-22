using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaNv { get; set; }
        public string TenNv { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Calam { get; set; } = null!;
        public DateTime Ngaysinh { get; set; }
        public string Dchi { get; set; } = null!;
        public int SoNgayNghi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
