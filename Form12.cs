using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form12 : Form
    {
        public static string numepasat;
        public Font SmallFont = new Font("Bahnschrift", 10);
        public Form12()
        {
            InitializeComponent();
        }
        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            int poz_img = 0;
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = path_desktop + "\\F1\\HallofFame_img\\";
            Graphics g = Graphics.FromHwnd(Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(255, 255);

            textBox1.Font = new Font(SmallFont, FontStyle.Bold);
            textBox1.Text = "Nino Farina";

            string nume_pilot = textBox1.Text + ".jpg";
            System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            Bitmap b = new Bitmap(img);
            System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox1.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox2.Font = new Font(SmallFont, FontStyle.Bold);
            textBox2.Text = "Jackie Stewart";

            nume_pilot = textBox2.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox2.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox3.Font = new Font(SmallFont, FontStyle.Bold);
            textBox3.Text = "Emerson Fittipaldi";

            nume_pilot = textBox3.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox3.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox4.Font = new Font(SmallFont, FontStyle.Bold);
            textBox4.Text = "Niki Lauda";

            nume_pilot = textBox4.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox4.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox5.Font = new Font(SmallFont, FontStyle.Bold);
            textBox5.Text = "Alain Prost";

            nume_pilot = textBox5.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox5.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox6.Font = new Font(SmallFont, FontStyle.Bold);
            textBox6.Text = "Ayrton Senna";

            nume_pilot = textBox6.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox6.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox7.Font = new Font(SmallFont, FontStyle.Bold);
            textBox7.Text = "Michael Schumacher";

            nume_pilot = textBox7.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox7.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox8.Font = new Font(SmallFont, FontStyle.Bold);
            textBox8.Text = "Fernando Alonso";

            nume_pilot = textBox8.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox8.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox8.Font = new Font(SmallFont, FontStyle.Bold);
            textBox8.Text = "Fernando Alonso";

            nume_pilot = textBox8.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox8.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox9.Font = new Font(SmallFont, FontStyle.Bold);
            textBox9.Text = "Lewis Hamilton";

            nume_pilot = textBox9.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox9.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox10.Font = new Font(SmallFont, FontStyle.Bold);
            textBox10.Text = "Sebastian Vettel";

            nume_pilot = textBox10.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox10.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox11.Font = new Font(SmallFont, FontStyle.Bold);
            textBox11.Text = "Nico Rosberg";

            nume_pilot = textBox11.Text + ".jpeg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox11.Image = imageList1.Images[poz_img];
            poz_img++;

            textBox12.Font = new Font(SmallFont, FontStyle.Bold);
            textBox12.Text = "Max Verstappen";

            nume_pilot = textBox12.Text + ".jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox12.Image = imageList1.Images[poz_img];
            poz_img++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numepasat = "Nino Farina.jpg";
            Form f13 = new Form13();
            f13.Text = "Nino Farina";
            f13.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numepasat = "Jackie Stewart.jpg";
            Form f13 = new Form13();
            f13.Text = "Jackie Stewart";
            f13.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numepasat = "Emerson Fittipaldi.jpg";
            Form f13 = new Form13();
            f13.Text = "Emerson Fittipaldi";
            f13.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numepasat = "Niki Lauda.jpg";
            Form f13 = new Form13();
            f13.Text = "Niki Lauda";
            f13.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            numepasat = "Alain Prost.jpg";
            Form f13 = new Form13();
            f13.Text = "Alain Prost";
            f13.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            numepasat = "Ayrton Senna.jpg";
            Form f13 = new Form13();
            f13.Text = "Ayrton Senna";
            f13.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            numepasat = "Michael Schumacher.jpg";
            Form f13 = new Form13();
            f13.Text = "Michael Schumacher";
            f13.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            numepasat = "Fernando Alonso.jpg";
            Form f13 = new Form13();
            f13.Text = "Fernando Alonso";
            f13.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            numepasat = "Lewis Hamilton.jpg";
            Form f13 = new Form13();
            f13.Text = "Lewis Hamilton";
            f13.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            numepasat = "Sebastian Vettel.jpg";
            Form f13 = new Form13();
            f13.Text = "Sebastian Vettel";
            f13.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            numepasat = "Nico Rosberg.jpeg";
            Form f13 = new Form13();
            f13.Text = "Nico Rosberg";
            f13.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            numepasat = "Max Verstappen.jpg";
            Form f13 = new Form13();
            f13.Text = "Max Verstappen";
            f13.Show();
        }
    }
}
