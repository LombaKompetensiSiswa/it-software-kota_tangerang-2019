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
    public partial class FrmPayment : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True");
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            con.Open();
            if(comboBox1.Text == "Credit Card" || comboBox1.Text == "Debit Card")
            {
                label4.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void insert()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "insert into Headeroder(EmployeeID,MemberID,Date,Payment,bank,status) values('" + FrmLogin.LogID + "','" + textBox1.Text + "',Getdate(),'" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','unConfirmed')";
            scom.ExecuteNonQuery();
            MessageBox.Show("Save Success!!", "Information", MessageBoxButtons.OK);
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && OrID.Text != "" && textBox2.Text != "" && comboBox2.Text != "")
            {
                insert();
            }
        }

        private void Mkorder_Click(object sender, EventArgs e)
        {
            FrmOrder order = new FrmOrder();
            order.ShowDialog();
        }

    }
}
