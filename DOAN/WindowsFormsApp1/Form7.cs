using Microsoft.Reporting.WinForms;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OTHERTRASUADataSet.TableDrinks' table. You can move, or remove it, as needed.
            this.TableDrinksTableAdapter.Fill(this.OTHERTRASUADataSet.TableDrinks);
            loadReport();
            this.reportViewer1.RefreshReport();
        }
        OrderTraSua orderTraSua = new OrderTraSua();
        void loadReport()
        {

            List<BILL> SVReport = orderTraSua.BILLs.ToList();
            //foreach (var i in diemSV)
            //{
            //    SinhVienReport a = new SinhVienReport();
            //    a.TenSinhVien = i.SinhVien.TenSinhVien;
            //    a.MaSV = i.MaSV;
            //    a.TenMonHoc = i.MonHoc.TenMonHoc;
            //    a.Diem = i.Diem;
            //    SVReport.Add(a);
            //}
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportdata = new ReportDataSource("DataSet3", SVReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportdata);
            this.reportViewer1.RefreshReport();
        }
    }
}
