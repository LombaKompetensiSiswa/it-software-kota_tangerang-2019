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
    public partial class FrmMain : Form
    {
        Msemployee emp;
        Form frm;
        public FrmMain(Msemployee emp, Form frm)
        {
            this.emp = emp;
            this.frm = frm;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Activate();
                WindowState = FormWindowState.Maximized;
                lblJam.Text = DateTime.Now.ToString();
                timer1.Start();
                lblName.Text = "Welcome, " + emp.Name;
                lblRole.Text = "Position : " + emp.Position;
                lblNav.Text = "Navigation Home";
                if (emp.Position == "Admin")
                {
                    btn1.Text = "Manage Employee";
                    btn2.Text = "Manage Member";
                    btn3.Text = "Manage Menu";
                    this.Text = "Admin Navigation";
                    lblNav.Text = "Admin Navigation";
                }
                else if (emp.Position == "Cashier")
                {
                    btn1.Text = "Order";
                    btn2.Text = "Payment";
                    btn3.Visible = false;
                    this.Text = "Cashier Navigation";
                    lblNav.Text = "Cashier Navigation";
                }
                else if (emp.Position == "Chef")
                {
                    btn1.Text = "View Order";
                    btn2.Visible = false;
                    btn3.Visible = false;
                    this.Text = "Chef Navigation";
                    lblNav.Text = "Chef Navigation";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void nav(Button btn)
        {
            foreach (Button c in panel4.Controls)
            {
                if (((Button)c) == btn)
                {
                    btn.BackColor = Color.FromName("Control");
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = btn.BackColor;
                }
                else
                {
                    c.BackColor = Color.FromArgb(132, 108, 255);
                    c.ForeColor = Color.White;
                    ((Button)c).FlatAppearance.BorderColor = c.BackColor;
                }
            }
        }
        private void Page(Form form)
        {
            panel5.Controls.Clear();
            form.TopLevel = false;
            panel5.Controls.Add(form);
            form.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn1.Text == "Manage Employee")
                {
                    Page(new FrmManageEmployee());
                    nav(btn1);
                    lblJudul.Text = "SMK RESTAURANT - Manage Employee";
                }
                else if (btn1.Text == "Order")
                {
                    Page(new FrmOrder(emp));
                    nav(btn1);
                    lblJudul.Text = "SMK RESTAURANT - Order";
                }
                else if (btn1.Text == "View Order")
                {
                    Page(new FrmViewOrder());
                    nav(btn1);
                    lblJudul.Text = "SMK RESTAURANT - View Order";
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
                if (btn2.Text == "Manage Member")
                {
                    Page(new FrmManageMember());
                    nav(btn2);
                    lblJudul.Text = "SMK RESTAURANT - Manage Member";
                }
                else if (btn2.Text == "Payment")
                {
                    Page(new FrmPayment(this));
                    nav(btn2);
                    lblJudul.Text = "SMK RESTAURANT - Payment";
                }
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
                Page(new FrmManageMenu());
                nav(btn3);
                lblJudul.Text = "SMK RESTAURANT - Manage Menu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                Page(new FrmChangePassword(emp));
                nav(btn5);
                lblJudul.Text = "SMK RESTAURANT - Change Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want Logout ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
