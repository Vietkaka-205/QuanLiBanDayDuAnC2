using System;
using System.Collections.Generic;

namespace GUI.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaHd { get; set; }
        public DateTime? NgayBan { get; set; }
        public int? MaKh { get; set; }
        public string? TenKh { get; set; }
        public string? DchiKh { get; set; }
        public string? Sdtkh { get; set; }
        public int? MaNv { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual NhanVien? MaNvNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
