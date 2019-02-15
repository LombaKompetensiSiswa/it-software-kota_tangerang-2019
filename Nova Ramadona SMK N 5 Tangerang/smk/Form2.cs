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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Msemployee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        public Msemployee emp;

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + emp.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form5()).Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form6()).Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form7()).Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form8()).Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
