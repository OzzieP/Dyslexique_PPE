using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Utilisateur
    {
        private int idUtilisateur;
        public int IdUtilisateur
        {
            get { return idUtilisateur; }
            set { idUtilisateur = value; }
        }

        private string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        private int idRole;
        public int IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }
    }
}