using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Mot // Texte, Genre, Classe
    {
        #region Nouveau
        private string idMot;
        public string IdMot
        {
            get { return idMot; }
            set { idMot = value; }
        }

        private string text;
        public string Texte
        {
            get { return text; }
            set { text = value; }
        }

        private string idClasse;
        public string IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        #endregion

    }
}
