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
namespace lks2019
{
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Frmadmin()).Show();
            this.Hide();
        }

        private void awal()
        {
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {
           
            awal();
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Msmenus;
            dataGridView1.Columns[0].HeaderText = "MenuID";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Poto";
            
        }

        private byte[] ImageToByteArray(Image image)
        {
            
            throw new NotImplementedException();
        }

        DataClasses1DataContext db;
        private void button2_Click(object sender, EventArgs e)
        {
           /* byte[] file_byte = ImageToByteArray(pictureBox1.Image);
            System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
            var st = new Msmenu
            {
                poto = file_binary
            };
            db.Msmenus.InsertOnSubmit(st);

            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmenus;
            MessageBox.Show("Poto Sudah Disimpan."); */

            db = new DataClasses1DataContext();
            Msmenu mn = new Msmenu();

            mn.Nama = textBox2.Text;
            mn.Price = textBox3.Text;
            
            
            db.Msmenus.InsertOnSubmit(mn);
            
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmenus;
            MessageBox.Show("Data Berhasil Disimpan.");

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var qu = db.Msmenus.Where(s => s.MenuID == id).FirstOrDefault();
            db.Msmenus.DeleteOnSubmit(qu);
            db.SubmitChanges();
            dataGridView1.DataSource = db.Msmenus;
            MessageBox.Show("Data Berhasil Dihapus.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
          db = new DataClasses1DataContext();
          int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
          var query = db.Msmenus.Where(s => s.MenuID == id).FirstOrDefault();

          query.Nama = textBox2.Text;
          query.Price = textBox3.Text;
          db.SubmitChanges();
          dataGridView1.DataSource = db.Msmenus;
          MessageBox.Show("Data Berhasil Diupdate.");

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = opf.FileName;
                MessageBox.Show(path);
                
                pictureBox1.Image = Image.FromFile(opf.FileName);
                textBox4.Text = opf.FileName;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

      
        }
    }
}
