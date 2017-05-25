using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO;
using System.Drawing;

namespace GUI
{
    public partial class frmMain : Form
    {
        private bool drag = false;
        private Point dragCursor, dragForm;
        public frmMain()
        {
            string a = Application.StartupPath.Replace(@"bin\Debug", @"data\QuanLyKho.mdf");
            DTO.Connect.SetConnectString(a);
            while (!DTO.Connect.Open() && MessageBox.Show("Can not connect database", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ;
            MessageBox.Show(DTO.Connect.GetSqlConnection().State.ToString());
            InitializeComponent();
        }
        private void changenk_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void mouseup(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void changenk_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                // Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                // QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
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
            //if (toolStripDropDownButton1.BackColor == ColorTransparent)
            //    toolStripDropDownButton1.BackColor = Color.SeaGreen;
            //else toolStripDropDownButton1.BackColor = Color.Transparent;

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
            //if (toolStripDropDownButton2.BackColor == Color.Transparent)
            //    toolStripDropDownButton2.BackColor = Color.SeaGreen;
            //else toolStripDropDownButton2.BackColor = Color.Transparent;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_NhaCungCap();
            showControl(us);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_NhanVien();
            showControl(us);
        }

        private void danhSáchHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UC_DSHangHoa hh = new UC_DSHangHoa();
            //hh.Show();
            UserControl us = new UC_DSHangHoa();
            showControl(us);
        }
    }
}
