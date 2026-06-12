namespace main_project
{
    partial class work_staion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_sales_count_today = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_total_sales_cash = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_total_sales_credit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_total_sales_today = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_payments = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_business_details = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1368, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 815);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_sales_count_today);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(24, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 104);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lbl_sales_count_today
            // 
            this.lbl_sales_count_today.AutoSize = true;
            this.lbl_sales_count_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales_count_today.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_sales_count_today.Location = new System.Drawing.Point(33, 55);
            this.lbl_sales_count_today.Name = "lbl_sales_count_today";
            this.lbl_sales_count_today.Size = new System.Drawing.Size(0, 25);
            this.lbl_sales_count_today.TabIndex = 1;
            this.lbl_sales_count_today.Click += new System.EventHandler(this.lbl_sales_count_today_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Count : (Today)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_total_sales_cash);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(26, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 104);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_total_sales_cash
            // 
            this.lbl_total_sales_cash.AutoSize = true;
            this.lbl_total_sales_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sales_cash.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total_sales_cash.Location = new System.Drawing.Point(31, 53);
            this.lbl_total_sales_cash.Name = "lbl_total_sales_cash";
            this.lbl_total_sales_cash.Size = new System.Drawing.Size(0, 25);
            this.lbl_total_sales_cash.TabIndex = 3;
            this.lbl_total_sales_cash.Click += new System.EventHandler(this.lbl_total_sales_cash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Sales : (Cash)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_total_sales_credit);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(26, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 104);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_total_sales_credit
            // 
            this.lbl_total_sales_credit.AutoSize = true;
            this.lbl_total_sales_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sales_credit.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total_sales_credit.Location = new System.Drawing.Point(31, 59);
            this.lbl_total_sales_credit.Name = "lbl_total_sales_credit";
            this.lbl_total_sales_credit.Size = new System.Drawing.Size(0, 25);
            this.lbl_total_sales_credit.TabIndex = 4;
            this.lbl_total_sales_credit.Click += new System.EventHandler(this.lbl_total_sales_credit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Sales : (Credit)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_total_sales_today);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 104);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_total_sales_today
            // 
            this.lbl_total_sales_today.AutoSize = true;
            this.lbl_total_sales_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sales_today.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total_sales_today.Location = new System.Drawing.Point(31, 55);
            this.lbl_total_sales_today.Name = "lbl_total_sales_today";
            this.lbl_total_sales_today.Size = new System.Drawing.Size(0, 25);
            this.lbl_total_sales_today.TabIndex = 2;
            this.lbl_total_sales_today.Click += new System.EventHandler(this.lbl_total_sales_today_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Sales : (Today)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(49)))));
            this.panelMain.Location = new System.Drawing.Point(0, 106);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1362, 718);
            this.panelMain.TabIndex = 10;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.btn_refresh, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_payments, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_customers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_business_details, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_stock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_invoice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_exit, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::main_project.Properties.Resources.refresh__1_;
            this.btn_refresh.Location = new System.Drawing.Point(978, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(189, 94);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_payments
            // 
            this.btn_payments.BackgroundImage = global::main_project.Properties.Resources.payment_method__1_;
            this.btn_payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payments.Location = new System.Drawing.Point(588, 3);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(189, 94);
            this.btn_payments.TabIndex = 3;
            this.btn_payments.Text = "Payments";
            this.btn_payments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_payments.UseVisualStyleBackColor = true;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click_1);
            // 
            // btn_customers
            // 
            this.btn_customers.BackgroundImage = global::main_project.Properties.Resources.service__1_;
            this.btn_customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Location = new System.Drawing.Point(393, 3);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(189, 94);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_business_details
            // 
            this.btn_business_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_business_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_business_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_business_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_business_details.Image = global::main_project.Properties.Resources.report;
            this.btn_business_details.Location = new System.Drawing.Point(783, 3);
            this.btn_business_details.Name = "btn_business_details";
            this.btn_business_details.Size = new System.Drawing.Size(189, 94);
            this.btn_business_details.TabIndex = 4;
            this.btn_business_details.Text = "Business Details";
            this.btn_business_details.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_business_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_business_details.UseVisualStyleBackColor = true;
            this.btn_business_details.Click += new System.EventHandler(this.btn_business_details_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackgroundImage = global::main_project.Properties.Resources.in_stock;
            this.btn_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Location = new System.Drawing.Point(3, 3);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(189, 94);
            this.btn_stock.TabIndex = 0;
            this.btn_stock.Text = "Stock";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click_1);
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackgroundImage = global::main_project.Properties.Resources.invoice__2_;
            this.btn_invoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.Location = new System.Drawing.Point(198, 3);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(189, 94);
            this.btn_invoice.TabIndex = 1;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = global::main_project.Properties.Resources.log_out;
            this.btn_exit.Location = new System.Drawing.Point(1173, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(192, 94);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // work_staion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1694, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(935, 548);
            this.Name = "work_staion";
            this.Text = "work_staion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.work_staion_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_sales_count_today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_total_sales_cash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_total_sales_credit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_total_sales_today;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_payments;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_business_details;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_invoice;
    }
}