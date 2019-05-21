using Dyslexique.DAL;
using Dyslexique.UI.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Fournit des propriétés et méthodes <c>static</c> utilisées dans l'ensemble de l'application.
    /// </summary>
    /// <remarks>
    /// Cette classe ainsi que toutes ses propriétés et méthodes sont <c>static</c>.
    /// </remarks>
    public static class Global
    {
        // Rôles des utilisateurs
        /// <summary>
        /// Constante gardant en mémoire l'IdRole corresponsant au rôle "Administrateur" dans la BDD.
        /// </summary>
        public const string ROLE_ADMINISTRATEUR = "1";
        /// <summary>
        /// Constante gardant en mémoire l'IdRole corresponsant au rôle "Utilisateur" dans la BDD.
        /// </summary>
        public const string ROLE_UTILISATEUR = "2";

        // Classes des mots
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Adjectif".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string ADJECTIF = "Adjectif";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Adverbe".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string ADVERBE = "Adverbe";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à la <c>Classe</c> de <c>Mot</c> "Conjonction".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string CONJONCTION = "Conjonction";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Déterminant".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string DETERMINANT = "Déterminant";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Interjection".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string INTERJECTION = "Interjection";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Nom".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string NOM = "Nom";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Préposition".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string PREPOSITION = "Préposition";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Pronom".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string PRONOM = "Pronom";
        /// <summary>
        /// Constante représentant une chaîne de caractères correspondant à <c>Classe</c> de <c>Mot</c> "Verbe".
        /// </summary>
        /// <see cref="CustomLabel(Mot, Phrase, UI.UserControls.Jeu, int)"/>
        public const string VERBE = "Verbe";


        /// <summary>
        /// Objet représentant l'<c>Utilisateur</c> connecté à l'application.
        /// </summary>
        /// <remarks>
        /// Cela permet la persistance dans toute l'application de l'<c>Utilisateur</c> connecté.
        /// </remarks>
        public static Utilisateur Utilisateur = new Utilisateur();

        /// <summary>
        /// Objet <c>List</c> gardant en mémoire l'ensemble des phrases non réussies par l'<c>Utilisateur</c> connecté.
        /// </summary>
        /// <remarks>
        /// Cela permet la persistance dans toute l'application des phrases non réussies par l'<c>Utilisateur</c> connecté.
        /// </remarks>
        public static List<Phrase> phrasesNonReussies = new List<Phrase>();

        /// <summary>
        /// Objet <c>List</c> gardant en mémoire l'ensemble des phrases stockées dans la BDD.
        /// </summary>
        /// <remarks>
        /// Cela permet la persistance dans toute l'application de l'ensemble des phrases stockées dans la BDD.
        /// </remarks>
        public static List<Phrase> allPhrases = new List<Phrase>();


        /// <summary>
        /// Rafraichit et met à jour la liste phrasesNonReussies de la classe <c>Global</c>.
        /// </summary>
        public static void RefreshListPhrasesNonReussies()
        {
            phrasesNonReussies = Queries.GetAllPhrasesNonReussiesByIdUtilisateur();
        }

        /// <summary>
        /// Rafraichit et met à jour la liste allPhrases de la classe <c>Global</c>.
        /// </summary>
        public static void RefreshListAllPhrases()
        {
            allPhrases = Queries.GetAllPhrases();
        }

        /// <summary>
        /// Hashe le mot de passe de l'<c>Utilisateur</c>.
        /// </summary>
        /// <param name="mdp"></param>
        /// <returns>
        /// Le mot de passe de l'<c>Utilisateur</c> hashé.
        /// </returns>
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
