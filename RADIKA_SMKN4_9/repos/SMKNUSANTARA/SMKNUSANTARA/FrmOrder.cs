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
    public partial class FrmOrder : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True");
        private string id;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smknusantaraDataSet1.Transact' table. You can move, or remove it, as needed.
            this.transactTableAdapter.Fill(this.smknusantaraDataSet1.Transact);
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Transact' table. You can move, or remove it, as needed.
            this.transactTableAdapter.Fill(this.smknusantaraDataSet.Transact);
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Msmenu1' table. You can move, or remove it, as needed.
            this.msmenu1TableAdapter.Fill(this.smknusantaraDataSet.Msmenu1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
        
            textBox1.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string img = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

            pictureBox1.Image = Image.FromFile(img);

        

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            id = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            string img = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                add();
            }
            else { MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void add()
        {
            bool add = false;
            int i = 0;
            int total;

            string menu, qty, price;
            menu = textBox1.Text;
            qty = textBox2.Text;
            price = textBox3.Text;
          

            while (add)
            {
                dataGridView1.DataMember.Insert(i, menu);
                dataGridView1.DataMember.Insert(i, qty);
                dataGridView1.DataMember.Insert(i, price);
                
              

                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                i++;
            }
        
    }

        private void del()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
          scom.CommandType = CommandType.Text;
            scom.CommandText = "delete Detailorder where MenuId='" + id + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("Save Success!!", "Information", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                del();
            }
            else { MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
