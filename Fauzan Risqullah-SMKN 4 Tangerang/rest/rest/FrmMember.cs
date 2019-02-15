using rest.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class FrmMember : Form
    {
        MemberClass mb = new MemberClass();

        public FrmMember()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            DataTable dt = mb.Select();
            dgv.DataSource = dt;
        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "" || dtPicker.Value == null)
            {
                MessageBox.Show("Please insert all data!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)//canceling
                {
                    mb.name = txtName.Text;
                    mb.email = txtEmail.Text;
                    mb.handphone = txtPhone.Text;
                    mb.joindate = dtPicker.Value;

                    bool Success = mb.Insert(mb);

                    if (Success == true)
                    {
                        MessageBox.Show("Action Success!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();

                        DataTable dt = mb.Select();
                        dgv.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Action failed!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)//canceling
            {
                mb.memberid = int.Parse(txtID.Text);

                bool Success = mb.Delete(mb);

                if (Success == true)
                {
                    MessageBox.Show("Action Success!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    DataTable dt = mb.Select();
                    dgv.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Action failed!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "" || dtPicker.Value == null)
            {
                MessageBox.Show("Please insert all data!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)//canceling
                {
                    mb.name = txtName.Text;
                    mb.email = txtEmail.Text;
                    mb.handphone = txtPhone.Text;
                    mb.joindate = dtPicker.Value;
                    mb.memberid = int.Parse(txtID.Text);

                    bool Success = mb.Update(mb);

                    if (Success == true)
                    {
                        MessageBox.Show("Action Success!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();

                        DataTable dt = mb.Select();
                        dgv.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Action failed!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }
    }
}
