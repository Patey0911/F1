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
using System.Windows.Forms.DataVisualization.Charting;

namespace F1
{
    public partial class Form11 : Form
    {
        int poz_vect = 0;
        int k;
        static string path_desktop1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static DirectoryInfo path = new DirectoryInfo(path_desktop1 + "\\F1\\2021\\Circuite");
        DirectoryInfo[] dirs = path.GetDirectories();

        string nume_pilot;
        int wid = 4;
        int cnt;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            int cnt = 0;
            foreach (var a in Form6.RedBull)
            {
                cnt++;
            }
            cnt--;

            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = cnt;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 1;
            objChart.AxisY.Maximum = 20;
            chart1.ChartAreas[0].AxisY.IsReversed = true;
            objChart.AxisY.RoundAxisValues();

            objChart.AxisX.Name = "Curse";
            

                chart1.Series.Clear();

                Random random = new Random();
                //Verstappen
                nume_pilot = "Verstappen";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(2, 30, 208);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Perez
                nume_pilot = "Perez";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(51, 255, 255);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Leclerc
                nume_pilot = "Leclerc";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(215, 0, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Sainz
                nume_pilot = "Sainz";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(102, 0, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Hamilton
                nume_pilot = "Hamilton";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(0, 0, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Russel
                nume_pilot = "Russel";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(64, 64, 64);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Norris
                nume_pilot = "Norris";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(255, 128, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Ricciardo
                nume_pilot = "Ricciardo";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(204, 102, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Gasly
                nume_pilot = "Gasly";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(140, 140, 140);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Tsunoda
                nume_pilot = "Tsunoda";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(192, 192, 192);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Vettel
                nume_pilot = "Vettel";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(0, 102, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Stroll
                nume_pilot = "Stroll";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(0, 255, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Ocon
                nume_pilot = "Ocon";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(153, 0, 76);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Alonso
                nume_pilot = "Alonso";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(255, 0, 127);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Bottas
                nume_pilot = "Bottas";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(65, 46, 7);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Zhou
                nume_pilot = "Zhou";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(128, 91, 17);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Magnussen
                nume_pilot = "Magnussen";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(192, 82, 48);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Schumacher
                nume_pilot = "Schumacher";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(122, 41, 16);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Albon
                nume_pilot = "Albon";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(255, 255, 0);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Latifi
                nume_pilot = "Latifi";
                chart1.Series.Add(nume_pilot);
                chart1.Series[nume_pilot].BorderWidth = wid;
                chart1.Series[nume_pilot].Color = Color.FromArgb(159, 159, 35);
                chart1.Series[nume_pilot].ChartArea = "ChartArea1";
                chart1.Series[nume_pilot].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int cnt = 1;
            nume_pilot = "Verstappen";
            if (checkBox1.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Verstappen";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                        
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox2_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Perez";
            if (checkBox2.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Perez";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
            }

            private void checkBox3_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Leclerc";
            if (checkBox3.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Leclerc";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox4_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Sainz";
            if (checkBox4.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Sainz";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox5_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Hamilton";
            if (checkBox5.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Hamilton";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox6_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Russel";
            if (checkBox6.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Russel";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox7_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Norris";
            if (checkBox7.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Norris";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox8_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Ricciardo";
            if (checkBox8.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Ricciardo";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox9_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Gasly";
            if (checkBox9.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Gasly";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox10_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Tsunoda";
            if (checkBox10.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Tsunoda";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox11_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Vettel";
            if (checkBox11.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Vettel";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox12_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Stroll";
            if (checkBox12.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Stroll";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox13_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Ocon";
            if (checkBox13.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Ocon";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox14_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Alonso";
            if (checkBox14.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Alonso";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox15_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Albon";
            if (checkBox15.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Albon";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Latifi";
            if (checkBox16.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Latifi";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Bottas";
            if (checkBox17.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Bottas";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox18_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Zhou";
            if (checkBox18.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Zhou";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox19_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Magnussen";
            if (checkBox19.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Magnussen";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }

            private void checkBox20_CheckedChanged(object sender, EventArgs e)
            {
            int cnt = 1;
            nume_pilot = "Schumacher";
            if (checkBox20.Checked == true)
            {
                foreach (DirectoryInfo dir in dirs.OrderBy(dir => dir.LastWriteTime))
                {
                    string nume_director = path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt";
                    if (File.Exists(nume_director))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path_desktop1 + "\\F1\\2021\\Circuite\\" + dir.Name + "\\" + "Rezultate.txt");
                        string nume_pilot = "Schumacher";
                        if (lines[0].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 1);
                        else if (lines[1].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 2);
                        else if (lines[2].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 3);
                        else if (lines[3].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 4);
                        else if (lines[4].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 5);
                        else if (lines[5].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 6);
                        else if (lines[6].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 7);
                        else if (lines[7].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 8);
                        else if (lines[8].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 9);
                        else if (lines[9].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 10);
                        else if (lines[10].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 11);
                        else if (lines[11].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 12);
                        else if (lines[12].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 13);
                        else if (lines[13].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 14);
                        else if (lines[14].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 15);
                        else if (lines[15].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 16);
                        else if (lines[16].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 17);
                        else if (lines[17].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 18);
                        else if (lines[18].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 19);
                        else if (lines[19].Contains(nume_pilot) == true)
                            chart1.Series[nume_pilot].Points.AddXY(cnt, 20);
                        cnt++;
                    }
                }
            }
            else
            {
                chart1.Series[nume_pilot].Points.Clear();
            }
        }
        }
    }

