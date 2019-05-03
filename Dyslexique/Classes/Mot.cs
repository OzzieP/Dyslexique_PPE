using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Mot
    {
        private string idMot;
        public string IdMot
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

        private string idClasse;
        public string IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        private Classe classe;
        public Classe Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        private Fonction fonction;
        public Fonction Fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private bool estATrouver;
        public bool EstATrouver
        {
            get { return estATrouver; }
            set { estATrouver = value; }
        }


        public Mot()
        {

        }

        public Mot(string texte, string position)
        {
            this.Texte = texte;
            this.Position = position;
            this.classe = new Classe();
            this.fonction = new Fonction();
        }

        public Mot(string id, string texte, Fonction fonction, string position)
        {
            this.idMot = id;
            this.Texte = texte;
            this.Fonction = fonction;
            this.Position = position;
            this.classe = new Classe();
        }
    }
}
