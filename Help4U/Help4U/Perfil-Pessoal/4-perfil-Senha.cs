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
    public partial class perfil_Senha : Form
    {
        public perfil_Senha()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox2.Text.Length != guna2TextBox3.Text.Length)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            

            //Salvar na BD 

            guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Close();   
        }

        private void perfil_Senha_Load(object sender, EventArgs e)
        {
            guna2TextBox1.PasswordChar = '●';
            guna2TextBox2.PasswordChar = '●';
            guna2TextBox3.PasswordChar = '●';
        }

       

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length <= 7)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
        }
    }
}

