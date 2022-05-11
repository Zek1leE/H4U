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

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Visible = false;
        }

        //Tops Categorias
        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            loadform(new top1());
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
