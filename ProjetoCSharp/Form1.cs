﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "Senac Largo Treze";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";
        }
    }
}
