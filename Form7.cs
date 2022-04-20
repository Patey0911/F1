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
    public partial class Form7 : Form
    {
        Font SmallFont = new Font("Bahnschrift", 10);
        public static string[] nume_pilot_sprint = new string[8];
        public Form7()
        {
            InitializeComponent();
            Form7_Load();
        }

        void Form7_Load()
        {
            textBox1.Font = SmallFont;
            textBox2.Font = SmallFont;
            textBox3.Font = SmallFont;
            textBox4.Font = SmallFont;
            textBox5.Font = SmallFont;
            textBox6.Font = SmallFont;
            textBox7.Font = SmallFont;
            textBox8.Font = SmallFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path_desktop + "\\F1\\Circuite\\" + Form1.traseu_selectat + "\\Rezultate" + ".txt";
            nume_pilot_sprint[0] = "1st Place Sprint: " + textBox1.Text;
            nume_pilot_sprint[1] = "2nd Place Sprint: " + textBox2.Text;
            nume_pilot_sprint[2] = "3rd Place Sprint: " + textBox3.Text;
            nume_pilot_sprint[3] = "4th Place Sprint: " + textBox4.Text;
            nume_pilot_sprint[4] = "5th Place Sprint: " + textBox5.Text;
            nume_pilot_sprint[5] = "6th Place Sprint: " + textBox6.Text;
            nume_pilot_sprint[6] = "7th Place Sprint: " + textBox7.Text;
            nume_pilot_sprint[7] = "8th Place Sprint: " + textBox8.Text;
            /*using (StreamWriter sw = File.AppendText(fileName))
            {
                for (int i = 0; i <= 2; i++)
                    sw.WriteLine(nume_pilot_sprint[i]);
                sw.WriteLine();
            }*/
            this.Close();
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
            textBox7.DragEnter -= textBox8_DragEnter;
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
