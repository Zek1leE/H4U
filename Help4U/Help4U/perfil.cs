using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help4U
{
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
           
        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }

      

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
