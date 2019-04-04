using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Mot // Texte, Genre, Classe
    {
        private int idMot;

        public int IdMot
        {
            get { return idMot; }
            set { idMot = value; }
        }

        private string texte;

        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        private Classe classe;

        public Classe Classe
        {
            get { return classe; }
            set { classe = value; }
        }



    }
}