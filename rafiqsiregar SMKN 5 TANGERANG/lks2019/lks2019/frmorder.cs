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
    public partial class frmorder : Form
    {
        public frmorder()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db;

        private void button3_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            Repotpenjualan emp = new Repotpenjualan();

            emp.Payment_Type = comboBox2.Text;

            emp.Card_number = textBox4.Text;
            emp.Bank_Name = comboBox3.Text;


            db.Repotpenjualans.InsertOnSubmit(emp);
            db.SubmitChanges();


            MessageBox.Show("Tagihan Anda : " + label6.Text, "Tagihan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            (new Frmcashier()).Show();
            this.Hide();

            /*(new Payment()).Show();
            this.Hide();
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult katanya = MessageBox.Show("Yakin Batal Beli?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (katanya == DialogResult.Yes)
            {
                (new Frmcashier()).Show();
                this.Hide();

            }
            
        }

    
        private void awal()
        {
            
            textBox3.Enabled = false;
        }

        private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView2.DataSource = db.Pesanans.Select(s => s);
                dataGridView2.Columns["Id"].HeaderText = "Id";
                dataGridView2.Columns["Menu"].HeaderText = "Menu";
                dataGridView2.Columns["Qty"].HeaderText = "Qty";
                dataGridView2.Columns["Price"].HeaderText = "Price";   
            }
        }

        private void tampil2()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = db.Msmenus.Select(s => s);
                dataGridView1.Columns["MenuID"].HeaderText = "Id";
                dataGridView1.Columns["Nama"].HeaderText = "Nama";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Photo"].Visible = false;
                dataGridView1.Columns["poto"].Visible = false;
            }
        }

        private void frmorder_Load(object sender, EventArgs e)
        {
            awal();
            tampil();
            tampil2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Msmenu mn = new Msmenu();
            textBox1.Text = "" + mn.Nama;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

            

        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            /*
            byte[] file_byte = ImageToByteArray(pictureBox1.Image);
            System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
            var st = new Msmenu
            {
                Nama = textBox1.Text,
                poto = file_binary

            };

            */

            int qty, price, total;
            qty = Convert.ToInt32(textBox2.Text);
            price = Convert.ToInt32(textBox3.Text);
            total = price * qty;
            label6.Text = "Rp. " + total.ToString();

            db = new DataClasses1DataContext();
            Pesanan emp = new Pesanan();
            emp.Menu = textBox1.Text;
            emp.Qty = textBox2.Text;
            emp.Price = textBox3.Text;
            
            db.Pesanans.InsertOnSubmit(emp);
            db.SubmitChanges();
            dataGridView2.DataSource = db.Pesanans;
            MessageBox.Show("Dimasukan Keranjang");
        }


        private byte[] ImageToByteArray(Image image)

        {
            
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = opf.FileName;
                MessageBox.Show(path);

                pictureBox1.Image = Image.FromFile(opf.FileName);
                //textBox4.Text = opf.FileName;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            /*
            var st = (from s in db.Msmenus where s.Nama == textBox1.Text select s).FirstOrDefault();

           pictureBox1.Image = ByteArrayToImage(st.poto.ToArray());
           */
           
        }

        private Image ByteArrayToImage(byte[] v)
        {
            throw new NotImplementedException();
        }

        private Image ByteArrayToImage(char[] v)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg; *.jpeg; *.bmp)| *.jpg; *.jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);

                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Msmenu mn = new Msmenu();
            textBox1.Text = "" + mn.Nama;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            var qu = db.Pesanans.Where(s => s.Id == id).FirstOrDefault();
            db.Pesanans.DeleteOnSubmit(qu);
            db.SubmitChanges();
            dataGridView2.DataSource = db.Pesanans;
            MessageBox.Show("Data Berhasil Dihapus.");
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        
            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int qty, price, total;
            qty = Convert.ToInt32(textBox2.Text);
            price = Convert.ToInt32(textBox3.Text);
            total = price * qty;
            label6.Text = "Rp. " + total.ToString();

            db = new DataClasses1DataContext();
            Pesanan emp = new Pesanan();
            emp.Menu = textBox1.Text;
            emp.Qty = textBox2.Text;
            emp.Price = textBox3.Text;

            db.Pesanans.InsertOnSubmit(emp);
            db.SubmitChanges();
            dataGridView2.DataSource = db.Pesanans;
            MessageBox.Show("Tagihan Anda : " + label6.Text, "Tagihan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            (new Frmcashier()).Show();
            this.Hide();
        }
    }
}
