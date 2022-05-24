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
    public partial class Perfil_Config : Form
    {
        public Perfil_Config()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           panel1.Visible = false;
           panel3.Visible = true;
           panel4.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
            panel4.Visible = true;

            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();

            comboBox1.Text = "";
            comboBox2.Text = "";

            maskedTextBox1.Clear();
            
        }
    }
}
