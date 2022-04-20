using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form2 : Form
    {
        public static string nume, locatie, lungime, distanta;
        public int laps;
        public DateTime data;
        private static Circuit traseu;

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        internal static Circuit Traseu { get => traseu; set => traseu = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            locatie = textBox2.Text;
            lungime = textBox3.Text;
            distanta = textBox4.Text;
            laps = (int)numericUpDown3.Value;
            var d = dateTimePicker1.Value; 
            var data = new DateTime(d.Year, d.Month, d.Day);

            traseu = new Circuit(nume, locatie, lungime, distanta, laps,data);

            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(path_desktop+"\\F1\\Circuite\\" + nume);
            string fileName = path_desktop+"\\F1\\Circuite\\" + nume+"\\"+nume+".txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Nume: " + nume);
                sw.WriteLine("Locatie: " + locatie);
                sw.WriteLine("Circuit Length: "+lungime);
                sw.WriteLine("Distance: "+distanta);
                sw.WriteLine("Laps: "+laps);
                if(data.Month/10>0)
                    sw.WriteLine("Data: "+data.Day+"/"+data.Month+"/"+data.Year);
                else
                    sw.WriteLine("Data: " + data.Day + "/0" + data.Month + "/" + data.Year);
                sw.WriteLine();
            }
            this.Close();
        }
    }
}
