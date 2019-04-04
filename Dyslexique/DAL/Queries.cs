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
                    string query = @"SELECT * FROM Utilisateur";

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
                                        IdUtilisateur = Convert.ToInt32(reader["idUtilisateur"].ToString()),
                                        Pseudo = reader["pseudo"].ToString(),
                                        IdRole = Convert.ToInt32(reader["idRole"].ToString())
                                    };

                                    utilisateurs.Add(utilisateur);
                                }
                            }
                        }
                    }
                }

                return utilisateurs;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de récupérer tous les utilisateurs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = @"SELECT * FROM Utilisateur WHERE pseudo = @Pseudo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Pseudo", pseudo));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                utilisateur.IdUtilisateur = Convert.ToInt32(reader["idUtilisateur"].ToString());
                                utilisateur.Pseudo = reader["pseudo"].ToString();
                                utilisateur.IdRole = Convert.ToInt32(reader["idRole"].ToString());
                            }
                        }
                    }
                }

                return utilisateur;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void InsertUtilisateur(string pseudo, int idRole)
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
                        command.Parameters.Add(new SqlParameter("@IdRole", idRole));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
                                        IdMot = Convert.ToInt32(reader["idMot"].ToString()),
                                        Texte = reader["texte"].ToString(),
                                        IdClasse = Convert.ToInt32(reader["idClasse"].ToString())
                                        //mot.IdGenre = Convert.ToInt32(reader["idGenre"].ToString());
                                    };

                                    listMots.Add(mot);
                                }
                            }
                        }
                    }
                }

                return listMots;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #endregion

    }
}
