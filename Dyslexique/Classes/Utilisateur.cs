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

        // Administrateur = 1 / Utilisateur = 2
        private int idRole;
        public int IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }

        public Utilisateur()
        {

        }

        public Utilisateur(string pseudo)
        {
            this.pseudo = pseudo;
        }
    }
}
