namespace GUI
{
    partial class PhieuTraSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNguoiLapPhieuTra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaTinhTrangSach = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuMuon = new System.Windows.Forms.DataGridView();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(1212, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(680, 244);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(363, 76);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 69);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(93, 76);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 69);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Trả sách";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNguoiLapPhieuTra
            // 
            this.txtNguoiLapPhieuTra.Enabled = false;
            this.txtNguoiLapPhieuTra.Location = new System.Drawing.Point(272, 165);
            this.txtNguoiLapPhieuTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNguoiLapPhieuTra.Name = "txtNguoiLapPhieuTra";
            this.txtNguoiLapPhieuTra.Size = new System.Drawing.Size(296, 31);
            this.txtNguoiLapPhieuTra.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Người lập phiếu trả";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cboMaTinhTrangSach);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNguoiLapPhieuTra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtNgayMuon);
            this.groupBox1.Controls.Add(this.txtMaPM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1212, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(688, 242);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập Phiếu Trả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboMaTinhTrangSach
            // 
            this.cboMaTinhTrangSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTinhTrangSach.FormattingEnabled = true;
            this.cboMaTinhTrangSach.Location = new System.Drawing.Point(272, 119);
            this.cboMaTinhTrangSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaTinhTrangSach.Name = "cboMaTinhTrangSach";
            this.cboMaTinhTrangSach.Size = new System.Drawing.Size(296, 33);
            this.cboMaTinhTrangSach.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 25);
            this.label11.TabIndex = 89;
            this.label11.Text = "Tình trạng sách";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.CustomFormat = "";
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(272, 73);
            this.dtNgayMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(296, 31);
            this.dtNgayMuon.TabIndex = 3;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Enabled = false;
            this.txtMaPM.Location = new System.Drawing.Point(272, 27);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.ReadOnly = true;
            this.txtMaPM.Size = new System.Drawing.Size(296, 31);
            this.txtMaPM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phiếu Mượn";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.dgvChiTietPhieuMuon);
            this.groupBox6.Location = new System.Drawing.Point(2, 506);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1198, 687);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi Tiết Phiếu Mượn";
            // 
            // dgvChiTietPhieuMuon
            // 
            this.dgvChiTietPhieuMuon.AllowUserToAddRows = false;
            this.dgvChiTietPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvChiTietPhieuMuon.AllowUserToResizeRows = false;
            this.dgvChiTietPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuMuon.Location = new System.Drawing.Point(4, 28);
            this.dgvChiTietPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietPhieuMuon.Name = "dgvChiTietPhieuMuon";
            this.dgvChiTietPhieuMuon.RowHeadersWidth = 62;
            this.dgvChiTietPhieuMuon.RowTemplate.Height = 28;
            this.dgvChiTietPhieuMuon.Size = new System.Drawing.Size(1190, 655);
            this.dgvChiTietPhieuMuon.TabIndex = 1;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(4, 29);
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 62;
            this.dgvPhieuMuon.RowTemplate.Height = 28;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(1198, 462);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.dgvPhieuMuon);
            this.groupBox3.Location = new System.Drawing.Point(-2, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1206, 494);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu mượn";
            // 
            // PhieuTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PhieuTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhieuTraSach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNguoiLapPhieuTra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuMuon;
        private System.Windows.Forms.ComboBox cboMaTinhTrangSach;
        private System.Windows.Forms.Label label11;
    }
}