namespace GUI
{
    partial class TimKiemDocGia
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 79;
            this.label7.Text = "Giới tính :";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1018, 275);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(156, 59);
            this.btnTim.TabIndex = 76;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1992, 1016);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 59);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDocGia);
            this.groupBox1.Location = new System.Drawing.Point(6, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(2198, 672);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.AllowUserToResizeColumns = false;
            this.dgvDocGia.AllowUserToResizeRows = false;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(4, 27);
            this.dgvDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 62;
            this.dgvDocGia.RowTemplate.Height = 28;
            this.dgvDocGia.Size = new System.Drawing.Size(2190, 642);
            this.dgvDocGia.TabIndex = 52;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(660, 147);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(385, 31);
            this.txtTenDocGia.TabIndex = 66;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(660, 86);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(385, 31);
            this.txtMaDocGia.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tên độc giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mã độc giả :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(892, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 51);
            this.label1.TabIndex = 61;
            this.label1.Text = "Quản Lý Độc Giả";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(660, 203);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(385, 31);
            this.txtGioiTinh.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1156, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 77;
            this.label6.Text = "Địa chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(1340, 92);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(312, 31);
            this.txtDiaChi.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1156, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 32);
            this.label8.TabIndex = 81;
            this.label8.Text = "SĐT :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1340, 147);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(312, 31);
            this.txtSDT.TabIndex = 82;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.DarkBlue;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(1803, 1017);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(156, 59);
            this.btnChon.TabIndex = 85;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // TimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(2222, 1112);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TimKiemDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm độc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TimKiemDocGia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Button btnChon;
    }
}