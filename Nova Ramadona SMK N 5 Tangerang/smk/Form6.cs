using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace smk
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Menuid"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Price"].Value.ToString();
                textBox4.Text = row.Cells["Photo"].Value.ToString();
                loadData();
            }
        }
        testDataContext test = new testDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string fname = textBox1.Text + ".JPG";
                string folder = @"C:\Users\ADMIN\source\repos\smk\smk\Images";
                string pathstring = System.IO.Path.Combine(fname, folder);

                var st = new Msmenu
                {
                    Name = textBox2.Text,
                    Price = textBox3.Text,
                    Photo = pathstring
                };
                test.Msmenus.InsertOnSubmit(st);
                test.SubmitChanges();
                loadData();
            }
            else
            {
                MessageBox.Show("Choose Photo!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loadData();
            button5.Visible = false;
            button6.Visible = false;
        }

        private void loadData()
        {
            testDataContext test = new testDataContext();
            var s = from o in test.Msmenus select o;
            dataGridView1.DataSource = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {
                if (pictureBox1.Image != null)
                {
                    string fname = textBox1.Text + ".jpg";
                    string folder = @"C:\Users\ADMIN\source\repos\smk\smk\Image";
                    string pathstring = System.IO.Path.Combine(fname, folder);

                    Msmenu mb = test.Msmenus.SingleOrDefault(x => x.Menuid == int.Parse(textBox1.Text));
                    mb.Name = textBox2.Text;
                    mb.Price = textBox3.Text;
                    mb.Photo = textBox4.Text;
                    test.Msmenus.DeleteOnSubmit(mb);
                    test.SubmitChanges();
                }
                loadData();
            }
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            open.Filter = "Image File (*.JPG; *.PNG; *.JPEG; *BMP;)|*.jpg; *.png; *.jpeg *bmp;";
            {
                if (open.ShowDialog() == DialogResult.Yes)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    textBox4.Text = open.FileName;
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (testDataContext test = new testDataContext())
            {

                Msmenu mb = test.Msmenus.SingleOrDefault(x => x.Menuid == int.Parse(textBox1.Text));
                mb.Name = textBox2.Text;
                mb.Price = textBox3.Text;
                mb.Photo = textBox4.Text;
                test.SubmitChanges();
            }
            loadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           /* testDataContext test = new testDataContext();
            var s = from o in test.Msmenus select o;
            dataGridView1.DataSource = s; */
        }
    }
}
