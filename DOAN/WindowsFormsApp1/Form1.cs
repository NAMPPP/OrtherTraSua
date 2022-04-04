using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataBase;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        OrderTraSua context = new OrderTraSua();
        public int quyen;
        public void button1_Click(object sender, EventArgs e)
        {
            String tk = textBox1.Text;
            String mk = textBox2.Text;
            account a = context.accounts.FirstOrDefault(s => s.TaiKhoan == tk && s.MatKhau == mk);

            Form4 F2 = new Form4();
            if (a != null)
            {
                a.Type = 1;
                context.SaveChanges();
                this.Hide();
                F2.ShowDialog();

                this.Close();

            }
            else
            {
                i++;
                MessageBox.Show("Dang Nhap Khong Thanh Cong!");
            }
            if (i > 3)
            {
                button1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = "123";
            textBox2.Text = "123";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
