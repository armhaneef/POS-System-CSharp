using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace main_project
{
    public partial class stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANEEF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True;TrustServerCertificate=True");
        public stock()
        {
            InitializeComponent();
            LoadData();
            lodedata_stock_co();
            lodestocksummury();
        }



        private void stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_dbDataSet15.BusinessDetiles' table. You can move, or remove it, as needed.
            this.businessDetilesTableAdapter.Fill(this.pos_dbDataSet15.BusinessDetiles);
            // TODO: This line of code loads data into the 'pos_dbDataSet6.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.pos_dbDataSet6.Stock);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbox_SellingPrice.Text))

            {
                txtbox_SellingPrice.Text = "";

            }
            else
            {
                float qty;
                if (float.TryParse(txtbox_SellingPrice.Text, out qty))

                {


                }
                else
                {
                    txtbox_SellingPrice.Text = "";

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbox_Purchasing_Order_Number.Text))

            {
                txtbox_Purchasing_Order_Number.Text = "";

            }
            else
            {
                float qty;
                if (float.TryParse(txtbox_Purchasing_Order_Number.Text, out qty))

                {


                }
                else
                {
                    txtbox_Purchasing_Order_Number.Text = "";

                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbox_Purchasing_Value.Text))

            {
                txtbox_Purchasing_Value.Text = "";

            }
            else
            {
                float qty;
                if (float.TryParse(txtbox_Purchasing_Value.Text, out qty))

                {


                }
                else
                {
                    txtbox_Purchasing_Value.Text = "";

                }

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbox_purchasing_Price.Text))

            {
                txtbox_purchasing_Price.Text = "";

            }
            else
            {
                float qty;
                if (float.TryParse(txtbox_purchasing_Price.Text, out qty))

                {


                }
                else
                {
                    txtbox_purchasing_Price.Text = "";

                }

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_Purchasing_Quantity.Text))
            {

                txtbox_Purchasing_Quantity.Text = "";

            }
            else {

                float qty;
                if (float.TryParse(txtbox_Purchasing_Quantity.Text, out qty))
                {

                }
                else
                {

                    txtbox_Purchasing_Quantity.Text = ""; }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_Item_Code.Text))

            {
                txtbox_Item_Code.Text = "";

            }
            else
            {
                float qty;
                if (float.TryParse(txtbox_Item_Code.Text, out qty))

                {


                }
                else
                {
                    txtbox_Item_Code.Text = "";

                }

            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_Description.Clear();
            txtbox_Item_Code.Clear();
            txtbox_Purchasing_Order_Number.Clear();
            txtbox_purchasing_Price.Clear();
            txtbox_Purchasing_Quantity.Clear();
            txtbox_Purchasing_Value.Clear();
            txtbox_SellingPrice.Clear();


        }

        private void combox_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbox_Item_Code.Text))
                {
                    MessageBox.Show("item code can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_Item_Code.Focus();
                    this.ActiveControl = txtbox_Item_Code;


                }
                else
                {
                    if (string.IsNullOrEmpty(txtbox_Description.Text))
                    {
                        MessageBox.Show("Description can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbox_Description.Focus();
                        this.ActiveControl = txtbox_Description;

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtbox_Purchasing_Quantity.Text))
                        {
                            MessageBox.Show("Purchasing Quantity can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox_Purchasing_Quantity.Focus();
                            this.ActiveControl = txtbox_Purchasing_Quantity;


                        }
                        else
                        {

                            if (string.IsNullOrEmpty(txtbox_purchasing_Price.Text))
                            {
                                MessageBox.Show("purchasing Price can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtbox_purchasing_Price.Focus();
                                this.ActiveControl = txtbox_purchasing_Price;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtbox_Purchasing_Value.Text))
                                {
                                    MessageBox.Show("Purchasing Value can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtbox_Purchasing_Value.Focus();
                                    this.ActiveControl = txtbox_Purchasing_Value;
                                }
                                else
                                    if (string.IsNullOrEmpty(txtbox_SellingPrice.Text))
                                    {
                                        MessageBox.Show("MRP can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtbox_SellingPrice.Focus();
                                        this.ActiveControl = txtbox_SellingPrice;



                                    }
                                    else
                                        if (string.IsNullOrEmpty(txtbox_Purchasing_Order_Number.Text))
                                        {
                                            MessageBox.Show("Purchasing Order Number can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtbox_Purchasing_Order_Number.Focus();
                                            this.ActiveControl = txtbox_Purchasing_Order_Number;



                                        }
                                        else
                                            if (string.IsNullOrEmpty(combox_Supplier.Text))
                                            {
                                                MessageBox.Show("Supplier can't be null", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                combox_Supplier.Focus();
                                                this.ActiveControl = combox_Supplier;
                                            }
                                            else
                                            {
                                                con.Open();

                                                SqlCommand stock_detiles = new SqlCommand("INSERT INTO Stock ([item_code],[Description],[Supplier],[Purch_quantity],[Purch_price],[Purch_valu],[MRP]) VALUES  (" +
                                                    "'" + txtbox_Item_Code.Text + "'," +
                                                    "'" + txtbox_Description.Text + "'," +
                                                    "'" + combox_Supplier.Text + "'," +
                                                    "'" + Convert.ToDouble(txtbox_Purchasing_Quantity.Text) + "'," +
                                                    "'" + Convert.ToDouble(txtbox_purchasing_Price.Text) + "'," +
                                                    "'" + Convert.ToDouble(txtbox_Purchasing_Value.Text) + "'," +
                                                    "'" + Convert.ToDouble(txtbox_SellingPrice.Text) + "',)", con);


                                                stock_detiles.ExecuteNonQuery();
                                                con.Close();
                                                MessageBox.Show("Item added", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                                LoadData();
                                                lodedata_stock_co();
                                                lodestocksummury();
                                            }






                            }
                        }

                    }
                }

            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            }

        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)

        {

        }


        private void data_gr_vi_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                clear();

            {
                DataGridViewRow row = data_gr_vi_stock.Rows[e.RowIndex];
                
                txtbox_Description.Text = row.Cells["Description"].Value.ToString();
                txtbox_Item_Code.Text = row.Cells["item_code"].Value.ToString();
                txtbox_purchasing_Price.Text = row.Cells["Purch_price"].Value.ToString();
                txtbox_Purchasing_Quantity.Text = row.Cells["Purch_quantity"].Value.ToString();
                txtbox_Purchasing_Value.Text = row.Cells["Purch_valu"].Value.ToString();
                txtbox_SellingPrice.Text = row.Cells["MRP"].Value.ToString();
                combox_Supplier.Text = row.Cells["Supplier"].Value.ToString();


            }


        }


        void LoadData()
        {

            con.Open();
            SqlCommand viewallitems = new SqlCommand("SELECT  * FROM [Stock]", con);
            viewallitems.ExecuteNonQuery();
            SqlDataAdapter itemdataadapter = new SqlDataAdapter(viewallitems);
            DataTable stocktable = new DataTable();
            itemdataadapter.Fill(stocktable);
            data_gr_vi_stock.DataSource = stocktable;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void lodedata_stock_co()
        {
            /*( try
             {
                 con.Open();
                 int va = 0;
                 foreach (DataGridViewRow row in data_gr_vi_stock.Rows)
                 {

                     va += Convert.ToInt32(row.Cells["Purch_valu"].Value);


                 }
                lbl_purch_valu.Text = va.ToString("00.00");
                 con.Close();
             }
             catch(Exception ex ) {
                 MessageBox.Show(ex.Message);

             }*/



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void lodestocksummury()
        {
            try
            {
                string quary = @"
                     SELECT 
                      SUM(CAST(Purch_quantity AS INT)) AS Totalqty,
                      SUM(CAST(Purch_quantity AS INT) * CAST(Purch_price AS DECIMAL(18,2))) AS TotalpurchasingValue
                      FROM Stock";


                SqlCommand sum = new SqlCommand(quary, con);
                con.Open();
                SqlDataReader sumread = sum.ExecuteReader();
                if (sumread.Read())
                {



                    int qty = sumread["Totalqty"] != DBNull.Value ? Convert.ToInt32(sumread["Totalqty"]) : 0;
                    decimal purchvalue = sumread["TotalpurchasingValue"] != DBNull.Value ? Convert.ToDecimal(sumread["TotalpurchasingValue"]) : 0;
                    lbl_purch_valu.Text = "Rs " + purchvalue.ToString("N2");
                    lbl_stoc_item_count.Text = qty.ToString();


                }
                con.Close();


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clear()
        {
            txtbox_Item_Code.Text = "";
            txtbox_Description.Text = "";
            txtbox_Purchasing_Order_Number.Text = "";
            txtbox_purchasing_Price.Text = "";
            txtbox_Purchasing_Quantity.Text = "";
            txtbox_Purchasing_Value.Text = "";
            txtbox_SellingPrice.Text = "";
            combox_Supplier.Text = "";




        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_gr_vi_stock.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delet this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            int itemcode = Convert.ToInt32(data_gr_vi_stock.SelectedRows[0].Cells["item_code"].Value);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Stock WHERE item_code=@id", con);
                cmd.Parameters.AddWithValue("@id", itemcode);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully",
                 "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                lodedata_stock_co();
                lodestocksummury();
                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            
            
            }

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand stock_update = new SqlCommand(
                "UPDATE Stock SET " +
                "Description='" + txtbox_Description.Text + "'," +
                "Supplier='" + combox_Supplier.Text + "'," +
                "Purch_quantity='" + Convert.ToDouble(txtbox_Purchasing_Quantity.Text) + "'," +
                "Purch_price='" + Convert.ToDouble(txtbox_purchasing_Price.Text) + "'," +
                "Purch_valu='" + Convert.ToDouble(txtbox_Purchasing_Value.Text) + "'," +
                "MRP='" + Convert.ToDouble(txtbox_SellingPrice.Text) + "' " +
                "WHERE item_code='" + txtbox_Item_Code.Text + "'",
                con
            );

            stock_update.ExecuteNonQuery();

            con.Close();
            LoadData();
           

            MessageBox.Show("Item updated successfully", "success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
