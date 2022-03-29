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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mimizar Fechar
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        // Abrir Insta e Email
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/help4u.official/");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.PasswordChar = '*';
        }
    }
}
