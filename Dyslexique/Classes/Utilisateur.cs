using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Utilisateur
    {
        private string idUtilisateur;
        public string IdUtilisateur
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
        private string idRole;
        public string IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
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
