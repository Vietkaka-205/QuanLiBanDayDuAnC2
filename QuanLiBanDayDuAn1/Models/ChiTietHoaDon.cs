using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class ChiTietHoaDon
    {
        public int MaCthd { get; set; }
        public int? MaHd { get; set; }
        public int? MaSp { get; set; }
        public string? TenSp { get; set; }
        public int? SoLuong { get; set; }
        public int? MaVoucher { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual HoaDon? MaHdNavigation { get; set; }
        public virtual Sanpham? MaSpNavigation { get; set; }
        public virtual Voucher? MaVoucherNavigation { get; set; }
    }
}
