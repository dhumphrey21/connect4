﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game Connect4 = null;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Connect4.StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect4 = new Game(pnlGamePanel);
        }
    }
}
