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

        // Classes des mots
        public const string ADJECTIF = "Adjectif";
        public const string ADVERBE = "Adverbe";
        public const string CONJONCTION = "Conjonction";
        public const string DETERMINANT = "Déterminant";
        public const string INTERJECTION = "Interjection";
        public const string NOM = "Nom";
        public const string PREPOSITION = "Préposition";
        public const string PRONOM = "Pronom";
        public const string VERBE = "Verbe";

        // Persistance dans toute l'application de l'utilisateur connecté
        public static Utilisateur Utilisateur = new Utilisateur();
        // Persistance dans toute l'application des phrases non réussies par l'utilisateur connecté
        public static List<Phrase> phrasesNonReussies = new List<Phrase>();
        // Persistance dans toute l'application de toutes les phrases stockées dans la DB
        public static List<Phrase> allPhrases = new List<Phrase>();


        public static List<string> allClasses = new List<string>
        {
            ADJECTIF,
            ADVERBE,
            CONJONCTION,
            DETERMINANT,
            INTERJECTION,
            NOM,
            PREPOSITION,
            PRONOM,
            VERBE
        };


        // Fonction utilisée pour mettre à jour la liste des phrases non réussies par l'utilisateur
        public static void RefreshListPhrasesNonReussies()
        {
            phrasesNonReussies = Queries.GetAllPhrasesNonReussiesByIdUtilisateur();
        }

        public static void RefreshListAllPhrases()
        {
            allPhrases = Queries.GetAllPhrases();
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
