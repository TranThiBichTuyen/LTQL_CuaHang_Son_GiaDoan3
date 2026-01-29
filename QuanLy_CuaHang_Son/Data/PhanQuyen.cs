using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang_Son.Data
{
    public class PhanQuyen
    {
        public int ID { get; set; }

        public string LoaiTaiKhoan { get; set; } = null!;
        // Ví dụ: Admin, Nhân viên bán hàng, Quản lý

        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<TaiKhoan> TaiKhoan { get; } = new();
    }
}
