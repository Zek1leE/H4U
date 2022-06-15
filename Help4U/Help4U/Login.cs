﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        bool mover = false;
        Point Pinicial;

        // Minimizar
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Fechar
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Abrir Insta 
       private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/help4u.official/");
        }

        //Abrir Email
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        //Abrir Principal
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.PasswordChar = '*';
        }
        
        //Mover Form
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mover = true;
            Pinicial = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.Pinicial.X, novo.Y - this.Pinicial.Y);
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", " help4u.604@gmail.com");
        }

    }
}
