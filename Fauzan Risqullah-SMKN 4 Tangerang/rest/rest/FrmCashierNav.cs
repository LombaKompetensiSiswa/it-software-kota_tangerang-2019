using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class FrmCashierNav : Form
    {
        FrmLogin flog = new FrmLogin();

        public FrmCashierNav()
        {
            InitializeComponent();
        }

        private void FrmCashierNav_Load(object sender, EventArgs e)
        {
            lblName.Text = FrmLogin.username;

            if (FrmLogin.status == "Admin" || FrmLogin.status == "Chef")//check access
            {
                MessageBox.Show("Access Denied!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flog.Show();

                this.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                flog.Show();

                this.Hide();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePass fcp = new FrmChangePass();
            fcp.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ConfirmMember conf = new ConfirmMember();
            conf.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrmPayment fpay = new FrmPayment();
            fpay.Show();
        }
    }
}
