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

        public QLBHDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
            }
        }

        // ===== DbSet =====
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<TonKho> TonKho { get; set; }

        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<PhanQuyen> PhanQuyen { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        public DbSet<NhatKy_HoaDon> NhatKy_HoaDon { get; set; }
        public DbSet<NhatKy_SanPham> NhatKy_SanPham { get; set; }

        // ===== FIX LỖI CASCADE =====
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ❌ Không cascade khi xóa TàiKhoản
            modelBuilder.Entity<NhatKy_HoaDon>()
                .HasOne(nk => nk.TaiKhoan)
                .WithMany()
                .HasForeignKey(nk => nk.TaiKhoanID)
                .OnDelete(DeleteBehavior.NoAction);

            // ❌ Không cascade khi xóa HóaĐơn
            modelBuilder.Entity<NhatKy_HoaDon>()
                .HasOne(nk => nk.HoaDon)
                .WithMany()
                .HasForeignKey(nk => nk.HoaDonID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}


/*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer( ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
            }
        }

        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<TonKho> TonKho { get; set; }

        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<PhanQuyen> PhanQuyen { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        public DbSet<NhatKy_HoaDon> NhatKy_HoaDon { get; set; }
        public DbSet<NhatKy_SanPham> NhatKy_SanPham { get; set; }
    }
}*/