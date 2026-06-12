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
using System.Data.SqlClient;

namespace main_project
{
    public partial class Customer : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public Customer()
        {
            InitializeComponent();
            loaddata_customer();
            lodedata();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand customer = new SqlCommand("INSERT INTO customer ([Customer_id],[Customer_name],[phone],[email],[address],[customer_type])  VALUES ('" +Convert.ToInt32( txtbox_customer_id.Text) + "','" + txtbox_customer_name.Text + "','" + txtbox_phone.Text+ "','" + txtbox_email.Text + "','" + txtbox_address.Text+ "','" + combox_type.Text + "')", con);

                customer.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("customer added","added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata_customer();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex.Message);



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_gr_vi_cus.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Please select a row to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                    return;

                int customerid = Convert.ToInt32(data_gr_vi_cus.SelectedRows[0].Cells["Customer_id"].Value);
                
                con.Open();
                SqlCommand cdm = new SqlCommand("DELETE FROM customer WHERE Customer_id=@id", con);

                cdm.Parameters.AddWithValue("@id", customerid);
                cdm.ExecuteNonQuery();
                con.Close();
                loaddata_customer();
                MessageBox.Show("customer Deleted!", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata_clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex.Message);



            }





        }
        void loaddata_clear()
        {
            txtbox_address.Text = "";
            txtbox_customer_id.Text = "";
            txtbox_customer_name.Text = "";
            txtbox_email.Text = "";
            txtbox_phone.Text = "";



        }
        void loaddata_customer()
        {
           con.Open();

            SqlCommand customer_vi = new SqlCommand("SELECT * FROM  [customer]", con);
            customer_vi.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(customer_vi);
            DataTable dr = new DataTable();
            da.Fill(dr);
            
            
            data_gr_vi_cus.DataSource = dr;
           
            con.Close();

           

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            loaddata_clear();
        }

        private void data_gr_vi_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    loaddata_clear();
                {
                    DataGridViewRow row = data_gr_vi_cus.Rows[e.RowIndex];
                    txtbox_address.Text = row.Cells["address"].Value.ToString();
                    txtbox_customer_id.Text = row.Cells["Customer_id"].Value.ToString();
                    txtbox_customer_name.Text = row.Cells["Customer_name"].Value.ToString();
                    txtbox_email.Text = row.Cells["email"].Value.ToString();
                    txtbox_phone.Text = row.Cells["phone"].Value.ToString();
                    combox_type.Text = row.Cells["customer_type"].Value.ToString();








                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void combox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*combox_type.Items.Clear();
            combox_type.Items.Add("cash");
            combox_type.Items.Add("card");
            combox_type.SelectedIndex = 0;
            */

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
        //partial void combox_type_lode(object sender, EventArgs e) {



        // }
        private void lodedata()
        {
            con.Open();
            SqlCommand viewallcustomer = new SqlCommand("SELECT  * FROM [customer]", con);
                   viewallcustomer.ExecuteNonQuery();
            SqlDataAdapter invoicedataadapter = new SqlDataAdapter(viewallcustomer);
            DataTable customertable = new DataTable();
            invoicedataadapter.Fill(customertable);
            data_gr_vi_cus.DataSource = customertable;
            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)

        {
            con.Open();

            SqlCommand customer_update = new SqlCommand(
                "UPDATE customer SET " +
                "Customer_name='" + txtbox_customer_name.Text + "'," +
                "phone='" + txtbox_phone.Text + "'," +
                "email='" + txtbox_email.Text + "'," +
                "address='" + txtbox_address.Text + "'," +
                "customer_type='" + combox_type.Text + "' " +
                "WHERE Customer_id='" + Convert.ToInt32(txtbox_customer_id.Text) + "'",
                con
            );

            customer_update.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Customer updated successfully",
                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loaddata_customer();


        }
    }


    
}
