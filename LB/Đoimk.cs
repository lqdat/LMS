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
    public partial class Đoimk : Form
    {
        public Đoimk()
        {
            InitializeComponent();
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu tc = new Trangchu();
            tc.Show();
        }

        private void dmkbtn_Click(object sender, EventArgs e)
        {
            //String qr="Select mk"
        }
    }
}
