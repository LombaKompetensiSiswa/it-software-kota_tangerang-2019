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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

     



      


        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Msemployees;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Position";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Silahkan Login Kembali!", "INFO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            (new frmlogin()).Show();
            this.Hide();
        }


        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        DataClasses1DataContext db;
        private void button1_Click_1(object sender, EventArgs e)
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
                dataGridView1.DataSource = db.Msemployees;
                MessageBox.Show("Data Berhasil Diupdate.");
                clear();
                MessageBox.Show("Silahkan Login Kembali!", "INFO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (new frmlogin()).Show();
                this.Hide();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          
        }
    }
}
