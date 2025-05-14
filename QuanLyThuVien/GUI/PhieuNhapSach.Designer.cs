namespace GUI
{
    partial class PhieuNhapSach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMaSach = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaPNCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(2, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1206, 494);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(4, 28);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 62;
            this.dgvPhieuNhap.RowTemplate.Height = 28;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1198, 462);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1216, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(688, 281);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập Phiếu Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Enabled = false;
            this.txtNguoiLap.Location = new System.Drawing.Point(218, 165);
            this.txtNguoiLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(350, 31);
            this.txtNguoiLap.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Người lập";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(218, 119);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 31);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ghi chú";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(218, 73);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(350, 31);
            this.dtNgayLap.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(218, 27);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(350, 31);
            this.txtMaPN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnKhongLuu);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(1216, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(688, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(448, 108);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 52);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKhongLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongLuu.ForeColor = System.Drawing.Color.White;
            this.btnKhongLuu.Location = new System.Drawing.Point(266, 108);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(148, 52);
            this.btnKhongLuu.TabIndex = 4;
            this.btnKhongLuu.Text = "Không";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(82, 108);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 52);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(446, 46);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 52);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(264, 46);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 52);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(78, 46);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox6.Location = new System.Drawing.Point(6, 504);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1198, 421);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeRows = false;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(4, 28);
            this.dgvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 62;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 28;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(1190, 389);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            this.dgvChiTietPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_RowEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox4.Controls.Add(this.cboMaNCC);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtTenSach);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnMaSach);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMaSach);
            this.groupBox4.Controls.Add(this.txtMaPNCT);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(1212, 508);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(692, 429);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bổ sung";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(226, 179);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(350, 33);
            this.cboMaNCC.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhà cung cấp";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Location = new System.Drawing.Point(12, 283);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(676, 138);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các Chức Năng";
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSuaCT.ForeColor = System.Drawing.Color.White;
            this.btnSuaCT.Location = new System.Drawing.Point(258, 52);
            this.btnSuaCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(148, 52);
            this.btnSuaCT.TabIndex = 5;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.Color.DarkBlue;
            this.btnXoaCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCT.ForeColor = System.Drawing.Color.White;
            this.btnXoaCT.Location = new System.Drawing.Point(440, 52);
            this.btnXoaCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(148, 52);
            this.btnXoaCT.TabIndex = 4;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThemCT.ForeColor = System.Drawing.Color.White;
            this.btnThemCT.Location = new System.Drawing.Point(74, 52);
            this.btnThemCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(148, 52);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(226, 133);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(350, 31);
            this.txtTenSach.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên sách";
            // 
            // btnMaSach
            // 
            this.btnMaSach.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaSach.ForeColor = System.Drawing.Color.White;
            this.btnMaSach.Location = new System.Drawing.Point(588, 77);
            this.btnMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaSach.Name = "btnMaSach";
            this.btnMaSach.Size = new System.Drawing.Size(100, 52);
            this.btnMaSach.TabIndex = 11;
            this.btnMaSach.Text = "Chọn";
            this.btnMaSach.UseVisualStyleBackColor = false;
            this.btnMaSach.Click += new System.EventHandler(this.btnMaSach_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(226, 227);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(350, 31);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số lượng";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(226, 85);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(350, 31);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtMaPNCT
            // 
            this.txtMaPNCT.Enabled = false;
            this.txtMaPNCT.Location = new System.Drawing.Point(226, 38);
            this.txtMaPNCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPNCT.Name = "txtMaPNCT";
            this.txtMaPNCT.Size = new System.Drawing.Size(350, 31);
            this.txtMaPNCT.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã phiếu nhập";
            // 
            // PhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 937);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuNhapSach_FormClosing);
            this.Load += new System.EventHandler(this.PhieuNhapSach_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaPNCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNCC;
    }
}