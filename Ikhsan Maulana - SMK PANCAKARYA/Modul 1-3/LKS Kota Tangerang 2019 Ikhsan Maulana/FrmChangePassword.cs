using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
{
    public partial class FrmChangePassword : Form
    {
        ErrorProvider er = new ErrorProvider();
        Msemployee emp;
        public FrmChangePassword(Msemployee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            tbxNew.PasswordChar = '\u25CF';
            tbxConfirm.PasswordChar = '\u25CF';
            WindowState = FormWindowState.Maximized;
            tbxConfirm.Enabled = false;
            tbxNew.Enabled = false;
            btn1.Enabled = false;
            lbl1.Visible = false;
            lbl1.Text = "\u221A";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Msemployee emp1 = db.Msemployees.Where(s => s.EmployeeID == emp.EmployeeID).FirstOrDefault();
                    if (tbxOld.Text == "" || tbxNew.Text == "" || tbxConfirm.Text == "")
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (emp1 != null)
                        {
                            emp1.Password = tbxConfirm.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Successfully changed password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxConfirm.Clear();
                            tbxNew.Clear();
                            tbxOld.Clear();
                            tbxOld.Enabled = true;
                            tbxConfirm.Enabled = false;
                            tbxNew.Enabled = false;
                            btn1.Enabled = false;
                            er.SetError(tbxOld, null);
                            er.SetError(tbxNew, null);
                            er.SetError(tbxConfirm, null);
                            lbl1.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxOld_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Msemployee emp1 = db.Msemployees.Where(s => s.EmployeeID == emp.EmployeeID).FirstOrDefault();
                    if (emp1.Password == tbxOld.Text)
                    {
                        tbxNew.Enabled = true;
                        lbl1.Visible = true;
                        er.SetError(tbxOld, null);
                        tbxOld.Enabled = false;
                    }
                    else
                    {
                        tbxNew.Enabled = false;
                        if (tbxOld.Text == "")
                        {
                            er.SetError(tbxOld, "Data can't be Empty");
                        }
                        else
                        {
                            er.SetError(tbxOld, "Old Password not same");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Kebutuhan.Reg.IsMatch(tbxNew.Text))
                {
                    tbxConfirm.Enabled = true;
                    er.SetError(tbxNew, null);
                }
                else
                {
                    tbxConfirm.Enabled = false;
                    if (tbxNew.Text == "")
                    {
                        er.SetError(tbxNew, "Data can't be Empty");
                    }
                    else
                    {
                        er.SetError(tbxNew, "Must Uppercase, Lowercase and Number");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxConfirm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxConfirm.Text == tbxNew.Text)
                {
                    btn1.Enabled = true;
                    er.SetError(tbxConfirm, null);
                }
                else
                {
                    btn1.Enabled = false;
                    if (tbxConfirm.Text == "" && tbxConfirm.Text != tbxNew.Text)
                    {
                        er.SetError(tbxConfirm, "Data can't be Empty");
                    }
                    else
                    {
                        er.SetError(tbxConfirm, "New password and Confirm password not same");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cek1_CheckedChanged(object sender, EventArgs e)
        {
            tbxNew.PasswordChar = cek1.Checked ? char.MinValue : '\u25CF';
        }

        private void cek2_CheckedChanged(object sender, EventArgs e)
        {
            tbxConfirm.PasswordChar = cek2.Checked ? char.MinValue : '\u25CF';
        }
    }
}
