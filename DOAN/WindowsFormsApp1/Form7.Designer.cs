namespace WindowsFormsApp1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableDrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OTHERTRASUADataSet = new WindowsFormsApp1.OTHERTRASUADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TableDrinksTableAdapter = new WindowsFormsApp1.OTHERTRASUADataSetTableAdapters.TableDrinksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TableDrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTHERTRASUADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TableDrinksBindingSource
            // 
            this.TableDrinksBindingSource.DataMember = "TableDrinks";
            this.TableDrinksBindingSource.DataSource = this.OTHERTRASUADataSet;
            // 
            // OTHERTRASUADataSet
            // 
            this.OTHERTRASUADataSet.DataSetName = "OTHERTRASUADataSet";
            this.OTHERTRASUADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1082, 637);
            this.reportViewer1.TabIndex = 0;
            // 
            // TableDrinksTableAdapter
            // 
            this.TableDrinksTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 637);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTHERTRASUADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableDrinksBindingSource;
        private OTHERTRASUADataSet OTHERTRASUADataSet;
        private OTHERTRASUADataSetTableAdapters.TableDrinksTableAdapter TableDrinksTableAdapter;
    }
}