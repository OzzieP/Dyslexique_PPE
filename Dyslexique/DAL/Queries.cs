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
                                        IdType = Convert.ToInt32(reader["idType"].ToString()),
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
                    string query = @"select idClasse, Classe.libelle as libelleClasse, Classe.idType as idType, Type.libelle as libelleType from Classe inner join Type on Classe.idType = Type.idType";

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
                                        IdType = Convert.ToInt32(reader["idType"].ToString()),
                                        Libelle = reader["libelleType"].ToString()
                                    };
                                    Classe classe = new Classe
                                    {
                                        IdClasse = Convert.ToInt32(reader["idClasse"].ToString()),
                                        Libelle = reader["libelleClasse"].ToString(),
                                        Type = type
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



        #endregion
    }
}
