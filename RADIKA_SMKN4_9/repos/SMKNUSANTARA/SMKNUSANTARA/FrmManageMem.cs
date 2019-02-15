﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SMKNUSANTARA
{
    public partial class FrmManageMem : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0HM1SS0\SQLSERVER;Initial Catalog=smknusantara;Integrated Security=True");
        public FrmManageMem()
        {
            InitializeComponent();
        }

        private void FrmManageMem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smknusantaraDataSet.Msmember' table. You can move, or remove it, as needed.
            this.msmemberTableAdapter.Fill(this.smknusantaraDataSet.Msmember);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox2.Text.Contains("@"))
                {
                    insert();
                }
                else { MessageBox.Show("Email incorrect!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            } else { MessageBox.Show("Data must be filled!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }
        }
        private void insert()
        {
            SqlCommand scom = new SqlCommand();
            scom.Connection = con;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "insert into Msmember(Name,Email,Handphone,JoinDate) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', Getdate())";
            scom.ExecuteNonQuery();
            MessageBox.Show("Insert Success!!", "Information", MessageBoxButtons.OK);
            this.msmemberTableAdapter.Fill(this.smknusantaraDataSet.Msmember);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text.Contains("@"))
                {
                    DialogResult res = MessageBox.Show("Are you sure want to save?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (res)
                    {
                        case DialogResult.Yes:
                            update();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else { MessageBox.Show("Email incorrect!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            scom.CommandText = "update Msmember set Name='"+textBox2.Text + "', Email='" + textBox3.Text + "', Handphone='" + textBox4.Text + "' where MemberID ='" + textBox1.Text + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("update Success!!", "Information",MessageBoxButtons.OK);
            this.msmemberTableAdapter.Fill(this.smknusantaraDataSet.Msmember);
        }

        private void button3_Click(object sender, EventArgs e)
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
            scom.CommandText = "delete from Msmember where MemberID='" + textBox1.Text + "'";
            scom.ExecuteNonQuery();
            MessageBox.Show("Delete Success!!", "Information", MessageBoxButtons.OK);
            this.msmemberTableAdapter.Fill(this.smknusantaraDataSet.Msmember);
        }
    }
}
