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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        //Abas
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Visible = false;
        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            //Top Ranking
            panel3.Visible = false;
            loadform(new top1());
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            loadform(new trabalho());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            loadform(new procPerfil());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            loadform(new maisTrabalho());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Close();
        }
    }
}
