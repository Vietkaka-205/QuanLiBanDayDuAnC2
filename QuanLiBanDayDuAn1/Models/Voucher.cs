using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaVoucher { get; set; }
        public string? TenVoucher { get; set; }
        public decimal? SoTienGiamGia { get; set; }
        public decimal? TiLeGiamGia { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string? DieuKienApDung { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
