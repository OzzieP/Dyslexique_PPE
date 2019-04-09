using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Fonction
    {
        private string idFonction;
        public string IdFonction
        {
            get { return idFonction; }
            set { idFonction = value; }
        }

        private string libelle;
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public Fonction(string idFonction, string libelle)
        {
            this.IdFonction = idFonction;
            this.Libelle = libelle;
        }
    }
}
