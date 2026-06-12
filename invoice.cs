using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main_project
{
    public partial class invoice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public invoice()
        {
            InitializeComponent();
          lodedata();
            lodedata_com_customer();
            lodedata_com_itemcode();
            
            
           

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_dbDataSet17.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter3.Fill(this.pos_dbDataSet17.Stock);
            // TODO: This line of code loads data into the 'pos_dbDataSet16.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.pos_dbDataSet16.customer);
            con.Open();
            this.stockTableAdapter2.Fill(this.pos_dbDataSet14.Stock);
            this.customerTableAdapter1.Fill(this.pos_dbDataSet8.customer);
            this.stockTableAdapter.Fill(this.pos_dbDataSet.Stock);

            
            combox_customer.DisplayMember = "Customer_id";
            combox_customer.ValueMember = "Customer_id";

            combox_item_code.DisplayMember = "item_code";
            combox_item_code.ValueMember = "item_code";
            con.Close();
            

        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblinvoiceNo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_quantity_TextChanged(object sender, EventArgs e)
        {
            
           try
            {
                if (string.IsNullOrWhiteSpace(txtbox_un_price.Text) ||
         string.IsNullOrWhiteSpace(txtbox_quantity.Text))
                {

                    txtbox_subtotal.Text = "";
                    return;

                }
                if (decimal.TryParse(txtbox_un_price.Text, out decimal price) && decimal.TryParse(txtbox_quantity.Text, out decimal qty))
                {

                    decimal subtotal = price * qty;
                    txtbox_subtotal.Text = subtotal.ToString("0.00");
                    decimal vat = subtotal * 0.18m;
                    txtbox_vat.Text = vat.ToString("0.00");
                    decimal ground_total = subtotal + vat;
                    txtbox_grand_total.Text= ground_total.ToString("0.00");


                }
                else
                {

                    txtbox_subtotal.Text = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                   } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lodedata_com_itemcode();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtbox_invoice_no.Clear();
            txtbox_quantity.Clear();
            txtbox_un_price.Clear();
            combox_customer.Text = "";
            txtbox_product.Text = "";
            combox_item_code.Text = "";
            txtbox_discount.Clear();
            txtbox_grand_total.Clear();
            txtbox_subtotal.Clear();txtbox_vat.Clear();

            
        }

        private void btn_add_invoice_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbox_invoice_no.Text))
            {

                MessageBox.Show("Invoice No can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_invoice_no.Focus();
                this.ActiveControl = txtbox_invoice_no;

            }
            else
            {
                if (string.IsNullOrEmpty(dtp_date.Text))
                {

                    MessageBox.Show("Date can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtp_date.Focus();
                    this.ActiveControl = dtp_date;

                }
                else

                    if (string.IsNullOrEmpty(combox_customer.Text))
                    {

                        MessageBox.Show("Customer can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        combox_customer.Focus();
                        this.ActiveControl = combox_customer;

                    }
                    else

                        if (string.IsNullOrEmpty(txtbox_product.Text))
                        {

                            MessageBox.Show("Product can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox_product.Focus();
                            this.ActiveControl = txtbox_product;

                        }
                        else

                            if (string.IsNullOrEmpty(txtbox_quantity.Text))
                            {

                                MessageBox.Show("Quantity can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtbox_quantity.Focus();
                                this.ActiveControl = txtbox_quantity;

                            }
                            else

                                if (string.IsNullOrEmpty(txtbox_un_price.Text))
                                {

                                    MessageBox.Show("Price can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtbox_un_price.Focus();
                                    this.ActiveControl = txtbox_un_price;

                                }
                                else
                                {


                                    con.Open();
                                    SqlCommand invoice = new SqlCommand("INSERT INTO Invoice ([InvoiceNo],[Date],[Customer],[Item_Code],[Product],[Quantity],[unitPrice],[subtotal],[vat],[discount],[grand_total])  VALUES" +
                                        " ('" + txtbox_invoice_no.Text + "','" + dtp_date.Text + "','" + combox_customer.SelectedValue + "','" + combox_item_code.Text + "','" + txtbox_product.Text + "','" + txtbox_quantity.Text + "','" + txtbox_un_price.Text + "','" + txtbox_subtotal.Text + "','" + txtbox_vat.Text + "','" + txtbox_discount.Text + "','" + txtbox_grand_total.Text + "')", con);

                                    invoice.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("invoice added", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                    dataclear();


                                    lodedata();
                                }
            }



        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
                dataclear();
                
            {
                DataGridViewRow row = dataGridView_invoice.Rows[e.RowIndex];
                txtbox_invoice_no.Text = row.Cells["InvoiceNo"].Value.ToString();
                dtp_date.Text = row.Cells["Date"].Value.ToString();
                combox_customer.Text = row.Cells["Customer"].Value.ToString();
                combox_item_code.Text = row.Cells["Item_Code"].Value.ToString();
                txtbox_product.Text = row.Cells["Product"].Value.ToString();
                txtbox_quantity.Text = row.Cells["Quantity"].Value.ToString();
                txtbox_un_price.Text = row.Cells["unitPrice"].Value.ToString();
                txtbox_subtotal.Text = row.Cells["subtotal"].Value.ToString();
                txtbox_vat.Text = row.Cells["vat"].Value.ToString();
                txtbox_discount.Text = row.Cells["discount"].Value.ToString();
                txtbox_grand_total.Text = row.Cells["grand_total"].Value.ToString();






            }








        } 
        
       

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void combox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_customer.Items.Count > 0)
            {
                combox_customer.SelectedIndex = 0;
            }

        }

        private void txtbox_invoice_no_TextChanged(object sender, EventArgs e)
        {
           
            float qty;
            if (float.TryParse(txtbox_invoice_no.Text, out qty))
                {

            }
            else
            {

                txtbox_invoice_no.Text = "";
            
            }

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_un_price_TextChanged(object sender, EventArgs e)
        {
          /*  if (string.IsNullOrEmpty(txtbox_un_price.Text))
            {

                txtbox_un_price.Text = "";
            }
            else
            
            
            {
                float qty;
                if (float.TryParse(txtbox_un_price.Text, out qty)) { 
                
                
                }
                else {
                    txtbox_un_price.Text = "";
                    
                    
                    
                    }
           
            
            }
            */
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void lodedata()
        {

          
            con.Open();
            SqlCommand viewallinvoice = new SqlCommand("SELECT  * FROM [Invoice]", con);
            viewallinvoice.ExecuteNonQuery();
            SqlDataAdapter invoicedataadapter = new SqlDataAdapter(viewallinvoice);
            DataTable invoicetable = new DataTable();
            invoicedataadapter.Fill(invoicetable);
            dataGridView_invoice.DataSource = invoicetable;
            con.Close();
          
        }

        private void combox_item_code_SelectedIndexChanged(object sender, EventArgs e)
        {

            lodedata_com_itemcode();
            item_detiles_lode();




            /*float qty;
            if (float.TryParse(combox_item_code.Text, out qty))
            {



            }
            else
            {

                combox_item_code.Text = "";
            
            } */

           // lodedata_com_itemcode();



        }

        private void combox_item_code_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          try
            {
                this.stockTableAdapter.FillBy(this.pos_dbDataSet.Stock);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
           /* if (dataGridView_invoice.SelectedRows.Count == 0)
            {
                MessageBox.Show("plese select a row to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dr = MessageBox.Show(
                "are you sure you want to delete this recod?", "confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr==DialogResult.No)
                
                return;
            
            
            
                int invoiceno = Convert.ToInt32(dataGridView_invoice.SelectedRows[0].Cells["InvoiceNo"].Value);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Invoice WHERE InvoiceNo=@invoiceno", con);
                cmd.Parameters.AddWithValue("@invoiceno", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record deleted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lodedata();
                //dataGridView_invoice.Rows.RemoveAt(dataGridView_invoice.SelectedRows[0].Index);

            
            */
            
            
            if (dataGridView_invoice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

           
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            
            int invoiceno = Convert.ToInt32(
                dataGridView_invoice.SelectedRows[0].Cells["InvoiceNo"].Value);

        
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Invoice WHERE InvoiceNo = @invoiceno", con);
            cmd.Parameters.AddWithValue("@invoiceno", invoiceno);
            cmd.ExecuteNonQuery();
            con.Close();

           
            MessageBox.Show("Record deleted successfully",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6️⃣ Reload DataGridView
            lodedata();

            


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void lodedata_com_customer()
        {
          /*  con.Open();
            SqlCommand customer = new SqlCommand("SELECT Customer_id FROM customer ", con);
            SqlDataReader dr = customer.ExecuteReader();
            
            while (dr.Read())3
            {
                combox_customer.Items.Add(dr["Customer_id"].ToString());


            }
            con.Close();
           */

        }
       void lodedata_com_itemcode() 
        {
            try
            {
                con.Open();

                SqlCommand itemcode = new SqlCommand
                    ("SELECT item_code FROM Stock", con);
                SqlDataReader dr = itemcode.ExecuteReader();
                

                while (dr.Read())
                {


                    combox_item_code.Items.Add(dr["item_code"].ToString());

                }
                
                con.Close();
                item_detiles_lode();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void item_detiles_lode()
        {
           string itemcode = combox_item_code.Text;

            
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

                con.Close();
            }
           



        }

        private void txtbox_discount_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void dataclear()
        {
            txtbox_invoice_no.Clear();
            txtbox_quantity.Clear();
            txtbox_un_price.Clear();
            combox_customer.Text = "";
            txtbox_product.Text = "";
            combox_item_code.Text = "";
            txtbox_grand_total.Text = "";
            txtbox_discount.Text = "";
            txtbox_subtotal.Text = "";
            txtbox_vat.Text = "";
        }

        private void txtbox_product_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand invoice_update = new SqlCommand(
                "UPDATE Invoice SET " +
                "[Date]='" + dtp_date.Text + "'," +
                "[Customer]='" + combox_customer.SelectedValue + "'," +
                "[Item_Code]='" + combox_item_code.Text + "'," +
                "[Product]='" + txtbox_product.Text + "'," +
                "[Quantity]='" + txtbox_quantity.Text + "'," +
                "[unitPrice]='" + txtbox_un_price.Text + "'," +
                "[subtotal]='" + txtbox_subtotal.Text + "'," +
                "[vat]='" + txtbox_vat.Text + "'," +
                "[discount]='" + txtbox_discount.Text + "'," +
                "[grand_total]='" + txtbox_grand_total.Text + "' " +
                "WHERE [InvoiceNo]='" + txtbox_invoice_no.Text + "'",
                con
            );

            invoice_update.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Invoice updated successfully",
                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            lodedata();
            dataclear();


        }
    }
    
}
