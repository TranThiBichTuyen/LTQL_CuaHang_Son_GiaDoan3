using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class QLBHDbContext : DbContext
    {
        public QLBHDbContext(DbContextOptions<QLBHDbContext> options)
           : base(options)
        {
        }

        // Thêm constructor này cho design-time
        public QLBHDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Thay YOUR_CONNECTION_STRING bằng connection string thực tế
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
            }
        }

        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<PhieuNhap_ChiTiet> ChiTietPhieuNhap { get; set; }
        public DbSet<NhatKy_HoaDon> NhatKy_HoaDon { get; set; }
        public DbSet<NhatKy_SanPham> NhatKy_SanPham { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<TonKho> TonKho { get; set; }
        public DbSet<ThongKe> ThongKe { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhatKy_HoaDon>()
                .HasOne(nk => nk.HoaDon)
                .WithMany()
                .HasForeignKey(nk => nk.HoaDonID)
                .OnDelete(DeleteBehavior.Restrict); // ❌ không cascade

            modelBuilder.Entity<NhatKy_HoaDon>()
                .HasOne(nk => nk.TaiKhoan)
                .WithMany()
                .HasForeignKey(nk => nk.TaiKhoanID)
                .OnDelete(DeleteBehavior.Restrict); // ❌ không cascade
        }

    }
}


