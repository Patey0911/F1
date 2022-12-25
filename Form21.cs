using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form21 : Form
    {
        public static string traseu_selectat;
        Font SmallFont = new Font("Bahnschrift", 15);
        public Form21()
        {
            InitializeComponent();
            Init_flowLayoutPanel1();
        }

        public void Init_flowLayoutPanel1()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo d = new DirectoryInfo(path + "\\F1\\2022\\Circuite");
            DirectoryInfo[] dirs = d.GetDirectories();

            foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
            {
                Button btn = new Button();
                btn.Text = dir.Name;
                btn.Width = 300;
                btn.Height = 30;
                btn.Tag = Form22.Traseu;
                btn.Font = SmallFont;
                flowLayoutPanel2.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form22 f2 = new Form22();
            f2.ShowDialog();
            Button btn = new Button();
            btn.Text = Form22.nume;
            btn.Width = 300;
            btn.Height = 30;
            btn.Font = SmallFont;
            btn.Tag = Form22.Traseu;
            flowLayoutPanel2.Controls.Add(btn);
            btn.Click += Btn_Click;
            btn.DoubleClick += Btn_DoubleClick;
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


        void Images_Load()
        {
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Graphics g = Graphics.FromHwnd(Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(255, 255);

            System.Drawing.Image img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Bahrain_img.png");
            //"C:\Users\mihal\Desktop\F1\2022\Circuite_img\Bahrain_img.png"
            Bitmap b = new Bitmap(img);
            System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Jeddah_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Melbourne_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Dell'Emilia-Romagna_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Miami_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Barcelona_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Monaco_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Baku_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Gilles-Villeneuve_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Silverstone_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Red Bull Ring_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Paul Ricard_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Hungaroring_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Spa_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Zandvoort_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Monza_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Marina Bay_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Suzuga_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Austin_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Autodromo Hermanos Rodriguez_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Sao Paulo_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Yas Marina_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\Lusail_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\LasVegas_img.png");
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageList1.Images.Add(i);

            img = System.Drawing.Image.FromFile(path_desktop + "\\F1\\2022\\Circuite_img\\f1Logo.png");
            b = new Bitmap(img);
            imageList1.Images.Add(b);
        }
        void Btn_Click(object sender, EventArgs e)
        {
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Button btn = (Button)sender;
            Circuit j = (Circuit)btn.Tag;
            traseu_selectat = btn.Text;

            string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\2022\\Circuite\\" + btn.Text + "\\" + btn.Text + ".txt");

            label6.Font = SmallFont;
            label7.Font = SmallFont;
            label8.Font = SmallFont;
            label9.Font = SmallFont;
            label10.Font = SmallFont;
            label11.Font = SmallFont;

            label6.Text = lines[0];
            label7.Text = lines[1];
            label8.Text = lines[2];
            label9.Text = lines[3];
            label10.Text = lines[4];
            label11.Text = lines[5];

            traseu_selectat = btn.Text;
            switch (traseu_selectat)
            {
                case "Bahrain":
                    pictureBox1.Image = imageList1.Images[0];
                    break;
                case "Jeddah":
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case "Melbourne":
                    pictureBox1.Image = imageList1.Images[2];
                    break;
                case "Imola":
                    pictureBox1.Image = imageList1.Images[3];
                    break;
                case "Miami":
                    pictureBox1.Image = imageList1.Images[4];
                    break;
                case "Barcelona":
                    pictureBox1.Image = imageList1.Images[5];
                    break;
                case "Monaco":
                    pictureBox1.Image = imageList1.Images[6];
                    break;
                case "Baku":
                    pictureBox1.Image = imageList1.Images[7];
                    break;
                case "Gilles-Villeneuve":
                    pictureBox1.Image = imageList1.Images[8];
                    break;
                case "Silverstone":
                    pictureBox1.Image = imageList1.Images[9];
                    break;
                case "Red Bull Ring":
                    pictureBox1.Image = imageList1.Images[10];
                    break;
                case "Paul Ricard":
                    pictureBox1.Image = imageList1.Images[11];
                    break;
                case "Hungaroring":
                    pictureBox1.Image = imageList1.Images[12];
                    break;
                case "Spa":
                    pictureBox1.Image = imageList1.Images[13];
                    break;
                case "Zandvoort":
                    pictureBox1.Image = imageList1.Images[14];
                    break;
                case "Monza":
                    pictureBox1.Image = imageList1.Images[15];
                    break;
                case "Marina Bay":
                    pictureBox1.Image = imageList1.Images[16];
                    break;
                case "Suzuka":
                    pictureBox1.Image = imageList1.Images[17];
                    break;
                case "Austin":
                    pictureBox1.Image = imageList1.Images[18];
                    break;
                case "Autodromo Hermanos Rodriguez":
                    pictureBox1.Image = imageList1.Images[19];
                    break;
                case "Sao Paulo":
                    pictureBox1.Image = imageList1.Images[20];
                    break;
                case "Yas Marina":
                    pictureBox1.Image = imageList1.Images[21];
                    break;
                case "Lusail":
                    pictureBox1.Image = imageList1.Images[22];
                    break;
                case "LasVegas":
                    pictureBox1.Image = imageList1.Images[23];
                    break;
            }
        }

        void Btn_DoubleClick(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();
            f23.Text = "Enter Results " + traseu_selectat;
            f23.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.Text = "Results " + traseu_selectat;
            f24.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f25 = new Form25();
            f25.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f26 = new Form26();
            f26.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Images_Load();
            pictureBox1.Image = imageList1.Images[24];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f11 = new Form31();
            f11.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f12 = new Form12();
            f12.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f14 = new Form14();
            f14.Text = "Quotes";
            f14.Show();
        }
    }
}