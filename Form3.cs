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
    public partial class Form3 : Form
    {
        int poz = 1;
        public static bool k = false;
        Font SmallFont = new Font("Bahnschrift", 10,FontStyle.Bold);
        public static string[] nume_pilot = new string[25];
        public Form3()
        {
            InitializeComponent();
            Form3_load();
        }

        public void Form3_load()
        {
            textBox1.Font = SmallFont;
            textBox2.Font = SmallFont;
            textBox3.Font = SmallFont;
            textBox4.Font = SmallFont;
            textBox5.Font = SmallFont;
            textBox6.Font = SmallFont;
            textBox7.Font = SmallFont;
            textBox8.Font = SmallFont;
            textBox9.Font = SmallFont;
            textBox10.Font = SmallFont;
            textBox11.Font = SmallFont;
            textBox12.Font = SmallFont;
            textBox13.Font = SmallFont;
            textBox14.Font = SmallFont;
            textBox15.Font = SmallFont; 
            textBox16.Font = SmallFont; 
            textBox17.Font = SmallFont;
            textBox18.Font = SmallFont;
            textBox19.Font = SmallFont;
            textBox20.Font = SmallFont;
            textBox21.Font = SmallFont;
            textBox22.Font = SmallFont;
            k = false;
            radioButton1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume_pilot[0] = "1st Place: " + textBox1.Text;
            nume_pilot[1] = "2nd Place: " + textBox2.Text;
            nume_pilot[2] = "3rd Place: " + textBox3.Text;
            nume_pilot[3] = "4th Place: " + textBox4.Text;
            nume_pilot[4] = "5th Place: " + textBox5.Text;
            nume_pilot[5] = "6th Place: " + textBox6.Text;
            nume_pilot[6] = "7th Place: " + textBox7.Text;
            nume_pilot[7] = "8th Place: " + textBox9.Text;
            nume_pilot[8] = "9th Place: " + textBox10.Text;
            nume_pilot[9] = "10th Place: " + textBox8.Text;
            nume_pilot[10] = "11th Place: " + textBox20.Text;
            nume_pilot[11] = "12th Place: " + textBox19.Text;
            nume_pilot[12] = "13th Place: " + textBox18.Text;
            nume_pilot[13] = "14th Place: " + textBox17.Text;
            nume_pilot[14] = "15th Place: " + textBox16.Text;
            nume_pilot[15] = "16th Place: " + textBox15.Text;
            nume_pilot[16] = "17th Place: " + textBox14.Text;
            nume_pilot[17] = "18th Place: " + textBox13.Text;
            nume_pilot[18] = "19th Place: " + textBox12.Text;
            nume_pilot[19] = "20th Place: " + textBox11.Text;
            nume_pilot[20] = "Pole: " + textBox21.Text;
            nume_pilot[21] = "Fastest Lap: " + textBox22.Text;

            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path_desktop+"\\F1\\Circuite\\" + Form1.traseu_selectat +"\\Rezultate"+ ".txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                for(int i=0;i<=21;i++)
                    sw.WriteLine(nume_pilot[i]);
                sw.WriteLine(k);
                if (radioButton1.Checked == true)
                    sw.WriteLine(100);
                else if (radioButton2.Checked == true)
                    sw.WriteLine(75);
                else if (radioButton3.Checked == true)
                    sw.WriteLine(50);
                else if (radioButton4.Checked == true)
                    sw.WriteLine(25);
            }
            if (k==true)
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    for (int i = 0; i <= 7; i++)
                        sw.WriteLine(Form7.nume_pilot_sprint[i]);
                    sw.WriteLine();
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = true;
            Form7 f7 = new Form7();
            f7.Text = "Enter Results Sprint Race " + Form1.traseu_selectat;
            f7.Show();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox1.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox1.DragDrop -= textBox1_DragDrop;
            textBox1.ReadOnly = true;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox1.DragEnter -= textBox1_DragEnter;
        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox2.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox2.DragDrop -= textBox2_DragDrop;
            textBox2.ReadOnly = true;   
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox2.DragEnter -= textBox2_DragEnter;
        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox3.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox3.DragDrop -= textBox3_DragDrop;
            textBox3.ReadOnly = true;
        }

        private void textBox3_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox3.DragEnter -= textBox3_DragEnter;
        }

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox4.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove); 
            textBox4.DragDrop -= textBox4_DragDrop;
            textBox4.ReadOnly = true;
        }

        private void textBox4_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox4.DragEnter -= textBox4_DragEnter;
        }

        private void textBox5_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox5.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox5.DragDrop -= textBox5_DragDrop;
            textBox5.ReadOnly = true;
        }

        private void textBox5_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox5.DragEnter -= textBox5_DragEnter;
        }

        private void textBox6_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox6.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox6.DragDrop -= textBox6_DragDrop;
            textBox6.ReadOnly = true;
        }

        private void textBox6_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox6.DragEnter -= textBox6_DragEnter;
        }

        private void textBox7_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox7.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox7.DragDrop -= textBox7_DragDrop;
            textBox7.ReadOnly = true;
        }

        private void textBox7_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox7.DragEnter -= textBox7_DragEnter;
        }

        private void textBox9_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox9.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox9.DragDrop -= textBox9_DragDrop;
            textBox9.ReadOnly = true;
        }

        private void textBox9_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox9.DragEnter -= textBox9_DragEnter;
        }
        private void textBox10_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox10.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox10.DragDrop -= textBox10_DragDrop;
            textBox10.ReadOnly = true;
        }

        private void textBox10_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox10.DragEnter -= textBox10_DragEnter;
        }

        private void textBox8_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox8.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox8.DragDrop -= textBox8_DragDrop;
            textBox8.ReadOnly = true;
        }

        private void textBox8_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox8.DragEnter -= textBox8_DragEnter;
        }

        private void textBox20_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox20.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox8.DragDrop -= textBox8_DragDrop;
            textBox20.ReadOnly = true;
        }

        private void textBox20_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox20.DragEnter -= textBox20_DragEnter;
        }

        private void textBox19_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox19.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox19.DragDrop -= textBox19_DragDrop;
            textBox19.ReadOnly = true;
        }

        private void textBox19_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox19.DragEnter -= textBox19_DragEnter;
        }

        private void textBox18_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox18.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox18.DragDrop -= textBox18_DragDrop;
            textBox18.ReadOnly = true;
        }

        private void textBox18_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox18.DragEnter -= textBox18_DragEnter;
        }

        private void textBox17_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox17.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox17.DragDrop -= textBox17_DragDrop;
            textBox17.ReadOnly = true;
        }

        private void textBox17_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox17.DragEnter -= textBox17_DragEnter;
        }

        private void textBox16_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox16.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox16.DragDrop -= textBox16_DragDrop;
            textBox16.ReadOnly = true;
        }

        private void textBox16_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox16.DragEnter -= textBox16_DragEnter;
        }

        private void textBox15_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox15.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox15.DragDrop -= textBox15_DragDrop;
            textBox15.ReadOnly = true;  
        }

        private void textBox15_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox15.DragEnter -= textBox15_DragEnter;
        }

        private void textBox14_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox14.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox14.DragDrop -= textBox14_DragDrop;
            textBox14.ReadOnly = true;  
        }

        private void textBox14_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox14.DragEnter -= textBox14_DragEnter;
        }

        private void textBox13_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox13.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox13.DragDrop -= textBox13_DragDrop;
            textBox13.ReadOnly = true;
        }

        private void textBox13_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox13.DragEnter -= textBox13_DragEnter;
        }

        private void textBox12_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox12.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox12.DragDrop -= textBox12_DragDrop;
            textBox12.ReadOnly = true;
        }

        private void textBox12_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox12.DragEnter -= textBox12_DragEnter;
        }

        private void textBox11_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = e.Data.GetData(typeof(Button)) as Button;
            textBox11.Text = btn.Text;
            Button buttonToRemove = btn;
            this.Controls.Remove(buttonToRemove);
            textBox11.DragDrop -= textBox11_DragDrop;
            textBox11.ReadOnly = true;
        }

        private void textBox11_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Link;
            textBox11.DragEnter -= textBox11_DragEnter;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button17_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button18_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button19_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button20_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button21_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }

        private void button22_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                DoDragDrop((sender as Button), DragDropEffects.Link);
        }


    }
}
