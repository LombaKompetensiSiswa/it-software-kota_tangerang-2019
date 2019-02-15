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
    public partial class FrmManageMenu : Form
    {
        public FrmManageMenu()
        {
            InitializeComponent();
        }
        private void bersih()
        {
            tbxID.Clear();
            tbxName.Clear();
            tbxPrice.Clear();
            tbxPhoto.Clear();
            pictureBox1.BackgroundImage = null;
            pictureBox1.ImageLocation = null;
        }
        private void tampil()
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    dg1.DataSource = db.Msmenus.Select(s => s);
                    dg1.Columns["Photo"].Visible = false;
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

            tbxPrice.Enabled = true;
            tbxName.Enabled = true;
            tbxPhoto.ReadOnly = true;
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
                Msmenu emp1 = db.Msmenus.OrderByDescending(s => Convert.ToInt32(s.MenuID)).FirstOrDefault();
                if (emp1 != null)
                {
                    String a = emp1.MenuID.ToString();
                    int b = Convert.ToInt32(a) + 1;
                    tbxID.Text = b.ToString("d1");
                }
                else
                {
                    tbxID.Text = "1";
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (tbxID.Text == "" || tbxPrice.Text == "" || tbxName.Text == "" || tbxPhoto.Text == "")
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (tbxPrice.Text.Length < 1 || tbxPrice.Text.Length > 10)
                    {
                        MessageBox.Show("Phone lenght must 1-10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (btn1.Text == "Insert")
                        {
                            db.Msmenus.InsertOnSubmit(new Msmenu
                            {
                                MenuID = Convert.ToInt32(tbxID.Text),
                                Price = Convert.ToInt32(tbxPrice.Text),
                                Name = tbxName.Text,
                                Photo = tbxPhoto.Text
                            });
                            db.SubmitChanges();
                            MessageBox.Show("Successfully added data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            awal();
                        }
                        else if (btn1.Text == "Save")
                        {
                            Msmenu emp1 = db.Msmenus.Where(s => s.MenuID == Convert.ToInt32(tbxID.Text)).FirstOrDefault();
                            emp1.Name = tbxName.Text;
                            emp1.Price = Convert.ToInt32(tbxPrice.Text);
                            emp1.Photo = tbxPhoto.Text;
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

                tbxPrice.Enabled = true;
                tbxName.Enabled = true;
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
                    if (tbxID.Text == "" || tbxPrice.Text == "" || tbxName.Text == "" || tbxPhoto.Text == "")
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (tbxPrice.Text.Length < 1 || tbxPrice.Text.Length > 10)
                    {
                        MessageBox.Show("Phone lenght must 1-10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (btn3.Text == "Delete")
                        {
                            Msmenu emp1 = db.Msmenus.Where(s => s.MenuID == Convert.ToInt32(tbxID.Text)).FirstOrDefault();
                            db.Msmenus.DeleteOnSubmit(emp1);
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
                MessageBox.Show("Can't delete, because the menu used on Detailorder", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmManageMenu_Load(object sender, EventArgs e)
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

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.ImageLocation = null;
                if (e.RowIndex > -1)
                {
                    DataGridViewRow r = dg1.Rows[e.RowIndex];
                    tbxID.Text = r.Cells["MenuID"].Value.ToString();
                    tbxPrice.Text = r.Cells["Price"].Value.ToString();
                    tbxName.Text = r.Cells["Name"].Value.ToString();
                    tbxPhoto.Text = r.Cells["Photo"].Value.ToString();
                    pictureBox1.ImageLocation = r.Cells["Photo"].Value.ToString();
                    btn1.Enabled = false;
                    btn2.Enabled = true;
                    btn3.Enabled = true;

                    tbxPrice.Enabled = false;
                    tbxName.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.ImageLocation = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                    tbxPhoto.Text = openFileDialog1.FileName;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
