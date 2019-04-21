using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public static class Global
    {
        // Rôles des utilisateurs
        public const string ROLE_ADMINISTRATEUR = "1";
        public const string ROLE_UTILISATEUR = "2";

        // Persistance de l'utilisateur connecté dans toute l'application
        public static Utilisateur Utilisateur = new Utilisateur();
    }
}
