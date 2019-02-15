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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db;

        private void button1_Click(object sender, EventArgs e)
        {
            (new Frmchef()).Show();
            this.Hide();
        }

        /*private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = db.Headerorders.Select(s => s);
               

            }
        }*/



       private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = db.Pesanans.Select(s => s);
                dataGridView1.Columns["Id"].HeaderText = "Id";
                dataGridView1.Columns["Menu"].HeaderText = "Menu";
                dataGridView1.Columns["Qty"].HeaderText = "Qty";
                dataGridView1.Columns["Price"].HeaderText = "Price";
            }
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            tampil();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["Column1", row].Value = dataGridView1.RowCount - 1;
            dataGridView1["Column2", row].Value = textBox1.Text;
            dataGridView1["Column3", row].Value = comboBox1.Text;
            dataGridView1["Column4", row].Value = textBox2.Text;
            dataGridView1["Column5", row].Value = textBox3.Text;
            dataGridView1.Refresh();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
