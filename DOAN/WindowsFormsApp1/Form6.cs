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
    public partial class Form6 : Form
    {
        OrderTraSua context = new OrderTraSua();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            xoakm();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                MessageBox.Show("Ban chua nhap muc khuyen mai");
            }
            else
            {
                int id = int.Parse(textBox1.Text);
                luusql(id);
            }
            
           
        }
        void luugiua(int ma)
        {
            KhuyenMai Km = new KhuyenMai();
            Km.MKM= ma;
            Km.NgayBD = DateTime.Parse(dateTimePicker1.Text);
            Km.NgayKT = DateTime.Parse(dateTimePicker2.Text);
            List<KhuyenMai> KT1 = context.KhuyenMais.OrderByDescending(s => s.NgayBD ).ToList();
            KhuyenMai Km1 = new KhuyenMai();
            foreach (var item1 in KT1)
            {
                if (item1.NgayKT == Km1.NgayBD)
                {
                    MessageBox.Show("thoi gian nay da ton tai ");
                    break;
                }
                if (Km.NgayBD >= item1.NgayKT && Km.NgayBD <= Km1.NgayBD)
                {
                        MessageBox.Show("Them thanh cong!");
                        context.KhuyenMais.Add(Km);
                        context.SaveChanges();
                        break;

                }
                else
                {
                    Km1.MKM = item1.MKM;
                    Km1.NgayBD = item1.NgayBD;
                    Km1.NgayKT = item1.NgayKT;
                    
                }
                
                
            }
            
        }
        
        void luusql(int ma)
        {
            
            KhuyenMai KT = context.KhuyenMais.FirstOrDefault(x => x.MKM == ma);
            DateTime a = DateTime.Now.Date;
            KhuyenMai Km = new KhuyenMai();
            Km.MKM = ma;
            Km.NgayBD = DateTime.Parse(dateTimePicker1.Text);
            Km.NgayKT = DateTime.Parse(dateTimePicker2.Text);
            //KhuyenMai kiemtraNBD = context.KhuyenMais.FirstOrDefault(x => x.NgayBD == Km.NgayBD);
            //DateTime kiemtraNKT;
            //kiemtraNKT = context.KhuyenMais.Max(x=>x.NgayKT).Value;
            
            if (Km.NgayBD < a || Km.NgayBD>=Km.NgayKT)
            {
                MessageBox.Show("ban nhap sai moi nhap lai");
            }
            else
            {
                if (context.KhuyenMais.Max(x => x.NgayKT) != null)
                {
                    
                        if (Km.NgayBD >= context.KhuyenMais.Max(x => x.NgayKT))
                        {
                            MessageBox.Show("Them thanh cong!");
                            context.KhuyenMais.Add(Km);
                            context.SaveChanges();
                        }
                        else
                        {
                            luugiua(ma);
                        }
                }
                else
                {
                    MessageBox.Show("Them thanh cong");
                    KhuyenMai Km1 = new KhuyenMai();
                    Km1.MKM = ma;
                    Km1.NgayBD = DateTime.Parse(dateTimePicker1.Text);
                    Km1.NgayKT = DateTime.Parse(dateTimePicker2.Text);  
                    context.KhuyenMais.Add(Km1);
                    context.SaveChanges();
                    
                }
            }
        }
        
        private void xoakm()
        {
            DateTime xoa = DateTime.Now.Date;
            List<KhuyenMai> khuyenMais = context.KhuyenMais.Where(s => s.NgayKT == xoa).ToList();

            foreach (KhuyenMai item in khuyenMais)
            {
                context.KhuyenMais.Remove(item);
                context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
               
        }
        
    }
    


}
