using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// Créer un lien entre la table question et le code
    /// </summary>
    public class QuestionCRUD
    {

        #region Propriétés
        private SQLiteConnection _connection;
        #endregion

        

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe QuestionCRUD 
        /// en ouvrant une connexion à la base de donnée et créant la 
        /// table question si pas existante
        /// </summary>
        public QuestionCRUD()
        {
            _connection = new SQLiteConnection("Data Source= 2025_Quiz_Cyber.sqlite;Version=3;");
            _connection.Open();
            CreerTable();
        }


        #endregion

        #region Méthodes

        /// <summary>
        /// Créer la table question si elle n'existe pas
        /// </summary>
        public void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS question ( " +
                 " Numero INTEGER NOT NULL," +
                 " Libelle TEXT NOT NULL," +
                 " NiveauDifficulte_id TEXT NOT NULL," +
                 " Theme_numero TEXT NOT NULL )";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, _connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Recupère une liste de questions en fonction
        /// du thème et de la difficulté choisi pour le quiz
        /// </summary>
        /// <param name="theme">Thème du quiz</param>
        /// <param name="difficulte">Difficulté du quiz</param>
        /// <returns>La liste des questions séléctionnées</returns>
        public List<Question> ChoixQuestion(string theme, string difficulte, int nbQuestion)
        {
            Random rand = new Random();
            List<Question> QuestionsSelect = new List<Question>();
            int TailleListe;
            string query = "SELECT * FROM question WHERE NiveauDifficulte_id = @difficulte AND Theme_numero LIKE @theme";
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.Parameters.AddWithValue("@theme", "%" + theme + "%");
            command.Parameters.AddWithValue("@difficulte", difficulte);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Question uneQuestion = new Question(
                     NettoyerLibelle(reader["Libelle"].ToString()),
                    int.Parse(reader["Numero"].ToString()),
                    _connection
                      );
                QuestionsSelect.Add(uneQuestion);   
            }
            TailleListe = QuestionsSelect.Count();
            //Mélange et réduit la liste a la taille désiré
            QuestionsSelect.Sort((x, y) => rand.Next(-1, 2));
            for (int i = nbQuestion; i < TailleListe; i++)
            {
                QuestionsSelect.RemoveAt(nbQuestion);
            }
            reader.Close();
            return QuestionsSelect;
              
        }

        /// <summary>
        /// Nettoie le libellé en supprimant les caractères indésirables
        /// </summary>
        /// <param name="libelle">Le libellé à nettoyer</param>
        /// <returns>Le libellé nettoyé</returns>
        private string NettoyerLibelle(string libelle)
        {
            if (string.IsNullOrEmpty(libelle))
                return libelle;

            // Remplace les séquences d'échappement courantes
            return libelle
                .Replace("\\r", "")     // Supprime \r
                .Replace("\\n", " ")    // Remplace \n par un espace
                .Replace("\\t", " ")    // Remplace \t par un espace
                .Replace("\r", "")      // Supprime les vrais retours chariot
                .Replace("\n", " ")     // Remplace les vrais sauts de ligne par un espace
                .Replace("\t", " ")     // Remplace les vraies tabulations par un espace
                .Replace("''", "'")     // Remplace les doubles apostrophes par une seule
                .Replace("  ", " ")     // Remplace les doubles espaces par un seul
                .Replace("')", "")     // Supprime les parenthèses et cotes de fin
                .Trim();                // Supprime les espaces en début et fin
        }

        #endregion

    }
}
