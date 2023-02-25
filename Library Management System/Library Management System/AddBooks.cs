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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_name.Text != "" && txt_Aname.Text != "" && txt_quantity.Text != "" && txt_price.Text != "")
            {
                String bId, bName, bAuthor, bPub;
                DateTime bPd;
                double bQty, bprice;

                bId = txt_id.Text;
                bName =txt_name.Text;
                bAuthor =txt_Aname.Text;
                bPub = txt_publication.Text;
                bPd =dateTimePicker1.Value;
                bQty = Convert.ToDouble(txt_quantity.Text);
                bprice = Convert.ToDouble(txt_price.Text);

                con.Open();

                cmd = new SqlCommand("insert into Book values(@a,@b,@c,@d,@e,@f,@g)", con);

                cmd.Parameters.AddWithValue("a", bId);
                cmd.Parameters.AddWithValue("b", bName);
                cmd.Parameters.AddWithValue("c", bAuthor);
                cmd.Parameters.AddWithValue("d", bPub);
                cmd.Parameters.AddWithValue("e", bPd);
                cmd.Parameters.AddWithValue("f", bQty);
                cmd.Parameters.AddWithValue("g", bprice);

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Book Added Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id.Clear();
                    txt_name.Clear();
                    txt_Aname.Clear();
                    txt_publication.Clear();
                    txt_quantity.Clear();
                    txt_price.Clear();
                }

            }
            else
            {
                MessageBox.Show("Please Fill All Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();

        }

        private void Add_Book_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Data Will Be Deleted! ", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
    }


