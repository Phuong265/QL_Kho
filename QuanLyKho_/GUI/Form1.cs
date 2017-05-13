using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void showControl(System.Windows.Forms.Control obj)
        {
            pnND.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            pnND.Controls.Add(obj);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_DSHangHoa();
            showControl(us);
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_BaoCao();
            showControl(us);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (toolStripDropDownButton1.BackColor == Color.Transparent)
                toolStripDropDownButton1.BackColor = Color.SeaGreen;
            else toolStripDropDownButton1.BackColor = Color.Transparent;
           
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_NhapKho();
            showControl(us);
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_XuatKho();
            showControl(us);

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            if (toolStripDropDownButton2.BackColor == Color.Transparent)
                toolStripDropDownButton2.BackColor = Color.SeaGreen;
            else toolStripDropDownButton2.BackColor = Color.Transparent;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_NhaCungCap();
            showControl(us);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
