using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks2019
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db;

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            (new frmorder()).Show();
            this.Hide();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            Repotpenjualan emp = new Repotpenjualan();

            emp.Payment_Type = comboBox2.Text;

            emp.Card_number = textBox1.Text;
            emp.Bank_Name = comboBox3.Text;


            db.Repotpenjualans.InsertOnSubmit(emp);
            db.SubmitChanges();
           

            MessageBox.Show("Tagihan Anda : " + label4.Text, "Tagihan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            (new Frmcashier()).Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lks2019DataSet4.Detailorder' table. You can move, or remove it, as needed.
            this.detailorderTableAdapter.Fill(this.lks2019DataSet4.Detailorder);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = db.Pesanans;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

            int qty, price, total;
            qty = Convert.ToInt32(dataGridView1.Columns[2]);
            price = Convert.ToInt32(dataGridView1.Columns[3]);
            total = (price + price) * (qty + qty);
            label4.Text = "Rp. " + total.ToString();

            
            
            

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
