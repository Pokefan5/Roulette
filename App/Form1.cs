﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FrenchWheel w = new FrenchWheel();
            w.Test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
