namespace GUI
{
    partial class QuanLyKeSach
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvKeSach = new System.Windows.Forms.DataGridView();
            this.MaKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaKe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(620, 771);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(156, 60);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(213, 782);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(385, 31);
            this.txtSearch.TabIndex = 32;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1132, 768);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 60);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvKeSach
            // 
            this.dgvKeSach.AllowUserToAddRows = false;
            this.dgvKeSach.AllowUserToDeleteRows = false;
            this.dgvKeSach.AllowUserToResizeColumns = false;
            this.dgvKeSach.AllowUserToResizeRows = false;
            this.dgvKeSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKeSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKe,
            this.ChatLieu,
            this.SucChua,
            this.LoaiSach});
            this.dgvKeSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeSach.Location = new System.Drawing.Point(4, 28);
            this.dgvKeSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKeSach.Name = "dgvKeSach";
            this.dgvKeSach.ReadOnly = true;
            this.dgvKeSach.RowHeadersWidth = 62;
            this.dgvKeSach.RowTemplate.Height = 28;
            this.dgvKeSach.Size = new System.Drawing.Size(1275, 420);
            this.dgvKeSach.TabIndex = 51;
            this.dgvKeSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeSach_CellClick);
            this.dgvKeSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeSach_RowEnter);
            // 
            // MaKe
            // 
            this.MaKe.DataPropertyName = "MaKe";
            this.MaKe.HeaderText = "Mã kệ";
            this.MaKe.MinimumWidth = 8;
            this.MaKe.Name = "MaKe";
            this.MaKe.ReadOnly = true;
            this.MaKe.Width = 200;
            // 
            // ChatLieu
            // 
            this.ChatLieu.DataPropertyName = "ChatLieu";
            this.ChatLieu.HeaderText = "Chất liệu";
            this.ChatLieu.MinimumWidth = 8;
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.ReadOnly = true;
            this.ChatLieu.Width = 200;
            // 
            // SucChua
            // 
            this.SucChua.DataPropertyName = "SucChua";
            this.SucChua.HeaderText = "Sức chứa";
            this.SucChua.MinimumWidth = 8;
            this.SucChua.Name = "SucChua";
            this.SucChua.ReadOnly = true;
            this.SucChua.Width = 200;
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại sách";
            this.LoaiSach.MinimumWidth = 8;
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.ReadOnly = true;
            this.LoaiSach.Width = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 789);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã kệ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKeSach);
            this.groupBox1.Location = new System.Drawing.Point(5, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1283, 452);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kệ sách";
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.Color.White;
            this.btnKhongLuu.Location = new System.Drawing.Point(1021, 231);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(156, 60);
            this.btnKhongLuu.TabIndex = 28;
            this.btnKhongLuu.Text = "Không";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(812, 231);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 60);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(589, 231);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 60);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(348, 231);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 60);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(108, 231);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 60);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Location = new System.Drawing.Point(235, 136);
            this.txtChatLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(385, 31);
            this.txtChatLieu.TabIndex = 22;
            // 
            // txtMaKe
            // 
            this.txtMaKe.Location = new System.Drawing.Point(235, 78);
            this.txtMaKe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKe.Name = "txtMaKe";
            this.txtMaKe.Size = new System.Drawing.Size(385, 31);
            this.txtMaKe.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(763, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sức chứa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chất liệu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã kệ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(467, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Kệ Sách";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(924, 78);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(4);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(312, 31);
            this.txtSucChua.TabIndex = 34;
            this.txtSucChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucChua_KeyPress);
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Location = new System.Drawing.Point(923, 132);
            this.txtLoaiSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(312, 31);
            this.txtLoaiSach.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(760, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Loại sách";
            // 
            // QuanLyKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1293, 832);
            this.Controls.Add(this.txtLoaiSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtChatLieu);
            this.Controls.Add(this.txtMaKe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "QuanLyKeSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kệ sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvKeSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtMaKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
    }
}