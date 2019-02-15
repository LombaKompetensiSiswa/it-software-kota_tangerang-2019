using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
{
    public partial class FrmPayment : Form
    {
        public static Form frm;
        int total1;
        public FrmPayment(Form frm)
        {
            FrmPayment.frm = frm;
            InitializeComponent();
        }
        private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                cbx1.DataSource = from a in db.Headerorders
                                  where a.Payment == null
                                  group a by a.OrderID into
                                  b
                                  select b.Key;

            }
        }
        private void bersih()
        {
            lblTotal.Text = "Total : Rp. 0";
            tbxCardNumber.Clear();
            cbx2.SelectedItem = null;
            cbx3.SelectedItem = null;
        }
        private void awal()
        {
            WindowState = FormWindowState.Maximized;
            tampil();
            total1 = 0;
        }
        private void FrmPayment_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (cbx1.SelectedItem == null || cbx2.SelectedItem == null || cbx3.SelectedItem == null || tbxCardNumber.Text == "")
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (tbxCardNumber.Text.Length > 10)
                    {
                        MessageBox.Show("Max Lenght 1-10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Headerorder o = db.Headerorders.Where(s => s.OrderID == cbx1.SelectedItem.ToString()).FirstOrDefault();
                        o.Payment = cbx2.SelectedItem.ToString();
                        o.bank = cbx3.SelectedItem.ToString();
                        o.CardNumber = tbxCardNumber.Text;
                        db.SubmitChanges();
                        if (MessageBox.Show("Successfully Pay Order \n Want print Struck ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            List<string> co = new List<string>();
                            co.Add("--------------------------------SMK RESTAURANT--------------------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("Order ID : " + Kebutuhan.orderid);
                            co.Add("");
                            co.Add("");
                            co.Add("--------------------------------");
                            foreach (DataGridViewRow i in dg1.Rows)
                            {
                                co.Add(i.Cells["Menu"].Value.ToString());
                                co.Add("Rp. " +i.Cells["Price"].Value.ToString() + " x " + i.Cells["Qty"].Value.ToString() + "                             Rp. "+i.Cells["Total"].Value.ToString());
                            }
                            co.Add("--------------------------------");
                            co.Add("Sub Total :                               Rp. " + total1);
                            co.Add("--------------------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("");
                            co.Add("--------------------------------");
                            co.Add("Total : Rp. " + total1);
                            co.Add("Payment Type : " + cbx2.SelectedItem.ToString());
                            co.Add("Card Number : "+ tbxCardNumber.Text);
                            co.Add("Bank Name : "+ cbx3.SelectedItem.ToString());
                            co.Add("--------------------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("-----------------------Terima Kasih-----------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("--------------------------------SMK RESTAURANT--------------------------------");

                            File.WriteAllLines(Application.StartupPath + "\\print.txt", co);
                            Process.Start("notepad.exe",Application.StartupPath + "\\print.txt");
                        }
                        awal();
                        bersih();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbx1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    dg1.DataSource = from a in db.Detailorders
                                     join b in db.Msmenus
                                     on a.Menuid equals b.MenuID
                                     join c in db.Headerorders
                                     on a.Orderid equals c.OrderID
                                     where a.Orderid == cbx1.Text && c.Payment == null 
                                     select new
                                     {
                                         Menu = b.Name,
                                         a.Qty,
                                         b.Price,
                                         Total = b.Price * a.Qty
                                     };
                    total1 = 0;
                    foreach (DataGridViewRow i in dg1.Rows)
                    {
                        total1 += Convert.ToInt32(i.Cells["Total"].Value.ToString());
                    }
                    lblTotal.Text = "Total : Rp. " + total1;
                    Kebutuhan.orderid = cbx1.SelectedItem.ToString();
                    Kebutuhan.totall = total1.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbx2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx1.SelectedItem == null)
                {
                    MessageBox.Show("Orderid can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cbx2.Text == "Cash")
                    {
                        (new FrmAmountCash(this)).Show();
                        FrmPayment.frm.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
