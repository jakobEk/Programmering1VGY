﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        DateTime start;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                start = DateTime.Now;
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tid = DateTime.Now - start;
            label1.Text = tid.Minutes.ToString().PadLeft(2, '0')
            + ":" + tid.Seconds.ToString().PadLeft(2, '0')
            + ":" + tid.Milliseconds.ToString().PadLeft(3, '0');
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Select();
        }
    }
}
