﻿using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajoutType btnAjoutType = new ajoutType();
            btnAjoutType.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ajoutClasse btnAjoutAdjectif = new ajoutClasse();
            btnAjoutAdjectif.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ajoutMot btnAjoutMot = new ajoutMot();
            btnAjoutMot.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhrasePossederMot btnPhrasePossederMot = new PhrasePossederMot();
            btnPhrasePossederMot.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ajoutFonction btnAjoutFonction = new ajoutFonction();
            btnAjoutFonction.ShowDialog();
        }
    }
}
