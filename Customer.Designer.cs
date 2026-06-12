namespace main_project
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pos_dbDataSet1 = new main_project.pos_dbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_customer_id = new System.Windows.Forms.TextBox();
            this.txtbox_customer_name = new System.Windows.Forms.TextBox();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.data_gr_vi_cus = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pos_dbDataSet9 = new main_project.pos_dbDataSet9();
            this.combox_type = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.customerTableAdapter = new main_project.pos_dbDataSet9TableAdapters.customerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gr_vi_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet9)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(350, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(350, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer name";
            // 
            // pos_dbDataSet1
            // 
            this.pos_dbDataSet1.DataSetName = "pos_dbDataSet";
            this.pos_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(350, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(728, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(728, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(728, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type";
            // 
            // txtbox_customer_id
            // 
            this.txtbox_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_customer_id.Location = new System.Drawing.Point(395, 65);
            this.txtbox_customer_id.Name = "txtbox_customer_id";
            this.txtbox_customer_id.Size = new System.Drawing.Size(256, 30);
            this.txtbox_customer_id.TabIndex = 6;
            // 
            // txtbox_customer_name
            // 
            this.txtbox_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_customer_name.Location = new System.Drawing.Point(395, 157);
            this.txtbox_customer_name.Name = "txtbox_customer_name";
            this.txtbox_customer_name.Size = new System.Drawing.Size(256, 30);
            this.txtbox_customer_name.TabIndex = 7;
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_phone.Location = new System.Drawing.Point(395, 249);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(256, 30);
            this.txtbox_phone.TabIndex = 8;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_address.Location = new System.Drawing.Point(746, 65);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(247, 30);
            this.txtbox_address.TabIndex = 9;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_email.Location = new System.Drawing.Point(746, 157);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(247, 30);
            this.txtbox_email.TabIndex = 10;
            // 
            // data_gr_vi_cus
            // 
            this.data_gr_vi_cus.AllowUserToOrderColumns = true;
            this.data_gr_vi_cus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gr_vi_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gr_vi_cus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_gr_vi_cus.Location = new System.Drawing.Point(0, 427);
            this.data_gr_vi_cus.MultiSelect = false;
            this.data_gr_vi_cus.Name = "data_gr_vi_cus";
            this.data_gr_vi_cus.ReadOnly = true;
            this.data_gr_vi_cus.RowHeadersWidth = 51;
            this.data_gr_vi_cus.RowTemplate.Height = 24;
            this.data_gr_vi_cus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_gr_vi_cus.Size = new System.Drawing.Size(1344, 202);
            this.data_gr_vi_cus.TabIndex = 14;
            this.data_gr_vi_cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gr_vi_cus_CellContentClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.pos_dbDataSet9;
            // 
            // pos_dbDataSet9
            // 
            this.pos_dbDataSet9.DataSetName = "pos_dbDataSet9";
            this.pos_dbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combox_type
            // 
            this.combox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_type.FormattingEnabled = true;
            this.combox_type.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.combox_type.Location = new System.Drawing.Point(746, 249);
            this.combox_type.Name = "combox_type";
            this.combox_type.Size = new System.Drawing.Size(247, 33);
            this.combox_type.TabIndex = 15;
            this.combox_type.SelectedIndexChanged += new System.EventHandler(this.combox_type_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.694715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23108F));
            this.tableLayoutPanel1.Controls.Add(this.btn_submit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clear, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(412, 319);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 83);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Black;
            this.btn_submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Image = global::main_project.Properties.Resources.public_relation1;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(3, 3);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(111, 77);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "  Submit";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Image = global::main_project.Properties.Resources.delete_user;
            this.btn_delete.Location = new System.Drawing.Point(167, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 77);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete ";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Black;
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Image = global::main_project.Properties.Resources.eraser__1_1;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(331, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 77);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "  Clear";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Image = global::main_project.Properties.Resources.captcha1;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(495, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 77);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "          Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::main_project.Properties.Resources.influencer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combox_type);
            this.Controls.Add(this.data_gr_vi_cus);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_phone);
            this.Controls.Add(this.txtbox_customer_name);
            this.Controls.Add(this.txtbox_customer_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gr_vi_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_dbDataSet9)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private pos_dbDataSet pos_dbDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_customer_id;
        private System.Windows.Forms.TextBox txtbox_customer_name;
        private System.Windows.Forms.TextBox txtbox_phone;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView data_gr_vi_cus;
        private System.Windows.Forms.ComboBox combox_type;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private pos_dbDataSet9 pos_dbDataSet9;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private pos_dbDataSet9TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btn_update;
    }
}