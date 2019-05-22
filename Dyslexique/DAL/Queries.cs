using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dyslexique.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

/// <summary>
/// Espace de nom contenant la classe <c>DAL</c> donnant accès à un ensemble de méthodes permettant la manipulation des données dans la BDD SQL Server.
/// </summary>
namespace Dyslexique.DAL
{
    /// <summary>
    /// Fournit des méthodes <c>static</c> permettant la manipulation des données dans la BDD SQL Server.
    /// </summary>
    /// <remarks>
    /// Cette classe ainsi que toutes ses méthodes sont <c>static</c>.
    /// </remarks>
    public static class Queries
    {
        /// <summary>
        /// Obtient la chaîne de connexion pour la connexion à la BDD.
        /// </summary>
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DyslexiqueConnectionString"].ConnectionString;

        #region Utilisateur
        /// <summary>
        /// Récupère tous les utilisateurs stockés dans la BDD.
        /// </summary>
        /// <returns>
        /// La liste de tous les utilisateurs dans la BDD.
        /// </returns>
        public static List<Utilisateur> GetAllUtilisateurs()
        {
            try
            {
                List<Utilisateur> utilisateurs = new List<Utilisateur>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS Pseudo, u.nom AS Nom, u.prenom AS Prenom, u.email AS Email, u.motDePasse AS MDP, 
                                    u.idRole AS idRole, r.libelle AS Role
                                    FROM Utilisateur u
                                    INNER JOIN Role r ON u.idRole = r.idRole
                                    ORDER BY Pseudo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Utilisateur utilisateur = new Utilisateur
                                    {
                                        IdUtilisateur = reader["idUtilisateur"].ToString(),
                                        Pseudo = reader["Pseudo"].ToString(),
                                        Nom = reader["Nom"].ToString(),
                                        Prenom = reader["Prenom"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        MotDePasse = reader["MDP"].ToString(),
                                        IdRole = reader["idRole"].ToString(),
                                        Role = reader["Role"].ToString()
                                    };

                                    utilisateurs.Add(utilisateur);
                                }
                            }
                        }
                    }
                }

                return utilisateurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de récupérer tous les utilisateurs. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Récupère un <c>Utilisateur</c> dans la BDD par le biais de son pseudo.
        /// </summary>
        /// <param name="pseudo"></param>
        /// <returns>
        /// Un <c>Utilisateur</c>.
        /// </returns>
        public static Utilisateur GetUtilisateurByPseudo(string pseudo)
        {
            try
            {
                Utilisateur utilisateur = new Utilisateur();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS Pseudo, u.nom AS Nom, u.prenom AS Prenom, u.email AS Email, u.motDePasse AS MDP, 
                                    u.idRole AS idRole, r.libelle AS Role
                                    FROM Utilisateur u
                                    INNER JOIN Role r ON u.idRole = r.idRole
                                    WHERE pseudo = @Pseudo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                utilisateur.IdUtilisateur = reader["idUtilisateur"].ToString();
                                utilisateur.Pseudo = reader["Pseudo"].ToString();
                                utilisateur.Nom = reader["Nom"].ToString();
                                utilisateur.Prenom = reader["Prenom"].ToString();
                                utilisateur.Email = reader["Email"].ToString();
                                utilisateur.MotDePasse = reader["MDP"].ToString();
                                utilisateur.IdRole = reader["idRole"].ToString();
                                utilisateur.Role = reader["Role"].ToString();
                            }
                        }
                    }
                }

                return utilisateur;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de récupérer l'utilisateur " + pseudo + ". \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Récupère un <c>Utilisateur</c> dans la BDD par le biais de son Id.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns>
        /// Un <c>Utilisateur</c>.
        /// </returns>
        public static Utilisateur GetUtilisateurById(string idUtilisateur)
        {
            try
            {
                Utilisateur utilisateur = new Utilisateur();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS Pseudo, u.nom AS Nom, u.prenom AS Prenom, u.email AS Email, u.motDePasse AS MDP, 
                                    u.idRole AS idRole, r.libelle AS Role
                                    FROM Utilisateur u
                                    INNER JOIN Role r ON u.idRole = r.idRole
                                    WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                utilisateur.IdUtilisateur = reader["idUtilisateur"].ToString();
                                utilisateur.Pseudo = reader["Pseudo"].ToString();
                                utilisateur.Nom = reader["Nom"].ToString();
                                utilisateur.Prenom = reader["Prenom"].ToString();
                                utilisateur.Email = reader["Email"].ToString();
                                utilisateur.MotDePasse = reader["MDP"].ToString();
                                utilisateur.IdRole = reader["idRole"].ToString();
                                utilisateur.Role = reader["Role"].ToString();
                            }
                        }
                    }
                }

                return utilisateur;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de récupérer l'utilisateur " + idUtilisateur + ". \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Effectue un INSERT SQL d'un nouvel <c>Utilisateur</c> dans la BDD.
        /// </summary>
        /// <param name="pseudo"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <param name="mdp"></param>
        /// <param name="idRole"></param>
        public static void InsertUtilisateur(string pseudo, string nom, string prenom, string email, string mdp, string idRole)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Utilisateur (pseudo, nom, prenom, email, motDePasse, idRole) 
                                    VALUES (@Pseudo, @Nom, @Prenom, @Email, @MDP, @IdRole)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));
                        command.Parameters.Add(new SqlParameter("@Nom", nom));
                        command.Parameters.Add(new SqlParameter("@Prenom", prenom));
                        command.Parameters.Add(new SqlParameter("@Email", email));
                        command.Parameters.Add(new SqlParameter("@MDP", Global.Hash256(mdp)));
                        command.Parameters.Add(new SqlParameter("@IdRole", Convert.ToInt32(idRole)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion de l'utilisateur. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Effectue un UPDATE SQL d'un <c>Utilisateur</c> dans la BDD.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="pseudo"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <param name="idRole"></param>
        public static void UpdateUtilisateur(string idUtilisateur, string pseudo, string nom, string prenom, string email, string idRole)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur 
                                    SET pseudo = @Pseudo, nom = @Nom, prenom = @Prenom, email = @Email, idRole = @IdRole
                                    WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));
                        command.Parameters.Add(new SqlParameter("@Nom", nom));
                        command.Parameters.Add(new SqlParameter("@Prenom", prenom));
                        command.Parameters.Add(new SqlParameter("@Email", email));
                        command.Parameters.Add(new SqlParameter("@IdRole", Convert.ToInt32(idRole)));
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur " + idUtilisateur + ", " + pseudo + ". \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Effectue un DELETE SQL d'un <c>Utilisateur</c> dans la BDD.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        public static void DeleteUtilisateur(string idUtilisateur)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Utilisateur_Essayer_Phrase WHERE idUtilisateur = @IdUtilisateur";
                    string query2 = @"DELETE FROM Utilisateur WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Erreur lors de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        using (SqlCommand command = new SqlCommand(query2, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Erreur lors de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur " + idUtilisateur + ". \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region Utilisateur_Essayer_Phrase
        /// <summary>
        /// Vérifie si un <c>Utilisateur</c> donné possède déjà au moins une tentative pour une <c>Phrase</c> donnée.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idPhrase"></param>
        /// <returns></returns>
        private static bool CheckIfTentativeForPhraseExists(string idUtilisateur, string idPhrase)
        {
            bool exists;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT COUNT(*)
                                    FROM Utilisateur_Essayer_Phrase uep
                                    WHERE uep.idUtilisateur = @IdUtilisateur AND uep.idPhrase = @IdPhrase";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(idPhrase)));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                exists = true;
                            else
                                exists = false;
                        }
                    }
                }

                return exists;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Effectue un INSERT ou un UPDATE SQL de la tentative d'un <c>Utilisateur</c> sur une <c>Phrase</c>.
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="phrase"></param>
        public static void InsertOrUpdateTentative(Utilisateur utilisateur, Phrase phrase)
        {
            /* On vérifie si l'Utilisateur passé en premier paramètre possède au moins une tentative pour la Phrase passée en second paramètre.
             * S'il a au moins une tentative sur la Phrase, alors on effectue un UPDATE.
             * S'il n'a pas de tentative sur la Phrase, alors on effectue un INSERT.
            */
            bool exists = CheckIfTentativeForPhraseExists(utilisateur.IdUtilisateur, phrase.IdPhrase);

            if (exists)
            {
                // UPDATE
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE Utilisateur_Essayer_Phrase 
                                        SET tentative = @Tentative, dateDerniereTentative = @Date, reussie = @Reussie 
                                        WHERE idUtilisateur = @IdUtilisateur AND idPhrase = @IdPhrase";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(utilisateur.IdUtilisateur)));
                            command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(phrase.IdPhrase)));
                            command.Parameters.Add(new SqlParameter("@Tentative", phrase.Tentative));
                            command.Parameters.AddWithValue("@Date", phrase.DateDerniereTentative.Value);
                            command.Parameters.Add(new SqlParameter("@Reussie", phrase.AEteReussie));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                                MessageBox.Show("Erreur lors de la mise à jour de Utilisateur_Essayer_Phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour de Utilisateur_Essayer_Phrase. \n" +
                                    "Message : " + ex.Message + "\n" +
                                    "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                // INSERT
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string query = @"INSERT INTO Utilisateur_Essayer_Phrase 
                                        (idUtilisateur, idPhrase, tentative, dateDerniereTentative, reussie) 
                                            VALUES 
                                        (@IdUtilisateur, @IdPhrase, @Tentative, @Date, @Reussie)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(utilisateur.IdUtilisateur)));
                            command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(phrase.IdPhrase)));
                            command.Parameters.Add(new SqlParameter("@Tentative", phrase.Tentative));
                            command.Parameters.AddWithValue("@Date", phrase.DateDerniereTentative.Value);
                            command.Parameters.Add(new SqlParameter("@Reussie", phrase.AEteReussie));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                                MessageBox.Show("Erreur lors de l'insertion de la tentative.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion de la tentative. \n" +
                                    "Message : " + ex.Message + "\n" +
                                    "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        /// <summary>
        /// Remet à zéro les statistiques (nombre de tentatives, date de dernière tentative, phrases réussies) d'un <c>Utilisateur</c>.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        public static void ResetProgressionByIdUtilisateur(string idUtilisateur)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur_Essayer_Phrase
                                    SET tentative = 0, dateDerniereTentative = NULL, reussie = 0
                                    WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la suppression de la progression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Progression remise à zéro.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression de la progression de l'utilisateur.\n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        #endregion

        #region Mot
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement
        public static void InsertMot(string texte, int idClasse)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Mot (texte, idClasse) VALUES (@Texte, @idClasse)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Texte", texte));
                        command.Parameters.Add(new SqlParameter("@idClasse", idClasse));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion du mot.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Mot créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion du mot.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Mot> GetAllMotOrderByClasse()
        {
            try
            {
                List<Mot> listMot = new List<Mot>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select idMot,
                                            texte,
                                            Mot.idClasse as idClasse,
                                            Classe.libelle as libelleClasse,
                                            Classe.idType as idType,
                                            Type.libelle as libelleType
                                            from Mot inner join Classe on Mot.idClasse = Classe.idClasse inner join Type on Classe.idType = Type.idType
                                            order by idClasse, idType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Types type = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["libelleType"].ToString()
                                    };
                                    Classe classe = new Classe
                                    {
                                        IdClasse = reader["idClasse"].ToString(),
                                        Libelle = reader["libelleClasse"].ToString(),
                                        Types = type
                                    };
                                    Mot mot = new Mot
                                    {
                                        IdMot =reader["idMot"].ToString(),
                                        Texte = reader["texte"].ToString(),
                                        Classe = classe
                                    };
                                    listMot.Add(mot);
                                }
                            }
                        }
                    }
                }

                return listMot;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Mot> GetAllMotOrderByTexte()
        {
            try
            {
                List<Mot> listMot = new List<Mot>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select idMot,
                                            texte,
                                            Mot.idClasse as idClasse,
                                            Classe.libelle as libelleClasse,
                                            Classe.idType as idType,
                                            Type.libelle as libelleType
                                            from Mot inner join Classe on Mot.idClasse = Classe.idClasse inner join Type on Classe.idType = Type.idType
                                            order by texte";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Types type = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["libelleType"].ToString()
                                    };
                                    Classe classe = new Classe
                                    {
                                        IdClasse = reader["idClasse"].ToString(),
                                        Libelle = reader["libelleClasse"].ToString(),
                                        Types = type
                                    };
                                    Mot mot = new Mot
                                    {
                                        IdMot = reader["idMot"].ToString(),
                                        Texte = reader["texte"].ToString(),
                                        Classe = classe
                                    };
                                    listMot.Add(mot);
                                }
                            }
                        }
                    }
                }

                return listMot;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        #endregion

        #region Type
        public static void InsertType(string libelle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Type (libelle) VALUES (@Libelle)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Libelle", libelle));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion du type.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Type créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion du type.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Types> GetAllType()
        {
            try
            {
                List<Types> listTypes = new List<Types>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Type";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Types type = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["libelle"].ToString(),
                                    };
                                    listTypes.Add(type);
                                }
                            }
                        }
                    }
                }

                return listTypes;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region Classe
        public static void InsertClasse(string libelle, int idType)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Classe (libelle, idType) VALUES (@Libelle, @idType)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Libelle", libelle));
                        command.Parameters.Add(new SqlParameter("@idType", idType));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de la classe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Classe créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la classe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Classe> GetAllClasse()
        {
            try
            {
                List<Classe> listClasse = new List<Classe>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select idClasse,
                                            Classe.libelle as libelleClasse,
                                            Classe.idType as idType,
                                            Type.libelle as libelleType
                                            from Classe inner join Type on Classe.idType = Type.idType
                                            order by idType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Types type = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["libelleType"].ToString()
                                    };
                                    Classe classe = new Classe
                                    {
                                        IdClasse = reader["idClasse"].ToString(),
                                        Libelle = reader["libelleClasse"].ToString(),
                                        Types = type
                                    };
                                    listClasse.Add(classe);
                                }
                            }
                        }
                    }
                }

                return listClasse;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<String> GetDistinctClasse()
        {
            try
            {
                List<String> listDistinctLibelle = new List<String>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select DISTINCT libelle from Classe";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    String classe = reader["libelle"].ToString();
                                    listDistinctLibelle.Add(classe);
                                }
                            }
                        }
                    }
                }

                return listDistinctLibelle;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Classe> GetClasseByLibelleClasse(string classe)
        {
            try
            {
                List<Classe> listClasse = new List<Classe>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select idClasse,
                                            Classe.libelle as libelleClasse,
                                            Classe.idType as idType,
                                            Type.libelle as libelleType
                                            from Classe inner join Type on Classe.idType = Type.idType
                                            where Classe.libelle = @libelle";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@libelle", classe));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Types type = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["libelleType"].ToString()
                                    };
                                    Classe classes = new Classe
                                    {
                                        IdClasse = reader["idClasse"].ToString(),
                                        Libelle = reader["libelleClasse"].ToString(),
                                        Types = type
                                    };
                                    listClasse.Add(classes);
                                }
                            }
                        }
                    }
                }

                return listClasse;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération de tous les mots. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region Phrase
        /// <summary>
        /// Effectue un INSERT SQL d'une nouvelle <c>Phrase</c> dans la BDD.
        /// </summary>
        /// <param name="phrase"></param>
        /*public static void InsertPhrase(Phrase phrase)
        {
            string output = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Phrase (texte) OUTPUT inserted.idPhrase VALUES (@Texte)";
                    string query2 = @"INSERT INTO Phrase_Posseder_Mot (idPhrase, idMot, idFonction, position) VALUES (@IdPhrase, @IdMot, @IdFonction, @Position)";

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@Texte", phrase.Texte));
                            output = command.ExecuteScalar().ToString();

                            if (string.IsNullOrEmpty(output) || string.IsNullOrWhiteSpace(output))
                            {
                                transaction.Rollback();
                                MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        foreach (Mot mot in phrase.Mots)
                        {
                            using (SqlCommand command = new SqlCommand(query2, connection, transaction))
                            {
                                command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(output)));
                                command.Parameters.Add(new SqlParameter("@IdMot", Convert.ToInt32(mot.IdMot)));
                                command.Parameters.Add(new SqlParameter("@IdFonction", Convert.ToInt32(mot.Fonction.IdFonction)));
                                command.Parameters.Add(new SqlParameter("@Position", Convert.ToInt32(mot.Position)));
                                int result = command.ExecuteNonQuery();

                                if (result <= 0)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion de la phrase. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }*/

        /// <summary>
        /// Récupère toutes les Phrases non réussies par l'<c>Utilisateur</c>.
        /// </summary>
        /// <returns>
        /// La liste de toutes les phrases non réussies par l'utilisateur.
        /// </returns>
        public static List<Phrase> GetAllPhrasesNonReussiesByIdUtilisateur()
        {
            try
            {
                CultureInfo cultureInfo = new CultureInfo("fr-FR");
                List<Phrase> listPhrasesNonReussies = new List<Phrase>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string queryPhrasesNonReussies = @"SELECT uep.idPhrase AS idPhrase, uep.tentative AS tentative, uep.dateDerniereTentative AS derniereTentative, uep.reussie AS aEteReussie, 
                                                    p.consigne AS consigne, p.texte AS textePhrase
                                                    FROM Utilisateur_Essayer_Phrase uep
                                                    INNER JOIN Phrase p ON uep.idPhrase = p.idPhrase
                                                    WHERE uep.reussie = 0 AND uep.idUtilisateur = @IdUtilisateur";

                    string queryInfosDesPhrasesNonReussies = @"SELECT t.idType AS idType, t.libelle AS typeLibelle, 
                                                            c.idClasse AS idClasse, c.libelle AS classeLibelle, 
                                                            f.idFonction AS idFonction, f.libelle AS fonctionLibelle, 
                                                            m.idMot AS idMot, m.texte AS texteMot, 
                                                            ppm.position AS positionMot, ppm.motATrouver AS estLeMotATrouver
                                                            FROM Phrase_Posseder_Mot ppm
                                                            INNER JOIN Mot m ON ppm.idMot = m.idMot
                                                            INNER JOIN Classe c ON m.idClasse = c.idClasse
                                                            INNER JOIN Type t ON c.idType = t.idType
                                                            INNER JOIN Fonction f ON ppm.idFonction = f.idFonction
                                                            WHERE ppm.idPhrase = @IdPhrase";

                    // Récupération de toutes les phrases non réussies
                    using (SqlCommand command = new SqlCommand(queryPhrasesNonReussies, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(Global.Utilisateur.IdUtilisateur)));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Phrase phrase = new Phrase
                                    {
                                        IdPhrase = reader["idPhrase"].ToString(),
                                        Texte = reader["textePhrase"].ToString(),
                                        Consigne = reader["consigne"].ToString(),
                                        Tentative = Convert.ToInt32(reader["tentative"]),
                                        DateDerniereTentative = reader["derniereTentative"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["derniereTentative"], cultureInfo),
                                        AEteReussie = Convert.ToBoolean(reader["aEteReussie"])
                                    };

                                    listPhrasesNonReussies.Add(phrase);
                                }
                            }
                        }
                    }

                    // Récupération de toutes les infos des phrases non réussies récupérées juste avant
                    foreach (Phrase phrase in listPhrasesNonReussies)
                    {
                        using (SqlCommand command = new SqlCommand(queryInfosDesPhrasesNonReussies, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(phrase.IdPhrase)));

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        Fonction fonction = new Fonction
                                        {
                                            IdFonction = reader["idFonction"].ToString(),
                                            Libelle = reader["fonctionLibelle"].ToString()
                                        };
                                        Types types = new Types
                                        {
                                            IdTypes = reader["idType"].ToString(),
                                            Libelle = reader["typeLibelle"].ToString()
                                        };
                                        Classe classe = new Classe
                                        {
                                            IdClasse = reader["idClasse"].ToString(),
                                            Libelle = reader["classeLibelle"].ToString(),
                                            Types = types
                                        };
                                        Mot mot = new Mot
                                        {
                                            IdMot = reader["idMot"].ToString(),
                                            Texte = reader["texteMot"].ToString(),
                                            Classe = classe,
                                            Fonction = fonction,
                                            Position = reader["positionMot"].ToString(),
                                            EstATrouver = Convert.ToBoolean(reader["estLeMotATrouver"])
                                        };

                                        if (mot.EstATrouver)
                                            phrase.MotATrouver = mot;

                                        phrase.Mots.Add(mot);
                                    }
                                }
                            }
                        }
                    }
                }

                return listPhrasesNonReussies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des phrases non réussies. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Récupère toutes les phrases stockées dans la BDD.
        /// </summary>
        /// <returns>
        /// La liste de toutes les phrases dans la BDD.
        /// </returns>
        public static List<Phrase> GetAllPhrases()
        {
            try
            {
                List<Phrase> phrases = new List<Phrase>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string queryAllPhrases = @"SELECT p.idPhrase AS idPhrase, p.texte AS textePhrase, p.consigne AS consigne FROM Phrase p";
                    string queryInfosDesPhrases = @"SELECT t.idType AS idType, t.libelle AS typeLibelle, 
                                                c.idClasse AS idClasse, c.libelle AS classeLibelle, 
                                                f.idFonction AS idFonction, f.libelle AS fonctionLibelle, 
                                                m.idMot AS idMot, m.texte AS texteMot, 
                                                ppm.position AS positionMot, ppm.motATrouver AS estLeMotATrouver
                                                FROM Phrase_Posseder_Mot ppm
                                                INNER JOIN Mot m ON ppm.idMot = m.idMot
                                                INNER JOIN Classe c ON m.idClasse = c.idClasse
                                                INNER JOIN Type t ON c.idType = t.idType
                                                INNER JOIN Fonction f ON ppm.idFonction = f.idFonction
                                                WHERE ppm.idPhrase = @IdPhrase";

                    using (SqlCommand command = new SqlCommand(queryAllPhrases, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Phrase phrase = new Phrase
                                    {
                                        IdPhrase = reader["idPhrase"].ToString(),
                                        Texte = reader["textePhrase"].ToString(),
                                        Consigne = reader["consigne"].ToString()
                                    };

                                    phrases.Add(phrase);
                                }
                            }
                        }
                    }

                    // Récupération de toutes les infos des phrases récupérées juste avant
                    foreach (Phrase phrase in phrases)
                    {
                        using (SqlCommand command = new SqlCommand(queryInfosDesPhrases, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(phrase.IdPhrase)));

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        Fonction fonction = new Fonction
                                        {
                                            IdFonction = reader["idFonction"].ToString(),
                                            Libelle = reader["fonctionLibelle"].ToString()
                                        };
                                        Types types = new Types
                                        {
                                            IdTypes = reader["idType"].ToString(),
                                            Libelle = reader["typeLibelle"].ToString()
                                        };
                                        Classe classe = new Classe
                                        {
                                            IdClasse = reader["idClasse"].ToString(),
                                            Libelle = reader["classeLibelle"].ToString(),
                                            Types = types
                                        };
                                        Mot mot = new Mot
                                        {
                                            IdMot = reader["idMot"].ToString(),
                                            Texte = reader["texteMot"].ToString(),
                                            Classe = classe,
                                            Fonction = fonction,
                                            Position = reader["positionMot"].ToString(),
                                            EstATrouver = Convert.ToBoolean(reader["estLeMotATrouver"])
                                        };

                                        if (mot.EstATrouver)
                                            phrase.MotATrouver = mot;

                                        phrase.Mots.Add(mot);
                                    }
                                }
                            }
                        }
                    }
                }

                return phrases;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de récupérer toutes les phrases. \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Récupère une <c>Phrase</c> dans la BDD par le biais de son Id.
        /// </summary>
        /// <param name="idPhrase"></param>
        /// <returns>
        /// Une <c>Phrase</c>.
        /// </returns>
        public static Phrase GetPhraseById(string idPhrase)
        {
            try
            {
                Phrase phrase = new Phrase();
                CultureInfo cultureInfo = new CultureInfo("fr-FR");

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT ppm.idPhrase AS idPhrase, p.consigne AS consigne, p.texte AS textePhrase, 
                                    ppm.idMot AS idMot, m.texte AS texteMot, ppm.motATrouver AS estLeMotATrouver, ppm.position AS positionMot, 
                                    c.idClasse AS idClasse, c.libelle AS classeLibelle, 
                                    t.idType AS idType, t.libelle AS typeLibelle, 
                                    ppm.idFonction AS idFonction, f.libelle AS fonctionLibelle, 
                                    uep.tentative AS tentative, uep.dateDerniereTentative AS derniereTentative, uep.reussie AS aEteReussie
                                    FROM Phrase_Posseder_Mot ppm
                                    INNER JOIN Phrase p ON ppm.idPhrase = p.idPhrase
                                    INNER JOIN Mot m ON ppm.idMot = m.idMot 
                                    INNER JOIN Fonction f ON ppm.idFonction = f.idFonction
                                    INNER JOIN Classe c ON m.idClasse = c.idClasse
                                    INNER JOIN Type t ON c.idType = t.idType
                                    INNER JOIN Utilisateur_Essayer_Phrase uep ON p.idPhrase = uep.idPhrase
                                    WHERE ppm.idPhrase = @IdPhrase";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdPhrase", Convert.ToInt32(idPhrase)));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    phrase.IdPhrase = reader["idPhrase"].ToString();
                                    phrase.Texte = reader["textePhrase"].ToString();
                                    phrase.Consigne = reader["consigne"].ToString();
                                    phrase.Tentative = Convert.ToInt32(reader["tentative"]);
                                    phrase.DateDerniereTentative = Convert.ToDateTime(reader["derniereTentative"], cultureInfo);
                                    phrase.AEteReussie = Convert.ToBoolean(reader["aEteReussie"]);

                                    Fonction fonction = new Fonction
                                    {
                                        IdFonction = reader["idFonction"].ToString(),
                                        Libelle = reader["fonctionLibelle"].ToString()
                                    };
                                    Types types = new Types
                                    {
                                        IdTypes = reader["idType"].ToString(),
                                        Libelle = reader["typeLibelle"].ToString()
                                    };
                                    Classe classe = new Classe
                                    {
                                        IdClasse = reader["idClasse"].ToString(),
                                        Libelle = reader["classeLibelle"].ToString(),
                                        Types = types
                                    };
                                    Mot mot = new Mot
                                    {
                                        IdMot = reader["idMot"].ToString(),
                                        Texte = reader["texteMot"].ToString(),
                                        Classe = classe,
                                        Fonction = fonction,
                                        Position = reader["positionMot"].ToString(),
                                        EstATrouver = Convert.ToBoolean(reader["estLeMotATrouver"])
                                    };

                                    if (mot.EstATrouver)
                                        phrase.MotATrouver = mot;

                                    phrase.Mots.Add(mot);
                                }
                            }
                        }
                    }
                }

                return phrase;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération de la phrase " + idPhrase + ". \n" +
                                "Message : " + ex.Message + "\n" +
                                "InnerException : " + ex.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



        #endregion
        #region Fonction
        public static void InsertFonction(string libelle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Fonction (libelle) VALUES (@Libelle)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Libelle", libelle));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de la fonction.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Fonction créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la fonction.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<Fonction> GetAllFonction()
        {
            try
            {
                List<Fonction> listTypes = new List<Fonction>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Fonction";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Fonction fonction = new Fonction
                                    {
                                        IdFonction = reader["idFonction"].ToString(),
                                        Libelle = reader["libelle"].ToString(),
                                    };
                                    listTypes.Add(fonction);
                                }
                            }
                        }
                    }
                }

                return listTypes;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region Phrase
        public static void InsertPhrase(string phrase, string consigne)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Phrase (texte, consigne) VALUES (@Texte, @Consigne)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Texte", phrase));
                        command.Parameters.Add(new SqlParameter("@Consigne", consigne));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static List<int> GetLastIdPhrase()
        {
            try
            {
                List<int> id = new List<int>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"select top 1 idPhrase from Phrase order by idPhrase desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                        int idPhrase = Convert.ToInt32(reader["idPhrase"].ToString());
                                        id.Add(idPhrase);
                                }
                            }
                        }
                    }
                }

                return id;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void InsertPhrasePossederMot(int idPhrase, int idMot, int idFonction, int position, bool motATrouver)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Phrase_Posseder_Mot (idPhrase, idMot, idFonction, Position, motATrouver) VALUES (@idPhrase, @idMot, @idFonction, @Position, @motATrouver)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@idPhrase", idPhrase));
                        command.Parameters.Add(new SqlParameter("@idMot", idMot));
                        command.Parameters.Add(new SqlParameter("@idFonction", idFonction));
                        command.Parameters.Add(new SqlParameter("@Position", position));
                        command.Parameters.Add(new SqlParameter("@motATrouver", motATrouver));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static void fonctionTest(int idPhrase, int idMot, int idFonction, int position, bool motATrouver)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Phrase_Posseder_Mot (idPhrase, idMot, idFonction, Position, motATrouver) VALUES (@idPhrase, @idMot, @idFonction, @Position, @motATrouver)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@idPhrase", idPhrase));
                        command.Parameters.Add(new SqlParameter("@idMot", idMot));
                        command.Parameters.Add(new SqlParameter("@idFonction", idFonction));
                        command.Parameters.Add(new SqlParameter("@Position", position));
                        command.Parameters.Add(new SqlParameter("@motATrouver", motATrouver));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
    }
}
