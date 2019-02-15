using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks2019
{
    public partial class Frmadmin : Form
    {
        public Frmadmin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult katanya = MessageBox.Show("Yakin Mau Logout?", "Anda Akan Terlogout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(katanya == DialogResult.Yes)
            {
                (new frmlogin()).Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ManageEmployee()).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ManageMenu()).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new ManageMember()).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new ChangePassword()).Show();
            this.Hide();
        }
    }
}
