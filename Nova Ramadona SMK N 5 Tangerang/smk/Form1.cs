using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace smk
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
            
        }

        /*public void Flut()
        {
            (new Form13()).Show();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            using (testDataContext test = new testDataContext())
            {
                Msemployee emp = test.Msemployees.Where(e => e.Email == textBox1.Text && e.Password == textBox2.Text)
                    .FirstOrDefault();

                if (emp != null)
                {
                    if (emp.Position == "admin")
                    {
                        (new Form2(emp)).Show();
                    }
                    else if (emp.Position == "chef")
                    {
                        (new Form3(emp)).Show();
                    }
                    else if (emp.Position == "cashier")
                    {
                        (new Form4(emp)).Show();
                    }
                    else
                    {
                        MessageBox.Show("Error! Position Not Found!");
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
