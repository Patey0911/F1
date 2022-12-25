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
    public partial class Form29 : Form
    {
        string nume_echipa;
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            foreach (var a in Form26.RedBull)
            {
                cnt++;
            }
            cnt--;
            int wid = 4;
            var objChart = chart2.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = cnt;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 600;

            chart2.Series.Clear();
            string nume_echipa;

            //RedBull
            nume_echipa = "RedBull";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(2, 30, 208);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Ferrari
            nume_echipa = "Ferrari";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(215, 0, 0);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Mercedes
            nume_echipa = "Mercedes";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(0, 0, 0);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //McLaren
            nume_echipa = "McLaren";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(255, 128, 0);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //AphaTauri
            nume_echipa = "AlphaTauri";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(140, 140, 140);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //AstonMartin
            nume_echipa = "AstonMartin";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(0, 192, 0);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Alpine
            nume_echipa = "Alpine";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(153, 0, 76);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //AlfaRomeo
            nume_echipa = "AlfaRomeo";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(65, 46, 7);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Haas
            nume_echipa = "Haas";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(192, 82, 48);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Williams
            nume_echipa = "Williams";
            chart2.Series.Add(nume_echipa);
            chart2.Series[nume_echipa].BorderWidth = wid;
            chart2.Series[nume_echipa].Color = Color.FromArgb(255, 255, 0);
            chart2.Series[nume_echipa].ChartArea = "ChartArea1";
            chart2.Series[nume_echipa].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "RedBull";
            if (checkBox1.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.RedBull)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.RedBull)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "Ferrari";
            if (checkBox2.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.Ferrari)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.Ferrari)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "Mercedes";
            if (checkBox3.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.Mercedes)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.Mercedes)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "McLaren";
            if (checkBox4.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.McLaren)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.McLaren)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "AlphaTauri";
            if (checkBox5.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.AlphaTauri)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.AlphaTauri)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "AstonMartin";
            if (checkBox6.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.AstonMartin)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.AstonMartin)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "Alpine";
            if (checkBox7.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.Alpine)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.Alpine)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "AlfaRomeo";
            if (checkBox8.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.AlfaRomeo)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.AlfaRomeo)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "Haas";
            if (checkBox9.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.Haas)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.Haas)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            nume_echipa = "Williams";
            if (checkBox10.Checked == true)
            {
                int cnt = 0;
                foreach (var a in Form26.Williams)
                {
                    chart2.Series[nume_echipa].Points.AddXY(cnt, a);
                    cnt++;
                }
            }
            else
            {
                foreach (var a in Form26.Williams)
                {
                    chart2.Series[nume_echipa].Points.Clear();
                }
            }
        }
    }
}
