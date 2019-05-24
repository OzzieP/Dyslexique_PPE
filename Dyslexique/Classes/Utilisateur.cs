using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Utilisateur</c> utilisée comme modèle pour la représentation d'une entité de la table Utilisateur dans la BDD.
    /// </summary>
    public class Utilisateur
    {
        private string idUtilisateur;
        /// <summary>
        /// Obtient ou définit l'Id de l'<c>Utilisateur</c>.
        /// </summary>
        public string IdUtilisateur
        {
            get { return idUtilisateur; }
            set { idUtilisateur = value; }
        }

        private string pseudo;
        /// <summary>
        /// Obtient ou définit le pseudo de l'<c>Utilisateur</c>.
        /// </summary>
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        private string nom;
        /// <summary>
        /// Obtient ou définit le nom de l'<c>Utilisateur</c>.
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        /// <summary>
        /// Obtient ou définit le prénom de l'<c>Utilisateur</c>.
        /// </summary>
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string email;
        /// <summary>
        /// Obtient ou définit l'adresse email de l'<c>Utilisateur</c>.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string motDePasse;
        /// <summary>
        /// Obtient ou définit le mot de passe hashé de l'<c>Utilisateur</c>.
        /// </summary>
        /// <remarks>Le mot de passe est stocké hashé dans la BDD et donc est récupéré hashé.</remarks>
        /// Voir <see cref="Global.Hash256(string)"/> pour hasher le mot de passe.
        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value; }
        }

        // Administrateur = 1 / Utilisateur = 2
        private string idRole;
        /// <summary>
        /// Obtient ou définit l'Id du rôle de l'<c>Utilisateur</c>.
        /// </summary>
        public string IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }

        private string role;
        /// <summary>
        /// Obtient ou définit le rôle de l'<c>Utilisateur</c>.
        /// </summary>
        public string Role
        {
            get { return role; }
            set { role = value; }
        }


        /// <summary>
        /// Constructeur par défaut d'un <c>Utilisateur</c>.
        /// </summary>
        public Utilisateur()
        {

        }

        /// <summary>
        /// Déconnecte l'<c>Utilisateur</c> et supprime de l'application les données qui lui sont liées.
        /// </summary>
        public void SignOut()
        {
            Global.Utilisateur.ClearUtilisateurAndGlobalLists();
        }

        /// <summary>
        /// Supprime de l'application toutes les données liées à l'<c>Utilisateur</c>.
        /// </summary>
        /// <see cref="Global.Utilisateur"/>
        /// <seealso cref="Global.allPhrases"/>
        /// <seealso cref="Global.phrasesNonReussies"/>
        private void ClearUtilisateurAndGlobalLists()
        {
            this.idUtilisateur = null;
            this.pseudo = null;
            this.nom = null;
            this.prenom = null;
            this.email = null;
            this.motDePasse = null;
            this.idRole = null;
            this.role = null;

            Global.allPhrases.Clear();
            Global.phrasesNonReussies.Clear();
        }

        /// <summary>
        /// Remet à zéro la progression globale de l'<c>Utilisateur</c>.
        /// </summary>
        public void ResetProgression()
        {
            DAL.Queries.ResetProgressionByIdUtilisateur(this.IdUtilisateur);
            Global.RefreshListPhrasesNonReussies();
        }
    }
}
