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
    public partial class definicoes_perfilPessoal : Form
    {
        public definicoes_perfilPessoal()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.info.Controls.Count > 0)
                this.info.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.info.Controls.Add(f);
            this.info.Tag = f;
            f.Show();
        }
        private void guna2Button16_Click(object sender, EventArgs e)
        {
            loadform(new Perfil_Config());
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            loadform(new Conta_Config());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            loadform(new perfil_Senha());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Close();
        }
    }
}
