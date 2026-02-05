namespace QuanLy_CuaHang_Son.Forms
{
    partial class frmLoaiSanPham
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            txtTenLoai = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1034, 75);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 28);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(871, 75);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(140, 28);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(218, 75);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 28);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(708, 75);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 28);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(381, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 28);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(544, 75);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 28);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 117);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(218, 23);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(942, 30);
            txtTenLoai.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(188, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên loại sản phẩm (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(19, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1222, 269);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1216, 243);
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
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenLoai.DefaultCellStyle = dataGridViewCellStyle2;
            TenLoai.HeaderText = "Tên loại sản phẩm";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 428);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoaiSanPham";
            Load += frmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox1;
        private TextBox txtTenLoai;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
    }
}