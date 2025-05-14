namespace GUI
{
    partial class DanhSachPhieuQuaHan
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMuon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.dgvChiTietPhieuMuon);
            this.groupBox6.Location = new System.Drawing.Point(22, 506);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1952, 687);
            this.groupBox6.TabIndex = 21;
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
            this.dgvChiTietPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietPhieuMuon.Name = "dgvChiTietPhieuMuon";
            this.dgvChiTietPhieuMuon.RowHeadersWidth = 62;
            this.dgvChiTietPhieuMuon.RowTemplate.Height = 28;
            this.dgvChiTietPhieuMuon.Size = new System.Drawing.Size(1944, 655);
            this.dgvChiTietPhieuMuon.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.dgvPhieuMuon);
            this.groupBox3.Location = new System.Drawing.Point(18, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1956, 494);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu mượn";
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
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 62;
            this.dgvPhieuMuon.RowTemplate.Height = 28;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(1948, 462);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // DanhSachPhieuQuaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1994, 1198);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DanhSachPhieuQuaHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu quá hạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachPhieuQuaHan_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMuon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
    }
}