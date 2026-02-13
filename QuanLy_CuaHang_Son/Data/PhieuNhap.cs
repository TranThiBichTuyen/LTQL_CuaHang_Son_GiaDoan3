using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }

        public DateTime NgayNhap { get; set; }

        public int NhanVienID { get; set; }

        public string? GhiChu { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;

        public virtual ObservableCollectionListSource<PhieuNhap_ChiTiet> ChiTietPhieuNhap { get; } = new();
    }
}
    