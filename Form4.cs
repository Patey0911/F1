using System;
//using Systemlabel1Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form4 : Form
    {
        Font SmallFont = new Font("Bahnschrift", 12);
        Font SmallFont1 = new Font("Bahnschrift", 12);
        Font BigFont = new Font("Bahnschrift", 24);
        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = path_desktop + "\\F1\\Piloti_img\\";
            Graphics g = Graphics.FromHwnd(Handle);
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(255, 255);

            if (File.Exists(path_desktop + "\\F1\\Circuite\\" + Form1.traseu_selectat + "\\" + "Rezultate" + ".txt"))
            {
                pictureBox4.Dispose();
                string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\Circuite\\" + Form1.traseu_selectat + "\\" + "Rezultate" + ".txt");
                textBox1.Font = new Font(SmallFont1, FontStyle.Bold);   
                textBox2.Font = new Font(SmallFont1, FontStyle.Bold);
                textBox3.Font = new Font(SmallFont1, FontStyle.Bold);
                label4.Font = SmallFont;
                label5.Font = SmallFont;
                label6.Font = SmallFont;
                label7.Font = SmallFont;
                label8.Font = SmallFont;
                label9.Font = SmallFont;
                label10.Font = SmallFont;
                label11.Font = SmallFont;
                label12.Font = SmallFont;
                label13.Font = SmallFont;
                label14.Font = SmallFont;
                label15.Font = SmallFont;
                label16.Font = SmallFont;
                label17.Font = SmallFont;
                label18.Font = SmallFont;
                label19.Font = SmallFont;
                label20.Font = SmallFont;
                label21.Font = new Font(SmallFont, FontStyle.Bold);
                label22.Font = new Font(SmallFont, FontStyle.Bold);
                label23.Font = new Font(SmallFont, FontStyle.Bold);
                label24.Font = new Font(SmallFont, FontStyle.Bold);
                label25.Font = new Font(SmallFont, FontStyle.Bold);

                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
                label4.Text = lines[3];
                label5.Text = lines[4];
                label6.Text = lines[5];
                label7.Text = lines[6];
                label8.Text = lines[7];
                label9.Text = lines[8];
                label10.Text = lines[9];
                label11.Text = lines[10];
                label12.Text = lines[11];
                label13.Text = lines[12];
                label14.Text = lines[13];
                label15.Text = lines[14];
                label16.Text = lines[15];
                label17.Text = lines[16];
                label18.Text = lines[17];
                label19.Text = lines[18];
                label20.Text = lines[19];
                label21.Text = lines[20];
                label22.Text = lines[21];
                label26.Text = "";

                if (lines[22].Contains("True") == true)
                {
                    label23.Text = lines[23];
                    label24.Text = lines[24];
                    label25.Text = lines[25];
                    button1.Enabled = true;
                }
                else
                {
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    button1.Enabled = false;
                }

                string nume_pilot = "Verstappen.png";
                System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                Bitmap b = new Bitmap(img);
                System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Leclerc.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Sainz.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Hamilton.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Perez.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Russel.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Norris.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Ricciardo.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Gasly.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Tsunoda.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Vettel.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Stroll.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Ocon.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Alonso.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Bottas.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Zhou.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Magnussen.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Schumacher.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Albon.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Latifi.png";
                img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);

                nume_pilot = "Verstappen";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[0];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[0];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[0];
                }

                nume_pilot = "Leclerc";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[1];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[1];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[1];
                }

                nume_pilot = "Sainz";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[2];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[2];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[2];
                }

                nume_pilot = "Hamilton";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[3];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[3];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[3];
                }

                nume_pilot = "Perez";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[4];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[4];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[4];
                }

                nume_pilot = "Russel";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[5];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[5];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[5];
                }

                nume_pilot = "Norris";
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[6];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[6];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[6];
                }

                nume_pilot = "Ricciardo";
                int poz = 7;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Gasly";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Tsunoda";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Vettel";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Stroll";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Ocon";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Alonso";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Bottas";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Zhou";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Magnussen";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Schumacher";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Albon";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }

                nume_pilot = "Latifi";
                poz++;
                if (textBox1.Text.Contains(nume_pilot) == true)
                {
                    pictureBox1.Image = imageList2.Images[poz];
                }
                if (textBox2.Text.Contains(nume_pilot) == true)
                {
                    pictureBox2.Image = imageList2.Images[poz];
                }
                if (textBox3.Text.Contains(nume_pilot) == true)
                {
                    pictureBox3.Image = imageList2.Images[poz];
                }
            }
            else
            {
                string nume_pilot = "MaxVerstappen.jpg";
                System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
                Bitmap b = new Bitmap(img);
                System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
                imageList2.Images.Add(i);
                pictureBox4.Image = imageList2.Images[0];

                pictureBox1.Dispose();
                pictureBox2.Dispose();
                pictureBox3.Dispose();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
                label18.Text = "";
                label19.Text = "";
                label20.Text = "";
                label21.Text = "";
                label22.Text = "";
                label23.Text = "";
                label24.Text = "";
                label25.Text = "";
                label26.Font = BigFont;
                label26.Text = "Max Verstappen you are the World Champion";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f4=new Form10();
            f4.ShowDialog();
        }
    }
}
