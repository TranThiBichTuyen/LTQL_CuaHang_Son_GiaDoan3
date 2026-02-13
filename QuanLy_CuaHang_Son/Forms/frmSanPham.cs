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
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        bool xulyTimKiem = false;
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = @"D:\LTQL_Nhan\DoAn_QL_Cua_Hang_Son\QuanLy_CuaHang_Son\QuanLy_CuaHang_Son\Images";
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThemAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHang";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            

            dataGridView.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };

            dataGridView.AutoGenerateColumns = false;

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                MoTa = r.MoTa,
                HinhAnh = r.HinhAnh
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                    e.Value = null;
                else
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);


            dataGridView.DataSource = bindingSource;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string path = Path.Combine(imagesFolder, e.Value.ToString());

                if (File.Exists(path))
                {
                    Image img = Image.FromFile(path);
                    e.Value = new Bitmap(img, 60, 60);
                }
                else
                {
                    e.Value = null; // hoặc ảnh mặc định
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi");
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi");
                return;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi");
                return;
            }
            // lấy tên ảnh từ ImageLocation
            string tenAnh = null;
            if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                tenAnh = Path.GetFileName(picHinhAnh.ImageLocation);

            // ===== XỬ LÝ THÊM / SỬA =====
            if (xuLyThem) // THÊM
            {
                SanPham sp = new SanPham
                {
                    TenSanPham = txtTenSanPham.Text,
                    LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue,
                    HangSanXuatID = (int)cboHangSanXuat.SelectedValue,
                    SoLuong = (int)numSoLuong.Value,
                    DonGia = (int)numDonGia.Value,
                    MoTa = txtMoTa.Text,
                    HinhAnh = tenAnh
                };

                context.SanPham.Add(sp);
                context.SaveChanges();

                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else // SỬA
            {
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                    sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.DonGia = (int)numDonGia.Value;
                    sp.MoTa = txtMoTa.Text;

                    // chỉ cập nhật ảnh nếu có chọn ảnh
                    if (!string.IsNullOrEmpty(tenAnh))
                        sp.HinhAnh = tenAnh;

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                }
            }

            BatTatChucNang(false);
            frmSanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();

                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn huỷ bỏ? ", "Huỷ bỏ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            frmSanPham_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh sản phẩm";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // tạo thư mục Images nếu chưa có
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                // tạo tên ảnh mới để không trùng
                string tenAnh = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);

                // đường dẫn lưu ảnh
                string duongDanLuu = Path.Combine(imagesFolder, tenAnh);

                // copy ảnh vào thư mục Images
                File.Copy(ofd.FileName, duongDanLuu, true);

                // hiển thị ảnh (QUAN TRỌNG)
                picHinhAnh.ImageLocation = duongDanLuu;
                picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xulyTimKiem = true;
            xuLyThem = false;
            BatTatChucNang(false);
            txtTenSanPham.Enabled = true;
            txtTenSanPham.Focus();
        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
            if (!xulyTimKiem) return;

            string key = txtTenSanPham.Text.Trim();

            if (string.IsNullOrEmpty(key))
            {
                dataGridView.DataSource = context.SanPham.ToList();
                return;
            }

            dataGridView.DataSource = context.SanPham
                .Where(sp => sp.TenSanPham.Contains(key))
                .ToList();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(openFileDialog.FileName)))
                {
                    var ws = package.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.Rows;

                    for (int i = 2; i <= rowCount; i++)
                    {
                        SanPham sp = new SanPham
                        {
                            TenSanPham = ws.Cells[i, 1].Text,
                            DonGia = int.Parse(ws.Cells[i, 2].Text),
                            SoLuong = int.Parse(ws.Cells[i, 3].Text),
                            LoaiSanPhamID = int.Parse(ws.Cells[i, 4].Text),
                            HangSanXuatID = int.Parse(ws.Cells[i, 5].Text),
                            HinhAnh = ws.Cells[i, 6].Text
                        };
                        context.SanPham.Add(sp);
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Nhập dữ liệu thành công!");
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.FileName = "DanhSachSanPham.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var ws = package.Workbook.Worksheets.Add("SanPham");

                    ws.Cells[1, 1].Value = "Tên sản phẩm";
                    ws.Cells[1, 2].Value = "Đơn giá";
                    ws.Cells[1, 3].Value = "Số lượng";
                    ws.Cells[1, 4].Value = "Loại";
                    ws.Cells[1, 5].Value = "Hãng";
                    ws.Cells[1, 6].Value = "Hình ảnh";

                    int row = 2;
                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        ws.Cells[row, 1].Value = r.Cells["colTenSanPham"].Value;
                        ws.Cells[row, 2].Value = r.Cells["colDonGia"].Value;
                        ws.Cells[row, 3].Value = r.Cells["colSoLuong"].Value;
                        ws.Cells[row, 4].Value = r.Cells["colTenLoai"].Value;
                        ws.Cells[row, 5].Value = r.Cells["colTenHangSanXuat"].Value;
                        ws.Cells[row, 6].Value = r.Cells["colHinhAnh"].Value;
                        row++;
                    }

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                }

                MessageBox.Show("Xuất Excel thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            btnDoiAnh_Click(sender, e);
        }
    }
}