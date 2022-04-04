using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataBase;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        OrderTraSua context = new OrderTraSua();
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

           
        }
        double t = 0;
        private void ThongKe()
        {
            dataGridView1.Rows.Clear();
            DateTime from = DateTime.Parse(dateTimePicker1.Text);
            DateTime to = DateTime.Parse(dateTimePicker2.Text);
            List<BILL> a = context.BILLs.Where(s => s.NGAYLAPHD >= from && s.NGAYLAPHD <= to).ToList();
            
            foreach (var item in a)
            {
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.MAHD;
                dataGridView1.Rows[i].Cells[1].Value = item.TONGBILL;
                dataGridView1.Rows[i].Cells[2].Value = item.NGAYLAPHD.Value;
                if (item.GIAMGIA == null)
                {
                    dataGridView1.Rows[i].Cells[3].Value = 0 + "%";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = item.GIAMGIA +"%";
                }
                t = t + double.Parse(item.TONGBILL.ToString());
            }

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US" 
            label10.Text = double.Parse(t.ToString()).ToString("#,###", cul.NumberFormat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            ThongKe();
            label9.Visible = true;
            label10.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
