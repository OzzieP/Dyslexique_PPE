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

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string motDePasse;
        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value; }
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
