using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GUI.Models
{
    public partial class DuAn1Context : DbContext
    {
        public DuAn1Context()
        {
        }

        public DuAn1Context(DbContextOptions<DuAn1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=DuAn1;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaCthd)
                    .HasName("PK__ChiTietH__1E4FA771D8BABDAC");

                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.MaCthd).HasColumnName("MaCTHD");

                entity.Property(e => e.DonGia).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__ChiTietHoa__MaHD__300424B4");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK__ChiTietHoa__MaSP__2F10007B");

                entity.HasOne(d => d.MaVoucherNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaVoucher)
                    .HasConstraintName("FK__ChiTietHo__MaVou__30F848ED");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E024A0D9A1");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.DchiKh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DchiKH");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayBan).HasColumnType("date");

                entity.Property(e => e.Sdtkh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDTKH");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TenKH");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__HoaDon__MaKH__2B3F6F97");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__HoaDon__MaNV__2C3393D0");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E95D3F9D0");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.Dchi).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.PhanLoaiKh)
                    .HasMaxLength(10)
                    .HasColumnName("PhanLoaiKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70AE4BB9BD8");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.Calam).HasMaxLength(10);

                entity.Property(e => e.Dchi).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__sanpham__2725081CA898A02B");

                entity.ToTable("sanpham");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.Anh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("anh");

                entity.Property(e => e.ChatLieu).HasMaxLength(20);

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.Property(e => e.MauSac).HasMaxLength(20);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.MaVoucher)
                    .HasName("PK__voucher__0AAC5B1114A7B6D2");

                entity.ToTable("voucher");

                entity.Property(e => e.DieuKienApDung).HasColumnType("text");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.SoTienGiamGia).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TenVoucher)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TiLeGiamGia).HasColumnType("decimal(5, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
