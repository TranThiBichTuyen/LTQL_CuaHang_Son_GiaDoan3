using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }

        public string TenDangNhap { get; set; } = null!;

        public string MatKhau { get; set; } = null!;

        public string VaiTro { get; set; } = null!;
        // Admin / QuanLy / NhanVien

        public int NhanVienID { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}