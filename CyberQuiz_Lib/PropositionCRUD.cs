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
        /// Récupère le libellé de la prosition grâce à son numéro
        /// </summary>
        /// <param name="numeroProposition">numéro de la proposition</param>
        /// <returns>libellé de la proposition</returns>
        public string RecupLibelleProposition(int numeroProposition)
        {
            string PropositionsQuestion;
            string query = "SELECT * FROM propositions WHERE Numero = @numero";
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.Parameters.AddWithValue("@numero", numeroProposition);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader["Libelle"].ToString();
            
            
        }
        #endregion

    }
}
