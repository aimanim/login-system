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

namespace project
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JI74OFL;Initial Catalog=registration;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("Please enter username and password");
                }
                else
                {
                    /*SqlCommand cmd = new SqlCommand("select * from LoginUsers where U_Name=@Name and U_Pass=@Pass", con);
                    cmd.Parameters.Add("@Name", txtUser.Text);
                    cmd.Parameters.Add("@Pass", txtPass.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;*/

                    if (txtUser.Text == "admin" && txtPass.Text == "admin")
                    {
                        MessageBox.Show("You have successfully logged in");
                        Form1 ob = new Form1();
                        this.Hide();
                        ob.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct username and password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
