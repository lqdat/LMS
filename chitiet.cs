using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB
{
    public partial class chitiet : Form
    {
        string id;
        Conect cn = new Conect();
        public chitiet(string id)
        {
            InitializeComponent();
            this.id = id;
            
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            //cn.excute("");
        }

        private void chitiet_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            DataTable dt = cn.getdata("select * from thuthu where matt ='"+ id +"'");
            txtmatt.Text = dt.Rows[0][0].ToString();
            txtanh.Text = dt.Rows[0][1].ToString();
            txtten.Text = dt.Rows[0][2].ToString();
            
            txtns.Text = dt.Rows[0][6].ToString();
            
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
