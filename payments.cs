using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project
{


    public partial class payments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public payments()
        {
            InitializeComponent();
            lodedata_payments();
            
            lodedata_itemcode();
            

        }

        private void btn_add_payments_Click(object sender, EventArgs e)
        {
        }










        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_payments_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_payments_Click(object sender, EventArgs e)
        {
            txtbox_amount.Text = "";
            txtbox_payment_id.Text = "";
            dtp_pay_date.Text = "";
            combox_invoice_ref.Text = "";
            combox_pay_customer.Text = "";
            combox_pay_method.Text = "";


        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_dbDataSet5.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.pos_dbDataSet5.payments);
            // TODO: This line of code loads data into the 'pos_dbDataSet3.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pos_dbDataSet3.customer);
            // TODO: This line of code loads data into the 'pos_dbDataSet2.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.pos_dbDataSet2.Invoice);

        }


        void lodedata_payments()
        {
            con.Open();
             SqlCommand paymentdetils = new SqlCommand("SELECT  * FROM [payments]", con);
             paymentdetils.ExecuteNonQuery();
             SqlDataAdapter paymentsataadapter = new SqlDataAdapter(paymentdetils);
             DataTable paymenttable = new DataTable();
             paymentsataadapter.Fill(paymenttable);
            data_gri_vi_payments.DataSource = paymenttable;
             con.Close();


        }

        private void btn_add_payments_Click_1(object sender, EventArgs e)
        {

        }

        private void data_gri_vi_payments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void combox_pay_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pay_Customer_Click(object sender, EventArgs e)
        {

        }

        private void dtp_pay_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pay_Date_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_payment_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_paymentid_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_payments_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_payment_id.Text))
            {
                MessageBox.Show("Payment id can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_payment_id.Focus();
                this.ActiveControl = txtbox_payment_id;
            }
            else

            {
                if (string.IsNullOrEmpty(dtp_pay_date.Text))
                {
                    MessageBox.Show("Date can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                    dtp_pay_date.Focus();
                    this.ActiveControl = dtp_pay_date;


                }
                else
                {
                    if (string.IsNullOrEmpty(combox_pay_customer.Text))

                    {
                        MessageBox.Show("Customer can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        combox_pay_customer.Focus();
                        this.ActiveControl = combox_pay_customer;



                    }
                    else
                    {

                        if (string.IsNullOrEmpty(combox_invoice_ref.Text))
                        {

                            MessageBox.Show("Invoice Ref can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            combox_invoice_ref.Focus();
                            this.ActiveControl = combox_invoice_ref;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtbox_amount.Text))

                            {

                                MessageBox.Show("amount can't be null ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtbox_amount.Focus();
                                this.ActiveControl = txtbox_amount;
                            }
                            else
                            {

                                if (string.IsNullOrEmpty(combox_pay_method.Text))
                                {

                                    MessageBox.Show("Payment Method can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    combox_pay_method.Focus();
                                    this.ActiveControl = combox_pay_method;
                                }
                                else
                                {
                                    try
                                    {

                                        con.Open();

                                        SqlCommand paymentdetiles = new SqlCommand("INSERT INTO payments ([Payment_id],[Date],[Customer],[Invoice_ref],[Amount],[Payment_method]) VALUES ('" + txtbox_payment_id.Text + "'," +
                                            "'" + dtp_pay_date.Text + "'," +
                                            "'" + combox_pay_customer.Text + "'," +
                                            "'" + combox_invoice_ref.Text + "'," +
                                            "'" + Convert.ToDouble(txtbox_amount.Text) + "'," +
                                            "'" + combox_pay_method.Text + "')", con);

                                        paymentdetiles.ExecuteNonQuery();
                                        con.Close();


                                        MessageBox.Show("Item added", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        


                                        lodedata_payments();

                                    } catch (Exception ex) { MessageBox.Show(ex.Message); }




                                }



                            }



                        }




                    }


                }


            }




        }

        private void combox_pay_method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_amount_TextChanged(object sender, EventArgs e)
        {
           // lodedata_amount();


        }
        private void lodedata_amount()
        {


            /*

            string invoiceno = combox_invoice_ref.Text;
            if (string.IsNullOrWhiteSpace(invoiceno))
            {
                return;

            }
            string qury = "SELECT grand_total FROM Invoice WHERE InvoiceNo=@invoiceno";
            using (SqlCommand item = new SqlCommand(qury, con))

            {

                item.Parameters.AddWithValue("@invoiceno", invoiceno);
                con.Open();
                SqlDataReader DR = item.ExecuteReader();
                if (DR.Read())
                {
                    txtbox_amount.Text = DR["grand_total"].ToString();

                }
                else
                {
                    MessageBox.Show("amount not fount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            */

                /*  string itemcode = combox_item_code.Text;


                  if (string.IsNullOrWhiteSpace(itemcode))
                  {
                      return;
                  }

                  string query = "SELECT Description, MRP FROM Stock WHERE item_code = @itemcode";

                  using (SqlCommand item = new SqlCommand(query, con))
                  {
                      item.Parameters.AddWithValue("@itemcode", itemcode);

                      con.Open();
                      SqlDataReader dr = item.ExecuteReader();

                      if (dr.Read())
                      {
                          txtbox_product.Text = dr["Description"].ToString();
                          txtbox_un_price.Text = dr["MRP"].ToString();
                      }
                      else
                      {
                          MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }

                      con.Close();*/





            }
        

            
          
        

        private void btn_clear_payments_Click_1(object sender, EventArgs e)
        {

        }

        private void combox_invoice_ref_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrWhiteSpace(combox_invoice_ref.Text))
                    return;

                int invoiceNo = Convert.ToInt32(combox_invoice_ref.Text);

                string query = "SELECT grand_total FROM Invoice WHERE InvoiceNo=@invoiceNo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@invoiceNo", invoiceNo);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    if (result != null)
                    {
                        txtbox_amount.Text = Convert.ToDecimal(result).ToString("0.00");
                    }

                    else
                    {
                        MessageBox.Show("Invoice amount not found",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
            

                lodedata_itemcode();
                //lodedata_amount();

            }
        
        private void lodedata_itemcode()
        {
            con.Open();
            SqlCommand itemcode = new SqlCommand("SELECT InvoiceNo FROM Invoice", con);
            SqlDataReader dr = itemcode.ExecuteReader();
            while (dr.Read()) 
            {

                combox_invoice_ref.Items.Add(dr["InvoiceNo"].ToString());
            
            
            
            
            }

            con.Close(); 



            


        }

        private void data_gri_vi_payments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                clear();
            {
                DataGridViewRow row = data_gri_vi_payments.Rows[e.RowIndex];
                txtbox_amount.Text = row.Cells["Amount"].Value.ToString();
                combox_invoice_ref.Text = row.Cells["Invoice_ref"].Value.ToString();
                combox_pay_customer.Text = row.Cells["Customer"].Value.ToString();
                txtbox_payment_id.Text = row.Cells["Payment_id"].Value.ToString();
                dtp_pay_date.Text = row.Cells["Date"].Value.ToString();
                combox_pay_method.Text = row.Cells["Payment_method"].Value.ToString();
                    


           
            
            
            
            
            
            
            
            }
        }
        private void clear() 
        {


            txtbox_amount.Text = "";
            txtbox_payment_id.Text = "";
            dtp_pay_date.Text = "";
            combox_invoice_ref.Text = "";
            combox_pay_customer.Text = "";
            combox_pay_method.Text = "";

            
            
            }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_gri_vi_payments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete  the selected payments", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;


            int payment = Convert.ToInt32(data_gri_vi_payments.SelectedRows[0].Cells["Payment_id"].Value);

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM payments WHERE Payment_id = @paymentid", con);
            
            cmd.Parameters.AddWithValue("@paymentid", payment);
            cmd.ExecuteNonQuery();
            con.Close();
            lodedata_payments();
            MessageBox.Show("Record deleted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            
            
            


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand payment_update = new SqlCommand(
                    "UPDATE payments SET " +
                    "[Date]='" + dtp_pay_date.Text + "'," +
                    "[Customer]='" + combox_pay_customer.Text + "'," +
                    "[Invoice_ref]='" + combox_invoice_ref.Text + "'," +
                    "[Amount]='" + Convert.ToDouble(txtbox_amount.Text) + "'," +
                    "[Payment_method]='" + combox_pay_method.Text + "' " +
                    "WHERE [Payment_id]='" + txtbox_payment_id.Text + "'",
                    con
                );

                payment_update.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Payment updated successfully",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lodedata_payments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
    
}
