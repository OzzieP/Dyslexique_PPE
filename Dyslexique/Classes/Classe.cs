using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Classe
    {
        private string idClasse;
        public string IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        private string libelle;
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        private Types types;
        public Types Types
        {
            get { return types; }
            set { types = value; }
        }

    }
}
