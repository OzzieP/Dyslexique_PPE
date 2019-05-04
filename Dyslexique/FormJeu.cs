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
        private Phrase phrase;
        private List<Phrase> phrases = new List<Phrase>();

        public FormJeu()
        {
            InitializeComponent();

            this.phrases = Queries.GetAllPhrasesNonReussies();
        }

        public FormJeu(Phrase phrase)
        {
            InitializeComponent();

            this.phrase = phrase;
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            //DisplayPhraseForm();
        }

        //public void DisplayPhraseForm()
        //{
        //    Random random = new Random();
        //    int index = random.Next(phrases.Count);
        //    Phrase phraseSelectionnee = phrases.ElementAt(index);

        //    label_Consigne.Text = phraseSelectionnee.Consigne;
        //    phraseSelectionnee.Afficher(this, phraseSelectionnee);
        //    label_Tentatives.Text = phraseSelectionnee.Tentative.ToString();
        //}
    }
}
