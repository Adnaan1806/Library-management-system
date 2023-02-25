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

namespace Library_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlCommand cmd;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_MID.Clear();
            txt_no.Clear();
            txt_mname.Clear();
        }

        private void btn_saveinfo_Click(object sender, EventArgs e)
        {
            String ID = txt_MID.Text;
            String name = txt_mname.Text;
            int mobile = Convert.ToInt32(txt_no.Text);
            String email = txt_email.Text;
            

            con = new SqlConnection("Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into NewStudent values(@a,@b,@c,@d)", con);

            cmd.Parameters.AddWithValue("a", ID);
            cmd.Parameters.AddWithValue("b", name);
            cmd.Parameters.AddWithValue("c", mobile);
            cmd.Parameters.AddWithValue("d", email);

            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Member Added Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MID.Clear();
                txt_mname.Clear();
                txt_no.Clear();
                txt_email.Clear();
            }

            else
            {
                MessageBox.Show("Please Fill All Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();


        }
    }
}
