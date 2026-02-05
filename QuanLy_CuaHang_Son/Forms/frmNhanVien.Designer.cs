namespace QuanLy_CuaHang_Son.Forms
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboHinhThucLamViec = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMatKhau = new TextBox();
            cboQuyenHan = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            HinhThucLamViec = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboHinhThucLamViec);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1738, 135);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboHinhThucLamViec
            // 
            cboHinhThucLamViec.FormattingEnabled = true;
            cboHinhThucLamViec.Items.AddRange(new object[] { "Bán thời gian", "Toàn thời gian" });
            cboHinhThucLamViec.Location = new Point(1049, 60);
            cboHinhThucLamViec.Name = "cboHinhThucLamViec";
            cboHinhThucLamViec.Size = new Size(228, 30);
            cboHinhThucLamViec.TabIndex = 23;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(1049, 27);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(228, 30);
            dtpNgaySinh.TabIndex = 15;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cboGioiTinh.Location = new Point(1049, 97);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(228, 30);
            cboGioiTinh.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(872, 98);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 21;
            label7.Text = "Giới tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(855, 63);
            label8.Name = "label8";
            label8.Size = new Size(166, 22);
            label8.TabIndex = 20;
            label8.Text = "Hình thức làm việc:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(872, 27);
            label9.Name = "label9";
            label9.Size = new Size(122, 22);
            label9.TabIndex = 18;
            label9.Text = "Ngày sinh (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(603, 63);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(228, 30);
            txtMatKhau.TabIndex = 17;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(603, 98);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(228, 30);
            cboQuyenHan.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(419, 98);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 15;
            label4.Text = "Quyền hạn (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(419, 63);
            label5.Name = "label5";
            label5.Size = new Size(116, 22);
            label5.TabIndex = 13;
            label5.Text = "Mật khẩu (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(603, 27);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(228, 30);
            txtTenDangNhap.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(419, 27);
            label6.Name = "label6";
            label6.Size = new Size(158, 22);
            label6.TabIndex = 11;
            label6.Text = "Tên đăng nhập (*):\r\n";
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuat.Location = new Point(1587, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(119, 28);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhap.Location = new Point(1587, 55);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(119, 28);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(1587, 10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(119, 28);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 100);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(228, 30);
            txtDiaChi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ: ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(150, 66);
            txtDienThoai.MaxLength = 10;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(228, 30);
            txtDienThoai.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 4;
            label1.Text = "Số điện thoại:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(150, 31);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(228, 30);
            txtHoVaTen.TabIndex = 3;
            txtHoVaTen.TextChanged += txtHoVaTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên (*):";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1445, 100);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 28);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(1445, 57);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(119, 28);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(1302, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 28);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(1445, 12);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 28);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(1302, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 28);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(1302, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 28);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(13, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1738, 294);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan, NgaySinh, HinhThucLamViec, GioiTinh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1732, 268);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID.DefaultCellStyle = dataGridViewCellStyle1;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HoVaTen.DefaultCellStyle = dataGridViewCellStyle2;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DienThoai.DefaultCellStyle = dataGridViewCellStyle3;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DiaChi.DefaultCellStyle = dataGridViewCellStyle4;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenDangNhap.DefaultCellStyle = dataGridViewCellStyle5;
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MatKhau.DefaultCellStyle = dataGridViewCellStyle6;
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            QuyenHan.DefaultCellStyle = dataGridViewCellStyle7;
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgaySinh.DefaultCellStyle = dataGridViewCellStyle8;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // HinhThucLamViec
            // 
            HinhThucLamViec.DataPropertyName = "HinhThucLamViec";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HinhThucLamViec.DefaultCellStyle = dataGridViewCellStyle9;
            HinhThucLamViec.HeaderText = "Hình thức làm việc";
            HinhThucLamViec.MinimumWidth = 6;
            HinhThucLamViec.Name = "HinhThucLamViec";
            HinhThucLamViec.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GioiTinh.DefaultCellStyle = dataGridViewCellStyle10;
            GioiTinh.HeaderText = "GIới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1873, 474);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboHinhThucLamViec;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMatKhau;
        private ComboBox cboQuyenHan;
        private Label label4;
        private Label label5;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label1;
        private TextBox txtHoVaTen;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn HinhThucLamViec;
        private DataGridViewTextBoxColumn GioiTinh;
    }
}