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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Msemployee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        public Msemployee emp;

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form9()).Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form10()).Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form8()).Show();
            //this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + emp.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
