using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(2500);
            t.Abort();
            InitializeComponent();
        }
        ErrorProvider er = new ErrorProvider();
        private void Start()
        {
            Application.Run(new FrmSplash());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = Convert.ToChar("\u25CF");
            this.Activate();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Msemployee emp = db.Msemployees.Where(s => s.Email == tbxEmail.Text && s.Password == tbxPassword.Text).FirstOrDefault();
                    if (tbxEmail.Text == "" || tbxPassword.Text == "")
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!tbxEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Email must each '@'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (emp != null)
                        {
                            (new FrmMain(emp,this)).Show();
                            this.Hide();
                        }
                        else
                        {
                            if (tbxEmail.Text == "" || tbxPassword.Text == "")
                            {
                                MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want Exit this Application ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxEmail.Text == "")
                {

                    er.SetError(tbxEmail, "Email can't be Empty");
                }
                else
                {

                    er.SetError(tbxEmail, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxPassword.Text == "")
                {
                    er.SetError(tbxPassword, "Password can't be Empty");
                }
                else
                {

                    er.SetError(tbxPassword, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cek_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = cek.Checked ? char.MinValue : '\u25CF';
        }
    }
}
