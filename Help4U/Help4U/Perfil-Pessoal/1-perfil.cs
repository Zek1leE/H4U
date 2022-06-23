using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Help4U
{
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = false;
            guna2Button2.Visible = true;
            guna2Button3.Visible = true;

            guna2TextBox1.Enabled = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;

            guna2TextBox1.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            definicoes_perfilPessoal f1 = new definicoes_perfilPessoal();
            f1.Show();
            this.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;

            guna2TextBox1.Enabled = false;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

    }
}
