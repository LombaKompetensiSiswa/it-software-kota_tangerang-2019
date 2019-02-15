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
    public partial class ConfirmMember : Form
    {
        public static string membid;
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public ConfirmMember()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM msmember WHERE memberid = '" + txtMembID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                membid = txtMembID.Text;

                FrmOrder ford = new FrmOrder();
                ford.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan!");
            }
        }
    }
}
