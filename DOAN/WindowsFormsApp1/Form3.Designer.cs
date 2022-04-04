namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThemSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenMon = new System.Windows.Forms.TextBox();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableDrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTHERTRASUADataSet = new WindowsFormsApp1.OTHERTRASUADataSet();
            this.tableDrinksTableAdapter = new WindowsFormsApp1.OTHERTRASUADataSetTableAdapters.TableDrinksTableAdapter();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.txbMaMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTHERTRASUADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btThemSua
            // 
            resources.ApplyResources(this.btThemSua, "btThemSua");
            this.btThemSua.BackColor = System.Drawing.Color.Transparent;
            this.btThemSua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btThemSua.FlatAppearance.BorderSize = 2;
            this.btThemSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btThemSua.Name = "btThemSua";
            this.btThemSua.UseVisualStyleBackColor = false;
            this.btThemSua.Click += new System.EventHandler(this.AddDrink_Click);
            // 
            // btXoa
            // 
            resources.ApplyResources(this.btXoa, "btXoa");
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btXoa.FlatAppearance.BorderSize = 2;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btXoa.Name = "btXoa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.DeleteDrink_Click);
            // 
            // lbTenMon
            // 
            resources.ApplyResources(this.lbTenMon, "lbTenMon");
            this.lbTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lbTenMon.Name = "lbTenMon";
            // 
            // lbGia
            // 
            resources.ApplyResources(this.lbGia, "lbGia");
            this.lbGia.BackColor = System.Drawing.Color.Transparent;
            this.lbGia.Name = "lbGia";
            // 
            // lbLoai
            // 
            resources.ApplyResources(this.lbLoai, "lbLoai");
            this.lbLoai.BackColor = System.Drawing.Color.Transparent;
            this.lbLoai.Name = "lbLoai";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txbTenMon
            // 
            resources.ApplyResources(this.txbTenMon, "txbTenMon");
            this.txbTenMon.Name = "txbTenMon";
            this.txbTenMon.TextChanged += new System.EventHandler(this.txbTenMon_TextChanged);
            // 
            // txbGia
            // 
            resources.ApplyResources(this.txbGia, "txbGia");
            this.txbGia.Name = "txbGia";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tableDrinksBindingSource, "MALOAI", true));
            this.comboBox1.DataSource = this.tableDrinksBindingSource;
            this.comboBox1.DisplayMember = "TENLOAI";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "MALOAI";
            // 
            // tableDrinksBindingSource
            // 
            this.tableDrinksBindingSource.DataMember = "TableDrinks";
            this.tableDrinksBindingSource.DataSource = this.oTHERTRASUADataSet;
            // 
            // oTHERTRASUADataSet
            // 
            this.oTHERTRASUADataSet.DataSetName = "OTHERTRASUADataSet";
            this.oTHERTRASUADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDrinksTableAdapter
            // 
            this.tableDrinksTableAdapter.ClearBeforeFill = true;
            // 
            // lbMaMon
            // 
            resources.ApplyResources(this.lbMaMon, "lbMaMon");
            this.lbMaMon.BackColor = System.Drawing.Color.Transparent;
            this.lbMaMon.Name = "lbMaMon";
            // 
            // txbMaMon
            // 
            resources.ApplyResources(this.txbMaMon, "txbMaMon");
            this.txbMaMon.Name = "txbMaMon";
            this.txbMaMon.ReadOnly = true;
            this.txbMaMon.TextChanged += new System.EventHandler(this.txbMaMon_TextChanged);
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txbMaMon);
            this.Controls.Add(this.lbMaMon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txbGia);
            this.Controls.Add(this.txbTenMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLoai);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenMon);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThemSua);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTHERTRASUADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThemSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenMon;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.ComboBox comboBox1;
        private OTHERTRASUADataSet oTHERTRASUADataSet;
        private System.Windows.Forms.BindingSource tableDrinksBindingSource;
        private OTHERTRASUADataSetTableAdapters.TableDrinksTableAdapter tableDrinksTableAdapter;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.TextBox txbMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}