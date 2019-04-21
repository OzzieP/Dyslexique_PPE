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
    public partial class Tests : UserControl
    {
        private List<Phrase> phrases = new List<Phrase>();
        private List<Phrase> phrasesSelectionnes = new List<Phrase>();

        public Tests()
        {
            InitializeComponent();

            this.phrases = Queries.GetAllPhrasesNonReussies();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] indexes = new int[5];
            int x = 0;

            while (x < 5)
            {
                indexes[x] = random.Next(this.phrases.Count);
                x++;
            }

            for (int i = 0; i < indexes.Length; i++)
            {
                phrasesSelectionnes.Add(phrases.ElementAt(i));
            }
        }
    }
}
