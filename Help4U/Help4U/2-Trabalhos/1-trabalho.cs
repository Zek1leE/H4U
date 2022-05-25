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
    public partial class trabalho : Form
    {
        public trabalho()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void construçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new construção());
        }

        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new design());
        }

        private void escritaETraduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new escrita_e_tradução());
        }

        private void estiloDeVidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new estilo_de_vida());
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new marketing());
        }

        private void negóciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new negócios());
        }

        private void tecnologiaEProgramaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new tecnologia());
        }
       
        private void trabalhosManuaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new tecnologia());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
