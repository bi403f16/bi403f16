﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaressoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Shop> MyShop = new List<Shop>();

        private void Form1_Load(object sender, EventArgs e)
        {
            MyShop.Add(new Shop("Hej"));

            foreach (Shop s in MyShop)
            {
                textBox1.Text = textBox1.Text + s.ToString() + Environment.NewLine;
            }


        }
    }
}