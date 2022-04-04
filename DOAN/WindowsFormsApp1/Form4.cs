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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OrderTraSua context = new OrderTraSua();
        
        private void bt1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            if (a.ChucVu == 0)
            {
                MessageBox.Show("Chi co admin moi co the su dung ");
            }
            else
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            if (a.ChucVu == 0)
            {
                MessageBox.Show("Chi co admin moi co the su dung ");
            }
            else
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            if (a.ChucVu == 0)
            {
                MessageBox.Show("Chi co admin moi co the su dung ");
            }
            else
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            DialogResult rt = MessageBox.Show("Ban Co thuc Su Muon LOGOUT ", "Thong Bao!", MessageBoxButtons.OKCancel);
                if (rt == DialogResult.OK)
                {
                    a.Type = 0;
                    context.SaveChanges();
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
           
            
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            account a = context.accounts.FirstOrDefault(s => s.Type == 1);
            DialogResult rt = MessageBox.Show("Ban Co thuc Su Muon LOGOUT ", "Thong Bao!", MessageBoxButtons.OKCancel);
            if (rt == DialogResult.OK)
            {
                a.Type = 0;
                context.SaveChanges();
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
