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
    public partial class FrmAmountCash : Form
    {
        List<IsiMen> list = new List<IsiMen>();
        Form frm;
        public FrmAmountCash(Form frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmAmmountCash_Load(object sender, EventArgs e)
        {
            lblOrderid.Text = "Order ID : " + Kebutuhan.orderid;
            lblTotal.Text = "Your Payment : Rp. " + Kebutuhan.totall;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(Kebutuhan.totall);
                int b = Convert.ToInt32(tbx1.Text);
                int c = b - a;
                if (tbx1.Text == "")
                {
                    MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (a > b)
                {
                    MessageBox.Show("Your money is not enough", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbx1.Text.Length > 10)
                {
                    MessageBox.Show("Max Lenght 1-10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (DataClasses1DataContext db = new DataClasses1DataContext())
                    {
                        //foreach (var i in a)
                        //{
                        //    a.Menu = i.Cells["Menu"].Value.ToString();
                        //    a.Price = i.Cells["Price"].Value.ToString();
                        //    a.Qty = i.Cells["Qty"].Value.ToString();
                        //    a.Total = i.Cells["Total"].Value.ToString();
                        //}

                        var g = from q in db.Detailorders
                                join w in db.Msmenus
                                on q.Menuid equals w.MenuID
                                where q.Orderid == Kebutuhan.orderid
                                select new
                                {
                                    w.Name,
                                    q.Qty,
                                    w.Price,
                                    Total = w.Price * q.Qty
                                };
                        //db.Detailorders.Where(s => s.Orderid == Kebutuhan.orderid);
                        Headerorder o = db.Headerorders.Where(s => s.OrderID == Kebutuhan.orderid).FirstOrDefault();
                        o.Payment = "Cash";
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
                            foreach (var i in g)
                            {
                                co.Add(i.Name);
                                co.Add("Rp. " + i.Price + " x " + i.Qty + "                             Rp. " + i.Total);

                            }
                            co.Add("--------------------------------");
                            co.Add("Sub Total :                               Rp. " + Kebutuhan.totall);
                            co.Add("--------------------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("");
                            co.Add("--------------------------------");
                            co.Add("Total : Rp. " + Kebutuhan.totall);
                            co.Add("Payment Type : Cash");
                            co.Add("Your Money : " + tbx1.Text);
                            co.Add("Return Money : " + c);
                            co.Add("--------------------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("-----------------------Terima Kasih-----------------------");
                            co.Add("");
                            co.Add("");
                            co.Add("--------------------------------SMK RESTAURANT--------------------------------");

                            File.WriteAllLines(Application.StartupPath + "\\print.txt", co);
                            Process.Start("notepad.exe", Application.StartupPath + "\\print.txt");
                        }

                        FrmPayment.frm.Enabled = true;
                        this.Close();
                        frm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin" + ex, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmPayment.frm.Enabled = true;
            this.Close();
        }
    }
    class IsiMen
    {
        public string Menu { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }
    }
}
