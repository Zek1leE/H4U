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
using System.IO;
namespace Help4U
{
    public partial class procPerfil : Form
    {
        public procPerfil()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void procPerfil_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=h4u;";
            string query = "Select Id,Nome, Foto from user;";

            MySqlDataAdapter sda = new MySqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int i = 0;

            ImageList images = new ImageList();

            foreach (DataRow row in dt.Rows)
            {
                images.ColorDepth = ColorDepth.Depth32Bit;

                listView1.LargeImageList = images;
                listView1.LargeImageList.ImageSize = new System.Drawing.Size(110, 110);


                byte[] imagebyte = (byte[])(row[2]);

                MemoryStream image_stream = new MemoryStream(imagebyte);

                image_stream.Write(imagebyte, 0, imagebyte.Length);

                images.Images.Add(row[1].ToString(), new Bitmap(image_stream));


                image_stream.Close();

                ListViewItem item = new ListViewItem();

                item.ImageIndex = i;

                item.Text = row["Nome"].ToString();


                i += 1;

                this.listView1.Items.Add(item);
            }
        }
    }
}
