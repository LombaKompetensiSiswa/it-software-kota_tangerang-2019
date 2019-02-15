using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SMKNUSANTARA
{
    public partial class FrmViewOrder : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True");
        public FrmViewOrder()
        {
            InitializeComponent();
        }

        private void FrmViewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Headerorder' table. You can move, or remove it, as needed.
            this.headerorderTableAdapter.Fill(this.smknusantaraDataSet.Headerorder);
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.smknusantaraDataSet.Order);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string ac = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "update Msmenu set status='" + ac + "'";
            scom.ExecuteNonQuery();
        }
    }
}
