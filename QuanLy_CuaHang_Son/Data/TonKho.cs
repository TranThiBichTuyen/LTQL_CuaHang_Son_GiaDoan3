using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
     public class TonKho
    {
            public int ID { get; set; }

            public int SanPhamID { get; set; }

            public int SoLuongTon { get; set; }

            public DateTime NgayCapNhat { get; set; }

            public string? GhiChu { get; set; }

            public virtual SanPham SanPham { get; set; } = null!;
        }
    }
