namespace GUI
{
    partial class QuanLySach
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
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaKe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenSachSearch = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLoaiSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTacGiaSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(1200, 181);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(312, 31);
            this.txtTacGia.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(979, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 32);
            this.label8.TabIndex = 81;
            this.label8.Text = "Tác giả :";
            // 
            // cboMaKe
            // 
            this.cboMaKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKe.FormattingEnabled = true;
            this.cboMaKe.Location = new System.Drawing.Point(512, 185);
            this.cboMaKe.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaKe.Name = "cboMaKe";
            this.cboMaKe.Size = new System.Drawing.Size(385, 33);
            this.cboMaKe.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 79;
            this.label7.Text = "Mã kệ :";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(1200, 128);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(312, 31);
            this.txtNamXuatBan.TabIndex = 78;
            this.txtNamXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamXuatBan_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(979, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 77;
            this.label6.Text = "Năm xuất bản :";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(635, 965);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(156, 60);
            this.btnTim.TabIndex = 76;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenSachSearch
            // 
            this.txtTenSachSearch.Location = new System.Drawing.Point(213, 931);
            this.txtTenSachSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSachSearch.Name = "txtTenSachSearch";
            this.txtTenSachSearch.Size = new System.Drawing.Size(385, 31);
            this.txtTenSachSearch.TabIndex = 75;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1595, 956);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 60);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 932);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tên sách :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSach);
            this.groupBox1.Location = new System.Drawing.Point(5, 379);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1748, 544);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(4, 28);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 28;
            this.dgvSach.Size = new System.Drawing.Size(1740, 512);
            this.dgvSach.TabIndex = 51;
            this.dgvSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_RowEnter);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.Color.White;
            this.btnKhongLuu.Location = new System.Drawing.Point(1325, 311);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(156, 60);
            this.btnKhongLuu.TabIndex = 71;
            this.btnKhongLuu.Text = "Không";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1116, 311);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 60);
            this.btnLuu.TabIndex = 70;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(893, 311);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 60);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(652, 311);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 60);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(412, 311);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 60);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(512, 131);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(385, 31);
            this.txtTenSach.TabIndex = 66;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(512, 71);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(385, 31);
            this.txtMaSach.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tên sách :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mã sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(804, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 51);
            this.label1.TabIndex = 61;
            this.label1.Text = "Quản Lý Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nhà xuất bản :";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(1200, 72);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(312, 31);
            this.txtNhaXuatBan.TabIndex = 83;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(512, 236);
            this.cboMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(385, 33);
            this.cboMaLoai.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 84;
            this.label9.Text = "Loại sách :";
            // 
            // txtTenLoaiSearch
            // 
            this.txtTenLoaiSearch.Location = new System.Drawing.Point(213, 978);
            this.txtTenLoaiSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiSearch.Name = "txtTenLoaiSearch";
            this.txtTenLoaiSearch.Size = new System.Drawing.Size(385, 31);
            this.txtTenLoaiSearch.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 979);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 32);
            this.label10.TabIndex = 86;
            this.label10.Text = "Thể loại :";
            // 
            // txtTacGiaSearch
            // 
            this.txtTacGiaSearch.Location = new System.Drawing.Point(213, 1022);
            this.txtTacGiaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGiaSearch.Name = "txtTacGiaSearch";
            this.txtTacGiaSearch.Size = new System.Drawing.Size(385, 31);
            this.txtTacGiaSearch.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 1025);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 32);
            this.label11.TabIndex = 88;
            this.label11.Text = "Tác giả :";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1763, 1068);
            this.Controls.Add(this.txtTacGiaSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTenLoaiSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMaKe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenSachSearch);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaKe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenSachSearch;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenLoaiSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTacGiaSearch;
        private System.Windows.Forms.Label label11;
    }
}