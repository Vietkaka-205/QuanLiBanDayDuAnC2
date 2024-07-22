using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; } = null!;
        public int SoLuong { get; set; }
        public string ChatLieu { get; set; } = null!;
        public int KichCo { get; set; }
        public string MauSac { get; set; } = null!;
        public decimal GiaBan { get; set; }
        public string? Anh { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
