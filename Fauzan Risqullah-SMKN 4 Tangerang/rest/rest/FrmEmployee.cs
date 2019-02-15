using rest.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();

            DataTable dt = emp.Select();
            dgv.DataSource = dt;
            dgv.Columns["password"].Visible = false;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtHandphone.Text = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            cmbPosition.Text = dgv.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtHandphone.Text = "";
            cmbPosition.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//btnAdd
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPass.Text == "" || txtHandphone.Text == "" || cmbPosition.Text == "")
            {
                MessageBox.Show("Data should not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EmployeeClass emp = new EmployeeClass();

                emp.name = txtName.Text;
                emp.email = txtEmail.Text;
                emp.password = txtPass.Text;
                emp.handphone = txtHandphone.Text;
                emp.position = cmbPosition.Text;

                bool Success = emp.Insert(emp);

                if (Success == true)
                {
                    MessageBox.Show("Action Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    DataTable dt = emp.Select();
                    dgv.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Action failed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)//canceling
            {
                if (txtName.Text == "" || txtEmail.Text == "" || txtHandphone.Text == "" || cmbPosition.Text == "")
                {
                    MessageBox.Show("Data should not be empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EmployeeClass emp = new EmployeeClass();

                    emp.id = int.Parse(txtID.Text);
                    emp.name = txtName.Text;
                    emp.email = txtEmail.Text;
                    emp.handphone = txtHandphone.Text;
                    emp.position = cmbPosition.Text;

                    bool Success = emp.Update(emp);

                    if (Success == true)
                    {
                        MessageBox.Show("Action Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();
                        DataTable dt = emp.Select();
                        dgv.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Action failed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)//canceling
            {
                EmployeeClass emp = new EmployeeClass();

                emp.id = int.Parse(txtID.Text);

                bool Success = emp.Delete(emp);

                if (Success == true)
                {
                    MessageBox.Show("Action Success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    DataTable dt = emp.Select();
                    dgv.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Action failed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
