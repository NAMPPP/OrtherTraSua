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
    public partial class Form3 : Form
    {
        OrderTraSua context = new OrderTraSua();
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private  int kt(int ma)
        {
           Drink a =  context.Drinks.FirstOrDefault(s => s.MAMON == ma);
            if (a != null) return 1;
            else return -1;
        }
        private void Theṃ̣()
        {
            List<Drink> a = context.Drinks.ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in a)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MAMON;
                dataGridView1.Rows[index].Cells[1].Value = item.TENMON;
                dataGridView1.Rows[index].Cells[2].Value = item.GIA;
                dataGridView1.Rows[index].Cells[3].Value = item.TableDrink.TENLOAI;
            }

        }
        private void update(Drink d)
        {
            List<Drink> a  = context.Drinks.Where(s=>s.TENMON == d.TENMON).ToList();
            
            dataGridView1.Rows.Clear();
            foreach (var item in a)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MAMON;
                dataGridView1.Rows[index].Cells[1].Value = d.TENMON;
                dataGridView1.Rows[index].Cells[2].Value = item.GIA;
                dataGridView1.Rows[index].Cells[3].Value = item.TableDrink.TENLOAI;
            }

        }
        private void Xoa1Drink()
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oTHERTRASUADataSet.TableDrinks' table. You can move, or remove it, as needed.
            this.tableDrinksTableAdapter.Fill(this.oTHERTRASUADataSet.TableDrinks);
            Theṃ̣();

        }

        private void DeleteDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink d = context.Drinks.FirstOrDefault(s => s.TENMON == txbTenMon.Text);
                BillInfo b = context.BillInfoes.FirstOrDefault(s => s.MAMON == d.MAMON);
                if (txbTenMon.Text == "" || txbGia.Text == "")
                {
                    MessageBox.Show("moi ban nhap mon can xoa");
                }

                else
                {
                    if (d != null)
                    {
                        if (b!=null)
                        {
                            MessageBox.Show("Mon nay hien nam trong hoa don k the xoa");

                        }
                        else
                        {
                            DialogResult rt = MessageBox.Show("Ban Co thuc Su Muon Xoa", "Thong Bao!", MessageBoxButtons.OKCancel);
                            if (rt == DialogResult.OK)
                            {
                                context.Drinks.Remove(d);
                                context.SaveChanges();
                                MessageBox.Show("Xoa thanh cong!");
                            }
                        }
                        
                    }
                    else
                        MessageBox.Show("khong co mon ban can xoa");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Xoa khong thanh cong");
                return;
            }
            Theṃ̣();
            clear();
        }
        private void clear()
        {
            txbMaMon.Clear();
            txbTenMon.Clear();
            txbGia.Clear();
            comboBox1.Text = "";
            txbTenMon.Focus();
        }
        private void txbTenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaMon.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txbTenMon.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbGia.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void AddDrink_Click(object sender, EventArgs e)
        {

            try
            {
                Drink d = context.Drinks.FirstOrDefault(s => s.TENMON == txbTenMon.Text);
                if(txbTenMon.Text=="" || txbGia.Text=="")
                {
                    MessageBox.Show("ban chua nhap mon");
                }
                if (d == null)
                {
                    Drink dd = new Drink()
                    {
                        TENMON = txbTenMon.Text,
                        GIA = double.Parse(txbGia.Text),
                        MALOAI = int.Parse(comboBox1.SelectedValue.ToString()),
                       
                    };
                    
                    context.Drinks.Add(dd);
                    context.SaveChanges();
   
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Drink da ton tai");
                }
            }
            catch
            {

                return;
            }
            Theṃ̣();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbMaMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
