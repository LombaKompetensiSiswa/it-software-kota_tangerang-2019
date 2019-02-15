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
    public partial class FrmAdminNav : Form
    {
        FrmLogin flog = new FrmLogin();

        public FrmAdminNav()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminNav_Load(object sender, EventArgs e)
        {
            lblName.Text = FrmLogin.username;

            if (FrmLogin.status == "Chef" || FrmLogin.status == "Cashier")//check access
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

        private void btnMngEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee femp = new FrmEmployee();
            femp.Show();
        }

        private void btnMngMenu_Click(object sender, EventArgs e)
        {
            FrmManageMenu fmm = new FrmManageMenu();
            fmm.Show();
        }

        private void btnMngMember_Click(object sender, EventArgs e)
        {
            FrmMember fm = new FrmMember();
            fm.Show();
        }
    }
}
