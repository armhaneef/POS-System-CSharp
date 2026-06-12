namespace main_project
{
    partial class stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.combox_Supplier = new System.Windows.Forms.ComboBox();
            this.businessDetilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pos_dbDataSet15 = new main_project.pos_dbDataSet15();
            this.txtbox_Purchasing_Order_Number = new System.Windows.Forms.TextBox();
            this.txtbox_SellingPrice = new System.Windows.Forms.TextBox();
            this.txtbox_Purchasing_Value = new System.Windows.Forms.TextBox();
            this.txtbox_purchasing_Price = new System.Windows.Forms.TextBox();
            this.txtbox_Purchasing_Quantity = new System.Windows.Forms.TextBox();
            this.txtbox_Description = new System.Windows.Forms.TextBox();
            this.txtbox_Item_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_gr_vi_stock = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pos_dbDataSet6 = new main_project.pos_dbDataSet6();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_purch_valu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_stoc_item_count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.stockTableAdapter = new main_project.pos_dbDataSet6TableAdapters.StockTableAdapter();
            this.businessDetilesTableAdapter = new main_project.pos_dbDataSet15TableAdapters.BusinessDetilesTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDetilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gr_vi_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet6)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.combox_Supplier);
            this.panel1.Controls.Add(this.txtbox_Purchasing_Order_Number);
            this.panel1.Controls.Add(this.txtbox_SellingPrice);
            this.panel1.Controls.Add(this.txtbox_Purchasing_Value);
            this.panel1.Controls.Add(this.txtbox_purchasing_Price);
            this.panel1.Controls.Add(this.txtbox_Purchasing_Quantity);
            this.panel1.Controls.Add(this.txtbox_Description);
            this.panel1.Controls.Add(this.txtbox_Item_Code);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 52);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.rToolStripMenuItem.Text = "Remove item";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 24);
            this.toolStripMenuItem2.Text = "Stock Full Screen View ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // combox_Supplier
            // 
            this.combox_Supplier.DataSource = this.businessDetilesBindingSource;
            this.combox_Supplier.DisplayMember = "Owner_Name";
            this.combox_Supplier.FormattingEnabled = true;
            this.combox_Supplier.Location = new System.Drawing.Point(13, 487);
            this.combox_Supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_Supplier.Name = "combox_Supplier";
            this.combox_Supplier.Size = new System.Drawing.Size(201, 26);
            this.combox_Supplier.TabIndex = 21;
            this.combox_Supplier.SelectedIndexChanged += new System.EventHandler(this.combox_Supplier_SelectedIndexChanged);
            // 
            // businessDetilesBindingSource
            // 
            this.businessDetilesBindingSource.DataMember = "BusinessDetiles";
            this.businessDetilesBindingSource.DataSource = this.pos_dbDataSet15;
            // 
            // pos_dbDataSet15
            // 
            this.pos_dbDataSet15.DataSetName = "pos_dbDataSet15";
            this.pos_dbDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbox_Purchasing_Order_Number
            // 
            this.txtbox_Purchasing_Order_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_Purchasing_Order_Number.Location = new System.Drawing.Point(13, 414);
            this.txtbox_Purchasing_Order_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Purchasing_Order_Number.Name = "txtbox_Purchasing_Order_Number";
            this.txtbox_Purchasing_Order_Number.Size = new System.Drawing.Size(200, 28);
            this.txtbox_Purchasing_Order_Number.TabIndex = 17;
            this.txtbox_Purchasing_Order_Number.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtbox_SellingPrice
            // 
            this.txtbox_SellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_SellingPrice.Location = new System.Drawing.Point(13, 348);
            this.txtbox_SellingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_SellingPrice.Name = "txtbox_SellingPrice";
            this.txtbox_SellingPrice.Size = new System.Drawing.Size(201, 28);
            this.txtbox_SellingPrice.TabIndex = 16;
            this.txtbox_SellingPrice.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtbox_Purchasing_Value
            // 
            this.txtbox_Purchasing_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_Purchasing_Value.Location = new System.Drawing.Point(13, 283);
            this.txtbox_Purchasing_Value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Purchasing_Value.Name = "txtbox_Purchasing_Value";
            this.txtbox_Purchasing_Value.Size = new System.Drawing.Size(200, 28);
            this.txtbox_Purchasing_Value.TabIndex = 15;
            this.txtbox_Purchasing_Value.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtbox_purchasing_Price
            // 
            this.txtbox_purchasing_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_purchasing_Price.Location = new System.Drawing.Point(13, 218);
            this.txtbox_purchasing_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_purchasing_Price.Name = "txtbox_purchasing_Price";
            this.txtbox_purchasing_Price.Size = new System.Drawing.Size(201, 28);
            this.txtbox_purchasing_Price.TabIndex = 14;
            this.txtbox_purchasing_Price.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtbox_Purchasing_Quantity
            // 
            this.txtbox_Purchasing_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_Purchasing_Quantity.Location = new System.Drawing.Point(13, 153);
            this.txtbox_Purchasing_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Purchasing_Quantity.Name = "txtbox_Purchasing_Quantity";
            this.txtbox_Purchasing_Quantity.Size = new System.Drawing.Size(201, 28);
            this.txtbox_Purchasing_Quantity.TabIndex = 13;
            this.txtbox_Purchasing_Quantity.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtbox_Description
            // 
            this.txtbox_Description.Location = new System.Drawing.Point(13, 92);
            this.txtbox_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Description.Name = "txtbox_Description";
            this.txtbox_Description.Size = new System.Drawing.Size(199, 24);
            this.txtbox_Description.TabIndex = 23;
            this.txtbox_Description.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbox_Item_Code
            // 
            this.txtbox_Item_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtbox_Item_Code.Location = new System.Drawing.Point(13, 27);
            this.txtbox_Item_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Item_Code.Name = "txtbox_Item_Code";
            this.txtbox_Item_Code.Size = new System.Drawing.Size(197, 28);
            this.txtbox_Item_Code.TabIndex = 8;
            this.txtbox_Item_Code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Supplier :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Purchasing Order Number :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "MRP/Selling Price :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purchasing Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "purchasing Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchasing Quantity :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // data_gr_vi_stock
            // 
            this.data_gr_vi_stock.AllowUserToAddRows = false;
            this.data_gr_vi_stock.AllowUserToDeleteRows = false;
            this.data_gr_vi_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_gr_vi_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_gr_vi_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_gr_vi_stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_gr_vi_stock.Location = new System.Drawing.Point(248, 6);
            this.data_gr_vi_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_gr_vi_stock.Name = "data_gr_vi_stock";
            this.data_gr_vi_stock.ReadOnly = true;
            this.data_gr_vi_stock.RowHeadersWidth = 51;
            this.data_gr_vi_stock.RowTemplate.Height = 24;
            this.data_gr_vi_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_gr_vi_stock.Size = new System.Drawing.Size(1091, 534);
            this.data_gr_vi_stock.TabIndex = 0;
            this.data_gr_vi_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gr_vi_stock_CellContentClick);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.pos_dbDataSet6;
            // 
            // pos_dbDataSet6
            // 
            this.pos_dbDataSet6.DataSetName = "pos_dbDataSet6";
            this.pos_dbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_purch_valu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1116, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 83);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_purch_valu
            // 
            this.lbl_purch_valu.AutoSize = true;
            this.lbl_purch_valu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purch_valu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.lbl_purch_valu.Location = new System.Drawing.Point(16, 46);
            this.lbl_purch_valu.Name = "lbl_purch_valu";
            this.lbl_purch_valu.Size = new System.Drawing.Size(0, 18);
            this.lbl_purch_valu.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Purchasing Value :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.lbl_stoc_item_count);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(888, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 83);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_stoc_item_count
            // 
            this.lbl_stoc_item_count.AutoSize = true;
            this.lbl_stoc_item_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stoc_item_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.lbl_stoc_item_count.Location = new System.Drawing.Point(12, 46);
            this.lbl_stoc_item_count.Name = "lbl_stoc_item_count";
            this.lbl_stoc_item_count.Size = new System.Drawing.Size(0, 18);
            this.lbl_stoc_item_count.TabIndex = 1;
            this.lbl_stoc_item_count.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Stock item Count :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(49)))));
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.490602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.490602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.490602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.490602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.486318F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.3601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.61325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.61325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.9812F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 542);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 87);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::main_project.Properties.Resources.eraser__1_2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(117, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 83);
            this.button2.TabIndex = 20;
            this.button2.Text = "       Clean ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 83);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add item";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Image = global::main_project.Properties.Resources.captcha1;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(231, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 81);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "          Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Image = global::main_project.Properties.Resources.delete_user;
            this.btn_delete.Location = new System.Drawing.Point(345, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 81);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // businessDetilesTableAdapter
            // 
            this.businessDetilesTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(459, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 83);
            this.button4.TabIndex = 1;
            this.button4.Text = "Print Stock Balance";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.data_gr_vi_stock);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(934, 547);
            this.Name = "stock";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessDetilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gr_vi_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_Purchasing_Order_Number;
        private System.Windows.Forms.TextBox txtbox_SellingPrice;
        private System.Windows.Forms.TextBox txtbox_Purchasing_Value;
        private System.Windows.Forms.TextBox txtbox_purchasing_Price;
        private System.Windows.Forms.TextBox txtbox_Purchasing_Quantity;
        private System.Windows.Forms.TextBox txtbox_Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_stoc_item_count;
        private System.Windows.Forms.Label lbl_purch_valu;
        private System.Windows.Forms.ComboBox combox_Supplier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        protected internal System.Windows.Forms.TextBox txtbox_Item_Code;
        private System.Windows.Forms.DataGridView data_gr_vi_stock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private pos_dbDataSet6 pos_dbDataSet6;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private pos_dbDataSet6TableAdapters.StockTableAdapter stockTableAdapter;
        private pos_dbDataSet15 pos_dbDataSet15;
        private System.Windows.Forms.BindingSource businessDetilesBindingSource;
        private pos_dbDataSet15TableAdapters.BusinessDetilesTableAdapter businessDetilesTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button4;
    }
}