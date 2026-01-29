using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class NhatKy_SanPham
    {
            public int ID { get; set; }

            public int SanPhamID { get; set; }

            public int TaiKhoanID { get; set; }

            public string HanhDong { get; set; } = null!;
            // Them / Sua / Xoa

            public DateTime ThoiGian { get; set; }

            public string? NoiDungCu { get; set; }

            public string? NoiDungMoi { get; set; }

            public virtual SanPham SanPham { get; set; } = null!;
            public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        }
    }

