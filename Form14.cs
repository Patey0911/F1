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
    public partial class Form14 : Form
    {
        public Font SmallFont = new Font("Bahnschrift", 12);
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form14()
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
        private void Form14_Load(object sender, EventArgs e)
        { 
            string path = path_desktop + "\\F1\\HallofFame_img\\";

            Graphics g = Graphics.FromHwnd(Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(255, 255);

            int poz_img = 0;
            string nume_pilot =  "Ayrton Senna.jpg";
            System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            Bitmap b = new Bitmap(img);
            System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox1.Image = imageList1.Images[poz_img];
            poz_img++;

            nume_pilot = "Michael Schumacher.jpg";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);
            pictureBox2.Image = imageList1.Images[poz_img];
            poz_img++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Font = SmallFont;
            string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\Quotes\\"+button1.Text+".txt");
            for (int i = 0; i < lines.Length; i++)
            {
                richTextBox1.AppendText(lines[i]);
                richTextBox1.AppendText("\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Font = SmallFont;
            string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\Quotes\\" + button2.Text + ".txt");
            for (int i = 0; i < lines.Length; i++)
            {
                richTextBox1.AppendText(lines[i]);
                richTextBox1.AppendText("\n");
            }
        }
    }
}
