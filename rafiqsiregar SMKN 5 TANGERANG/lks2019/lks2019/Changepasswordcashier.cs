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
    public partial class Changepasswordcashier : Form
    {
        public Changepasswordcashier()
        {
            InitializeComponent();
        }


        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        DataClasses1DataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.Msemployees.Where(s => s.EmployeeID == id).FirstOrDefault();
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Konfirmasi Password Salah!");

            }
            else
            {
                query.Password = textBox3.Text;
                db.SubmitChanges();
                dataGridView1.DataSource = db.Msemployees.Where(s => s.Position == "Cashier");
                MessageBox.Show("Data Berhasil Diupdate.");
                clear();
                MessageBox.Show("Silahkan Login Kembali!", "INFO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (new frmlogin()).Show();
                this.Hide();
            }
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silahkan Login Kembali!", "INFO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            (new frmlogin()).Show();
            this.Hide();
        }

        private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = db.Msemployees.Where(s => s.Position == "Cashier");
                dataGridView1.Columns[3].HeaderText = "password";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Position";
            }
        }

        private void Changepasswordcashier_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
