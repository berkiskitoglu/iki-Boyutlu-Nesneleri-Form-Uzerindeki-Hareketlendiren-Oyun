﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Nesne_Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer5.Start();

        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top -= 6;
           
            if (pictureBox1.Top <= 25 )
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 722)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 424)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 36)
            {
                timer4.Stop();
                timer1.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            pictureBox2.Top -= 5;
            if(pictureBox2.Top <= 99)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 5;
            if(pictureBox2.Left >=653)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 346)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 5;
            if(pictureBox2.Left <= 123)
            {
                timer8.Stop();
                MessageBox.Show("Çıkışa Ulaştınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
