using Dyslexique.Classes;
using Dyslexique.DAL;
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
    public partial class FormJeu : Form
    {
        private Utilisateur utilisateur;
        private Phrase phrase;

        public FormJeu()
        {
            InitializeComponent();
        }

        public FormJeu(Utilisateur utilisateur, Phrase phrase)
        {
            InitializeComponent();

            this.utilisateur = utilisateur;
            this.phrase = phrase;
            //this.phrase = Queries.GetPhraseById(phrase.IdPhrase);
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            label_Consigne.Text = this.phrase.Consigne;
            this.phrase.Afficher(this);
        }

        //private bool UserHasWon()
        //{

        //}
    }
}
