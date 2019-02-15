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
    public partial class FrmManageMenu : Form
    {
        static string RealFileName;
        static string PathImg;

        MenuClass mc = new MenuClass();

        public FrmManageMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg, *.png";
            open.FilterIndex = 1;
            open.ShowDialog();

            RealFileName = System.IO.Path.GetFileName(open.FileName);

            txtPhoto.Text = RealFileName;
            pb.Image = Image.FromFile(open.FileName);

            string Paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            System.IO.File.Copy(open.FileName, Paths + "\\Images\\" + RealFileName);
            PathImg = "\\Images\\" + RealFileName;
        }

        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhoto.Text = "";
            txtPrice.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtPhoto.Text == "")
            {
                MessageBox.Show("Error, a photo must be selected!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtName.Text == "" || txtPrice.Text == "")//check null
                {
                    MessageBox.Show("Error, name and price must be inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mc.name = txtName.Text;
                    mc.price = int.Parse(txtPrice.Text);
                    mc.photo = PathImg;

                    bool Success = mc.Insert(mc);

                    if (Success == true)
                    {
                        MessageBox.Show("Action Success!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();

                        DataTable dt = mc.Select();
                        dgv.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Action failed!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FrmManageMenu_Load(object sender, EventArgs e)
        {
            DataTable dt = mc.Select();
            dgv.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)//canceling
            {
                mc.menuid = int.Parse(txtID.Text);

                bool Success = mc.Delete(mc);

                if (Success == true)
                {
                    MessageBox.Show("Action Success!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    DataTable dt = mc.Select();
                    dgv.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Action failed!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtPhoto.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString();

            string Paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            pb.Image = Image.FromFile(Paths + dgv.Rows[rowIndex].Cells[3].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)//canceling
            {
                if (txtPhoto.Text == "")
                {
                    MessageBox.Show("Error, a photo must be selected!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtName.Text == "" || txtPrice.Text == "")
                    {
                        MessageBox.Show("Error, name and price must be inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mc.name = txtName.Text;
                        mc.price = int.Parse(txtPrice.Text);
                        mc.photo = PathImg;
                        mc.menuid = int.Parse(txtID.Text);

                        bool Success = mc.Update(mc);

                        if (Success == true)
                        {
                            MessageBox.Show("Action Success!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Clear();

                            DataTable dt = mc.Select();
                            dgv.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Action failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
