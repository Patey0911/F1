using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form13 : Form
    {
        string[] images;
        int poz=0;
        Font SmallFont = new Font("Bahnschrift", 12);
        Font bigFont = new Font("Bahnschrift", 10);
        public Form13()
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

        public string[] Images_Read()
        {
            char[] MyChar = { '.', 'j', 'p', 'e', 'g' };
            string nume_pasat_partial = Form12.numepasat.TrimEnd(MyChar);
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = path_desktop + "\\F1\\HallofFame_img\\" + nume_pasat_partial + "_img";
            string[] images = Directory.GetFiles(path, "*.jpg");
            Array.Sort(images);
            return images;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            images = Images_Read();

            pictureBox1.Image = new Bitmap(images[0]);

            char[] MyChar = { '.', 'j', 'p', 'e', 'g' };
            string nume_pasat_partial = Form12.numepasat.TrimEnd(MyChar);
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = path_desktop + "\\F1\\HallofFame_img\\" + nume_pasat_partial + "_img";
            path = path_desktop + "\\F1\\HallofFame\\"+nume_pasat_partial+".txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            label1.Font = new Font(SmallFont,FontStyle.Bold);
            label2.Font = new Font(SmallFont, FontStyle.Bold);
            label3.Font = new Font(SmallFont, FontStyle.Bold);
            label4.Font = new Font(SmallFont, FontStyle.Bold);
            label5.Font = new Font(SmallFont, FontStyle.Bold);
            label6.Font = new Font(SmallFont, FontStyle.Bold);
            label7.Font = new Font(SmallFont, FontStyle.Bold);
            label8.Font = new Font(SmallFont, FontStyle.Bold);
            label9.Font = new Font(SmallFont, FontStyle.Bold);

            label1.Text = lines[0];
            label2.Text = lines[1];
            label3.Text = lines[2];
            label4.Text = lines[3];
            label5.Text = lines[4];
            label6.Text = lines[5];
            label7.Text = lines[6];
            label8.Text = lines[7];
            label9.Text = lines[8];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            poz++;
            if (poz == images.Length)
                poz = 0;
            pictureBox1.Image = new Bitmap(images[poz]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poz--;
            if (poz < 0)
                poz = images.Length-1;
            pictureBox1.Image = new Bitmap(images[poz]);
        }
    }
}
