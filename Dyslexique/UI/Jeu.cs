using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyslexique.Classes;
using Dyslexique.DAL;

namespace Dyslexique.UI
{
    public partial class Jeu : UserControl
    {
        public string Title = "Passer les tests";
        public bool utilisateurAJouer = false;
        private Phrase phraseSelectionnee;

        public Jeu()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            DisplayPhrase();
        }

        private void Button_PhrasePrecedente_Click(object sender, EventArgs e)
        {

        }

        private void Button_PhraseSuivante_Click(object sender, EventArgs e)
        {

        }

        //private void DisplayPhrase()
        //{
        //    Random random = new Random();
        //    int randomIndex = random.Next(Global.phrasesNonReussies.Count);
        //    Phrase phraseSelectionnee = Global.phrasesNonReussies.ElementAt(randomIndex);

        //    label_Consigne.Text += phraseSelectionnee.Consigne;
        //    phraseSelectionnee.Afficher(this, phraseSelectionnee);
        //    label_Tentatives.Text += phraseSelectionnee.Tentative.ToString();
        //}

        public void DisplayPhrase()
        {
            Random random = new Random();
            int randomIndex = random.Next(Global.phrasesNonReussies.Count);
            this.phraseSelectionnee = Global.phrasesNonReussies.ElementAt(randomIndex);

            label_Consigne.Text += phraseSelectionnee.Consigne;
            phraseSelectionnee.Afficher(this, phraseSelectionnee);
            label_Tentatives.Text += phraseSelectionnee.Tentative.ToString();
        }

    }
}
