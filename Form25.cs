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
    public partial class Form25 : Form
    {
        Form26 f26 = new Form26();
        public List<Echipa> lista_echipe = new List<Echipa>();
        Font SmallFont = new Font("Bahnschrift", 14);
        Font SmallFont1 = new Font("Bahnschrift", 10);
        Font BigFont = new Font("Bahnschrift", 17);
        public Form25()
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

        private void Form25_Load(object sender, EventArgs e)
        {
            var a = new Echipa("RedBull", 0);
            lista_echipe.Add(a);
            a = new Echipa("Mercedes", 0);
            lista_echipe.Add(a);
            a = new Echipa("Ferrari", 0);
            lista_echipe.Add(a);
            a = new Echipa("McLaren", 0);
            lista_echipe.Add(a);
            a = new Echipa("AlphaTauri", 0);
            lista_echipe.Add(a);
            a = new Echipa("Alpine", 0);
            lista_echipe.Add(a);
            a = new Echipa("AlfaRomeo", 0);
            lista_echipe.Add(a);
            a = new Echipa("Haas", 0);
            lista_echipe.Add(a);
            a = new Echipa("AstonMartin", 0);
            lista_echipe.Add(a);
            a = new Echipa("Williams", 0);
            lista_echipe.Add(a);

            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (Echipa ech in lista_echipe)
            {
                string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\2022\\RezultateEchipe\\" + ech.Nume + ".txt");
                ech.Puncte = Int32.Parse(lines[0]);
            }
            Compara_punctaj_echipe comp = new Compara_punctaj_echipe();
            lista_echipe.Sort(comp);

            string path_pilot = path_desktop + "\\F1\\2022\\Ploti_Echipe_img\\";
            string path_logo = path_desktop + "\\F1\\2022\\Logo_img\\";
            string path_masina = path_desktop + "\\F1\\2022\\Masini_img\\";
            Graphics g = Graphics.FromHwnd(Handle);
            PilotsList.ColorDepth = ColorDepth.Depth32Bit;
            PilotsList.ImageSize = new Size(255, 255);
            LogoList.ColorDepth = ColorDepth.Depth32Bit;
            LogoList.ImageSize = new Size(255, 255);
            CarList.ColorDepth = ColorDepth.Depth32Bit;
            CarList.ImageSize = new Size(255, 255);


            foreach (Echipa ech in lista_echipe)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path_logo, ech.Nume + ".png"));
                Bitmap b = new Bitmap(img);
                System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
                LogoList.Images.Add(i);
            }

            foreach (Echipa ech in lista_echipe)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path_masina, ech.Nume + ".png"));
                Bitmap b = new Bitmap(img);
                System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
                CarList.Images.Add(b);
            }

            foreach (Echipa ech in lista_echipe)
            {
                var img = System.Drawing.Image.FromFile(string.Concat(path_pilot, ech.Nume + "_1.png"));
                var b = new Bitmap(img);
                var i = resizeImage(b, new Size(1000, 1000));
                PilotsList.Images.Add(b);
                img = System.Drawing.Image.FromFile(string.Concat(path_pilot, ech.Nume + "_2.png"));
                b = new Bitmap(img);
                i = resizeImage(b, new Size(1000, 1000));
                PilotsList.Images.Add(b);
            }


            //Poz1
            label1.Font = BigFont;
            label1.Text = lista_echipe[0].Nume;
            label2.Font = SmallFont;
            label2.Text = lista_echipe[0].puncte + "PTS";
            this.pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = LogoList.Images[0];
            pictureBox2.Image = CarList.Images[0];
            pictureBox3.Image = PilotsList.Images[0];
            pictureBox4.Image = PilotsList.Images[1];

            //Poz2
            label3.Font = BigFont;
            label3.Text = lista_echipe[1].Nume;
            label4.Font = SmallFont;
            label4.Text = lista_echipe[1].puncte + "PTS";
            pictureBox8.Image = LogoList.Images[1];
            pictureBox7.Image = CarList.Images[1];
            pictureBox6.Image = PilotsList.Images[2];
            pictureBox5.Image = PilotsList.Images[3];

            //Poz3
            label5.Font = BigFont;
            label5.Text = lista_echipe[2].Nume;
            label6.Font = SmallFont;
            label6.Text = lista_echipe[2].puncte + "PTS";
            pictureBox12.Image = LogoList.Images[2];
            pictureBox11.Image = CarList.Images[2];
            pictureBox10.Image = PilotsList.Images[4];
            pictureBox9.Image = PilotsList.Images[5];

            //Poz4
            label7.Font = BigFont;
            label7.Text = lista_echipe[3].Nume;
            label8.Font = SmallFont;
            label8.Text = lista_echipe[3].puncte + "PTS";
            pictureBox24.Image = LogoList.Images[3];
            pictureBox23.Image = CarList.Images[3];
            pictureBox22.Image = PilotsList.Images[6];
            pictureBox21.Image = PilotsList.Images[7];

            //Poz5
            label9.Font = BigFont;
            label9.Text = lista_echipe[4].Nume;
            label10.Font = SmallFont;
            label10.Text = lista_echipe[4].puncte + "PTS";
            pictureBox20.Image = LogoList.Images[4];
            pictureBox19.Image = CarList.Images[4];
            pictureBox18.Image = PilotsList.Images[8];
            pictureBox17.Image = PilotsList.Images[9];

            //Poz6
            label11.Font = BigFont;
            label11.Text = lista_echipe[5].Nume;
            label12.Font = SmallFont;
            label12.Text = lista_echipe[5].puncte + "PTS";
            pictureBox16.Image = LogoList.Images[5];
            pictureBox15.Image = CarList.Images[5];
            pictureBox14.Image = PilotsList.Images[10];
            pictureBox13.Image = PilotsList.Images[11];

            //Poz7
            label18.Font = BigFont;
            label18.Text = lista_echipe[6].Nume;
            label17.Font = SmallFont;
            label17.Text = lista_echipe[6].puncte + "PTS";
            pictureBox36.Image = LogoList.Images[6];
            pictureBox35.Image = CarList.Images[6];
            pictureBox34.Image = PilotsList.Images[12];
            pictureBox33.Image = PilotsList.Images[13];

            //Poz8
            label16.Font = BigFont;
            label16.Text = lista_echipe[7].Nume;
            label15.Font = SmallFont;
            label15.Text = lista_echipe[7].puncte + "PTS";
            pictureBox32.Image = LogoList.Images[7];
            pictureBox31.Image = CarList.Images[7];
            pictureBox30.Image = PilotsList.Images[14];
            pictureBox29.Image = PilotsList.Images[15];

            //Poz9
            label14.Font = BigFont;
            label14.Text = lista_echipe[8].Nume;
            label13.Font = SmallFont;
            label13.Text = lista_echipe[8].puncte + "PTS";
            pictureBox28.Image = LogoList.Images[8];
            pictureBox27.Image = CarList.Images[8];
            pictureBox26.Image = PilotsList.Images[16];
            pictureBox25.Image = PilotsList.Images[17];

            //Poz10
            label20.Font = BigFont;
            label20.Text = lista_echipe[9].Nume;
            label19.Font = SmallFont;
            label19.Text = lista_echipe[9].puncte + "PTS";
            pictureBox40.Image = LogoList.Images[9];
            pictureBox39.Image = CarList.Images[9];
            pictureBox38.Image = PilotsList.Images[18];
            pictureBox37.Image = PilotsList.Images[19];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form29 f = new Form29();
            f.Show();
        }
    }
}
