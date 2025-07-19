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
                string createTableQuery = "CREATE TABLE utilisateur (" +
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
            /// du pseudo et du mot de passe hasher
            /// </summary>
            /// <param name="motDePasse">Mot de passe du l'utilisateur hasher</param>
            /// <param name="pseudo">Pseudo de l'utilisateur</param>
            /// <returns>L'utilisateur voulu ou null si pas dans la base</returns>
            public Utilisateur GetUtilisateur(string motDePasse, string pseudo)
            {
                //utilisateur utilisateursSelect = new utilisateur();
                // Séléctionne l'utilisateur grâce au pseudo et à son mot de passe
                string query = "SELECT * FROM utilisateur WHERE Pseudo = @pseudo AND MotDePasse LIKE @motDePasse";
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

            public void CreateUtilisateur(string pseudo, string motDePasse)
            {
                // Créer un Utilisateur
                string insertQuery = "INSERT INTO utilisateurs (Pseudo, MotDePasse, " +
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

            public void UpdateUtilisateur(Utilisateur utilisateur)
            {
                // Mettre à jour un utilisateur
                string updateQuery = "UPDATE utilisateurs" +
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
            #endregion

        }
    }
}