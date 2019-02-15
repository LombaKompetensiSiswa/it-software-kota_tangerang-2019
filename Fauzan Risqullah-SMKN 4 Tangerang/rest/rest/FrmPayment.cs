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
    public partial class FrmPayment : Form
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public FrmPayment()
        {
            InitializeComponent();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM headerorder WHERE status = 'Memesan'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbID.Items.Add(dt.Rows[i]["orderid"].ToString());
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT name, qty, detailorders.price, total FROM detailorders INNER JOIN msmenu ON detailorders.menuid = msmenu.menuid WHERE orderid = '" + int.Parse(cmbID.Text) + "' AND status = 'Selesai'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE headerorder SET date = '" + dtPicker.Value + "', payment = '" + cmbPayment.Text + "', bank = '" + cmbBank.Text + "', status = 'Paid'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }
    }
}
