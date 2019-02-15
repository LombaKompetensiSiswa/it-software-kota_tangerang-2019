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
    public partial class Frmchef : Form
    {
        public Frmchef()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Changepasswordchef()).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ViewOrder()).Show();
            this.Hide();
        }

        private void Frmchef_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult katanya = MessageBox.Show("Yakin Mau Logout?", "Sebelum Anda Terlogout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (katanya == DialogResult.Yes)
            {
                (new frmlogin()).Show();
                this.Hide();
            }
        }
    }
}
