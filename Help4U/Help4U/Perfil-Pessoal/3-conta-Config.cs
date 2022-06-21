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
    public partial class Conta_Config : Form
    {
        public Conta_Config()
        {
            InitializeComponent();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Close();
        }

        private void Conta_Config_Load(object sender, EventArgs e)
        {
           
        }
    }
}
