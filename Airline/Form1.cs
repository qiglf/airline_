﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace Airline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            All_Flights frm = new All_Flights();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            All_Flights frm = new All_Flights();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            All_Flights frm = new All_Flights();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            All_Flights frm = new All_Flights();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            All_Flights frm = new All_Flights();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}

