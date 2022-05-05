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
        public Font SmallFont = new Font("Bahnschrift", 11);
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
        }
    }
}
