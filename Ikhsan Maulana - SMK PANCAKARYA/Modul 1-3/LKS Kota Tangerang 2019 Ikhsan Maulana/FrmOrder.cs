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
    public partial class FrmOrder : Form
    {
        Msemployee emp;
        string kodeid;
        List<Mennn> list = new List<Mennn>();
        Mennn selected;
        string orderid;
        public FrmOrder(Msemployee emp)
        {
            orderid = auto();
            this.emp = emp;
            InitializeComponent();
        }
        private void bersih()
        {
            tbxName.Clear();
            tbxPrice.Clear();
            tbxQty.Clear();
            cbx1.SelectedItem = null;
            pictureBox1.BackgroundImage = null;
            pictureBox1.ImageLocation = null;
            lblTotal.Text = "Total : 0";
            dg2.Rows.Clear();
            dg2.Refresh();
            dg2.DataSource = null;
        }
        private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dg1.DataSource = db.Msmenus.Select(s => s);
                dg1.Columns["MenuID"].Visible = false;
                dg1.Columns["Photo"].Visible = false;
                dg1.Columns["Name"].HeaderText = "Menu";
                cbx1.DataSource = db.Msmembers.Select(s => s.Name);
            }
        }
        private void awal()
        {
            tampil();
            bersih();
            WindowState = FormWindowState.Maximized;
            tbxName.Enabled = false;
            tbxPrice.Enabled = false;
            cbx1.Enabled = true;
        }
        private void FrmOrder_Load(object sender, EventArgs e)
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
                pictureBox1.ImageLocation = null;
                pictureBox1.BackgroundImage = null;
                if (e.RowIndex > -1)
                {
                    DataGridViewRow r = dg1.Rows[e.RowIndex];
                    tbxName.Text = r.Cells["Name"].Value.ToString();
                    tbxPrice.Text = r.Cells["Price"].Value.ToString();
                    kodeid = r.Cells["MenuID"].Value.ToString();
                    pictureBox1.ImageLocation = r.Cells["Photo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void refdg()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dg2.DataSource = bs;
            if (list.Count == 0)
            {
                dg2.DataSource = null;
                lblTotal.Text = "Total : Rp. 0";
            }
            else
            {
                dg2.Columns["kodemenu"].Visible = false;
                dg2.Columns["namamember"].HeaderText = "Nama Member";
                dg2.Columns["namamenu"].HeaderText = "Menu";
            }


            int total = 0;
            foreach (Mennn i in list)
            {
                total += i.Total;
                lblTotal.Text = "Total : Rp. " + total.ToString();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (tbxName.Text == "" || tbxPrice.Text == "" || tbxQty.Text == "" || cbx1.SelectedItem == null)
                    {
                        MessageBox.Show("Data can't be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (tbxQty.Text.Length > 10)
                    {
                        MessageBox.Show("Max Lenght 1-10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Mennn m = list.Where(s => s.kodemenu == kodeid).FirstOrDefault();
                        List<Msmember> l = db.Msmembers.Select(s => s).ToList();
                        if (m != null)
                        {
                            m.Qty += Convert.ToInt32(tbxQty.Text);
                        }
                        else
                        {
                            list.Add(new Mennn
                            {
                                kodemenu = kodeid,
                                namamember = cbx1.SelectedItem.ToString(),
                                namamenu = tbxName.Text,
                                Price = Convert.ToInt32(tbxPrice.Text),
                                Qty = Convert.ToInt32(tbxQty.Text)
                            });
                        }
                        refdg();
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
                if (selected == null)
                {
                    MessageBox.Show("Please Selected data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (selected.Qty > 1)
                    {
                        selected.Qty--;
                    }
                    else
                    {
                        list.Remove(selected);
                    }
                    refdg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string auto()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Headerorder o = db.Headerorders.OrderByDescending(s => s.OrderID).FirstOrDefault();
                if (o != null)
                {
                    String a = o.OrderID.ToString().Substring(6,4);
                    int b = Convert.ToInt32(a) + 1;
                    return DateTime.Now.ToString("yyyyMM") + b.ToString("d4");
                }
                else
                {
                    return DateTime.Now.ToString("yyyyMM") + "0001";
                }
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {

                    List<Msmember> l = db.Msmembers.Select(s => s).ToList();
                    db.Headerorders.InsertOnSubmit(new Headerorder {
                        OrderID = orderid,
                        Employeeid = emp.EmployeeID,
                        Memberid = l[cbx1.SelectedIndex].MemberID,
                        Date = DateTime.Today
                    });
                    db.SubmitChanges();

                    foreach (Mennn i in list)
                    {
                        int detid;
                        Detailorder o1 = db.Detailorders.OrderByDescending(s => s.Detailid).FirstOrDefault();
                        if (o1 != null)
                        {
                            String a = o1.Detailid.ToString();
                            int b = Convert.ToInt32(a) + 1;
                            detid = Convert.ToInt32(b.ToString("d1"));
                        }
                        else
                        {
                            detid = 1;
                        }

                        db.Detailorders.InsertOnSubmit(new Detailorder
                        {
                            Detailid = detid,
                            Orderid = orderid,
                            Menuid = Convert.ToInt32(i.kodemenu),
                            Qty = i.Qty,
                            Price = i.Qty * i.Price,
                            Status = "Preparing"
                        });
                        db.SubmitChanges();
                    }
                    awal();
                    MessageBox.Show("Successfully Order ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    orderid = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    selected = new Mennn();
                    selected = list[e.RowIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbx1_SelectedValueChanged(object sender, EventArgs e)
        {
            cbx1.Enabled = false;
        }

        private void tbxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
    class Mennn
    {
        public string kodemenu { get; set; }
        public string namamenu { get; set; }
        public string namamember { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int Total { get { return (Price * Qty); } }
    }
}
