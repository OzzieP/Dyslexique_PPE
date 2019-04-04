using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Phrase
    {
        private int idPhrase;
        public int IdPhrase
        {
            get { return idPhrase; }
            set { idPhrase = value; }
        }

        private string texte;
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        private List<Mot> mots;
        public List<Mot> Mots
        {
            get { return mots; }
            set { mots = value; }
        }

        public Phrase()
        {
            
        }
    }
}
