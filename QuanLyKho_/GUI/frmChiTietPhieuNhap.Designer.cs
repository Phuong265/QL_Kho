namespace GUI
{
    partial class frmChiTietPhieuNhap
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
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaPhieu = new System.Windows.Forms.ComboBox();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXem.Location = new System.Drawing.Point(482, 39);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 25;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(191, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chi tiết phiếu nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboMaPhieu
            // 
            this.cboMaPhieu.FormattingEnabled = true;
            this.cboMaPhieu.Location = new System.Drawing.Point(208, 41);
            this.cboMaPhieu.Name = "cboMaPhieu";
            this.cboMaPhieu.Size = new System.Drawing.Size(230, 21);
            this.cboMaPhieu.TabIndex = 23;
            this.cboMaPhieu.SelectedIndexChanged += new System.EventHandler(this.cboMaPhieu_SelectedIndexChanged);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(1, 77);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(576, 193);
            this.dgvChiTietPhieuNhap.TabIndex = 22;
            this.dgvChiTietPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellContentClick);
            // 
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 275);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaPhieu);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Name = "frmChiTietPhieuNhap";
            this.Text = "frmChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.frmChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
    }
}