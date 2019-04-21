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
        private List<Phrase> phrasesSelectionnees = new List<Phrase>();

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
            Random random = new Random();
            int[] indexes = new int[5];
            //int x = 0;

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = random.Next(0, this.phrases.Count);
            }

            //while (x < 5)
            //{
            //    indexes[x] = random.Next(0, this.phrases.Count);
            //    x++;
            //}

            for (int i = 0; i < indexes.Length; i++)
            {
                phrasesSelectionnees.Add(phrases.ElementAt(i));
            }

            var abc = phrasesSelectionnees;
            //label_Consigne.Text = this.phrase.Consigne;
            //this.phrase.Afficher(this, this.phrase);
        }
    }

}
