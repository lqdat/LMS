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

namespace LB
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }
        Conect con = new Conect();
       

        private void Thongke_Load(object sender, EventArgs e)
        {
            load1();
        }
        public void load1()
        {
            dgv.DataSource = con.getdata("Select * from LSHDTT");
        }
        public void s1()
        {
           
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbsearch.Text == "matt")
            {
            // DataTable dt = new DataTable();
            // SqlDataReader dr = con.all("Select * from LSHDTT where CONCAT(tg,matt,tentt,hd,chitiet) like'%" + txtsearch.Text.Trim() + "%' ");
            // dt.Load(dr);
            dgv.DataSource = con.getdata("Select * from LSHDTT where matt like'%" + txtsearch.Text.Trim() + "%'");              
           } 
            else if(cbsearch.Text == "tentt")
                {
                dgv.DataSource = con.getdata("Select * from LSHDTT where tentt like'%" + txtsearch.Text.Trim() + "%'");
                }
                else if (cbsearch.Text == "hd")
                    {
                        dgv.DataSource = con.getdata("Select * from LSHDTT where hd like'%" + txtsearch.Text.Trim() + "%'");
                    }
                     else if (cbsearch.Text == "chitiet")
                        {
                            dgv.DataSource = con.getdata("Select * from LSHDTT where chitiet like'%" + txtsearch.Text.Trim() + "%'");
                        }
                        else if (cbsearch.Text == "tg")
                            {
                                dgv.DataSource = con.getdata("Select * from thuvien.dbo.LSHDTT where tg like'%" + txtsearch.Text.Trim() + "%'");
                            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bm, new Rectangle(0, 0, dgv.Width, dgv.Height));
            e.Graphics.DrawImage(bm, 0, 200);
        }
        private void txtsearch_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }
       
    }
}
