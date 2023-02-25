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

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BTN_signup_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Clear();
            }
        }

        private void txt_Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "")
            {
                MessageBox.Show("Enter the Username");
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-ONE9JG64;Initial Catalog=LoginForm;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from lg where username = @uname and password = @pass",con);

                    cmd.Parameters.AddWithValue("@uname",txt_Username.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_Password.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Dashboard d = new Dashboard();
                        d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            {

            }
        }
    }
}
