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
using System.Text.RegularExpressions;

namespace SMKNUSANTARA
{
    public partial class FrmChangePass : Form
    {
       public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True;MultipleActiveResultSets=True");
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private void chapassbtn_Click(object sender, EventArgs e)
        {
            if(oldpass.Text != "" && newpass.Text != "" && conpass.Text != "")
            {
                auth();
            } else { MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }
        }

        private void auth()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "select password from Msemployee where EmployeeID='" + FrmLogin.LogID + "'";
            SqlDataReader sda = scom.ExecuteReader();
            if (sda.Read())
            {
                string passed = sda["password"].ToString();
                if (oldpass.Text == passed)
                {
                    if (newpass.Text == conpass.Text)
                    {
                        string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])";
                        if (!Regex.IsMatch(newpass.Text, pattern))
                        {
                            MessageBox.Show("Required Uppercase, Lowercase and Number !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } else { chapass(); }
                    } 
                    else { MessageBox.Show("New Password and Confirmation Password didn't match!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                } else { MessageBox.Show("Incorrect Old Password!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            } else { }
        }

        private void chapass()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "update Msemployee set password='" + newpass.Text + "' where EmployeeID='" + FrmLogin.LogID + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("Change Success!!");
            Close();
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
