using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Form11 : Form
    {
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

            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 5;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 80;

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
            nume_pilot = "Verstappen";
            if (checkBox1.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Verstappen)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Verstappen)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Perez";
            if (checkBox2.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Perez)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Perez)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Leclerc";
            if (checkBox3.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Leclerc)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Leclerc)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Sainz";
            if (checkBox4.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Sainz)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Sainz)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Hamilton";
            if (checkBox5.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Hamilton)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Hamilton)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Russel";
            if (checkBox6.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Russel)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Russel)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Norris";
            if (checkBox7.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Norris)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Norris)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Ricciardo";
            if (checkBox8.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Ricciardo)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Ricciardo)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Gasly";
            if (checkBox9.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Gasly)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Gasly)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Tsunoda";
            if (checkBox10.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Tsunoda)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Tsunoda)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Vettel";
            if (checkBox11.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Vettel)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Vettel)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Stroll";
            if (checkBox12.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Stroll)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Stroll)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Ocon";
            if (checkBox13.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Ocon)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Ocon)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Alonso";
            if (checkBox14.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Alonso)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Alonso)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Albon";
            if (checkBox15.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Albon)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Albon)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Latifi";
            if (checkBox16.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Latifi)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Latifi)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Bottas";
            if (checkBox17.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Bottas)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Bottas)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Zhou";
            if (checkBox18.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Zhou)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Zhou)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Magnussen";
            if (checkBox19.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Magnussen)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Magnussen)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            nume_pilot = "Schumacher";
            if (checkBox20.Checked == true)
            {
                int cnt = 1;
                foreach (var a in Form6.Schumacher)
                {
                    chart1.Series[nume_pilot].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form6.Schumacher)
                {
                    chart1.Series[nume_pilot].Points.Clear();
                }
            }
        }
    }
}


