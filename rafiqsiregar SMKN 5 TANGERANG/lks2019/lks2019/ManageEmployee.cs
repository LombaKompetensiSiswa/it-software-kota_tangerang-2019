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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Frmadmin()).Show();
            this.Hide();
        }

        private void awal()
        {
            textBox1.Enabled = false;

        }

        DataClasses1DataContext db;
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            awal();
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Msemployees;
        }

       
       

        private void button1_Click(object sender, EventArgs e)
        { 
            db = new DataClasses1DataContext();
            Msemployee emp = new Msemployee();

            emp.Name = textBox2.Text;
            emp.Email = textBox3.Text;
            emp.Password = textBox4.Text;
            emp.Handphone = textBox5.Text;
            emp.Position = comboBox1.Text;

            db.Msemployees.InsertOnSubmit(emp);
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msemployees;
            MessageBox.Show("Data Berhasil Ditambah.");
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int old = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.Msemployees.Where(s => s.EmployeeID == old).FirstOrDefault();
            query.Name = textBox2.Text;
            query.Email = textBox3.Text;
            query.Handphone = textBox4.Text;
            query.Position = comboBox1.Text;
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msemployees;
            MessageBox.Show("Data Berhasil Diupdate.");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int old = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.Msemployees.Where(s => s.EmployeeID == old).FirstOrDefault();
            db.Msemployees.DeleteOnSubmit(query);
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msemployees;
            MessageBox.Show("Data Berhasil Dihapus.");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
