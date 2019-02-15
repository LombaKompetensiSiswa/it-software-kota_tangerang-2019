using rest.Classes;
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
    public partial class FrmOrder : Form
    {
        static int total;
        FrmLogin flog = new FrmLogin();
        MenuClass mn = new MenuClass();

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public FrmOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = mn.Select();
            dgvMenu.DataSource = dt;

            string sql = "INSERT INTO headerorder(employeeid, memberid, date, payment, bank, status) VALUES('" + int.Parse(FrmLogin.id) + "', '" + int.Parse(ConfirmMember.membid) + "', '1/1/1', 'Cash', 'Bank', 'Memesan')";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtMenuID.Text = dgvMenu.Rows[rowIndex].Cells[0].Value.ToString();
            txtMenu.Text = dgvMenu.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvMenu.Rows[rowIndex].Cells[2].Value.ToString();

            string Paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            pb.Image = Image.FromFile(Paths + dgvMenu.Rows[rowIndex].Cells[3].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total = int.Parse(txtQty.Text) * int.Parse(txtPrice.Text);

            try
            {
                string sql2 = "SELECT * FROM headerorder WHERE memberid = '" + ConfirmMember.membid + "' AND status = 'Memesan'";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);

                DataTable dt = new DataTable();

                conn.Open();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql = "INSERT INTO detailorders(orderid, menuid, qty, price, total, status) VALUES('" + dt.Rows[i]["orderid"] + "', '" + int.Parse(txtMenuID.Text) + "', '" + txtQty.Text + "', '" + txtPrice.Text + "', '" + total + "', 'Memasak')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    string sql3 = "SELECT * FROM detailorders WHERE orderid = '" + dt.Rows[i]["orderid"] + "' AND status = 'Memasak'";
                    SqlCommand cmd3 = new SqlCommand(sql3, conn);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd3);

                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    dgvOrder.DataSource = dt2;

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string sql = "DELETE FROM detailorders WHERE detailid = '" + int.Parse(txtMenuID.Text) + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Item removed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Action Failed!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtMenuID.Text = dgvOrder.Rows[rowIndex].Cells[0].ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You gonna be redirected, continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for purchasing", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
