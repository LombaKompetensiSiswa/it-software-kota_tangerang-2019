using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
{
    public partial class FrmViewOrder : Form
    {
        public FrmViewOrder()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                cbx1.DataSource = from a in db.Detailorders
                                  where a.Status != "Delivered"
                                  group a by a.Orderid into
                                  b
                                  select b.Key;
            }
        }
        private void awal()
        {
            WindowState = FormWindowState.Maximized;
            tampil();
            dg1.Rows.Clear();
            dg1.Refresh();
            cbx1.Text = "";
            dg1.DataSource = null;
            dg1.ColumnHeadersVisible = false;
            dg1.RowHeadersVisible = false;
        }
        private void FrmViewOrder_Load(object sender, EventArgs e)
        {
            try
            {
                awal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbx1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (cbx1.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select orderid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dg1.DataSource = from a in db.Detailorders
                                         join b in db.Msmenus
                                         on a.Menuid equals b.MenuID
                                         where a.Orderid == cbx1.Text && a.Status != "Delivered"
                                         select new
                                         {
                                             a.Detailid,
                                             b.MenuID,
                                             Menu = b.Name,
                                             a.Qty,
                                             a.Status
                                         };
                        dg1.Columns["MenuId"].Visible = false;
                        dg1.Columns["Detailid"].Visible = false;
                        dg1.Columns["Status"].Visible = false;
                        dg1.Columns["Action"].DisplayIndex = 4;
                        foreach (DataGridViewRow i in dg1.Rows)
                        {
                            i.Cells["Action"].Value = i.Cells["Status"].Value.ToString();
                        }

                        dg1.ColumnHeadersVisible = true;
                        dg1.RowHeadersVisible = true;
                        isR = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool isR;
        private void dg1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    if (isR)
                    {
                        DataGridViewRow r = dg1.Rows[e.RowIndex];
                        Detailorder o = db.Detailorders.Where(s => s.Detailid == Convert.ToInt32(r.Cells["Detailid"].Value.ToString())).FirstOrDefault();
                        o.Status = r.Cells["Action"].Value.ToString();
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
