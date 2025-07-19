using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CyberQuiz_Lib
{
    public class UtilisateurCRUD
    {
        /// <summary>
        /// Créer un lien entre la table utilisateur et le code
        /// </summary>
        public class utilisateurCRUD
        {

            #region Propriétés
            private SQLiteConnection _connection;
            #endregion



            #region Constructeur

            /// <summary>
            /// Initialise une nouvelle instance de la classe utilisateurCRUD 
            /// en ouvrant une connexion à la base de donnée et créant la 
            /// table utilisateur si pas existante
            /// </summary>
            public utilisateurCRUD()
            {
                _connection = new SQLiteConnection("Data Source= 2025_Quiz_Cyber.sqlite;Version=3;");
                _connection.Open();
                CreerTable();
            }


            #endregion

            #region Méthodes

            /// <summary>
            /// Créer la table utilisateur si elle n'existe pas
            /// </summary>
            public void CreerTable()
            {
                String createTableQuery = "CREATE TABLE utilisateur (" +
                    "Pseudo    TEXT, NOT NULL" +
                    "MotDePasse   TEXT, NOT NULL" +
                    "HighScoreDifficileResaux  REAL," +
                    "HighScoreDifficileCulture  REAL," +
                    "HighScoreDifficileEntreprise  REAL," +
                    "HighScoreMoyenResaux  REAL," +
                    "HighScoreMoyenCulture REAL," +
                    "HighScoreMoyenEntreprise  REAL," +
                    "HighScoreFacileResaux REAL," +
                    "HighScoreFacileEntreprise REAL," +
                    "HighScoreFacileCulture    REAL," +
                    "Admin    INTEGER," +
                   " PRIMARY KEY('Pseudo'))";
                SQLiteCommand command = new SQLiteCommand(createTableQuery, _connection);
                command.ExecuteNonQuery();
            }


            /// <summary>
            /// Recupère l'utilisateur en fonction
            /// du pseudo et du mot de passe hashé
            /// </summary>
            /// <param name="motDePasse">Mot de passe du l'utilisateur hasher</param>
            /// <param name="pseudo">Pseudo de l'utilisateur</param>
            /// <returns>L'utilisateur voulu ou null si pas dans la base</returns>
            public Utilisateur GetUtilisateur(String motDePasse, String pseudo)
            {
                //utilisateur utilisateursSelect = new utilisateur();
                // Séléctionne l'utilisateur grâce au pseudo et à son mot de passe
                String query = "SELECT * FROM utilisateur WHERE Pseudo = @pseudo AND MotDePasse LIKE @motDePasse";
                SQLiteCommand command = new SQLiteCommand(query, _connection);
                command.Parameters.AddWithValue("@motDePasse", motDePasse);
                command.Parameters.AddWithValue("@pseudo", pseudo);
                SQLiteDataReader reader = command.ExecuteReader();

                // Teste si l'utilisateur est dans la base de données
                if (reader.Read())
                {
                    Utilisateur utilisateurSelect = new Utilisateur(
                            reader["Pseudo"].ToString(),
                            reader["motDePasse"].ToString(),
                            float.Parse(reader["HighScoreDifficileResaux"].ToString()),
                            float.Parse(reader["HighScoreDifficileCulture"].ToString()),
                            float.Parse(reader["HighScoreDifficileEntreprise"].ToString()),
                            float.Parse(reader["HighScoreMoyenResaux"].ToString()),
                            float.Parse(reader["HighScoreMoyenCulture"].ToString()),
                            float.Parse(reader["HighScoreMoyenEntreprise"].ToString()),
                            float.Parse(reader["HighScoreFacileResaux"].ToString()),
                            float.Parse(reader["HighScoreFacileEntreprise"].ToString()),
                            float.Parse(reader["HighScoreFacileCulture"].ToString()),
                            int.Parse(reader["Admin"].ToString()),
                            _connection
                            );
                }
                else
                {
                    utilisateurSelect = null;
                }

                reader.Close();
                return utilisateurSelect;

            }


            /// <summary>
            /// Recupère les utilisateurs ayant les
            /// meilleurs HighScore de ce thème et difficulté
            /// </summary>
            /// <param name="motDePasse">Mot de passe du l'utilisateur hasher</param>
            /// <param name="pseudo">Pseudo de l'utilisateur</param>
            /// <returns>L'utilisateur voulu ou null si pas dans la base</returns>
            public List<Utilisateur> GetUtilisateurListe(String theme, String difficulte, int nbHighScore)
            {
                String nomHighScore;
                List<Utilisateur> ListeUtilisateurs = new List<Utilisateur>();

                // Créer le nom du champ HighScore voulue en fonction du thème et de la difficulté
                //tout en respectant la casse du champ dans la base
                nomHighScore = "HighScore" 
                    // Permet de s'assurer que le premier caractère de la difficulté est en majuscule et le reste en minuscule
                    + char.ToUpper(difficulte[0]) + (difficulte.Substring(1)).ToLower()
                    // Permet de s'assurer que le premier caractère du thème est en majuscule et le reste en minuscule
                    + char.ToUpper(theme[0]) + (theme.Substring(1)).ToLower();
               
                // Séléctionne le pseudo et le HighScore voulue des utilisateur
                // ayant les meilleurs HighScore
                String query = "SELECT Pseudo, @nomHighScore FROM utilisateur" +
                                "ORDER BY @nomHighScore " +
                                "LIMIT @nbHighScore";
                SQLiteCommand command = new SQLiteCommand(query, _connection);
                command.Parameters.AddWithValue("@nomHighScore", theme);
                command.Parameters.AddWithValue("@nbHighScore", nbHighScore);
                SQLiteDataReader reader = command.ExecuteReader();

                // Récupère les données des HighScore et le pseudo des joueurs ayant le meilleurs score sur ce thème et difficulté
                while (reader.Read())
                {
                    Utilisateur utilisateurSelect = new Utilisateur(
                            reader["Pseudo"].ToString(),
                            float.Parse(reader[nomHighScore].ToString()),
                            _connection
                            );
                    listeUtilisateurs.Add(utilisateurSelect);
                }
                reader.Close();
                return utilisateurSelect;

            }


            /// <summary>
            /// Recupère tous les utilisateurs de la base
            /// de donnée. Utilisable uniquement si 
            /// l'utilisateur connecté est un admin
            /// </summary>
            /// <param name="utilisateurConnecte">Utilisateur actulelement connecté</param>
            /// <returns>Liste de tous les utilisateur exisistant par ordre 
            /// alphabétique des pseudo ou nul si l'utilisateurconnecté n'est pas admin</returns>
            public List<Utilisateur> GetUtilisateurListeAdmin(Utilisateur utilisateurConnecte)
            {
                List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();

                // Test si l'utilisateur est admin
                if (utilisateurConnecte.Admin)
                {
                    // Séléctionne tous les utilisateurs de la base de donnée
                    String query = "SELECT * FROM utilisateur ORDER BY pseudo";
                    SQLiteCommand command = new SQLiteCommand(query, _connection);
                    command.Parameters.AddWithValue("@pseudo", pseudo);
                    SQLiteDataReader reader = command.ExecuteReader();

                    // Récupère les données de tous les utilisateurs de la bases et les mets dans des objet de type Utilisateur
                    while (reader.Read())
                    {
                        Utilisateur utilisateurSelect = new Utilisateur(
                                reader["Pseudo"].ToString(),
                                reader["motDePasse"].ToString(),
                                float.Parse(reader["HighScoreDifficileResaux"].ToString()),
                                float.Parse(reader["HighScoreDifficileCulture"].ToString()),
                                float.Parse(reader["HighScoreDifficileEntreprise"].ToString()),
                                float.Parse(reader["HighScoreMoyenResaux"].ToString()),
                                float.Parse(reader["HighScoreMoyenCulture"].ToString()),
                                float.Parse(reader["HighScoreMoyenEntreprise"].ToString()),
                                float.Parse(reader["HighScoreFacileResaux"].ToString()),
                                float.Parse(reader["HighScoreFacileEntreprise"].ToString()),
                                float.Parse(reader["HighScoreFacileCulture"].ToString()),
                                int.Parse(reader["Admin"].ToString()),
                                _connection
                                );
                        listeUtilisateurs.Add(utilisateurSelect);
                    }
                    reader.Close();
                }
                // Si l'utilisateur connecté n'est pas admin
                else
                {
                    listeUtilisateurs = null;
                }

                return listeUtilisateurs;
            }


            /// <summary>
            /// Créer un nouvel utilisateur s'il n'existe pas,
            /// avec un pseudo et un mot de passe
            /// </summary>
            /// <param name="pseudo">Pseudo de l'utilisateur à créer</param>
            /// <param name="motDePasse">Mot de passe hashé de l'utilisateur à créer</param>
            public void CreateUtilisateur(String pseudo, String motDePasse)
            {
                if (String.IsNullOrEmpty(pseudo) && String.IsNullOrEmpty(motDePasse) && GetUtilisateur(motDePasse, pseudo) == null)
                {
                    // Créer un Utilisateur
                    String insertQuery = "INSERT INTO utilisateurs (Pseudo, MotDePasse, " +
                                        "HighScoreDifficileResaux,HighScoreDifficileCulture,HighScoreDifficileEntreprise," +
                                        "HighScoreMoyenResaux,HighScoreMoyenCulture,HighScoreMoyenEntreprise," +
                                        "HighScoreFacileResaux,HighScoreFacileEntreprise,HighScoreFacileCulture,admin) " +
                                        "VALUES (@Pseudo, @MotDePasse, " +
                                        "@HighScoreDifficileResaux,@HighScoreDifficileCulture,@HighScoreDifficileEntreprise," +
                                        "@HighScoreMoyenResaux,@HighScoreMoyenCulture,@HighScoreMoyenEntreprise," +
                                        "@HighScoreFacileResaux,@HighScoreFacileEntreprise,@HighScoreFacileCulture,@admin)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, _connection))
                    {
                        command.Parameters.AddWithValue("@Pseudo", pseudo);
                        command.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        command.Parameters.AddWithValue("@HighScoreDifficileResaux", 0);
                        command.Parameters.AddWithValue("@HighScoreDifficileCulture", 0);
                        command.Parameters.AddWithValue("@HighScoreDifficileEntreprise", 0);
                        command.Parameters.AddWithValue("@HighScoreMoyenResaux", 0);
                        command.Parameters.AddWithValue("@HighScoreMoyenCulture", 0);
                        command.Parameters.AddWithValue("@HighScoreMoyenEntreprise", 0);
                        command.Parameters.AddWithValue("@HighScoreFacileResaux", 0);
                        command.Parameters.AddWithValue("@HighScoreFacileEntreprise", 0);
                        command.Parameters.AddWithValue("@HighScoreFacileCulture", 0);
                        command.Parameters.AddWithValue("@admin", 0);
                    }
                }

            }


            /// <summary>
            /// Modifie le mot de passe ou/et les HighScore
            /// de l'utilisateur.
            /// </summary>
            /// <param name="utilisateur"> Utilisateur à modifier</param>
            public void UpdateUtilisateur(Utilisateur utilisateur)
            {
                // Mettre à jour un utilisateur
                String updateQuery = "UPDATE utilisateurs" +
                                    "SET (MotDePasse = @MotDePasse" +
                                    "HighScoreDifficileResaux = @HighScoreDifficileResaux," +
                                    "HighScoreDifficileCulture = @HighScoreDifficileCulture," +
                                    "HighScoreDifficileEntreprise = @HighScoreDifficileEntreprise," +
                                    "HighScoreMoyenResaux = @HighScoreMoyenResaux," +
                                    "HighScoreMoyenCulture = @HighScoreMoyenCulture," +
                                    "HighScoreMoyenEntreprise = @HighScoreMoyenEntreprise," +
                                    "HighScoreFacileResaux = @HighScoreFacileResaux," +
                                    "HighScoreFacileEntreprise = @HighScoreFacileEntreprise," +
                                    "HighScoreFacileCulture = @HighScoreFacileCulture)";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, _connection))
                {
                    command.Parameters.AddWithValue("@MotDePasse", utilisateur.MotDePasse);
                    command.Parameters.AddWithValue("@HighScoreDifficileResaux", utilisateur.HighScoreDifficileResaux);
                    command.Parameters.AddWithValue("@HighScoreDifficileCulture", utilisateur.HighScoreDifficileCulture);
                    command.Parameters.AddWithValue("@HighScoreDifficileEntreprise", utilisateur.HighScoreDifficileEntreprise);
                    command.Parameters.AddWithValue("@HighScoreMoyenResaux", utilisateur.HighScoreMoyenResaux);
                    command.Parameters.AddWithValue("@HighScoreMoyenCulture", utilisateur.HighScoreMoyenCulture);
                    command.Parameters.AddWithValue("@HighScoreMoyenEntreprise", utilisateur.HighScoreMoyenEntreprise);
                    command.Parameters.AddWithValue("@HighScoreFacileResaux", utilisateur.HighScoreFacileResaux);
                    command.Parameters.AddWithValue("@HighScoreFacileEntreprise", utilisateur.HighScoreFacileEntreprise);
                    command.Parameters.AddWithValue("@HighScoreFacileCulture", utilisateur.HighScoreFacileCulture);
                }
            }


            /// <summary>
            /// Supprime l'utilisateur en fonction d'un objet
            /// de type utilisateur
            /// </summary>
            /// <param name="utilisateur">Utilisateur à supprimer</param>
            public void DeleteUtilisateur(Utilisateur utilisateur)
            {

                String deleteQuery = "DELETE FROM utilisateurs WHERE Pseudo = @Pseudo";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, _connection))
                {
                    command.Parameters.AddWithValue("@Pseudo", utilisateur.Pseudo);
                }


            }


            /// <summary>
            ///  Supprime l'utilisateur en fonction de son pseudo.
            ///  Utilisable uniquement si l'utilisateur connecté est un admin.
            /// </summary>
            /// <param name="pseudo">Pseudo de l'utilisateur à supprimer</param>
            /// <param name="utilisateurConnecte">Utilisateur actuelement connecté</param>
            /// <returns></returns>
            public bool DeleteUtilisateurAdmin(String pseudo, Utilisateur utilisateurConnecte)
            {
                bool estSupprime = true;
                // Test si l'utilisateur connecté est admin
                if (Utilisateur.Admin)
                {
                    String deleteQuery = "DELETE FROM utilisateurs WHERE Pseudo = @Pseudo";

                    using (SQLiteCommand command = new SQLiteCommand(deleteQuery, _connection))
                    {
                        command.Parameters.AddWithValue("@Pseudo", pseudo);
                    }
                }
                // Si l'utilisateur connecté n'est pas admin
                else
                {
                    estSupprime = false;
                }
                return estSupprime;
            }

            #endregion

        }
    }
}