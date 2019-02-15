using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest.Classes
{
    class PasswordClass
    {
        public string password { get; set; }
        public int id { get; set; }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public bool Insert(PasswordClass p)
        {
            SqlConnection conn = new SqlConnection(myconnstr);

            bool isSuccess = false;

            try
            {
                string sql = "UPDATE msemployee SET password = @password WHERE employeeid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@password", p.password);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();
                int Rows = cmd.ExecuteNonQuery();

                if (Rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
