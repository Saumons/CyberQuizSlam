using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// Représente le lien entre la table reponse et le code
    /// </summary>
    public class ReponseCRUD
    {

        #region Propriétés

        private SQLiteConnection _connection;

        #endregion

        #region Constructeur

        /// <summary>
        ///  Initialise une nouvelle instance de la classe ReponseCRUD 
        /// en ouvrant une connexion à la base de donnée et créant la 
        /// table reponse si pas existante
        /// </summary>
        public ReponseCRUD(SQLiteConnection connection)
        {
            //_connection = new SQLiteConnection("Data Source= 2025_Quiz_Cyber.sqlite;Version=3;");
            //_connection.Open();
            _connection = connection;
            CreerTable();
        }


        #endregion

        #region Méthodes

        /// <summary>
        /// Créer la table reponse si elle n'existe pas
        /// </summary>
        public void CreerTable()
        {
            string createTableQuery = " CREATE TABLE IF NOT EXISTS reponse( " +
             " Question_numero INTEGER NOT NULL, " +
             " Proposition_numero INTEGER NOT NULL, " +
             " BonneRep INTEGER NOT NULL ) ";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, _connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Récupère la liste des réponses d'une question
        /// </summary>
        /// <param name="numeroQuestion">Numéro de la question</param>
        /// <returns>Liste d'objet Reponse</returns>
        public List<Reponse> RecupReponses(int numeroQuestion)
        {
            List<Reponse> ReponsesSelect = new List<Reponse>();
            string query = "SELECT * FROM reponse WHERE Question_Numero = @numero";
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.Parameters.AddWithValue("@numero", numeroQuestion);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                bool BonneReponse;
                PropositionCRUD LienProposition = new PropositionCRUD(_connection);
                if (int.Parse(reader["Numero"].ToString()) == 1 )
                {
                    BonneReponse = true;
                }
                else {BonneReponse = false;}
                Reponse uneReponse = new Reponse(
                    //reader["Libelle"].ToString(),
                    LienProposition.RecupLibelleProposition(int.Parse(reader["Numero"].ToString())),
                    int.Parse(reader["Numero"].ToString()),
                    BonneReponse
                    ) ;
                ReponsesSelect.Add(uneReponse);
            }
            return ReponsesSelect;
        }
        #endregion

    }
}
