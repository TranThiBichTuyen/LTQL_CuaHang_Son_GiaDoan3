namespace QuanLy_CuaHang_Son.Forms
{
    partial class frmKhachHang
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
            btnXuat = new Button();
            btnNhap = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cboTinh = new ComboBox();
            label4 = new Label();
            btnTimKiem = new Button();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuat.Location = new Point(1120, 103);
            btnXuat.Margin = new Padding(4, 2, 4, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(106, 30);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhap.Location = new Point(1120, 57);
            btnNhap.Margin = new Padding(4, 2, 4, 2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(106, 30);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTinh);
            groupBox1.Controls.Add(label4);
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
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(14, 11);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(1240, 142);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cboTinh
            // 
            cboTinh.FormattingEnabled = true;
            cboTinh.Items.AddRange(new object[] { "An Giang", "", "Bạc Liêu", "", "Bà Rịa – Vũng Tàu", "", "Bến Tre", "", "Bình Dương", "", "Bình Phước", "", "Cà Mau", "", "Đồng Nai", "", "Đồng Tháp", "", "Hậu Giang", "", "Kiên Giang", "", "Long An", "", "Sóc Trăng", "", "Tây Ninh", "", "Tiền Giang", "", "TP. Cần Thơ", "", "TP. Hồ Chí Minh", "", "Trà Vinh", "", "Vĩnh Long" });
            cboTinh.Location = new Point(616, 78);
            cboTinh.Margin = new Padding(4, 2, 4, 2);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new Size(170, 27);
            cboTinh.TabIndex = 12;
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(464, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 22);
            label4.TabIndex = 11;
            label4.Text = "Tỉnh/ Thành phố: ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(1120, 10);
            btnTimKiem.Margin = new Padding(4, 2, 4, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 30);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(133, 78);
            txtDiaChi.Margin = new Padding(4, 2, 4, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(273, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ cụ thể:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(616, 36);
            txtDienThoai.Margin = new Padding(4, 2, 4, 2);
            txtDienThoai.MaxLength = 10;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(220, 27);
            txtDienThoai.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 4;
            label1.Text = "Số điện thoại:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(133, 32);
            txtHoVaTen.Margin = new Padding(4, 2, 4, 2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(273, 27);
            txtHoVaTen.TabIndex = 3;
            txtHoVaTen.TextChanged += txtHoVaTen_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(994, 105);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 30);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(994, 59);
            btnHuyBo.Margin = new Padding(4, 2, 4, 2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 30);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(866, 13);
            btnThem.Margin = new Padding(4, 2, 4, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(994, 12);
            btnLuu.Margin = new Padding(4, 2, 4, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 30);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(866, 59);
            btnSua.Margin = new Padding(4, 2, 4, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 30);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(866, 105);
            btnXoa.Margin = new Padding(4, 2, 4, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(14, 158);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(1240, 294);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 22);
            dataGridView.Margin = new Padding(4, 2, 4, 2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1232, 270);
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
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 464);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHang";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXuat;
        private Button btnNhap;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnTimKiem;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label1;
        private TextBox txtHoVaTen;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cboTinh;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}