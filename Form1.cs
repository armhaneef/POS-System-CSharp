using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace main_project
{
    

    public partial class Form1 : Form
    {
       

        SqlConnection con = new SqlConnection(@"Data Source=Haneef\SQLEXPRESS;
Initial Catalog=Rimsan_db;
Integrated Security=True;
TrustServerCertificate=True;
");


        public Form1()
        {
            InitializeComponent();

            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            
           con.Open();

            string user_velues = "SELECT * FROM User_detiles WHERE Username = @user AND Password = @pass";

            SqlCommand user_name_password = new SqlCommand(user_velues, con);

            user_name_password.Parameters.AddWithValue("@user", txtusername.Text);

            user_name_password.Parameters.AddWithValue("@pass", txtpassword.Text);

            SqlDataReader user_name_password_chack = user_name_password.ExecuteReader();

            if (user_name_password_chack.Read())
            {     
                
                work_staion ws = new work_staion();
                ws.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            con.Close();
            


        }

        private void check_box_password_CheckedChanged(object sender, EventArgs e)
        {
           /* if (check_box_password.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                    
                    }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }*/
        }
    }
}
