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
    public partial class FrmRatingReview : Form
    {
        public FrmRatingReview()
        {
            InitializeComponent();
        }

        private void FrmRatingReview_Load(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var qq = from a in db.Msmenus
                             join b in db.Detailorders
                             on a.MenuID equals b.Menuid
                             join c in db.Reviews
                             on b.Orderid equals c.Orderid
                             where c.Menuid == Kebutuhan.menid && a.MenuID == Kebutuhan.menid
                             select new
                             {
                                 c.Reviewid,
                                 c.Orderid,
                                 c.Date,
                                 c.Note,
                                 c.Photo,
                                 c.Rating
                             };
                    foreach (var ww in qq)
                    {
                        Label l1 = new Label()
                        {
                            //Size = new Size(100, 100),
                            Text = ww.Orderid
                        };
                        Label l2 = new Label()
                        {
                            //Size = new Size(100, 100),
                            Text = ww.Date.ToString()
                        };
                        Label l3 = new Label()
                        {
                            Size = new Size(300, 15),
                            Text = ww.Note
                        };
                        Label l4 = new Label()
                        {
                            Text = "\u2605" + "\u2605" + "\u2605" + "\u2605" + "\u2605",
                            ForeColor = Color.Gold,
                            Size = new Size(100, 10)
                        };
                        PictureBox l5 = new PictureBox()
                        {
                            //ImageLocation = ww.Photo,
                            Size = new Size(150,150),
                            BackgroundImage = Image.FromFile(ww.Photo),
                            BackgroundImageLayout = ImageLayout.Zoom
                        };
                        TableLayoutPanel t = new TableLayoutPanel()
                        {
                            Size = new Size(300,250),
                            ColumnCount =1,
                            RowCount = 5
                        };
                        t.Controls.Add(l1);
                        t.Controls.Add(l2);
                        t.Controls.Add(l3);
                        t.Controls.Add(l4);
                        t.Controls.Add(l5);

                        flowLayoutPanel1.Controls.Add(t);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again, Please contact Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
