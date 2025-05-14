namespace GUI
{
    partial class BaoCao
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSL1 = new System.Windows.Forms.Label();
            this.lblSL2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 942);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 32);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tổng số phiếu mượn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(5, 179);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1589, 760);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(4, 28);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(1581, 728);
            this.dgvData.TabIndex = 51;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(780, 111);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(251, 60);
            this.btnLoc.TabIndex = 69;
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(203, 122);
            this.txtThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(215, 31);
            this.txtThang.TabIndex = 65;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(579, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 61);
            this.label1.TabIndex = 61;
            this.label1.Text = "BÁO CÁO THƯ VIỆN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(555, 122);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(215, 31);
            this.txtNam.TabIndex = 76;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 986);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tổng số phiếu trả :";
            // 
            // lblSL1
            // 
            this.lblSL1.AutoSize = true;
            this.lblSL1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL1.ForeColor = System.Drawing.Color.Red;
            this.lblSL1.Location = new System.Drawing.Point(332, 942);
            this.lblSL1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL1.Name = "lblSL1";
            this.lblSL1.Size = new System.Drawing.Size(29, 32);
            this.lblSL1.TabIndex = 78;
            this.lblSL1.Text = "0";
            // 
            // lblSL2
            // 
            this.lblSL2.AutoSize = true;
            this.lblSL2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL2.ForeColor = System.Drawing.Color.Red;
            this.lblSL2.Location = new System.Drawing.Point(331, 986);
            this.lblSL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL2.Name = "lblSL2";
            this.lblSL2.Size = new System.Drawing.Size(29, 32);
            this.lblSL2.TabIndex = 79;
            this.lblSL2.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1037, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 60);
            this.button1.TabIndex = 80;
            this.button1.Text = "Top 5 sách mượn nhiều nhất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1603, 1051);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSL2);
            this.Controls.Add(this.lblSL1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê và báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSL1;
        private System.Windows.Forms.Label lblSL2;
        private System.Windows.Forms.Button button1;
    }
}