using QuanLy_CuaHang_Son.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang_Son.Forms
{
    public partial class frmHangSanXuat : Form
    {
        //khai báo biến toàn cục
        QLBHDbContext context = new QLBHDbContext(); //Khởi tạo biến ngữ cảnh CSDL
        bool xulyThem = false;                  // kiểm tra có nhấn vào nút thêm hay không
        int id;                                 //lấy mã hãng sản xuất dùng cho sửa, xóa
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        //các sự kiện
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenHangSanXuat.Enabled = giaTri;
            txtSĐTHangSanXuat.Enabled = giaTri;
            txtDiaChiHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            //load địa chỉ
            cboTinh.Items.Clear();
            cboTinh.Items.AddRange(new string[]
            {
                "Hà Nội","TP. Hồ Chí Minh","Hải Phòng","Đà Nẵng","Cần Thơ","Huế",
                "Hà Giang","Cao Bằng","Bắc Kạn","Tuyên Quang","Lào Cai","Yên Bái",
                "Thái Nguyên","Lạng Sơn","Quảng Ninh","Bắc Giang","Phú Thọ",
                "Vĩnh Phúc","Bắc Ninh","Hải Dương","Hưng Yên","Hà Nam",
                "Nam Định","Thái Bình","Ninh Bình","Hòa Bình","Sơn La",
                "Điện Biên","Lai Châu","Thanh Hóa","Nghệ An","Hà Tĩnh",
                "Quảng Bình","Quảng Trị","Quảng Nam","Quảng Ngãi","Bình Định",
                "Phú Yên","Khánh Hòa","Ninh Thuận","Bình Thuận","Kon Tum",
                "Gia Lai","Đắk Lắk","Đắk Nông","Lâm Đồng","Bình Phước",
                "Bình Dương","Đồng Nai","Bà Rịa - Vũng Tàu","Tây Ninh",
                "Long An","Tiền Giang","Bến Tre","Trà Vinh","Vĩnh Long",
                "Đồng Tháp","An Giang","Kiên Giang","Hậu Giang","Sóc Trăng",
                "Bạc Liêu","Cà Mau"
            });

            //Load hang sản xuất
            List<HangSanXuat> hsx = new List<HangSanXuat>();
            hsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            txtSĐTHangSanXuat.DataBindings.Clear();
            txtSĐTHangSanXuat.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChiHangSanXuat.DataBindings.Clear();
            txtDiaChiHangSanXuat.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);


            dataGridView.DataSource = bindingSource;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
            txtTenHangSanXuat.Clear();
            txtSĐTHangSanXuat.Clear();
            txtDiaChiHangSanXuat.Clear();
            cboTinh.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất?",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xulyThem)
                {
                    // ===== KHÔNG KIỂM TRA TRÙNG =====

                    // XỬ LÝ ĐỊA CHỈ
                    string diaChi = "";
                    if (!string.IsNullOrWhiteSpace(txtDiaChiHangSanXuat.Text))
                        diaChi = txtDiaChiHangSanXuat.Text;
                    else
                        diaChi = cboTinh.SelectedItem?.ToString();

                    // THÊM
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    hsx.SoDienThoai = txtSĐTHangSanXuat.Text;
                    hsx.DiaChi = diaChi;

                    context.HangSanXuat.Add(hsx);
                    context.SaveChanges();

                    MessageBox.Show("Thêm hãng sản xuất thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // XỬ LÝ SỬA
                    HangSanXuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                        hsx.SoDienThoai = txtSĐTHangSanXuat.Text;

                        string diaChi = "";
                        if (!string.IsNullOrWhiteSpace(txtDiaChiHangSanXuat.Text))
                            diaChi = txtDiaChiHangSanXuat.Text;
                        else
                            diaChi = cboTinh.SelectedItem?.ToString();

                        hsx.DiaChi = diaChi;

                        context.SaveChanges();

                        MessageBox.Show("Cập nhật hãng sản xuất thành công!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xac nhận xóa loại sản phẩm?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi= MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();
            }
    }
}
}