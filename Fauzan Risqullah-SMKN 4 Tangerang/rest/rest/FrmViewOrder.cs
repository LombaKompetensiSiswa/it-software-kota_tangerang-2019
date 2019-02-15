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
    public partial class FrmViewOrder : Form
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public FrmViewOrder()
        {
            InitializeComponent();
        }

        private void FrmViewOrder_Load(object sender, EventArgs e)
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
            string sql = "SELECT * FROM detailorders WHERE orderid = '" + int.Parse(cmbID.Text) + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv.DataSource = dt;

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Action";
            cmb.Name = "Combo";
            cmb.Items.Add("Memasak");
            cmb.Items.Add("Diantar");
            cmb.Items.Add("Pending");
            cmb.Items.Add("Selesai");

            dgv.Columns.Add(cmb);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE detailorders SET status = '" + dgv.Rows[0].Cells["Combo"].Value.ToString() + "' WHERE detailid = '"+ int.Parse(dgv.Rows[0].Cells[0].Value.ToString()) + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string sql2 = "SELECT * FROM detailorders WHERE orderid = '"+int.Parse(cmbID.Text)+"'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            dgv.Columns.Remove("Combo");
            dgv.DataSource = dt2;
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Action";
            cmb.Name = "Combo";
            cmb.Items.Add("Memasak");
            cmb.Items.Add("Diantar");
            cmb.Items.Add("Pending");
            cmb.Items.Add("Selesai");

            dgv.Columns.Add(cmb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
