namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InforDrinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.bthuydon = new System.Windows.Forms.Button();
            this.btxoamon = new System.Windows.Forms.Button();
            this.khuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTHERTRASUADataSet1 = new WindowsFormsApp1.OTHERTRASUADataSet1();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
            this.khuyenMaiTableAdapter = new WindowsFormsApp1.OTHERTRASUADataSet1TableAdapters.KhuyenMaiTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTHERTRASUADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(656, 612);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(648, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trà Sữa";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(645, 583);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Coffee";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel3.BackgroundImage")));
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(645, 577);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 572);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Trân Châu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(645, 583);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.btthanhtoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btthanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btthanhtoan.Image")));
            this.btthanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthanhtoan.Location = new System.Drawing.Point(672, 542);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(145, 65);
            this.btthanhtoan.TabIndex = 7;
            this.btthanhtoan.Text = "Thanh toán";
            this.btthanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthanhtoan.UseVisualStyleBackColor = false;
            this.btthanhtoan.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InforDrinks,
            this.price,
            this.amount});
            this.dataGridView1.Location = new System.Drawing.Point(661, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 407);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InforDrinks
            // 
            this.InforDrinks.HeaderText = "Tên Món";
            this.InforDrinks.Name = "InforDrinks";
            this.InforDrinks.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Số Lượng";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(665, 485);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(183, 54);
            this.lbTongTien.TabIndex = 9;
            this.lbTongTien.Text = "Tổng Tiền :";
            // 
            // lbSoTien
            // 
            this.lbSoTien.BackColor = System.Drawing.Color.Transparent;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(859, 485);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(282, 54);
            this.lbSoTien.TabIndex = 10;
            this.lbSoTien.Click += new System.EventHandler(this.label2_Click);
            // 
            // bthuydon
            // 
            this.bthuydon.BackColor = System.Drawing.Color.Transparent;
            this.bthuydon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bthuydon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bthuydon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthuydon.Image = ((System.Drawing.Image)(resources.GetObject("bthuydon.Image")));
            this.bthuydon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuydon.Location = new System.Drawing.Point(838, 542);
            this.bthuydon.Name = "bthuydon";
            this.bthuydon.Size = new System.Drawing.Size(145, 65);
            this.bthuydon.TabIndex = 11;
            this.bthuydon.Text = "Hủy đơn";
            this.bthuydon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuydon.UseVisualStyleBackColor = false;
            this.bthuydon.Click += new System.EventHandler(this.button2_Click);
            // 
            // btxoamon
            // 
            this.btxoamon.BackColor = System.Drawing.Color.Transparent;
            this.btxoamon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btxoamon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxoamon.Image = ((System.Drawing.Image)(resources.GetObject("btxoamon.Image")));
            this.btxoamon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoamon.Location = new System.Drawing.Point(1009, 542);
            this.btxoamon.Name = "btxoamon";
            this.btxoamon.Size = new System.Drawing.Size(145, 65);
            this.btxoamon.TabIndex = 12;
            this.btxoamon.Text = "Xóa món";
            this.btxoamon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoamon.UseVisualStyleBackColor = false;
            this.btxoamon.Click += new System.EventHandler(this.button3_Click);
            // 
            // khuyenMaiBindingSource
            // 
            this.khuyenMaiBindingSource.DataMember = "KhuyenMai";
            this.khuyenMaiBindingSource.DataSource = this.oTHERTRASUADataSet1;
            // 
            // oTHERTRASUADataSet1
            // 
            this.oTHERTRASUADataSet1.DataSetName = "OTHERTRASUADataSet1";
            this.oTHERTRASUADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.lbKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenMai.Location = new System.Drawing.Point(666, 437);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(165, 32);
            this.lbKhuyenMai.TabIndex = 14;
            this.lbKhuyenMai.Text = "Khuyến Mãi";
            // 
            // khuyenMaiTableAdapter
            // 
            this.khuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 15;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(887, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 626);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKhuyenMai);
            this.Controls.Add(this.btxoamon);
            this.Controls.Add(this.bthuydon);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btthanhtoan);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Trà Sữa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTHERTRASUADataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button bthuydon;
        private System.Windows.Forms.Button btxoamon;
        private System.Windows.Forms.Label lbKhuyenMai;
        private OTHERTRASUADataSet1 oTHERTRASUADataSet1;
        private System.Windows.Forms.BindingSource khuyenMaiBindingSource;
        private OTHERTRASUADataSet1TableAdapters.KhuyenMaiTableAdapter khuyenMaiTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InforDrinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}