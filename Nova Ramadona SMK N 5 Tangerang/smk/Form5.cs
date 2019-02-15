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
    public partial class Form5 : Form
    {
        testDataContext test = new testDataContext();
        public Form5()
        {
            InitializeComponent();
        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            loadData();
            btnsave.Visible = false;
            btncancel.Visible = false;  
        }

        private void loadData()
        {
            testDataContext test = new testDataContext();

            dataGridView1.DataSource = test.Msemployees;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msemployee em = new Msemployee
                {
                    Name = textBox2.Text,
                    Email = textBox3.Text,
                    Handphone = textBox4.Text,
                    Password = textBox5.Text,
                    Position = comboBox1.Text
                };
                test.Msemployees.InsertOnSubmit(em);
                test.SubmitChanges();
               
                loadData();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            btnsave.Visible = true;
            btncancel.Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msemployee m = test.Msemployees.SingleOrDefault(x => x.Employeeid == int.Parse(textBox1.Text));
                m.Name = textBox2.Text;
                m.Email = textBox3.Text;
                m.Handphone = textBox4.Text;
                m.Password = textBox5.Text;
                m.Position = comboBox1.Text;
                test.Msemployees.DeleteOnSubmit(m);
                test.SubmitChanges();
               
            }
            loadData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                Msemployee m = test.Msemployees.SingleOrDefault(x => x.Employeeid == int.Parse(textBox1.Text));
                m.Name = textBox2.Text;
                m.Email = textBox3.Text;
                m.Handphone = textBox4.Text;
                m.Password = textBox5.Text;
                m.Position = comboBox1.Text;
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
            textBox5.Clear();
            comboBox1.SelectedItem = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Employeeid"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Email"].Value.ToString();
                textBox4.Text = row.Cells["Handphone"].Value.ToString();
                textBox5.Text = row.Cells["Password"].Value.ToString();
                comboBox1.Text = row.Cells["Position"].Value.ToString();
                loadData();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
