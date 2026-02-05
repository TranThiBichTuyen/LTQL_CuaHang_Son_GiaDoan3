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
        bool xuLyThem = false;                  // kiểm tra có nhấn vào nút thêm hay không
        bool xuLyTimKiem = false;               //kiểm tra có nhấn vào nút tìm kiếm hay không
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

            txtTenHangSanXuat.Enabled = giaTri || xuLyTimKiem;
            txtSĐTHangSanXuat.Enabled = giaTri;
            txtDiaChiHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            xuLyThem = false;
            xuLyTimKiem = false;

            BatTatChucNang(false);
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
            xuLyThem = true;
            xuLyTimKiem = false;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
            txtTenHangSanXuat.Clear();
            txtSĐTHangSanXuat.Clear();
            txtDiaChiHangSanXuat.Clear();
            cboTinh.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            xuLyTimKiem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Rỗng
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text) ||
                string.IsNullOrWhiteSpace(txtSĐTHangSanXuat.Text))
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi");
                return;
            }

            // 2. SĐT chỉ số
            if (!txtSĐTHangSanXuat.Text.All(char.IsDigit))
            {
                MessageBox.Show("SĐT chỉ chứa số!", "Lỗi");
                return;
            }

            // 3. Đúng 10 số
            if (txtSĐTHangSanXuat.Text.Length != 10)
            {
                MessageBox.Show("SĐT phải đủ 10 số!", "Lỗi");
                return;
            }

            // 4. Trùng SĐT (KHÔNG dùng ?: )
            bool trungSDT = false;
            if (xuLyThem)
            {
                trungSDT = context.HangSanXuat.Any(hsx =>hsx.SoDienThoai == txtSĐTHangSanXuat.Text);
            }
            else
            {
                trungSDT = context.HangSanXuat.Any(hsx =>hsx.SoDienThoai == txtSĐTHangSanXuat.Text && hsx.ID != id);
            }

            if (trungSDT)
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi");
                return;
            }

            // 5. Lưu
            if (xuLyThem)
            {
                HangSanXuat hsx = new HangSanXuat
                {
                    TenHangSanXuat = txtTenHangSanXuat.Text,
                    SoDienThoai = txtSĐTHangSanXuat.Text,
                    DiaChi = txtDiaChiHangSanXuat.Text
                };
                context.HangSanXuat.Add(hsx);
            }
            else
            {
                HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    hsx.SoDienThoai = txtSĐTHangSanXuat.Text;
                    hsx.DiaChi = txtDiaChiHangSanXuat.Text;
                }
            }

            context.SaveChanges();
            frmHangSanXuat_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận xoá hãng sản xuất?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Data.HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
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
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedItem != null)
            {
                txtDiaChiHangSanXuat.Text = cboTinh.SelectedItem.ToString();
            }
        }
    }
}