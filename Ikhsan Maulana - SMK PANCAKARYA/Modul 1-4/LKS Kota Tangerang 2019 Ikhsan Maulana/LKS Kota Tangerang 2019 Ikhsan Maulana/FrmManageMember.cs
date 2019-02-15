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
    public partial class FrmManageMember : Form
    {
        public FrmManageMember()
        {
            InitializeComponent();
        }
        private void bersih()
        {
            tbxID.Clear();
            tbxName.Clear();
            tbxEmail.Clear();
            tbxPhone.Clear();
        }
        private void tampil()
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    dg1.DataSource = db.Msmembers.Select(s => s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void awal()
        {
            tampil();
            bersih();
            autonumber();
            WindowState = FormWindowState.Maximized;

            tbxEmail.Enabled = true;
            tbxName.Enabled = true;
            tbxPhone.Enabled = true;
            tbxID.ReadOnly = true;

            btn1.Text = "Insert";
            btn2.Text = "Update";
            btn3.Text = "Delete";

            btn1.Enabled = true;
            btn2.Enabled = false;
            btn3.Enabled = false;

        }
        private void autonumber()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Msmember emp1 = db.Msmembers.OrderByDescending(s => Convert.ToInt32(s.MemberID)).FirstOrDefault();
                if (emp1 != null)
                {
                    String a = emp1.MemberID.ToString();
                    int b = Convert.ToInt32(a) + 1;
                    tbxID.Text = b.ToString("d1");
                }
                else
                {
                    tbxID.Text = "1";
                }
            }
        }
        private void FrmManageMember_Load(object sender, EventArgs e)
        {
            try
            {
                awal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (tbxID.Text == "" || tbxEmail.Text == "" || tbxName.Text == "" || tbxPhone.Text == "" )
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (!tbxEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Email must each '@'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (!tbxPhone.Text.Substring(0, 2).Equals("08"))
                    {
                        MessageBox.Show("Phone must Start '08'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (tbxPhone.Text.Length < 11 || tbxPhone.Text.Length > 13)
                    {
                        MessageBox.Show("Phone lenght must 11-13", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (btn1.Text == "Insert")
                        {
                            db.Msmembers.InsertOnSubmit(new Msmember
                            {
                                MemberID = tbxID.Text,
                                Email = tbxEmail.Text,
                                Name = tbxName.Text,
                                Handphone = tbxPhone.Text,
                                JoinDate = DateTime.Today
                            });
                            db.SubmitChanges();
                            MessageBox.Show("Successfully added data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            awal();
                        }
                        else if (btn1.Text == "Save")
                        {
                            Msmember emp1 = db.Msmembers.Where(s => s.MemberID == tbxID.Text).FirstOrDefault();
                            emp1.Name = tbxName.Text;
                            emp1.Email = tbxEmail.Text;
                            emp1.Handphone = tbxPhone.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Successfully saved data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            awal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                btn1.Text = "Save";
                btn3.Text = "Cancel";
                btn1.Enabled = true;
                btn2.Enabled = false;
                btn3.Enabled = true;

                tbxEmail.Enabled = true;
                tbxName.Enabled = true;
                tbxPhone.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (tbxID.Text == "" || tbxEmail.Text == "" || tbxName.Text == "" || tbxPhone.Text == "" )
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (!tbxEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Email must each '@'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (!tbxPhone.Text.Substring(0, 2).Equals("08"))
                    {
                        MessageBox.Show("Phone must Start '08'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (tbxPhone.Text.Length < 11 || tbxPhone.Text.Length > 13)
                    {
                        MessageBox.Show("Phone lenght must 11-13", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (btn3.Text == "Delete")
                        {
                            Msmember emp1 = db.Msmembers.Where(s => s.MemberID == tbxID.Text).FirstOrDefault();
                            db.Msmembers.DeleteOnSubmit(emp1);
                            db.SubmitChanges();
                            MessageBox.Show("Successfully deleted data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            awal();
                        }
                        else if (btn3.Text == "Cancel")
                        {
                            awal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }
        

        private void dg1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow r = dg1.Rows[e.RowIndex];
                    tbxID.Text = r.Cells["MemberID"].Value.ToString();
                    tbxEmail.Text = r.Cells["Email"].Value.ToString();
                    tbxName.Text = r.Cells["Name"].Value.ToString();
                    tbxPhone.Text = r.Cells["Handphone"].Value.ToString();

                    btn1.Enabled = false;
                    btn2.Enabled = true;
                    btn3.Enabled = true;

                    tbxEmail.Enabled = false;
                    tbxName.Enabled = false;
                    tbxPhone.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
