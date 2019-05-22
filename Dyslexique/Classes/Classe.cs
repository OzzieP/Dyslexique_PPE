using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Classe
    {
        private int idClasse;

        public int IdClasse
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
        private Types type;

        public Types Type
        {
            get { return type; }
            set { type = value; }
        }



    }
}
