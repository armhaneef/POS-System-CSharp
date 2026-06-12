using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project
{
    public partial class work_staion : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public work_staion()
        {
            InitializeComponent();
            datalode_cu();
            lodedata_stock();
        }

        private void work_staion_Load(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            lodedata_stock();

        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {


        }

        private void btn_payments_Click(object sender, EventArgs e)
        {



        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stock_Click_1(object sender, EventArgs e)
        {
            lodedata_stock();

        }

        private void btn_invoice_Click_1(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0) ;
            
            {
                panelMain.Controls.RemoveAt(0);

            }
            invoice invoice = new invoice();
            invoice.TopLevel = false;
            invoice.Dock = DockStyle.Fill;

            panelMain.Controls.Add(invoice);
            invoice.Show();
            datalode_cu();

        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0) ;

            {
                panelMain.Controls.RemoveAt(0);


            }
            Customer cu = new Customer();
            cu.TopLevel = false;
            cu.Dock = DockStyle.Fill;
            panelMain.Controls.Add(cu);
            cu.Show();
            datalode_cu();
        }

        private void btn_payments_Click_1(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0) ;

            {
                panelMain.Controls.RemoveAt(0);



            }
            payments payments = new payments();
            payments.TopLevel = false;
            payments.Dock = DockStyle.Fill;
            panelMain.Controls.Add(payments);
            payments.Show();
            datalode_cu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            datalode_cu();
        }

        private void btn_business_details_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0) ;
            { panelMain.Controls.RemoveAt(0);
            }
            business_details bd = new business_details();
            bd.TopLevel = false;
            bd.Dock = DockStyle.Fill;
            panelMain.Controls.Add(bd);
            bd.Show();
            datalode_cu();
           
        }
        private void datalode_cu() 
        {
            try
            {
                con.Open();
                SqlCommand sa_cou = new SqlCommand("SELECT COUNT(*) FROM Invoice WHERE CAST (Date AS Date)= CAST(GETDATE() AS Date)", con);
                int salescount = Convert.ToInt32(sa_cou.ExecuteScalar());
                con.Close();
                lbl_sales_count_today.Text = salescount.ToString();


                SqlCommand today_sales = new SqlCommand("SELECT ISNULL(SUM(Amount),0) FROM payments WHERE CAST (Date AS Date) = CAST(GETDATE() AS DATE)", con);
                con.Open();
                decimal today_sales_cu = Convert.ToDecimal(today_sales.ExecuteScalar());
                con.Close();
                lbl_total_sales_today.Text = "Rs " + today_sales_cu.ToString("0.00");


                con.Open();

                SqlCommand cmdCash = new SqlCommand(
                    "SELECT ISNULL(SUM(amount),0) FROM Payments " +
                    "WHERE Payment_method = 'Cash' " +
                    "AND CAST(date AS DATE) = CAST(GETDATE() AS DATE)", con);

                decimal cashSalesToday = Convert.ToDecimal(cmdCash.ExecuteScalar());

                lbl_total_sales_cash.Text = "Rs " + cashSalesToday.ToString("0.00");



                SqlCommand cmdCredit = new SqlCommand( "SELECT ISNULL(SUM(amount),0) FROM Payments " +
                    "WHERE Payment_method = 'Credit' " +
                     "AND CAST(date AS DATE) = CAST(GETDATE() AS DATE)", con);

                decimal creditSalesToday = Convert.ToDecimal(cmdCredit.ExecuteScalar());

                lbl_total_sales_credit.Text = "Rs " + creditSalesToday.ToString("0.00");

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }




        }

        private void lbl_sales_count_today_Click(object sender, EventArgs e)
        {

        }
        private void lodedata_stock()
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }

            stock stock = new stock();
            stock.TopLevel = false;


            stock.Dock = DockStyle.Fill;


            panelMain.Controls.Add(stock);
            stock.Show();
            datalode_cu();
        }

        private void lbl_total_sales_today_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_total_sales_cash_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_total_sales_credit_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
