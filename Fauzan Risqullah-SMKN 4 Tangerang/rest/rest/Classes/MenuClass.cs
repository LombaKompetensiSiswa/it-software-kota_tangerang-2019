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
    class MenuClass
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public int menuid { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string photo { get; set; }

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstr);

            string sql = "SELECT * FROM msmenu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(MenuClass m)
        {
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "INSERT INTO msmenu(name, price, photo) VALUES(@name, @price, @photo)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", m.name);
                cmd.Parameters.AddWithValue("@price", m.price);
                cmd.Parameters.AddWithValue("@photo", m.photo);

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

        public bool Update(MenuClass m)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "UPDATE msmenu SET name = @name, price = @price, photo = @photo WHERE menuid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", m.menuid);
                cmd.Parameters.AddWithValue("@name", m.name);
                cmd.Parameters.AddWithValue("@price", m.price);
                cmd.Parameters.AddWithValue("@photo", m.photo);

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

        public bool Delete(MenuClass m)
        {
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "DELETE FROM msmenu WHERE menuid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", m.menuid);

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
