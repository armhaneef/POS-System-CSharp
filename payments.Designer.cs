namespace main_project
{
    partial class payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payments));
            this.customerTableAdapter = new main_project.pos_dbDataSet3TableAdapters.customerTableAdapter();
            this.data_gri_vi_payments = new System.Windows.Forms.DataGridView();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pos_dbDataSet5 = new main_project.pos_dbDataSet5();
            this.posdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pos_dbDataSet = new main_project.pos_dbDataSet();
            this.pos_dbDataSet3 = new main_project.pos_dbDataSet3();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pos_dbDataSet2 = new main_project.pos_dbDataSet2();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_payments = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_clear_payments = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.combox_pay_method = new System.Windows.Forms.ComboBox();
            this.lbl_pay_Method = new System.Windows.Forms.Label();
            this.combox_invoice_ref = new System.Windows.Forms.ComboBox();
            this.txtbox_payment_id = new System.Windows.Forms.TextBox();
            this.lbl_paymentid = new System.Windows.Forms.Label();
            this.dtp_pay_date = new System.Windows.Forms.DateTimePicker();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbl_pay_Date = new System.Windows.Forms.Label();
            this.combox_pay_customer = new System.Windows.Forms.ComboBox();
            this.lbl_pay_Customer = new System.Windows.Forms.Label();
            this.invoiceTableAdapter = new main_project.pos_dbDataSet2TableAdapters.InvoiceTableAdapter();
            this.lblinvoice_ref = new System.Windows.Forms.Label();
            this.paymentsTableAdapter = new main_project.pos_dbDataSet5TableAdapters.paymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_gri_vi_payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // data_gri_vi_payments
            // 
            this.data_gri_vi_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gri_vi_payments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_gri_vi_payments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_gri_vi_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gri_vi_payments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_gri_vi_payments.Location = new System.Drawing.Point(0, 411);
            this.data_gri_vi_payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_gri_vi_payments.Name = "data_gri_vi_payments";
            this.data_gri_vi_payments.ReadOnly = true;
            this.data_gri_vi_payments.RowHeadersWidth = 51;
            this.data_gri_vi_payments.RowTemplate.Height = 24;
            this.data_gri_vi_payments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.data_gri_vi_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_gri_vi_payments.Size = new System.Drawing.Size(1344, 218);
            this.data_gri_vi_payments.TabIndex = 61;
            this.data_gri_vi_payments.VirtualMode = true;
            this.data_gri_vi_payments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gri_vi_payments_CellContentClick_1);
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.pos_dbDataSet5;
            // 
            // pos_dbDataSet5
            // 
            this.pos_dbDataSet5.DataSetName = "pos_dbDataSet5";
            this.pos_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posdbDataSetBindingSource
            // 
            this.posdbDataSetBindingSource.DataSource = this.pos_dbDataSet;
            this.posdbDataSetBindingSource.Position = 0;
            // 
            // pos_dbDataSet
            // 
            this.pos_dbDataSet.DataSetName = "pos_dbDataSet";
            this.pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pos_dbDataSet3
            // 
            this.pos_dbDataSet3.DataSetName = "pos_dbDataSet3";
            this.pos_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.pos_dbDataSet3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::main_project.Properties.Resources._81959da6_00b1_4ad3_8779_e89ddfabb40f;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pos_dbDataSet2
            // 
            this.pos_dbDataSet2.DataSetName = "pos_dbDataSet2";
            this.pos_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.pos_dbDataSet2;
            // 
            // btn_add_payments
            // 
            this.btn_add_payments.BackColor = System.Drawing.Color.Black;
            this.btn_add_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_payments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_payments.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_payments.Image")));
            this.btn_add_payments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_payments.Location = new System.Drawing.Point(3, 2);
            this.btn_add_payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_payments.Name = "btn_add_payments";
            this.btn_add_payments.Size = new System.Drawing.Size(119, 58);
            this.btn_add_payments.TabIndex = 27;
            this.btn_add_payments.Text = "Add item";
            this.btn_add_payments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_payments.UseVisualStyleBackColor = false;
            this.btn_add_payments.Click += new System.EventHandler(this.btn_add_payments_Click_2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add_payments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clear_payments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1063, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.22966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.691867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.22966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.691867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.22966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.694556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23274F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 326);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // btn_clear_payments
            // 
            this.btn_clear_payments.AutoSize = true;
            this.btn_clear_payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clear_payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear_payments.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_payments.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear_payments.Image")));
            this.btn_clear_payments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear_payments.Location = new System.Drawing.Point(3, 89);
            this.btn_clear_payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_payments.Name = "btn_clear_payments";
            this.btn_clear_payments.Size = new System.Drawing.Size(119, 58);
            this.btn_clear_payments.TabIndex = 28;
            this.btn_clear_payments.Text = "       Clean ";
            this.btn_clear_payments.UseVisualStyleBackColor = true;
            this.btn_clear_payments.Click += new System.EventHandler(this.btn_clear_payments_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Image = global::main_project.Properties.Resources.delete_user;
            this.btn_delete.Location = new System.Drawing.Point(3, 177);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 56);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete item";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Image = global::main_project.Properties.Resources.captcha1;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(3, 264);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 59);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "          Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // combox_pay_method
            // 
            this.combox_pay_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_pay_method.FormattingEnabled = true;
            this.combox_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.combox_pay_method.Location = new System.Drawing.Point(669, 273);
            this.combox_pay_method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_pay_method.Name = "combox_pay_method";
            this.combox_pay_method.Size = new System.Drawing.Size(295, 30);
            this.combox_pay_method.TabIndex = 60;
            this.combox_pay_method.SelectedIndexChanged += new System.EventHandler(this.combox_pay_method_SelectedIndexChanged);
            // 
            // lbl_pay_Method
            // 
            this.lbl_pay_Method.AutoSize = true;
            this.lbl_pay_Method.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pay_Method.Location = new System.Drawing.Point(651, 236);
            this.lbl_pay_Method.Name = "lbl_pay_Method";
            this.lbl_pay_Method.Size = new System.Drawing.Size(178, 24);
            this.lbl_pay_Method.TabIndex = 59;
            this.lbl_pay_Method.Text = "Payment Method :";
            // 
            // combox_invoice_ref
            // 
            this.combox_invoice_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_invoice_ref.FormattingEnabled = true;
            this.combox_invoice_ref.Location = new System.Drawing.Point(669, 113);
            this.combox_invoice_ref.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_invoice_ref.Name = "combox_invoice_ref";
            this.combox_invoice_ref.Size = new System.Drawing.Size(297, 30);
            this.combox_invoice_ref.TabIndex = 58;
            this.combox_invoice_ref.SelectedIndexChanged += new System.EventHandler(this.combox_invoice_ref_SelectedIndexChanged);
            // 
            // txtbox_payment_id
            // 
            this.txtbox_payment_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_payment_id.Location = new System.Drawing.Point(299, 111);
            this.txtbox_payment_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_payment_id.Name = "txtbox_payment_id";
            this.txtbox_payment_id.Size = new System.Drawing.Size(280, 28);
            this.txtbox_payment_id.TabIndex = 56;
            // 
            // lbl_paymentid
            // 
            this.lbl_paymentid.AutoSize = true;
            this.lbl_paymentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentid.Location = new System.Drawing.Point(283, 76);
            this.lbl_paymentid.Name = "lbl_paymentid";
            this.lbl_paymentid.Size = new System.Drawing.Size(127, 24);
            this.lbl_paymentid.TabIndex = 55;
            this.lbl_paymentid.Text = "Payment ID :";
            // 
            // dtp_pay_date
            // 
            this.dtp_pay_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_pay_date.Location = new System.Drawing.Point(299, 185);
            this.dtp_pay_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_pay_date.Name = "dtp_pay_date";
            this.dtp_pay_date.Size = new System.Drawing.Size(280, 28);
            this.dtp_pay_date.TabIndex = 52;
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_amount.Location = new System.Drawing.Point(669, 188);
            this.txtbox_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(295, 28);
            this.txtbox_amount.TabIndex = 54;
            this.txtbox_amount.TextChanged += new System.EventHandler(this.txtbox_amount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmount.Location = new System.Drawing.Point(651, 156);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(94, 24);
            this.lblAmount.TabIndex = 51;
            this.lblAmount.Text = "Amount :";
            // 
            // lbl_pay_Date
            // 
            this.lbl_pay_Date.AutoSize = true;
            this.lbl_pay_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pay_Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pay_Date.Location = new System.Drawing.Point(283, 154);
            this.lbl_pay_Date.Name = "lbl_pay_Date";
            this.lbl_pay_Date.Size = new System.Drawing.Size(64, 24);
            this.lbl_pay_Date.TabIndex = 49;
            this.lbl_pay_Date.Text = "Date :";
            // 
            // combox_pay_customer
            // 
            this.combox_pay_customer.DataSource = this.customerBindingSource;
            this.combox_pay_customer.DisplayMember = "Customer_id";
            this.combox_pay_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_pay_customer.FormattingEnabled = true;
            this.combox_pay_customer.Location = new System.Drawing.Point(299, 271);
            this.combox_pay_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_pay_customer.Name = "combox_pay_customer";
            this.combox_pay_customer.Size = new System.Drawing.Size(280, 30);
            this.combox_pay_customer.TabIndex = 53;
            // 
            // lbl_pay_Customer
            // 
            this.lbl_pay_Customer.AutoSize = true;
            this.lbl_pay_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pay_Customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pay_Customer.Location = new System.Drawing.Point(283, 234);
            this.lbl_pay_Customer.Name = "lbl_pay_Customer";
            this.lbl_pay_Customer.Size = new System.Drawing.Size(111, 24);
            this.lbl_pay_Customer.TabIndex = 50;
            this.lbl_pay_Customer.Text = "Customer :";
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // lblinvoice_ref
            // 
            this.lblinvoice_ref.AutoSize = true;
            this.lblinvoice_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoice_ref.Location = new System.Drawing.Point(651, 78);
            this.lblinvoice_ref.Name = "lblinvoice_ref";
            this.lblinvoice_ref.Size = new System.Drawing.Size(126, 24);
            this.lblinvoice_ref.TabIndex = 57;
            this.lblinvoice_ref.Text = "Invoice Ref :";
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.data_gri_vi_payments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.combox_pay_method);
            this.Controls.Add(this.lbl_pay_Method);
            this.Controls.Add(this.combox_invoice_ref);
            this.Controls.Add(this.txtbox_payment_id);
            this.Controls.Add(this.lbl_paymentid);
            this.Controls.Add(this.dtp_pay_date);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbl_pay_Date);
            this.Controls.Add(this.combox_pay_customer);
            this.Controls.Add(this.lbl_pay_Customer);
            this.Controls.Add(this.lblinvoice_ref);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payments";
            this.Text = "payments";
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_gri_vi_payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pos_dbDataSet3TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView data_gri_vi_payments;
        private System.Windows.Forms.BindingSource posdbDataSetBindingSource;
        private pos_dbDataSet pos_dbDataSet;
        private pos_dbDataSet3 pos_dbDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pos_dbDataSet2 pos_dbDataSet2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Button btn_add_payments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox combox_pay_method;
        private System.Windows.Forms.Label lbl_pay_Method;
        private System.Windows.Forms.ComboBox combox_invoice_ref;
        private System.Windows.Forms.TextBox txtbox_payment_id;
        private System.Windows.Forms.Label lbl_paymentid;
        private System.Windows.Forms.DateTimePicker dtp_pay_date;
        private System.Windows.Forms.TextBox txtbox_amount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbl_pay_Date;
        private System.Windows.Forms.ComboBox combox_pay_customer;
        private System.Windows.Forms.Label lbl_pay_Customer;
        private pos_dbDataSet2TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.Label lblinvoice_ref;
        private pos_dbDataSet5 pos_dbDataSet5;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private pos_dbDataSet5TableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Button btn_clear_payments;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}