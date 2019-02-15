using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest.Classes
{
    class EmployeeClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string handphone { get; set; }
        public string position { get; set; }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstr);

            string sql = "SELECT * FROM msemployee";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(EmployeeClass e)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "INSERT INTO msemployee(name, email, password, handphone, position) VALUES(@name, @email, @password, @handphone, @position)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", e.name);
                cmd.Parameters.AddWithValue("@email", e.email);
                cmd.Parameters.AddWithValue("@password", e.password);
                cmd.Parameters.AddWithValue("@handphone", e.handphone);
                cmd.Parameters.AddWithValue("@position", e.position);

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

        public bool Update(EmployeeClass e)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "UPDATE msemployee SET employeeid = @id, name = @name, email = @email, handphone = @handphone, position = @position WHERE employeeid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", e.id);
                cmd.Parameters.AddWithValue("@name", e.name);
                cmd.Parameters.AddWithValue("@email", e.email);
                cmd.Parameters.AddWithValue("@handphone", e.handphone);
                cmd.Parameters.AddWithValue("@position", e.position);

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

        public bool Delete(EmployeeClass e)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "DELETE FROM msemployee WHERE employeeid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", e.id);

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
