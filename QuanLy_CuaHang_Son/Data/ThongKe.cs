using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class ThongKe
    {
        public int ID { get; set; }
        public DateTime ThoiGian { get; set; }

        // BÁN HÀNG
        public int TongSoHoaDon { get; set; }
        public int TongSoSanPhamBan { get; set; }
        public decimal TongDoanhThu { get; set; }

        // NHẬP HÀNG
        public int TongSoPhieuNhap { get; set; }
        public int TongSoSanPhamNhap { get; set; }
        public decimal TongTienNhap { get; set; }

        // TỒN KHO
        public int TongSanPhamTon { get; set; }
    }
}
  