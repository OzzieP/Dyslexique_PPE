using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public static class Global
    {
        // Rôles des utilisateurs
        public const string ROLE_ADMINISTRATEUR = "1";
        public const string ROLE_UTILISATEUR = "2";

        // Persistance dans toute l'application de l'utilisateur connecté
        public static Utilisateur Utilisateur = new Utilisateur();
        // Persistance dans toute l'application des phrases non réussies par l'utilisateur connecté
        public static List<Phrase> phrasesNonReussies = new List<Phrase>();


        // Fonction utilisée pour mettre à jour la liste des phrases non réussies par l'utilisateur
        public static void RefreshListPhrasesNonReussies()
        {
            phrasesNonReussies = Queries.GetAllPhrasesNonReussies();
        }

        public static string Hash256(string mdp)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(mdp));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
