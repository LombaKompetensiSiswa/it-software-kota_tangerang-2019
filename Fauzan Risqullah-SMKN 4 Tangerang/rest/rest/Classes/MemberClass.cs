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
    class MemberClass
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public int memberid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string handphone { get; set; }
        public DateTime joindate { get; set; }

        public DataTable Select()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(myconnstr);
            string sql = "SELECT * FROM msmember";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(MemberClass m)
        {
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {

                string sql = "INSERT INTO msmember(name, email, handphone,joindate) VALUES(@name, @email, @handphone, @joindate)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", m.name);
                cmd.Parameters.AddWithValue("@email", m.email);
                cmd.Parameters.AddWithValue("@handphone", m.handphone);
                cmd.Parameters.AddWithValue("@joindate", m.joindate);

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

        public bool Update(MemberClass m)
        {
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "UPDATE msmember SET name = @name, email = @email, handphone = @handphone, joindate = @joindate WHERE memberid = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", m.name);
                cmd.Parameters.AddWithValue("@email", m.email);
                cmd.Parameters.AddWithValue("@handphone", m.handphone);
                cmd.Parameters.AddWithValue("@joindate", m.joindate);
                cmd.Parameters.AddWithValue("@id", m.memberid);

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

        public bool Delete(MemberClass m)
        {
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "DELETE FROM msmember WHERE memberid = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", m.memberid);

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
