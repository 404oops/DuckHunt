using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckHunt
{
    public partial class Form1 : Form
    {
        int state = 1;
        int level = 0;
        long points = 0;
        private bool position, running, isegg;
        int egg = 0;
        Random random = new Random();
        int range;
        bool carnage;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (running)
            {
                points++;
                stop();
                label1.Text = "Broj poena je: " + points;
            }
            if (carnage)
            {
                isegg = true;
                groupBox1.Visible = true;
                label4.Visible = true;
                points = long.MaxValue;

                label1.Text = "Broj poena je: " + points;
            }
        }
        private void MovementAnim_Tick(object sender, EventArgs e)
        {
            switch (level)
            {
                case 0:
                    switch (state)
                    {
                        case 0: pictureBox1.Image = Properties.Resources.b1_1; state++; pictureBox1.Top -= range; break;
                        case 1: pictureBox1.Image = Properties.Resources.b1_2; state++; break;
                        case 2: pictureBox1.Image = Properties.Resources.b1_3; state=0; pictureBox1.Top += range; break;
                    }
                    break;
            }
        }

        private void Tracking_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
            if (pictureBox1.Left >= MainControl.Size.Width)
                pictureBox1.Left = 0;
            label1.Text = "Broj poena je: " + points;
            if (carnage)
            {
                pictureBox1.Top = random.Next(0, MainControl.Size.Height);
                pictureBox1.Left = random.Next(0, MainControl.Size.Width);
            }
        }
        
        void start()
        {
            if (radioButton1.Checked)
            {
                carnage = false;
                fall.Interval = 100;
                Tracking.Interval = 100;
                MovementAnim.Interval = 100;
                UpDown.Interval = 100;
                range = 10;
            }
            if (radioButton2.Checked)
            {
                carnage = false;
                fall.Interval = 50;
                Tracking.Interval = 50;
                MovementAnim.Interval = 50;
                UpDown.Interval = 50;
                range = 30;
            }
            if (radioButton3.Checked)
            {
                carnage = true;
                fall.Interval = 100;
                Tracking.Interval = 100;
                MovementAnim.Interval = 100;
                UpDown.Interval = 100;
                range = 10;
            }
            if (!carnage)
            {
                MovementAnim.Enabled =
                    UpDown.Enabled = running = true; fall.Enabled = false;
            }
            Tracking.Enabled = true;
            if (isegg)
                isegg = groupBox1.Visible = false;
        }
        void stop()
        {
            Tracking.Enabled = 
                MovementAnim.Enabled = 
                UpDown.Enabled = running = false; fall.Enabled = true;
            pictureBox1.Image = Properties.Resources.fall;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (egg != 5)
            {
                egg++;
                Console.WriteLine(egg);
                isegg = true;
            }
            else
            {
                groupBox1.Visible = true;
                egg = 0;
                Console.WriteLine(egg);
            }
        }
        private void button1_Click(object sender, EventArgs e) { start(); }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < MainControl.Size.Height)
                pictureBox1.Top += 10;
            else
            {
                pictureBox1.Top = MainControl.Size.Height - 154;
                pictureBox1.Left = 27;
                fall.Stop();
                pictureBox1.Image = Properties.Resources.b1_1;
                state = 0;
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpDown_Tick(object sender, EventArgs e)
        {
            switch (position)
            {
                case true:
                    position = false; pictureBox1.Top += 20; break;
                case false:
                    position = true; pictureBox1.Top -= 20; break;
            }
        }
    }
}
