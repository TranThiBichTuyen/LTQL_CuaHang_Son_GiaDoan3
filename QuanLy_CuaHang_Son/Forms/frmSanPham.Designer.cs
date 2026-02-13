namespace QuanLy_CuaHang_Son.Forms
{
    partial class frmSanPham
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
            label7 = new Label();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            picHinhAnh = new PictureBox();
            txtMoTa = new TextBox();
            label6 = new Label();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            GroupBox1 = new GroupBox();
            btnThemAnh = new Button();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 74);
            label7.Name = "label7";
            label7.Size = new Size(148, 22);
            label7.TabIndex = 21;
            label7.Text = "Hãng sản xuất(*):";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoiAnh.Location = new Point(1225, 83);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(106, 28);
            btnDoiAnh.TabIndex = 19;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Times New Roman", 12F);
            btnXuat.Location = new Point(1233, 266);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(106, 28);
            btnXuat.TabIndex = 18;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 12F);
            btnNhap.Location = new Point(1081, 266);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(106, 28);
            btnNhap.TabIndex = 17;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F);
            btnTimKiem.Location = new Point(929, 266);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 28);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BackColor = Color.White;
            picHinhAnh.Location = new Point(887, 29);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(300, 203);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 15;
            picHinhAnh.TabStop = false;
            // 
            // txtMoTa
            // 
            txtMoTa.AcceptsReturn = true;
            txtMoTa.Location = new Point(197, 187);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(615, 30);
            txtMoTa.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 186);
            label6.Name = "label6";
            label6.Size = new Size(163, 22);
            label6.TabIndex = 13;
            label6.Text = "Mô tả sản phẩm(*):";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(611, 83);
            numDonGia.Margin = new Padding(3, 7, 3, 7);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(148, 30);
            numDonGia.TabIndex = 12;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(611, 40);
            numSoLuong.Margin = new Padding(3, 7, 3, 7);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(148, 30);
            numSoLuong.TabIndex = 11;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(487, 74);
            label5.Name = "label5";
            label5.Size = new Size(102, 22);
            label5.TabIndex = 10;
            label5.Text = "Đơn giá(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(484, 39);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 9;
            label4.Text = "Số lượng(*):";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.AcceptsReturn = true;
            txtTenSanPham.Location = new Point(197, 140);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(615, 30);
            txtTenSanPham.TabIndex = 8;
            txtTenSanPham.TextChanged += txtTenSanPham_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 7;
            label3.Text = "Tên sản phẩm(*):";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(197, 83);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(148, 30);
            cboHangSanXuat.TabIndex = 6;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(197, 39);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(148, 30);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 3;
            label1.Text = "Phân loại(*):";
            // 
            // label2
            // 
            label2.Location = new Point(26, 109);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 20;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F);
            btnThoat.Location = new Point(777, 266);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 28);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F);
            btnHuyBo.Location = new Point(627, 266);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 28);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.Location = new Point(19, 266);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 28);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F);
            btnLuu.Location = new Point(475, 266);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 28);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(171, 266);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 28);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, MoTa, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 50;
            dataGridView.Size = new Size(1468, 193);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1474, 219);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.Location = new Point(323, 266);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 28);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(btnThemAnh);
            GroupBox1.Controls.Add(label7);
            GroupBox1.Controls.Add(btnDoiAnh);
            GroupBox1.Controls.Add(btnXuat);
            GroupBox1.Controls.Add(btnNhap);
            GroupBox1.Controls.Add(btnTimKiem);
            GroupBox1.Controls.Add(picHinhAnh);
            GroupBox1.Controls.Add(txtMoTa);
            GroupBox1.Controls.Add(label6);
            GroupBox1.Controls.Add(numDonGia);
            GroupBox1.Controls.Add(numSoLuong);
            GroupBox1.Controls.Add(label5);
            GroupBox1.Controls.Add(label4);
            GroupBox1.Controls.Add(txtTenSanPham);
            GroupBox1.Controls.Add(label3);
            GroupBox1.Controls.Add(cboHangSanXuat);
            GroupBox1.Controls.Add(cboLoaiSanPham);
            GroupBox1.Controls.Add(label1);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(btnThoat);
            GroupBox1.Controls.Add(btnHuyBo);
            GroupBox1.Controls.Add(btnThem);
            GroupBox1.Controls.Add(btnLuu);
            GroupBox1.Controls.Add(btnSua);
            GroupBox1.Controls.Add(btnXoa);
            GroupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(1356, 317);
            GroupBox1.TabIndex = 9;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // btnThemAnh
            // 
            btnThemAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemAnh.Location = new Point(1225, 142);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(106, 28);
            btnThemAnh.TabIndex = 22;
            btnThemAnh.Text = "Thêm ảnh";
            btnThemAnh.UseVisualStyleBackColor = true;
            btnThemAnh.Click += btnThemAnh_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID.DefaultCellStyle = dataGridViewCellStyle1;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MoTa.DefaultCellStyle = dataGridViewCellStyle2;
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 574);
            Controls.Add(groupBox2);
            Controls.Add(GroupBox1);
            Name = "frmSanPham";
            Text = "SanPham";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Button btnDoiAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private PictureBox picHinhAnh;
        private TextBox txtMoTa;
        private Label label6;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Label label5;
        private Label label4;
        private TextBox txtTenSanPham;
        private Label label3;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Label label1;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnXoa;
        private GroupBox GroupBox1;
        private Button btnThemAnh;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewImageColumn HinhAnh;
    }
}