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

namespace lks2019
{
    public partial class frmlogin : Form
    {

        private void Start()
        {
            Application.Run(new frmsplash());
            

        }
        public frmlogin()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(2000);
            t.Abort();

            InitializeComponent();
             
        }

     

   



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Msemployee emp = db.Msemployees.Where(s => s.Email == textBox1.Text && s.Password == textBox2.Text)
                    .FirstOrDefault();

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Email / Password Tidak Boleh Kosong");
                }
                else if(emp != null)
                {
                    if (emp.Position == "Admin")
                    {
                        (new Frmadmin()).Show();
                        this.Hide();
                    }
                    else if (emp.Position == "Cashier")
                    {
                        (new Frmcashier()).Show();
                        this.Hide();
                    }
                    else if (emp.Position == "Chef")
                    {
                        (new Frmchef()).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Akun Tidak Ada");
                    }
                }
                else
                {
                    MessageBox.Show("Email / Password Salah");
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = this.checkBox1.Checked ? char.MinValue : '*';
        }
    }
}
