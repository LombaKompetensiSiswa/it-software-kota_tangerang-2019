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
    public partial class ManageMember : Form
    {
        public ManageMember()
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
        private void ManageMember_Load(object sender, EventArgs e)
        {
            awal();
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Msmembers;
            dataGridView1.Columns[0].HeaderText = "MemberID";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "JoinDate";
        }

        DataClasses1DataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            Msmember mm = new Msmember();

            mm.Name = textBox2.Text;
            mm.Email = textBox3.Text;
            mm.JoinDate = DateTime.Now;

            db.Msmembers.InsertOnSubmit(mm);
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmembers;
            MessageBox.Show("Data Berhasil Disimpan.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.Msmembers.Where(s => s.MemberID == id).FirstOrDefault();

            query.Name = textBox2.Text;
            query.Email = textBox3.Text;
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmembers;
            MessageBox.Show("Data Berhasil Diupdate.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var qu = db.Msmembers.Where(s => s.MemberID == id).FirstOrDefault();
            db.Msmembers.DeleteOnSubmit(qu);
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmembers;
            MessageBox.Show("Data Berhasil Dihapus.");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
