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
    public partial class FrmManageEmployee : Form
    {
        public FrmManageEmployee()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void bersih()
        {
            tbxID.Clear();
            tbxName.Clear();
            tbxEmail.Clear();
            tbxPhone.Clear();
            cbx1.SelectedItem = null;
        }
        private void tampil()
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    dg1.DataSource = db.Msemployees.Select(s => s);
                    dg1.Columns["Password"].Visible = false;
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
            cbx1.Enabled = true;

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
                Msemployee emp1 = db.Msemployees.OrderByDescending(s => s.EmployeeID).FirstOrDefault();
                if (emp1 != null)
                {
                    String a = emp1.EmployeeID.ToString().Substring(2, 4);
                    int b = Convert.ToInt32(a) + 1;
                    tbxID.Text = "EM" + b.ToString("d4");
                }
                else
                {
                    tbxID.Text = "EM0001";
                }
            }
        }
        private void FrmManageEmployee_Load(object sender, EventArgs e)
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
                    if (tbxID.Text == "" || tbxEmail.Text == "" || tbxName.Text == "" || tbxPhone.Text == "" || cbx1.SelectedItem == null)
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
                            var pas = Kebutuhan.RandomPas(8);
                            db.Msemployees.InsertOnSubmit(new Msemployee
                            {
                                EmployeeID = tbxID.Text,
                                Email = tbxEmail.Text,
                                Name = tbxName.Text,
                                Handphone = tbxPhone.Text,
                                Position = cbx1.SelectedItem.ToString(),
                                Password = pas
                            });
                            db.SubmitChanges();
                            MessageBox.Show("Successfully added data \n Password : " + pas, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            awal();
                        }
                        else if (btn1.Text == "Save")
                        {
                            Msemployee emp1 = db.Msemployees.Where(s => s.EmployeeID == tbxID.Text).FirstOrDefault();
                            emp1.Name = tbxName.Text;
                            emp1.Email = tbxEmail.Text;
                            emp1.Handphone = tbxPhone.Text;
                            emp1.Position = cbx1.SelectedItem.ToString();
                            db.SubmitChanges();
                            MessageBox.Show("Successfully saved data " , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cbx1.Enabled = true;
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
                    if (tbxID.Text == "" || tbxEmail.Text == "" || tbxName.Text == "" || tbxPhone.Text == "" || cbx1.SelectedItem == null)
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
                            Msemployee emp1 = db.Msemployees.Where(s => s.EmployeeID == tbxID.Text).FirstOrDefault();
                            db.Msemployees.DeleteOnSubmit(emp1);
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

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow r = dg1.Rows[e.RowIndex];
                    tbxID.Text = r.Cells["EmployeeID"].Value.ToString();
                    tbxEmail.Text = r.Cells["Email"].Value.ToString();
                    tbxName.Text = r.Cells["Name"].Value.ToString();
                    tbxPhone.Text = r.Cells["Handphone"].Value.ToString();
                    cbx1.SelectedItem = r.Cells["Position"].Value.ToString();

                    btn1.Enabled = false;
                    btn2.Enabled = true;
                    btn3.Enabled = true;

                    tbxEmail.Enabled = false;
                    tbxName.Enabled = false;
                    tbxPhone.Enabled = false;
                    cbx1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
