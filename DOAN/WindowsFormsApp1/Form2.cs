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
    public partial class Form2 : Form
    {
        OrderTraSua context = new OrderTraSua();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oTHERTRASUADataSet1.KhuyenMai' table. You can move, or remove it, as needed.
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            TalbTraSua();
            TableConlai();
            TableTranChau();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<KhuyenMai> LISTKM = context.KhuyenMais.ToList();
            showkm();
            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btTS1_Click(object sender, EventArgs e)
        {
            //Drink a = context.Drinks;
            int index = dataGridView1.Rows.Add();
            //dataGridView1.Rows[index].Cells[0].Value 

        }
        private void TalbTraSua()
        {
            
            flowLayoutPanel2.Controls.Clear();     //xóa các buton sau mỗi lần chạy
            List<Drink> tabtrasua = context.Drinks.Where(s => s.MALOAI ==1).ToList(); /// dò trong bản drink tìm ra ma loại=1
            foreach (var item in tabtrasua)          //duyệt vòng for theo tabtrasua có mã loại =1
            {
                
                Button b = new Button() { Width =150,Height=150};
                Font f = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Pixel);
                b.Text = item.TENMON;       
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.Transparent;
                b.FlatAppearance.MouseOverBackColor = Color.Salmon;
                IMAGE hinh = context.IMAGEs.FirstOrDefault(s => s.Drink.MAMON == item.MAMON);
                if (hinh != null)
                {
                    string tenhinh = hinh.TENHINH.ToString();
                    b.Image = Image.FromFile("C:/Users/nguye/OneDrive/Pictures/hinh/TraSua/" + hinh.TENHINH + ".png");
                    button1.ImageAlign = ContentAlignment.MiddleCenter;
                }

                //gán tên drinks vào button đầu tiên ->...
                b.TextAlign = ContentAlignment.MiddleCenter;        //râu ria
                flowLayoutPanel2.Controls.Add(b);        //thêm buton vào tabcontrol
                b.Click +=  B_Click;
                b.Tag = item;
              
            }
              


        }

        private void B_Click(object sender, EventArgs e)
        {
            
            int id = ((sender as Button).Tag as Drink).MAMON;
            if (dataGridView1.Rows.Count <= 0)
            {

                BILL b = new BILL()
                {
                    NGAYLAPHD = DateTime.Now
                };
                context.BILLs.Add(b);
                context.SaveChanges();
            }
             int idbill = context.BILLs.Max(s => s.MAHD);
             BillInfo TimMon = context.BillInfoes.FirstOrDefault(s => s.MAHD == idbill && s.Drink.MAMON == id);
             if(TimMon == null)
             {
                    BillInfo c = new BillInfo()
                    {
                        MAHD = idbill,
                        MAMON = id,
                        SOLUONG = 1,
                        
                    };
                    context.BillInfoes.Add(c);
                    context.SaveChanges();
             }
             else
             {
                    TimMon.SOLUONG += 1;
                    context.SaveChanges();
             }
            Sql(idbill);
            label2_Click(sender, e);
        }

        private void Sql(int ma)
        {
            List<BillInfo> l = context.BillInfoes.Where(s=>s.MAHD == ma).ToList();
            dataGridView1.Rows.Clear();
            double t=0;
            foreach (var item in l)
            {
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.Drink.TENMON;
                dataGridView1.Rows[i].Cells[1].Value = item.Drink.GIA;
                dataGridView1.Rows[i].Cells[2].Value = item.SOLUONG;
                
                item.BILL.GIAMGIA = double.Parse(label4.Text);
                double? j = item.SOLUONG * item.Drink.GIA;
                t = t + double.Parse(j.ToString());
                item.BILL.TONGBILL = t-((t*item.BILL.GIAMGIA)/100);
                
                context.SaveChanges(); 
            }
            BILL tong = context.BILLs.FirstOrDefault(s => s.MAHD == ma);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US" 
            lbSoTien.Text = double.Parse(tong.TONGBILL.ToString()).ToString("#,###", cul.NumberFormat);


        }   
        private void Luubill()
        {
            BillInfo a = new BillInfo();
            
        }
        /// <summary>
        ///C            CÁC MÓN CÒN LẠI TRONG MENU CỬA TIỆM
        /// </summary>
        private void TableConlai()
        {
            flowLayoutPanel3.Controls.Clear();
            List<Drink> table = context.Drinks.Where(s => s.MALOAI != 1 && s.MALOAI !=5).ToList();
            foreach (var item in table)
            {
                Button c = new Button() { Width = 150, Height = 150 };
                //IMAGE hinh = context.IMAGEs.FirstOrDefault(s => s.Drink.MAMON == item.MAMON);
                //if (hinh != null)
                //{
                //    string tenhinh = hinh.TENHINH.ToString();
                //    c.Image = Image.FromFile("C:/Users/nguye/OneDrive/Pictures/hinh/NuocKhac/" + hinh.TENHINH + ".png");
                //    button1.ImageAlign = ContentAlignment.MiddleCenter;
                //}
                c.FlatStyle = FlatStyle.Flat;
                c.BackColor = Color.Transparent;
                c.FlatAppearance.MouseOverBackColor = Color.Orange;
                c.Text = item.TENMON;
                c.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel3.Controls.Add(c);
                c.Click += C_Click;
                c.Tag = item;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                BILL a = new BILL()
                {
                    NGAYLAPHD = DateTime.Now
                };
                context.BILLs.Add(a);
                context.SaveChanges();
            }
            int id = ((sender as Button).Tag as Drink).MAMON;
            int idbill = context.BILLs.Max(q => q.MAHD);
            BillInfo TimMon = context.BillInfoes.FirstOrDefault(q => q.MAHD == idbill && q.Drink.MAMON == id);
            if (TimMon ==null)
            {
                BillInfo c = new BillInfo();
                c.MAHD = idbill;
                c.MAMON = id;
                c.SOLUONG = 1;
                context.BillInfoes.Add(c);
                context.SaveChanges();
            }
            else
            {
                TimMon.SOLUONG +=1 ;
                context.SaveChanges();
            }
                
            Sql(idbill);

            // MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }

        /// <summary>
        ///                 Talb Các loại trân châu          
        /// </summary>
        private void TableTranChau()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Drink> table = context.Drinks.Where(s => s.MALOAI == 5).ToList();
            foreach (var item in table)
            {
                Button b = new Button() { Width = 150 , Height = 150 };
                /////////////////////////////////////////////////////
                Font f = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
                b.Text = item.TENMON;
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.Transparent;
                b.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
                b.ForeColor = Color.Black;
                b.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel1.Controls.Add(b);
                b.Click += b_Click;
                b.Tag = item;
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                BILL a = new BILL()
                {
                    NGAYLAPHD = DateTime.Now
                };
                context.BILLs.Add(a);
                context.SaveChanges();
            }
            int id = ((sender as Button).Tag as Drink).MAMON;
            int idbill = context.BILLs.Max(s => s.MAHD);
            BillInfo TimMon = context.BillInfoes.FirstOrDefault(s => s.Drink.MAMON == id && s.MAHD== idbill);
            if (TimMon == null)
            {
                BillInfo c = new BillInfo();
                c.MAHD = idbill;
                c.MAMON = id;
                c.SOLUONG = 1;
                context.BillInfoes.Add(c);
                context.SaveChanges();
            }
            else
            {
                TimMon.SOLUONG += 1;
                context.SaveChanges();
            }
            Sql(idbill);

            // MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }
        private void TongTien()
        {
            List<BillInfo> l = context.BillInfoes.ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in l)
            {
                double? j = item.SOLUONG * item.Drink.GIA;
                j += j;
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            if (i == 0)
            {
                MessageBox.Show("Moi ban other mon");
            }
            else
            {
                DialogResult rt = MessageBox.Show("Ban Co thuc Su Muon IN BILL ", "Thong Bao!", MessageBoxButtons.OKCancel);
                if (rt == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    lbSoTien.Text = "0";
                   
                    MessageBox.Show("In thanh cong!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int text = dataGridView1.RowCount;
            if (text == 0)
            {
                MessageBox.Show("Chua co bill ma huy qq gi`");
            }
            else
            {
                DialogResult rt = MessageBox.Show("Ban Co thuc Su Muon Huy Bill ", "Thong Bao!", MessageBoxButtons.OKCancel);
                if (rt == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();

                    int i = context.BILLs.Max(s => s.MAHD);
                    BILL bILL = context.BILLs.FirstOrDefault(s => s.MAHD == i);
                    List<BillInfo> c = context.BillInfoes.Where(s => s.MAHD == bILL.MAHD).ToList();
                    context.BILLs.Remove(bILL);
                    foreach (var item in c)
                    {
                        context.BillInfoes.Remove(item);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Huy thanh cong!");
                    lbSoTien.Text = "0";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idbill;
            idbill = context.BILLs.Max(s => s.MAHD);
            
            BillInfo b = context.BillInfoes.FirstOrDefault
               (s => s.MAHD == idbill && s.MAMON == chon);
            
            if (b == null)
            {

                MessageBox.Show("vui long nhap mon can xoa");
                return;         
            }
            else
            {
                if (b.SOLUONG>1)
                {
                    b.SOLUONG--;
                    context.SaveChanges();
                }
                else
                {
                    
                    context.BillInfoes.Remove(b);
                    context.SaveChanges();
                    
                }
                Sql(idbill);
            }
            BillInfo d = context.BillInfoes.FirstOrDefault(s => s.MAHD == idbill);
            if (d == null)
            {
                BILL bILL = context.BILLs.FirstOrDefault(s=>s.MAHD==idbill);
                
                context.BILLs.Remove(bILL);
                context.SaveChanges();
            }

        }
        int chon;
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string s1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                chon = context.Drinks.FirstOrDefault(s => s.TENMON == s1).MAMON;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //int i = int.Parse(label2.Text) * (int.Parse(comboBox1.DisplayMember) / 100);
            //label2.Text = (int.Parse(label2.Text) - i ).ToString();
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        private void button4_Click(object sender, EventArgs e)
        {

          
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        private void showkm()
        {
            DateTime show = DateTime.Now.Date;
            List<KhuyenMai> khuyenMais = context.KhuyenMais.ToList();
            foreach (KhuyenMai item in khuyenMais)
            {
                if (item.NgayBD <= show &&  show <= item.NgayKT)
                {
                    label4.Text = item.MKM.ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(label4.Text))
            {
                label4.Text = 0.ToString();
            }

            
        }
    }

}
