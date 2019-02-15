using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKNUSANTARA
{
    public partial class FrmChefNav : Form
    {
        public FrmChefNav()
        {
            InitializeComponent();
        }

        private void change()
        {
            label3.Text = FrmLogin.LogName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmChangePass chapass = new FrmChangePass();
            chapass.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Yes:
                    Form1 form1 = new Form1();
                    FrmLogin login = new FrmLogin();
                    login.Close();
                    Close();
                    form1.Visible = true;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void FrmChefNav_Load(object sender, EventArgs e)
        {
            change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmViewOrder viewOrder = new FrmViewOrder();
            viewOrder.ShowDialog();
        }
    }
}