using OfficeOpenXml;
using QuanLy_CuaHang_Son.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang_Son.Forms
{
    public partial class frmNhanVien : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        bool xuLyTimKiem = false;
        int id; // Lấy mã nhân viên (dùng cho Sửa và Xóa)
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri || xuLyTimKiem;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cboHinhThucLamViec.Enabled = giaTri;
            cboGioiTinh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            dataGridView.AutoGenerateColumns = false;

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);

            cboHinhThucLamViec.DataBindings.Clear();
            cboHinhThucLamViec.DataBindings.Add("Text", bindingSource, "HinhThucLamViec", false, DataSourceUpdateMode.Never);

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLyTimKiem = false;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboHinhThucLamViec.Text = "";
            cboGioiTinh.Text = "";
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
            bool trungSDT = false;
            string sdt = txtDienThoai.Text.Trim();
            //kiểm tra nhập dữ liệu bị thiếu
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(dtpNgaySinh.Text))
                MessageBox.Show("Vui lòng chọn ngày sinh cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // sđt có ký tự chữ
            else if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi");
                txtDienThoai.Focus();

            }

            // sđt không đủ hoặc hơn 10 số
            else if (txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số!", "Lỗi");
                txtDienThoai.Focus();
            }
            else
            {
                // Kiểm tra trùng SĐT
                if (xuLyThem)
                {
                    trungSDT = context.NhanVien.Any(nv => nv.DienThoai == txtDienThoai.Text);
                }
                else
                {
                    trungSDT = context.NhanVien.Any(nv => nv.DienThoai == txtDienThoai.Text && nv.ID != id);
                }

                if (trungSDT)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi");
                }
                else
                {
                    // Lưu dữ liệu
                    if (xuLyThem)
                    {
                        if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi");
                        }
                        else
                        {
                            NhanVien nv = new NhanVien();
                            nv.HoVaTen = txtHoVaTen.Text;
                            nv.DienThoai = txtDienThoai.Text;
                            nv.DiaChi = txtDiaChi.Text;
                            nv.TenDangNhap = txtTenDangNhap.Text;
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                            nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;
                            nv.NgaySinh = dtpNgaySinh.Value;
                            nv.HinhThucLamViec = cboHinhThucLamViec.Text;
                            nv.GioiTinh = cboGioiTinh.Text;

                            context.NhanVien.Add(nv);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        NhanVien nv = context.NhanVien.Find(id);
                        if (nv != null)
                        {
                            nv.HoVaTen = txtHoVaTen.Text;
                            nv.DienThoai = txtDienThoai.Text;
                            nv.DiaChi = txtDiaChi.Text;
                            nv.TenDangNhap = txtTenDangNhap.Text;
                            nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;
                            nv.NgaySinh = dtpNgaySinh.Value;
                            nv.HinhThucLamViec = cboHinhThucLamViec.Text;
                            nv.GioiTinh = cboGioiTinh.Text;

                            if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                            context.SaveChanges();
                        }
                    }

                    frmNhanVien_Load(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();

                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLyTimKiem = true;
            xuLyThem = false;
            BatTatChucNang(false);
            txtHoVaTen.Enabled = true;
            txtHoVaTen.Focus();
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (xuLyTimKiem)
            {
                string key = txtHoVaTen.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    dataGridView.DataSource = context.NhanVien.ToList();
                }
                else
                {
                    dataGridView.DataSource = context.NhanVien
                        .Where(nv => nv.HoVaTen.Contains(key))
                        .ToList();
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage(new FileInfo(ofd.FileName)))
                {
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    int soDong = ws.Dimension.Rows;

                    for (int i = 2; i <= soDong; i++) // bỏ dòng tiêu đề
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = ws.Cells[i, 1].Text;
                        nv.DienThoai = ws.Cells[i, 2].Text;
                        nv.DiaChi = ws.Cells[i, 3].Text;
                        nv.TenDangNhap = ws.Cells[i, 4].Text;

                        string mk = ws.Cells[i, 5].Text.Trim();
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(mk);

                        string quyen = ws.Cells[i, 6].Text.Trim();
                        nv.QuyenHan = quyen == "Admin";   // true = Admin, false = Nhân viên

                        nv.NgaySinh = ws.Cells[i, 7].GetValue<DateTime>();
                        nv.HinhThucLamViec = ws.Cells[i, 8].Text;
                        nv.GioiTinh = ws.Cells[i, 9].Text;
                        context.NhanVien.Add(nv);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Nhập Excel thành công!");
                    frmNhanVien_Load(sender, e);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "DanhSachKhachHang.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet ws = excel.Workbook.Worksheets.Add("NhanVien");

                    // Tiêu đề
                    ws.Cells[1, 1].Value = "Họ và tên";
                    ws.Cells[1, 2].Value = "Điện thoại";
                    ws.Cells[1, 3].Value = "Địa chỉ";
                    ws.Cells[1, 4].Value = "Tên đăng nhập";
                    ws.Cells[1, 5].Value = "Mật khẩu";
                    ws.Cells[1, 6].Value = "Quyền hạn";
                    ws.Cells[1, 7].Value = "Ngày sinh";
                    ws.Cells[1, 8].Value = "Hình thức làm việc";
                    ws.Cells[1, 9].Value = "Giới tính";

                    int row = 2;
                    foreach (var nv in context.NhanVien.ToList())
                    {
                        ws.Cells[row, 1].Value = nv.HoVaTen;
                        ws.Cells[row, 2].Value = nv.DienThoai;
                        ws.Cells[row, 3].Value = nv.DiaChi;
                        ws.Cells[row, 4].Value = nv.TenDangNhap;
                        ws.Cells[row, 5].Value = nv.MatKhau;
                        ws.Cells[row, 6].Value = nv.QuyenHan ? "Admin" : "Nhân viên";
                        ws.Cells[row, 7].Value = nv.NgaySinh.ToString();
                        ws.Cells[row, 8].Value = nv.HinhThucLamViec;
                        row++;
                    }

                    File.WriteAllBytes(sfd.FileName, excel.GetAsByteArray());
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

    }
}

