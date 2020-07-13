using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LB
{
    public partial class Trangchu : Form
    {
        
        public Trangchu()
        {

            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            String sql = "Select * form LSHDTT";
            Conect cn = new Conect();

            Dgv.DataSource = cn.getdata(sql);
           

            
            

        }

        private void tkbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thongke tk = new Thongke();
            tk.Show();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
             this.Hide();
            Thongke tk = new Thongke();
            tk.Show();
        }

        private void doimkbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đoimk doimk = new Đoimk();
            doimk.Show();
        }

        private void lSHDTTBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void dangxuatbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
