using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SMKNUSANTARA
{
    public partial class FrmManageMencs : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True");
        private static string imgiN;
        private static string imgOut;
        public FrmManageMencs()
        {
            InitializeComponent();
        }

        private void FrmManageMencs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Msmenu' table. You can move, or remove it, as needed.
            this.msmenuTableAdapter.Fill(this.smknusantaraDataSet.Msmenu);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = ("C://");
            open.Filter = "(*.jpg; *.png;) | *.jpg; *.png";
            open.FilterIndex = 1;
            
            if(open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string name = open.FileName.ToString();
                    imgiN = name;
                    pictureBox1.Image = Image.FromFile(name);
                    textBox4.Text = imgiN;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auth();
        }

        private void insert()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "insert into Msmenu(Name,Price,Photo) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            scom.ExecuteNonQuery();
            MessageBox.Show("Insert Success!!", "Information", MessageBoxButtons.OK);
            this.msmenuTableAdapter.Fill(this.smknusantaraDataSet.Msmenu);
        }
        private void auth()
        {
            if ( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                insert();
                reset();
            }
            else
            {
                MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure want to save?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (res)
                {
                    case DialogResult.Yes:
                        update();
                        reset();
                        break;
                    case DialogResult.No:
                        reset();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         
        private void update()
        {
            SqlCommand scom = new SqlCommand(); 
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "update Msmenu set Name='" + textBox2.Text + "',Price='" + textBox3.Text + "',Photo='" + textBox4.Text + "' where MenuID='" + textBox1.Text + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("Update Success!!", "Information", MessageBoxButtons.OK);
            this.msmenuTableAdapter.Fill(this.smknusantaraDataSet.Msmenu);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row =  e.RowIndex;

            textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();

            pictureBox1.Image = Image.FromFile(textBox4.Text);
            
        }

        private void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Yes:
                    del();
                    break;
                case DialogResult.No:
                    break;
            }
        }
        
        private void del()
        { 
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "delete from Msmenu where MenuID='" + textBox1.Text + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("Delete Success!!", "Information", MessageBoxButtons.OK);
            this.msmenuTableAdapter.Fill(this.smknusantaraDataSet.Msmenu);
        }
    }
}
