using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class NhatKy_HoaDon
    {
            public int ID { get; set; }

            public int HoaDonID { get; set; }

            public int TaiKhoanID { get; set; }

            public string HanhDong { get; set; } = null!;

            public DateTime ThoiGian { get; set; }

            public string? GhiChu { get; set; }

            public virtual HoaDon HoaDon { get; set; } = null!;
            public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        }
    }
