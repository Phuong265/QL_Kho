namespace GUI
{
    partial class UC_NhapKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Hộp"});
            this.cboDonViTinh.Location = new System.Drawing.Point(62, 206);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(120, 21);
            this.cboDonViTinh.TabIndex = 23;
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(62, 102);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(120, 21);
            this.cboNCC.TabIndex = 22;
            // 
            // cboMa
            // 
            this.cboMa.FormattingEnabled = true;
            this.cboMa.Location = new System.Drawing.Point(62, 49);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(120, 21);
            this.cboMa.TabIndex = 21;
            this.cboMa.SelectedIndexChanged += new System.EventHandler(this.cboMa_SelectedIndexChanged);
            this.cboMa.TextChanged += new System.EventHandler(this.cboMa_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(62, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(62, 259);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(120, 20);
            this.txtThanhTien.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Thành tiền";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(62, 233);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(120, 20);
            this.txtGiaNhap.TabIndex = 17;
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Giá nhập";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapNhat.Location = new System.Drawing.Point(778, 381);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(505, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Chi tiết phiếu nhập";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.A,
            this.Column5,
            this.q,
            this.X,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(202, 129);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(679, 240);
            this.dgvChiTietPhieuNhap.TabIndex = 25;
            this.dgvChiTietPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellClick);
            this.dgvChiTietPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A.HeaderText = "Tên hàng";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NCC";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // q
            // 
            this.q.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.q.HeaderText = "SL";
            this.q.Name = "q";
            this.q.ReadOnly = true;
            // 
            // X
            // 
            this.X.HeaderText = "Xuất xứ";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Đơn vị ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giá nhập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Đơn vị tính";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(202, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 70);
            this.panel1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(-1, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 29;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(422, 9);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(143, 21);
            this.cboMaNV.TabIndex = 17;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(144, 36);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(150, 20);
            this.dtpNgayNhap.TabIndex = 16;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(422, 37);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(143, 20);
            this.txtTongTien.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(144, 11);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(150, 20);
            this.txtMaPN.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(368, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phiếu nhập kho";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(62, 181);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(120, 20);
            this.txtGhichu.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ghi chú";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(62, 155);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(120, 20);
            this.txtXuatXu.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Xuất xứ";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(62, 129);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(120, 20);
            this.txtSL.TabIndex = 9;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "SL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "NCC";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(62, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(120, 20);
            this.txtTen.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(77, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập hàng hoá";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboDonViTinh);
            this.panel2.Controls.Add(this.cboNCC);
            this.panel2.Controls.Add(this.cboMa);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtXuatXu);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 337);
            this.panel2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(668, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Danh sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(444, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa1.Location = new System.Drawing.Point(554, 381);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 23);
            this.btnXoa1.TabIndex = 29;
            this.btnXoa1.Text = "Xoá toàn bộ";
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // UC_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_NhapKho";
            this.Size = new System.Drawing.Size(883, 414);
            this.Load += new System.EventHandler(this.UC_NhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoa1;
    }
}
