using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project

{
   
    public partial class business_details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public business_details()
        {
            InitializeComponent();
            lodedata_datagridwive();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_inovice_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxP_businees_detiles.Text))
            {

                MessageBox.Show("business name can,t be null","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxP_businees_detiles.Focus();
                this.ActiveControl = txtboxP_businees_detiles;


            }
            else {
                if (string.IsNullOrEmpty(txtbox_owner_name.Text))
                {


                    MessageBox.Show("owner number can't be null","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_owner_name.Focus();
                    this.ActiveControl = txtbox_owner_name;





                }
                else {
                    if (string.IsNullOrEmpty(txtbox_phone.Text)) {
                        MessageBox.Show("phone can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbox_phone.Focus();
                        this.ActiveControl = txtbox_phone;

                   
                    }
                    else
                    { if (string.IsNullOrEmpty(txtbox_email.Text))
                        {
                            MessageBox.Show("email can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox_email.Focus();
                            this.ActiveControl = txtbox_email;
                        }
                        else {
                            if (string.IsNullOrEmpty(txtbox_address.Text))
                            {
                                MessageBox.Show("address can't null ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtbox_address.Focus();
                                this.ActiveControl = txtbox_address;

                            }
                            else
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand bu_detiles = new SqlCommand("INSERT INTO BusinessDetiles ([Business_Name],[Owner_Name],[Phone],[Email],[Address]) VALUES ('" + txtboxP_businees_detiles.Text + "','" + txtbox_owner_name.Text + "','" + txtbox_phone.Text + "','" + txtbox_email.Text + "','" + txtbox_address.Text + "') ", con);
                                    bu_detiles.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("business details added", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clear();

                                    lodedata_datagridwive();
                                }
                                catch (Exception ex ) {
                                    MessageBox.Show(ex.Message);
                                
                                
                                }
                            
                            
                            
                            
                            
                            
                            
                            
                            
                            }
                                
                                    
                                    
                                    
                                    
                                    
                                    
                                    }




                    }
                
                
                
                
                }
            
            
            
            
            
            }
        }

        private void business_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_dbDataSet12.BusinessDetiles' table. You can move, or remove it, as needed.
            this.businessDetilesTableAdapter.Fill(this.pos_dbDataSet12.BusinessDetiles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

                clear(); 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string BN = row.Cells["Business_Name"].Value.ToString();
                txtboxP_businees_detiles.Text = BN;
                string add = row.Cells["Address"].Value.ToString();
                txtbox_address.Text = add;
                string email = row.Cells["Email"].Value.ToString();
                txtbox_email.Text = email;
                string on = row.Cells["Owner_Name"].Value.ToString();
                txtbox_owner_name.Text = on;

                string phone = row.Cells["Phone"].Value.ToString();
                txtbox_phone.Text = phone;
                
            }
        }
        private void lodedata_datagridwive()
        {
            con.Open();
            SqlCommand viwebd = new SqlCommand("SELECT * FROM [BusinessDetiles]", con);
            viwebd.ExecuteNonQuery();
            SqlDataAdapter bddata = new SqlDataAdapter(viwebd);
            DataTable bdtable = new DataTable();
            bddata.Fill(bdtable);
            dataGridView1.DataSource = bdtable;
            con.Close();



            
        }
        private void clear()
        {
            txtboxP_businees_detiles.Text = "";
            txtbox_address.Text = "";
            txtbox_email.Text = "";
            txtbox_owner_name.Text = "";
            txtbox_phone.Text = "";



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            
            }
            DialogResult dr = MessageBox.Show("are you sure want to delete this record", "confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (dr == DialogResult.No)
                    return;

                int bu_de = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Business_Name"].Value);

                con.Open();
                SqlCommand detiles = new SqlCommand("DELETE FROM BusinessDetiles WHERE Business_Name=@bn");
                detiles.Parameters.AddWithValue("@bn", bu_de);
                detiles.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand bu_update = new SqlCommand(
                    "UPDATE BusinessDetiles SET " +
                    "[Owner_Name]='" + txtbox_owner_name.Text + "'," +
                    "[Phone]='" + txtbox_phone.Text + "'," +
                    "[Email]='" + txtbox_email.Text + "'," +
                    "[Address]='" + txtbox_address.Text + "' " +
                    "WHERE [Business_Name]='" + txtboxP_businees_detiles.Text + "'",
                    con
                );

                bu_update.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Business details updated successfully",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();
                lodedata_datagridwive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
