using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class FrmLogin : Form
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public static string username;
        public static string status;
        public static string id;
        public static string telp;
        SqlConnection conn = new SqlConnection(myconnstr);

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void taro()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "" || txtPass.Text == "")//check if textbox filled or not
            {
                MessageBox.Show("Please insert value", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string sql = "SELECT * FROM msemployee WHERE email = '" + txtEmail.Text + "' AND password = '" + txtPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    conn.Open();
                    int Rows = cmd.ExecuteNonQuery();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)//check if profile is exist
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["position"].ToString() == "Admin")
                            {
                                username = dt.Rows[i]["name"].ToString();
                                status = dt.Rows[i]["position"].ToString();
                                id = dt.Rows[i]["employeeid"].ToString();

                                //form link
                                FrmAdminNav fadmin = new FrmAdminNav();
                                fadmin.Show();

                                this.Hide();
                            }
                            else if (dt.Rows[i]["position"].ToString() == "Chef")
                            {
                                username = dt.Rows[i]["name"].ToString();
                                status = dt.Rows[i]["position"].ToString();
                                id = dt.Rows[i]["employeeid"].ToString();

                                //form link
                                FrmChefNav fchef = new FrmChefNav();
                                fchef.Show();

                                this.Hide();
                            }
                            else if (dt.Rows[i]["position"].ToString() == "Cashier")
                            {
                                username = dt.Rows[i]["name"].ToString();
                                status = dt.Rows[i]["position"].ToString();
                                id = dt.Rows[i]["employeeid"].ToString();

                                //form link
                                FrmCashierNav fcash = new FrmCashierNav();
                                fcash.Show();

                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data not found!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
                
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
