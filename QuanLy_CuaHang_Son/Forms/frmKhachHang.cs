using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
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
    public partial class frmKhachHang : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        bool xuLyTimKiem = false;                     // bool xuLyTimKiem = false;
        int id; // Lấy mã nhân viên (dùng cho Sửa và Xóa)
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri|| xuLyTimKiem; //họ và tên đang tắt khi nhấn thêm xoá sửa và tim kiem nó sẽ mở lại 
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            xuLyThem = false;
            xuLyTimKiem = false;

            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

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
            //1. kiểm tra chưa nhập thông tin
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
    string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Không được bỏ trống họ tên hoặc số điện thoại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
            }
            //2. sđt có ký tự
            else if (!txtDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
            }
            //3. sđt chưa đủ hoặc sư 10 số
            else if (txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
            }
            else
            {
                // 4. Kiểm tra trùng SĐT
                if (xuLyThem)
                {
                    trungSDT = context.KhachHang.Any(kh => kh.DienThoai == txtDienThoai.Text);
                }
                else
                {
                    trungSDT = context.KhachHang.Any(kh => kh.DienThoai == txtDienThoai.Text && kh.ID != id);
                }

                if (trungSDT)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi");
                }
                else
                {
                    // 5. Lưu dữ liệu
                    if (xuLyThem)
                    {
                        KhachHang kh = new KhachHang()
                        {
                            HoVaTen = txtHoVaTen.Text,
                            DienThoai = txtDienThoai.Text,
                            DiaChi = txtDiaChi.Text
                        };
                        context.KhachHang.Add(kh);
                    }
                    else
                    {
                        KhachHang kh = context.KhachHang.Find(id);
                        if (kh != null)
                        {
                            kh.HoVaTen = txtHoVaTen.Text;
                            kh.DienThoai = txtDienThoai.Text;
                            kh.DiaChi = txtDiaChi.Text;
                        }
                    }

                    context.SaveChanges();
                    frmKhachHang_Load(sender, e);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
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
                        KhachHang kh = new KhachHang();
                        kh.HoVaTen = ws.Cells[i, 1].Text;
                        kh.DienThoai = ws.Cells[i, 2].Text;
                        kh.DiaChi = ws.Cells[i, 3].Text;

                        context.KhachHang.Add(kh);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Nhập Excel thành công!");
                    frmKhachHang_Load(sender, e);
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
                    ExcelWorksheet ws = excel.Workbook.Worksheets.Add("KhachHang");

                    // Tiêu đề
                    ws.Cells[1, 1].Value = "Họ và tên";
                    ws.Cells[1, 2].Value = "Điện thoại";
                    ws.Cells[1, 3].Value = "Địa chỉ";

                    int row = 2;
                    foreach (var kh in context.KhachHang.ToList())
                    {
                        ws.Cells[row, 1].Value = kh.HoVaTen;
                        ws.Cells[row, 2].Value = kh.DienThoai;
                        ws.Cells[row, 3].Value = kh.DiaChi;
                        row++;
                    }

                    File.WriteAllBytes(sfd.FileName, excel.GetAsByteArray());
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLyTimKiem = true;
            xuLyThem = false;
            BatTatChucNang(false);
            txtHoVaTen.Enabled = true;   
            txtHoVaTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (xuLyTimKiem)
            {
                string key = txtHoVaTen.Text.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    dataGridView.DataSource = context.KhachHang.ToList();
                }
                else
                {
                    dataGridView.DataSource = context.KhachHang.Where(kh => kh.HoVaTen.Contains(key)).ToList();
                }
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTinh.SelectedItem != null)
            {
                txtDiaChi.Text = cboTinh.SelectedItem.ToString();
            }
        }

    }
}


