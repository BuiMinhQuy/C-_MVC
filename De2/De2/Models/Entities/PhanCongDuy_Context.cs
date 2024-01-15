using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De2.Models.Entities
{
    public partial class PhanCongDuy_Context : DbContext
    {
        public PhanCongDuy_Context()
            : base("name=PhanCongDuy_Context")
        {
        }

        public virtual DbSet<AnhChiTietSP> AnhChiTietSPs { get; set; }
        public virtual DbSet<ChiTietDH> ChiTietDHs { get; set; }
        public virtual DbSet<ChiTietSPBan> ChiTietSPBans { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanLoai> PhanLoais { get; set; }
        public virtual DbSet<PhanLoaiPhu> PhanLoaiPhus { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SPtheoMau> SPtheoMaus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnhChiTietSP>()
                .Property(e => e.MaAnh)
                .IsUnicode(false);

            modelBuilder.Entity<AnhChiTietSP>()
                .Property(e => e.MaSPTheoMau)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDH>()
                .Property(e => e.MaDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDH>()
                .Property(e => e.MaChiTietSP)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSPBan>()
                .Property(e => e.MaChiTietSP)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSPBan>()
                .Property(e => e.MaSPTheoMau)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSPBan>()
                .Property(e => e.KichCo)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSPBan>()
                .HasMany(e => e.ChiTietDHs)
                .WithRequired(e => e.ChiTietSPBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.SoDienThoaiNhanHang)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDHs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauSac>()
                .Property(e => e.MaMau)
                .IsUnicode(false);

            modelBuilder.Entity<MauSac>()
                .HasMany(e => e.SPtheoMaus)
                .WithRequired(e => e.MauSac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<PhanLoai>()
                .Property(e => e.MaPhanLoai)
                .IsUnicode(false);

            modelBuilder.Entity<PhanLoaiPhu>()
                .Property(e => e.MaPhanLoaiPhu)
                .IsUnicode(false);

            modelBuilder.Entity<PhanLoaiPhu>()
                .Property(e => e.MaPhanLoai)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaPhanLoai)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaPhanLoaiPhu)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.SPtheoMaus)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPtheoMau>()
                .Property(e => e.MaSPTheoMau)
                .IsUnicode(false);

            modelBuilder.Entity<SPtheoMau>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SPtheoMau>()
                .Property(e => e.MaMau)
                .IsUnicode(false);
        }
    }
}
