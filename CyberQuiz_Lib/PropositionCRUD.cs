using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// Représente le lien entre la table proposition et le code
    /// </summary>
    public class PropositionCRUD
    {


        #region Propriétés

        private SQLiteConnection _connection;

        #endregion

        #region Constructeur

        /// <summary>
        ///  Initialise une nouvelle instance de la classe PropositionCRUD 
        /// en ouvrant une connexion à la base de donnée et créant la 
        /// table proposition si pas existante
        /// </summary>
        public PropositionCRUD(SQLiteConnection connection)
        {
            //connection = new SQLiteConnection("Data Source= 2025_Quiz_Cyber.sqlite;Version=3;");
            //connection.Open();
            _connection = connection;
            CreerTable();
        }


        #endregion

        #region Méthodes

        /// <summary>
        /// Créer la table proposition si elle n'existe pas
        /// </summary>
        public void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS propositions (" +
             " `Numero` INTEGER NOT NULL," +
             " `Libelle` TEXT(250) NOT NULL ) ";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, _connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Récupère le libellé de la proposition grâce à son numéro
        /// </summary>
        /// <param name="numeroProposition">numéro de la proposition</param>
        /// <returns>libellé de la proposition nettoyé</returns>
        public string RecupLibelleProposition(int numeroProposition)
        {
            string libelle = "";
            string query = "SELECT Libelle FROM propositions WHERE Numero = @numero";
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.Parameters.AddWithValue("@numero", numeroProposition);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                libelle = reader["Libelle"].ToString();
                libelle = NettoyerLibelle(libelle);
            }
            reader.Close();
            return libelle;
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
