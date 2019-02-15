using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smk
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msmember mb = new Msmember
                {
                    Name = textBox2.Text,
                    Email = textBox3.Text,
                    Handphone = textBox4.Text,
                    Joindate = dateTimePicker1.Value
                };
                test.Msmembers.InsertOnSubmit(mb);
                test.SubmitChanges();
                loadData();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            loadData();
            btncancel.Visible = false;
            btnsave.Visible = false;
        }

        private void loadData()
        {
            testDataContext test = new testDataContext();
            dataGridView1.DataSource = test.Msmembers;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            btnsave.Visible = true;
            btncancel.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msmember mb = test.Msmembers.SingleOrDefault(x => x.Memberid == int.Parse(textBox1.Text));
                mb.Name = textBox2.Text;
                mb.Email = textBox3.Text;
                mb.Handphone = textBox4.Text;
                mb.Joindate = dateTimePicker1.Value;
                test.SubmitChanges();
            }
            loadData();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Memberid"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Email"].Value.ToString();
                textBox4.Text = row.Cells["Handphone"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Joindate"].Value.ToString());
                loadData();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msmember mb = test.Msmembers.SingleOrDefault(x => x.Memberid == int.Parse(textBox1.Text));
                mb.Name = textBox2.Text;
                mb.Email = textBox3.Text;
                mb.Handphone = textBox4.Text;
                test.Msmembers.DeleteOnSubmit(mb);
                test.SubmitChanges();
            }
            loadData();
        }
    }
}
