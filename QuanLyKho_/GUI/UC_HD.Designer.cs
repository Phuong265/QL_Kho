namespace GUI
{
    partial class UC_HD
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hướng dẫn sử dụng phần mềm quản lý kho hàng",
            "",
            "1. Chức năng: bao gồm các chức năng nhập kho, xuất kho gồm các chức năng :",
            "\t- Nhập kho : thêm hàng hóa vào kho, xóa hàng hóa nhập sai hiện tại, hoặc xóa phi" +
                "ếu nhập hiện tại.",
            "\t-Xuất kho : các thông tin về khách hàng, nhập hàng hóa để xuất kho, cho phép sửa" +
                " hoặc xóa trong phần chi tiết phiếu xuất",
            "",
            "2. Danh mục: ",
            "    Quản lý các thông tin nhân viên và nhà cung cấp bao gồm các chức năng:",
            "     \t-  Thêm nhân viên: mã nhân viên, tên nhân viên, địa chỉ, sdt, giới tính, ng" +
                "ày sinh",
            "   \t-  Thêm nhà cung cấp: mã nhà cung cấp, tên nhà cung cấp, địa chỉ, sdt",
            "    \t-  Sửa thông tin nhân viên, thông tin nhà cung cấp",
            "\t-  Xóa thông tin nhân viên, thông tin nhà cung cấp",
            "",
            "3. Hàng hóa:",
            "    \tĐưa ra danh sách các mặt hàng trong kho với các thông tin của hàng hóa như :" +
                " mã hàng hóa,",
            "    tên hàng hóa, số lượng, xuất xứ, ghi chú.",
            "",
            "4. Báo cáo :",
            "   \tĐưa ra báo cáo tổng số lượng hàng nhập, hàng xuất theo ngày hoặc tháng, chi t" +
                "iết của từng loại ",
            "phiếu đã nhập hoặc xuất trong ngày hoặc tháng đấy."});
            this.listBox1.Location = new System.Drawing.Point(3, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(874, 446);
            this.listBox1.TabIndex = 2;
            // 
            // UC_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Name = "UC_HD";
            this.Size = new System.Drawing.Size(880, 463);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}
