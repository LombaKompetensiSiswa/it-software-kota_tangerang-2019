using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class FrmChangePass : Form
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public FrmChangePass()
        {
            InitializeComponent();
        }

        public void test()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg, *.png";
            open.FilterIndex = 1;
            open.ShowDialog();

            string RealFileName = System.IO.Path.GetFileName(open.FileName);

            //

            //

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            System.IO.File.Copy(open.FileName, paths + "\\Images\\" +RealFileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT password FROM msemployee WHERE employeeid = '" + int.Parse(FrmLogin.id) + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                conn.Open();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["password"].ToString() == txtOldPass.Text)
                    {
                        if (txtNewPass.Text == txtConfirmPass.Text)
                        {
                            string filter = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])";

                            if (!Regex.IsMatch(txtNewPass.Text, filter))//check if new pass contain [a-z], [A-Z], [0-9]
                            {
                                MessageBox.Show("Password must contain atleast 1 Uppercase letter and 1 number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Classes.PasswordClass p = new Classes.PasswordClass();

                                p.password = txtNewPass.Text;
                                p.id = int.Parse(FrmLogin.id);

                                bool Success = p.Insert(p);

                                if (Success == true)
                                {
                                    MessageBox.Show("Action Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Error!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("New password did not match!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old pass did not match!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
}
