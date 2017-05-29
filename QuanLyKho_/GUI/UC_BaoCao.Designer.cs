namespace GUI
{
    partial class UC_BaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbb_time = new System.Windows.Forms.ComboBox();
            this.lbl_ctnhap = new System.Windows.Forms.Label();
            this.lbl_ctban = new System.Windows.Forms.Label();
            this.txt_ban = new System.Windows.Forms.TextBox();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdb_month = new System.Windows.Forms.RadioButton();
            this.rdb_day = new System.Windows.Forms.RadioButton();
            this.dgv_time = new System.Windows.Forms.DataGridView();
            this.C_bieudo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_bieudo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 413);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.cbb_nam);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.cbb_time);
            this.panel2.Controls.Add(this.lbl_ctnhap);
            this.panel2.Controls.Add(this.lbl_ctban);
            this.panel2.Controls.Add(this.txt_ban);
            this.panel2.Controls.Add(this.txt_nhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rdb_month);
            this.panel2.Controls.Add(this.rdb_day);
            this.panel2.Controls.Add(this.dgv_time);
            this.panel2.Controls.Add(this.C_bieudo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 413);
            this.panel2.TabIndex = 0;
            // 
            // cbb_nam
            // 
            this.cbb_nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Location = new System.Drawing.Point(799, 129);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(84, 21);
            this.cbb_nam.Sorted = true;
            this.cbb_nam.TabIndex = 34;
            this.cbb_nam.Tag = "";
            this.cbb_nam.SelectedIndexChanged += new System.EventHandler(this.cbb_nam_SelectedIndexChanged);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXem.Location = new System.Drawing.Point(609, 127);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 33;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbb_time
            // 
            this.cbb_time.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_time.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_time.FormattingEnabled = true;
            this.cbb_time.Location = new System.Drawing.Point(709, 129);
            this.cbb_time.Name = "cbb_time";
            this.cbb_time.Size = new System.Drawing.Size(84, 21);
            this.cbb_time.Sorted = true;
            this.cbb_time.TabIndex = 32;
            this.cbb_time.Tag = "";
            this.cbb_time.SelectedIndexChanged += new System.EventHandler(this.cbb_time_SelectedIndexChanged);
            // 
            // lbl_ctnhap
            // 
            this.lbl_ctnhap.AutoSize = true;
            this.lbl_ctnhap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_ctnhap.Location = new System.Drawing.Point(804, 53);
            this.lbl_ctnhap.Name = "lbl_ctnhap";
            this.lbl_ctnhap.Size = new System.Drawing.Size(16, 13);
            this.lbl_ctnhap.TabIndex = 31;
            this.lbl_ctnhap.Text = "...";
            this.lbl_ctnhap.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_ctban
            // 
            this.lbl_ctban.AutoSize = true;
            this.lbl_ctban.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_ctban.Location = new System.Drawing.Point(804, 86);
            this.lbl_ctban.Name = "lbl_ctban";
            this.lbl_ctban.Size = new System.Drawing.Size(16, 13);
            this.lbl_ctban.TabIndex = 30;
            this.lbl_ctban.Text = "...";
            this.lbl_ctban.Click += new System.EventHandler(this.lbl_ctban_Click);
            // 
            // txt_ban
            // 
            this.txt_ban.Enabled = false;
            this.txt_ban.Location = new System.Drawing.Point(698, 79);
            this.txt_ban.Name = "txt_ban";
            this.txt_ban.Size = new System.Drawing.Size(100, 20);
            this.txt_ban.TabIndex = 18;
            // 
            // txt_nhap
            // 
            this.txt_nhap.Enabled = false;
            this.txt_nhap.Location = new System.Drawing.Point(698, 46);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(100, 20);
            this.txt_nhap.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bán ra :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhập vào :";
            // 
            // rdb_month
            // 
            this.rdb_month.AutoSize = true;
            this.rdb_month.Location = new System.Drawing.Point(742, 13);
            this.rdb_month.Name = "rdb_month";
            this.rdb_month.Size = new System.Drawing.Size(56, 17);
            this.rdb_month.TabIndex = 3;
            this.rdb_month.TabStop = true;
            this.rdb_month.Text = "Tháng";
            this.rdb_month.UseVisualStyleBackColor = true;
            this.rdb_month.CheckedChanged += new System.EventHandler(this.rdb_month_CheckedChanged);
            // 
            // rdb_day
            // 
            this.rdb_day.AutoSize = true;
            this.rdb_day.Location = new System.Drawing.Point(634, 13);
            this.rdb_day.Name = "rdb_day";
            this.rdb_day.Size = new System.Drawing.Size(50, 17);
            this.rdb_day.TabIndex = 2;
            this.rdb_day.TabStop = true;
            this.rdb_day.Text = "Ngày";
            this.rdb_day.UseVisualStyleBackColor = true;
            this.rdb_day.CheckedChanged += new System.EventHandler(this.rdb_day_CheckedChanged);
            // 
            // dgv_time
            // 
            this.dgv_time.AllowUserToAddRows = false;
            this.dgv_time.AllowUserToDeleteRows = false;
            this.dgv_time.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_time.Location = new System.Drawing.Point(573, 156);
            this.dgv_time.Name = "dgv_time";
            this.dgv_time.ReadOnly = true;
            this.dgv_time.Size = new System.Drawing.Size(313, 257);
            this.dgv_time.TabIndex = 1;
            this.dgv_time.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_time_CellClick);
            // 
            // C_bieudo
            // 
            this.C_bieudo.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.Name = "ChartArea1";
            this.C_bieudo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_bieudo.Legends.Add(legend1);
            this.C_bieudo.Location = new System.Drawing.Point(0, 0);
            this.C_bieudo.Name = "C_bieudo";
            this.C_bieudo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.C_bieudo.Series.Add(series1);
            this.C_bieudo.Series.Add(series2);
            this.C_bieudo.Size = new System.Drawing.Size(567, 410);
            this.C_bieudo.TabIndex = 0;
            this.C_bieudo.Text = "chart1";
            // 
            // UC_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_BaoCao";
            this.Size = new System.Drawing.Size(886, 413);
            this.Load += new System.EventHandler(this.UC_BaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_bieudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_bieudo;
        private System.Windows.Forms.RadioButton rdb_month;
        private System.Windows.Forms.RadioButton rdb_day;
        private System.Windows.Forms.DataGridView dgv_time;
        private System.Windows.Forms.TextBox txt_ban;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ctnhap;
        private System.Windows.Forms.Label lbl_ctban;
        private System.Windows.Forms.ComboBox cbb_time;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbb_nam;
    }
}
