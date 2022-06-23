using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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

        // Abrir Insta 
       private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/help4u.official/");
        }

        //Abrir Email
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // help4u.604@gmail.com  
        }

        //Abrir Principal
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length == 0 | guna2TextBox2.Text.Length == 0)
            {

                label1.Visible = true;
            }

            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=H4u;";
            //string query = "Select * from user where Email = '" + guna2TextBox1.Text.Trim() + "' and Password = '" + guna2TextBox2.Text.Trim() + "'";

            //MySqlDataAdapter sda = new MySqlDataAdapter(query, connectionString);
            //DataTable dataTable = new DataTable();
            //sda.Fill(dataTable);

            //if (dataTable.Rows.Count >= 1)
            //{
               Principal principal = new Principal();
                principal.Show();
                this.Visible = false;
            //}
            //else
            //{
            //    label1.Visible = true;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.PasswordChar = '●';

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

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
