using Dyslexique.DAL;
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


        // Fonction utilisée pour mettre à jour la liste des phrases non réussies par l'utilisateur
        public static void RefreshListPhrasesNonReussies()
        {
            phrasesNonReussies = Queries.GetAllPhrasesNonReussies();
        }
    }

    public enum EnumClassesMot
    {
        Adjectif,
        Adverbe,
        Conjonction,
        Determinant,
        Interjection,
        Nom,
        Preposition,
        Pronom,
        Verbe
    }
}
