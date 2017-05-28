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
    public partial class ChitietBaoCao : Form
    {
        private bool drag = false;
        private Point dragCursor, dragForm;
        public ChitietBaoCao()
        {
            InitializeComponent();
        }
        public ChitietBaoCao(DataTable dt)
        {
            InitializeComponent();
            dgvDSHangHoa.DataSource = dt;
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
                //    Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                //      QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChitietBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
