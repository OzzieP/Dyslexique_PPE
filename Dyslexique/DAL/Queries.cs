using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dyslexique.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dyslexique.DAL
{
    public static class Queries
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DyslexiqueConnectionString"].ConnectionString;

        #region Utilisateur
        public static List<Utilisateur> GetAllUtilisateurs()
        {
            try
            {
                List<Utilisateur> utilisateurs = new List<Utilisateur>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS Pseudo, u.idRole AS idRole, r.libelle AS Rôle
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
                                        IdRole = reader["idRole"].ToString(),
                                        Role = reader["Rôle"].ToString()
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

        public static Utilisateur GetUtilisateurByPseudo(string pseudo)
        {
            try
            {
                Utilisateur utilisateur = new Utilisateur();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS pseudo, u.idRole AS idRole, r.libelle AS role
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
                                utilisateur.Pseudo = reader["pseudo"].ToString();
                                utilisateur.IdRole = reader["idRole"].ToString();
                                utilisateur.Role = reader["role"].ToString();
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

        public static Utilisateur GetUtilisateurById(string idUtilisateur)
        {
            try
            {
                Utilisateur utilisateur = new Utilisateur();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT u.idUtilisateur AS idUtilisateur, u.pseudo AS pseudo, u.idRole AS idRole, r.libelle AS role
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
                                utilisateur.Pseudo = reader["pseudo"].ToString();
                                utilisateur.IdRole = reader["idRole"].ToString();
                                utilisateur.Role = reader["role"].ToString();
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

        public static void InsertUtilisateur(string pseudo, string idRole)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Utilisateur (pseudo, idRole) VALUES (@Pseudo, @IdRole)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));
                        command.Parameters.Add(new SqlParameter("@IdRole", Convert.ToInt32(idRole)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static void UpdateUtilisateur(string idUtilisateur, string pseudo, string idRole)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur SET pseudo = @Pseudo, idRole = @IdRole WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));
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

        public static void DeleteUtilisateur(string idUtilisateur)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Utilisateur WHERE idUtilisateur = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static bool CheckIfTentativeExists(string idUtilisateur, string idPhrase)
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

        public static void InsertOrUpdateTentative(Utilisateur utilisateur, Phrase phrase, string date, bool reussie)
        {
            bool exists = CheckIfTentativeExists(utilisateur.IdUtilisateur, phrase.IdPhrase);

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
                            command.Parameters.Add(new SqlParameter("@Tentative", Convert.ToInt32(phrase.Tentative)));
                            command.Parameters.Add(new SqlParameter("@Date", date));
                            command.Parameters.Add(new SqlParameter("@Reussie", reussie));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                                MessageBox.Show("Erreur lors de la mise à jour de Utilisateur_Essayer_Phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(utilisateur.Pseudo + " mis à jour avec succès dans la table Utilisateur_Essayer_Phrase.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            command.Parameters.Add(new SqlParameter("@Tentative", Convert.ToInt32(phrase.Tentative)));
                            command.Parameters.Add(new SqlParameter("@Date", date));
                            command.Parameters.Add(new SqlParameter("@Reussie", reussie));
                            int result = command.ExecuteNonQuery();

                            if (result <= 0)
                                MessageBox.Show("Erreur lors de l'insertion de la tentative.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Tentative créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion

        #region Mot
        public static List<Mot> GetAllMots()
        {
            try
            {
                List<Mot> listMots = new List<Mot>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Mot";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Mot mot = new Mot
                                    {
                                        IdMot = reader["idMot"].ToString(),
                                        Texte = reader["texte"].ToString(),
                                        IdClasse = reader["idClasse"].ToString()
                                        //mot.IdGenre = reader["idGenre"].ToString());
                                    };

                                    listMots.Add(mot);
                                }
                            }
                        }
                    }
                }

                return listMots;
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
        public static void InsertPhrase(Phrase phrase)
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
        }

        public static Phrase GetPhraseById(string idPhrase)
        {
            try
            {
                Phrase phrase = new Phrase();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT p.idPhrase AS idPhrase, p.texte AS textePhrase, 
                                    ppm.idFonction AS idFonction, ppm.position AS position, 
                                    f.idFonction AS idFonction, f.libelle AS fonctionLibelle, 
                                    m.idMot AS idMot, m.texte AS texteMot, 
                                    c.idClasse AS idClasse, c.libelle AS classeLibelle, 
                                    t.idType AS idType, t.libelle AS typeLibelle
                                    FROM Phrase p
                                    INNER JOIN Phrase_Posseder_Mot ppm ON p.idPhrase = ppm.idPhrase
                                    INNER JOIN Mot m ON ppm.idMot = m.idMot
                                    INNER JOIN Fonction f ON ppm.idFonction = f.idFonction
                                    INNER JOIN Classe c ON m.idClasse = c.idClasse
                                    INNER JOIN Type t ON c.idType = t.idType
                                    WHERE p.idPhrase = @IdPhrase";

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
                                        Libelle = reader["typeLibelle"].ToString(),
                                        Types = types
                                    };
                                    Mot mot = new Mot
                                    {
                                        IdMot = reader["idMot"].ToString(),
                                        Texte = reader["texteMot"].ToString(),
                                        Classe = classe,
                                        Fonction = fonction,
                                        Position = reader["position"].ToString()
                                    };

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
    }
}
