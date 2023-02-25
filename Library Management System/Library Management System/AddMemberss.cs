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
    public partial class AddMemberss : Form
    {
        public AddMemberss()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void txt_refreshh_Click(object sender, EventArgs e)
        {
            txt_mEmail.Clear();
            txt_MID.Clear();
            txt_mname.Clear();
            txt_mno.Clear();
        }

        private void txt_exitm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_saveM_Click(object sender, EventArgs e)
        {
            String ID = txt_MID.Text;
            String name = txt_mname.Text;
            int mobile = Convert.ToInt32(txt_mno.Text);
            String email = txt_mEmail.Text;


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
                txt_mno.Clear();
                txt_mEmail.Clear();
            }

            else
            {
                MessageBox.Show("Please Fill All Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }
    }
}
