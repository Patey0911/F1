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
    public partial class Form6 : Form
    {
        public Font SmallFont = new Font("Bahnschrift", 10);
        public List<Pilot> lista_piloti = new List<Pilot>();
        static public List<int> Verstappen = new List<int>();
        static public List<int> Perez = new List<int>();
        static public List<int> Leclerc = new List<int>();
        static public List<int> Sainz = new List<int>();
        static public List<int> Hamilton = new List<int>();
        static public List<int> Russel = new List<int>();
        static public List<int> Norris = new List<int>();
        static public List<int> Ricciardo = new List<int>();
        static public List<int> Vettel = new List<int>();
        static public List<int> Stroll = new List<int>();
        static public List<int> Magnussen = new List<int>();
        static public List<int> Schumacher = new List<int>();
        static public List<int> Latifi = new List<int>();
        static public List<int> Albon = new List<int>();
        static public List<int> Ocon = new List<int>();
        static public List<int> Alonso = new List<int>();
        static public List<int> Gasly = new List<int>();
        static public List<int> Tsunoda = new List<int>();
        static public List<int> Zhou = new List<int>();
        static public List<int> Bottas = new List<int>();
        static public List<int> Ferrari = new List<int>();
        static public List<int> RedBull = new List<int>();
        static public List<int> Mercedes = new List<int>();
        static public List<int> McLaren = new List<int>();
        static public List<int> AlphaTauri = new List<int>();
        static public List<int> Alpine = new List<int>();
        static public List<int> Haas = new List<int>();
        static public List<int> AstonMartin = new List<int>();
        static public List<int> Williams = new List<int>();
        static public List<int> AlfaRomeo = new List<int>();
        public Form6()
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

        public void Curatenie()
        {
            Verstappen.Clear();
            Verstappen.Add(0);
            Perez.Clear();
            Perez.Add(0);
            Leclerc.Clear();
            Leclerc.Add(0);
            Sainz.Clear();
            Sainz.Add(0);
            Norris.Clear();
            Norris.Add(0);  
            Ricciardo.Clear();
            Ricciardo.Add(0);
            Hamilton.Clear();
            Hamilton.Add(0);
            Russel.Clear();
            Russel.Add(0);
            Gasly.Clear();
            Gasly.Add(0);
            Tsunoda.Clear();
            Tsunoda.Add(0);
            Alonso.Clear();
            Alonso.Add(0);
            Ocon.Clear();
            Ocon.Add(0);
            Vettel.Clear();
            Vettel.Add(0);
            Stroll.Clear();
            Stroll.Add(0);
            Magnussen.Clear();
            Magnussen.Add(0);
            Schumacher.Clear();
            Schumacher.Add(0);
            Latifi.Clear();
            Latifi.Add(0);
            Albon.Clear();
            Albon.Add(0);
            Bottas.Clear();
            Bottas.Add(0);
            Zhou.Clear();
            Zhou.Add(0);
            Ferrari.Clear();
            Ferrari.Add(0);
            RedBull.Clear();
            RedBull.Add(0);
            Mercedes.Clear();
            Mercedes.Add(0);
            McLaren.Clear();
            McLaren.Add(0);
            AlphaTauri.Clear();
            AlphaTauri.Add(0);
            Alpine.Clear();
            Alpine.Add(0);
            AlfaRomeo.Clear();
            AlfaRomeo.Add(0);
            Williams.Clear();
            Williams.Add(0);
            Haas.Clear();
            Haas.Add(0);
            AstonMartin.Clear();
            AstonMartin.Add(0);
        }
        public void calcul_puncte()
        {
            int poz_vect = 0;
            Curatenie();
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo path = new DirectoryInfo(path_desktop+"\\F1\\Circuite");
            DirectoryInfo[] dirs = path.GetDirectories();
            foreach (DirectoryInfo dir in dirs.OrderBy(dir=>dir.LastWriteTime))
            {
                string nume_director = path_desktop + "\\F1\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                if (File.Exists(nume_director))
                {
                    string[] lines = System.IO.File.ReadAllLines(path_desktop + "\\F1\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                    //Verstappen
                    string nume_pilot = "Verstappen";
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[0].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[0].Puncte = 1;
                    }
                    Verstappen.Add(lista_piloti[0].puncte);
                    //Perez
                    nume_pilot = "Perez";
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[1].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[1].Puncte = 1;
                    }
                    Perez.Add(lista_piloti[1].puncte);
                    RedBull.Add(lista_piloti[0].puncte + lista_piloti[1].puncte);
                    //Hamilton
                    nume_pilot = "Hamilton";
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[2].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[2].Puncte = 1;
                    }
                    Hamilton.Add(lista_piloti[2].puncte);

                    //Russel
                    nume_pilot = "Russel";
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[3].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[3].Puncte = 1;
                    }
                    Russel.Add(lista_piloti[3].puncte);
                    Mercedes.Add(lista_piloti[2].puncte + lista_piloti[3].puncte);

                    //Leclerc
                    nume_pilot = "Leclerc";
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[4].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[4].Puncte = 1;
                    }
                    Leclerc.Add(lista_piloti[4].puncte);

                    //Sainz
                    nume_pilot = "Sainz";
                    int poz = 5;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Sainz.Add(lista_piloti[poz].puncte);
                    Ferrari.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Norris
                    nume_pilot = "Norris";
                    poz = 6;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Norris.Add(lista_piloti[poz].puncte);

                    //Ricciardo
                    nume_pilot = "Ricciardo";
                    poz = 7;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Ricciardo.Add(lista_piloti[poz].puncte);
                    McLaren.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Gasly
                    nume_pilot = "Gasly";
                    poz = 8;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Gasly.Add(lista_piloti[poz].puncte);

                    //Tsunoda
                    nume_pilot = "Tsunoda";
                    poz = 9;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Tsunoda.Add(lista_piloti[poz].puncte);
                    AlphaTauri.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Vettel
                    nume_pilot = "Vettel";
                    poz = 10;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Vettel.Add(lista_piloti[poz].puncte);

                    //Stroll
                    nume_pilot = "Stroll";
                    poz = 11;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Stroll.Add(lista_piloti[poz].puncte);
                    AstonMartin.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Bottas
                    nume_pilot = "Bottas";
                    poz = 12;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Bottas.Add(lista_piloti[poz].puncte);

                    //Zhou
                    nume_pilot = "Zhou";
                    poz = 13;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Zhou.Add(lista_piloti[poz].puncte);
                    AlfaRomeo.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Schumacher
                    nume_pilot = "Schumacher";
                    poz = 14;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Schumacher.Add(lista_piloti[poz].puncte);

                    //Magnussen
                    nume_pilot = "Magnussen";
                    poz = 15;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Magnussen.Add(lista_piloti[poz].puncte);
                    Haas.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Alonso
                    nume_pilot = "Alonso";
                    poz = 16;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Alonso.Add(lista_piloti[poz].puncte);

                    //Ocon
                    nume_pilot = "Ocon";
                    poz = 17;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Ocon.Add(lista_piloti[poz].puncte);
                    Alpine.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);

                    //Latifi
                    nume_pilot = "Latifi";
                    poz = 18;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Latifi.Add(lista_piloti[poz].puncte);

                    //Albon
                    nume_pilot = "Albon";
                    poz = 19;
                    if (lines[0].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 25;
                    else if (lines[1].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 18;
                    else if (lines[2].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 15;
                    else if (lines[3].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 12;
                    else if (lines[4].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 10;
                    else if (lines[5].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 8;
                    else if (lines[6].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 6;
                    else if (lines[7].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 4;
                    else if (lines[8].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 2;
                    else if (lines[9].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[21].Contains(nume_pilot) == true)
                        lista_piloti[poz].Puncte = 1;
                    if (lines[22].Contains("True") == true)
                    {
                        if (lines[23].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 8;
                        else if (lines[24].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 7;
                        else if (lines[25].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 6;
                        else if (lines[26].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 5;
                        else if (lines[27].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 4;
                        else if (lines[28].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 3;
                        else if (lines[29].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 2;
                        else if (lines[30].Contains(nume_pilot) == true)
                            lista_piloti[poz].Puncte = 1;
                    }
                    Albon.Add(lista_piloti[poz].puncte);
                    Williams.Add(lista_piloti[poz - 1].puncte + lista_piloti[poz].puncte);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int poz_img=-1;
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = path_desktop+"\\F1\\Piloti_img\\";
            Graphics g = Graphics.FromHwnd(Handle);
            imageListPiloti.ColorDepth = ColorDepth.Depth32Bit;
            imageListPiloti.ImageSize = new Size(255, 255);

            var pilot_adaug = new Pilot("Verstappen", "RedBull", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Perez", "RedBull", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Hamilton", "Mercedes", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Russel", "Mercedes", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Leclerc", "Ferrari", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Sainz", "Ferrari", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Norris", "McLaren", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Ricciardo", "McLaren", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Gasly", "AlphaTauri", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Tsunoda", "AlphaTauri", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Vettel", "AstonMartin", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Stroll", "AstonMartin", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Bottas", "AlfaRomeo", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Zhou", "AlfaRomeo", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Schumacher", "Haas", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Magnussen", "Haas", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Alonso", "Alpine", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Ocon", "Alpine", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Latifi", "Williams", 0);
            lista_piloti.Add(pilot_adaug);
            pilot_adaug = new Pilot("Albon", "Williams", 0);
            lista_piloti.Add(pilot_adaug);

            calcul_puncte();

            Compara_punctaj comp = new Compara_punctaj();
            lista_piloti.Sort(comp);

            label1.Font = new Font(SmallFont, FontStyle.Bold);
            label2.Font = new Font(SmallFont, FontStyle.Bold);
            label1.Text = lista_piloti[0].Nume;
            label2.Text = lista_piloti[0].Puncte.ToString()+"PTS";

            string nume_pilot = label1.Text+".png";
            System.Drawing.Image img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            Bitmap b = new Bitmap(img);
            System.Drawing.Image i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox1.Image = imageListPiloti.Images[poz_img];

            label3.Font = new Font(SmallFont, FontStyle.Bold);
            label4.Font = new Font(SmallFont, FontStyle.Bold);
            label4.Text = lista_piloti[1].Nume;
            label3.Text = lista_piloti[1].Puncte.ToString() + "PTS";

            nume_pilot = label4.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox2.Image = imageListPiloti.Images[poz_img];

            label6.Font = new Font(SmallFont, FontStyle.Bold);
            label5.Font = new Font(SmallFont, FontStyle.Bold);
            label6.Text = lista_piloti[2].Nume;
            label5.Text = lista_piloti[2].Puncte.ToString() + "PTS";

            nume_pilot = label6.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox3.Image = imageListPiloti.Images[poz_img];

            label8.Font = SmallFont;
            label7.Font = SmallFont;
            label8.Text = lista_piloti[3].Nume;
            label7.Text = lista_piloti[3].Puncte.ToString() + "PTS";

            nume_pilot = label8.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox4.Image = imageListPiloti.Images[poz_img];

            label10.Font = SmallFont;
            label9.Font = SmallFont;
            label10.Text = lista_piloti[4].Nume;
            label9.Text = lista_piloti[4].Puncte.ToString() + "PTS";

            nume_pilot = label10.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox5.Image = imageListPiloti.Images[poz_img];

            label12.Font = SmallFont;
            label11.Font = SmallFont;
            label12.Text = lista_piloti[5].Nume;
            label11.Text = lista_piloti[5].Puncte.ToString() + "PTS";

            nume_pilot = label12.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox6.Image = imageListPiloti.Images[poz_img];

            label14.Font = SmallFont;
            label13.Font = SmallFont;
            label14.Text = lista_piloti[6].Nume;
            label13.Text = lista_piloti[6].Puncte.ToString() + "PTS";

            nume_pilot = label14.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox7.Image = imageListPiloti.Images[poz_img];

            label16.Font = SmallFont;
            label15.Font = SmallFont;
            label16.Text = lista_piloti[7].Nume;
            label15.Text = lista_piloti[7].Puncte.ToString() + "PTS";

            nume_pilot = label16.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox8.Image = imageListPiloti.Images[poz_img];

            label26.Font = SmallFont;
            label25.Font = SmallFont;
            label26.Text = lista_piloti[8].Nume;
            label25.Text = lista_piloti[8].Puncte.ToString() + "PTS";

            nume_pilot = label26.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox13.Image = imageListPiloti.Images[poz_img];

            label24.Font = SmallFont;
            label23.Font = SmallFont;
            label24.Text = lista_piloti[9].Nume;
            label23.Text = lista_piloti[9].Puncte.ToString() + "PTS";

            nume_pilot = label24.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox12.Image = imageListPiloti.Images[poz_img];

            label22.Font = SmallFont;
            label21.Font = SmallFont;
            label22.Text = lista_piloti[10].Nume;
            label21.Text = lista_piloti[10].Puncte.ToString() + "PTS";

            nume_pilot = label22.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox11.Image = imageListPiloti.Images[poz_img];

            label20.Font = SmallFont;
            label19.Font = SmallFont;
            label20.Text = lista_piloti[11].Nume;
            label19.Text = lista_piloti[11].Puncte.ToString() + "PTS";

            nume_pilot = label20.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox10.Image = imageListPiloti.Images[poz_img];

            label18.Font = SmallFont;
            label17.Font = SmallFont;
            label18.Text = lista_piloti[12].Nume;
            label17.Text = lista_piloti[12].Puncte.ToString() + "PTS";

            nume_pilot = label18.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox9.Image = imageListPiloti.Images[poz_img];

            label36.Font = SmallFont;
            label35.Font = SmallFont;
            label36.Text = lista_piloti[13].Nume;
            label35.Text = lista_piloti[13].Puncte.ToString() + "PTS";

            nume_pilot = label36.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox18.Image = imageListPiloti.Images[poz_img];

            label34.Font = SmallFont;
            label33.Font = SmallFont;
            label34.Text = lista_piloti[14].Nume;
            label33.Text = lista_piloti[14].Puncte.ToString() + "PTS";

            nume_pilot = label34.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox17.Image = imageListPiloti.Images[poz_img];

            label32.Font = SmallFont;
            label31.Font = SmallFont;
            label32.Text = lista_piloti[15].Nume;
            label31.Text = lista_piloti[15].Puncte.ToString() + "PTS";

            nume_pilot = label32.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox16.Image = imageListPiloti.Images[poz_img];

            label30.Font = SmallFont;
            label29.Font = SmallFont;
            label30.Text = lista_piloti[16].Nume;
            label29.Text = lista_piloti[16].Puncte.ToString() + "PTS";

            nume_pilot = label30.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox15.Image = imageListPiloti.Images[poz_img];

            label28.Font = SmallFont;
            label27.Font = SmallFont;
            label28.Text = lista_piloti[17].Nume;
            label27.Text = lista_piloti[17].Puncte.ToString() + "PTS";

            nume_pilot = label28.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox14.Image = imageListPiloti.Images[poz_img];

            label40.Font = SmallFont;
            label39.Font = SmallFont;
            label40.Text = lista_piloti[18].Nume;
            label39.Text = lista_piloti[18].Puncte.ToString() + "PTS";

            nume_pilot = label40.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox20.Image = imageListPiloti.Images[poz_img];

            label38.Font = SmallFont;
            label37.Font = SmallFont;
            label38.Text = lista_piloti[19].Nume;
            label37.Text = lista_piloti[19].Puncte.ToString() + "PTS";

            nume_pilot = label38.Text + ".png";
            img = System.Drawing.Image.FromFile(string.Concat(path, nume_pilot));
            b = new Bitmap(img);
            i = resizeImage(b, new Size(1000, 1000));
            imageListPiloti.Images.Add(i);
            poz_img++;
            pictureBox19.Image = imageListPiloti.Images[poz_img];

            Directory.CreateDirectory(path_desktop+"\\F1\\RezultateEchipe");
            string fileName = path_desktop+"\\F1\\RezultateEchipe\\";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            string nume_echipa = "RedBull";
            string nume_intreg = fileName + nume_echipa + ".txt";

            using (StreamWriter sw = File.CreateText(nume_intreg))
            {
                
            }
            nume_echipa = "Ferrari";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "McLaren";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {
                sw.WriteLine(fileName);
            }
            nume_echipa = "AlphaTauri";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "Alpine";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "AstonMartin";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "AlfaRomeo";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "Haas";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }
            nume_echipa = "Williams";
            using (StreamWriter sw = File.CreateText(fileName + nume_echipa + ".txt"))
            {

            }

            foreach (Pilot pil in lista_piloti)
            {
                using (StreamWriter sw = File.CreateText(fileName + pil.echipa + ".txt"))
                {
                    sw.WriteLine("0");
                }
            }

            foreach (Pilot pil in lista_piloti)
            {
                string[] lines = System.IO.File.ReadAllLines(path_desktop+"\\F1\\RezultateEchipe\\"+pil.echipa+ ".txt");
                int punctaj = Int32.Parse(lines[0]);
                punctaj = punctaj + pil.puncte;
                using (StreamWriter sw = File.CreateText(fileName + pil.echipa + ".txt"))
                {
                    sw.WriteLine(punctaj);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }
    }
}
