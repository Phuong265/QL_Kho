using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UC_BaoCao : UserControl
    {
        DataTable time = new DataTable();
        public UC_BaoCao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (txt_nhap.Text != "")
            {
                DataTable dt = new DataTable();
                if (rdb_day.Checked == true && dgv_time.CurrentRow != null)
                {
                    dt = BaoCao.mathangnhapinday(DateTime.Parse(dgv_time.CurrentRow.Cells[0].Value.ToString()));
                }
                else if (rdb_day.Checked != true)
                {
                    dt = BaoCao.mathangnhapinmonth(cbb_nam.Text, cbb_time.Text);
                }
                ChitietBaoCao ct = new ChitietBaoCao(dt);
                ct.Show();
            }
            else
                MessageBox.Show("Không có dữ liệu");
            
        }
        private void setchecked()
        {
            if (rdb_day.Checked == true)
            {
                rdb_month.Checked = false;
            }
            else
            {
                rdb_month.Checked = true;
            }

        }
        private void rdb_day_CheckedChanged(object sender, EventArgs e)
        {
            setchecked();
            dgv_time.Visible = true;
            reset();
        }
        private void reset()
        {
            txt_nhap.Text = "";
            txt_ban.Text = "";
        }
        private void rdb_month_CheckedChanged(object sender, EventArgs e)
        {
            setchecked();
            dgv_time.Visible = false;
            reset();
        }

        private void UC_BaoCao_Load(object sender, EventArgs e)
        {
            DataTable dt = DTO.BaoCao.get_nam();
            cbb_nam.DataSource = dt;
            cbb_nam.ValueMember = "nam";
            cbb_nam.DisplayMember = "nam";
            rdb_day.Checked = true;
        }

        private void lbl_ctban_Click(object sender, EventArgs e)
        {
            if (txt_ban.Text != "")
            {
                DataTable dt = new DataTable();
                if (rdb_day.Checked == true && dgv_time.CurrentRow != null)
                {
                    dt = BaoCao.mathangxuatinday(DateTime.Parse(dgv_time.CurrentRow.Cells[0].Value.ToString()));
                }
                else if (rdb_day.Checked != true)
                {
                    dt = BaoCao.mathangxuatinmonth(cbb_nam.Text, cbb_time.Text);
                }
                ChitietBaoCao ct = new ChitietBaoCao(dt);
                ct.Show();
            }
            else
                MessageBox.Show("Không có dữ liệu");
        }

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_nam.Text != "")
            {
                DataTable dt = new DataTable();
                dt = BaoCao.get_thang(cbb_nam.Text);
                if (dt != null)
                {
                    cbb_time.DataSource = dt;
                    cbb_time.ValueMember = "thang";
                    cbb_time.DisplayMember = "thang";
                }
                else
                    MessageBox.Show("Không có dữ liệu cho năm " + cbb_nam.Text);

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dts = new DataTable();
            time = BaoCao.get_ngay(cbb_nam.Text, cbb_time.Text);
            if (rdb_day.Checked == true)
            {
                dt = BaoCao.get_soluongnhapngay(cbb_nam.Text, cbb_time.Text);
                dts = BaoCao.get_soluongxuatngay(cbb_nam.Text, cbb_time.Text);
                if(dts!=null)
                    for (int i = 0; i < dts.Columns.Count; i++)
                { DataColumn newcolumn = new DataColumn(dts.Columns[i].ColumnName, dts.Columns[i].DataType); dt.Columns.Add(newcolumn); }
                if (dt != null)
                {
                    dgv_time.DataSource = time;
                    dgv_time.Columns[0].HeaderText = "Ngày";
                    dgv_time.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho tháng " + cbb_time.Text);
                    return;
                }
                   
            }
            else
            {
                dt = BaoCao.get_soluongnhapthang(cbb_nam.Text, cbb_time.Text);
                dts = BaoCao.get_soluongxuatthang(cbb_nam.Text, cbb_time.Text);
            }
            if(dts!=null)
            txt_ban.Text = dts.Rows[0][0].ToString();
            if(dt!=null)
            txt_nhap.Text = dt.Rows[0][0].ToString();

            displaychart();
        }
        private void setxy(int x, decimal y, int i)
        {
            C_bieudo.Series[i].Points.AddXY(x, y);
        }
        private void displaychart()
        {
            //Tìm và đặt giá trị MAX cho trục Y
            //int max = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //for (int i = 1; i < 6; i++)
            //    if (max < Convert.ToInt32(dataGridView1.CurrentRow.Cells[i].Value))
            //        max = Convert.ToInt32(dataGridView1.CurrentRow.Cells[i].Value);
            //if (chart1.ChartAreas[0].AxisY.Maximum < max) chart1.ChartAreas[0].AxisY.Maximum = max;

           
            C_bieudo.Series[0].Points.Clear();
            C_bieudo.Series[1].Points.Clear();
            C_bieudo.Series.Clear();
            C_bieudo.Series.Add("Nhập");
            C_bieudo.Series.Add("Xuất");

            if (rdb_day.Checked == true)
            {
                decimal temp,temp2;
                DataPoint p = new DataPoint();
                p.XValue = 1;
                if (txt_nhap.Text != "")
                {
                    temp = Convert.ToDecimal(txt_nhap.Text);
                }
                else temp = 0;
                if (txt_ban.Text != "")
                {
                    temp2 = Convert.ToDecimal(txt_ban.Text);
                }
                else temp2 = 0;
                p.AxisLabel = dgv_time.CurrentCell.Value.ToString();
                setxy(1, temp, 0);
                setxy(1, temp2, 1);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = BaoCao.SLnhapdaymonth(cbb_nam.Text, cbb_time.Text);
                if(dt!=null)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ngay;
                    ngay = int.Parse(dt.Rows[i][1].ToString());
                    decimal SL = decimal.Parse(dt.Rows[i][0].ToString());
                    setxy(ngay, SL, 0);
                }
                dt = BaoCao.SLxuatdaymonth(cbb_nam.Text, cbb_time.Text);
                if(dt!=null)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ngay;
                    ngay = int.Parse(dt.Rows[i][1].ToString());
                    decimal SL = decimal.Parse(dt.Rows[i][0].ToString());
                    setxy(ngay, SL, 1);
                }
            }

        }
    }
}
