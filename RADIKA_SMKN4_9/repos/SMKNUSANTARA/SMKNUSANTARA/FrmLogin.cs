using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMKNUSANTARA
{
    public partial class FrmLogin : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True;MultipleActiveResultSets=True");
        public static string LogID;
        public static string LogName;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mailtxt.Text != "" && passtxt.Text != "")
            {
                SqlCommand sda = new SqlCommand();
                SqlCommand sda2 = new SqlCommand();
                SqlCommand sda3 = new SqlCommand();

                sda.Connection = con;
                sda2.Connection = con;
                sda3.Connection = con;

                sda.CommandType = CommandType.Text;
                sda2.CommandType = CommandType.Text;
                sda3.CommandType = CommandType.Text;

                string admin = "select * from Msemployee where Email='" + mailtxt.Text + "' and password='" + passtxt.Text + "' and Position='Admin'";
                string chef = "select * from Msemployee where Email='" + mailtxt.Text + "' and password='" + passtxt.Text + "' and Position='Chef'";
                string cashier = "select * from Msemployee where Email='" + mailtxt.Text + "' and password='" + passtxt.Text + "' and Position='Cashier'";

                sda.CommandText = admin;
                sda2.CommandText = chef;
                sda3.CommandText = cashier;

                SqlDataReader scom = sda.ExecuteReader();
                SqlDataReader scom2 = sda2.ExecuteReader();
                SqlDataReader scom3 = sda3.ExecuteReader();

                if (scom.Read())
                {
                    LogID = scom["EmployeeID"].ToString();
                    LogName = scom["Name"].ToString();
                    MessageBox.Show("Login Success!!");
                    FrmAdminNav adminNav = new FrmAdminNav();
                    adminNav.Show();
                    Visible = false;

                }
                else if (scom2.Read())
                {
                    LogID = scom2["EmployeeID"].ToString();
                    LogName = scom2["Name"].ToString();
                    MessageBox.Show("Login Success!!");
                    FrmChefNav chefNav = new FrmChefNav();
                    chefNav.Show();
                    Visible = false;
                }
                else if (scom3.Read())
                {
                    LogID = scom3["EmployeeID"].ToString();
                    LogName = scom3["Name"].ToString();
                    MessageBox.Show("Login Success!!");
                    FrmCashierNav cashierNav = new FrmCashierNav();
                    cashierNav.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Password didn't match!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else { MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
