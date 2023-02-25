using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AddBooks a = new AddBooks();
            a.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks rB = new ReturnBooks();
            rB.Show();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInfo vs = new ViewStudentInfo();
            vs.Show();
        }
    }
}
