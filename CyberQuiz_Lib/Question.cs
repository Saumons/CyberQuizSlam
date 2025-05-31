using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// Représente une question du quiz
    /// </summary>
    public class Question
    {
        #region Propriétés

        private String _libelle;
        private List<Reponse> _reponses;
        private int _numero;

        #endregion

        #region Property

        /// <summary>
        /// Obtient la liste des réponses de la question
        /// </summary>
        public List<Reponse> Reponses 
        {
            get { return _reponses; }
            //set { _reponses = value; }
        }

        /// <summary>
        /// Obtient le libelle de la question
        /// </summary>
        public String Libelle
        {
            get { return _libelle; }
            //set { _libelle = value; }
        }

        /// <summary>
        /// Obtient le numéro de la question
        /// </summary>
        public int Numero
        {
            get { return _numero; }
            //set { _numero = value; }
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe Question 
        /// avec un libellé et un numéro. Et en initialisant la liste
        /// de réponse grâce à la BDD
        /// </summary>
        /// <param name="libelle">libellé de la question</param>
        /// <param name="numero">numéro de la question</param>
        public Question(String libelle, int numero, SQLiteConnection connexion)
        {
            _libelle = libelle;
            _numero = numero;
            _reponses = new List<Reponse>();
            RemplirReponse(connexion);
        }


        #endregion

        #region Méthodes

        //Remplit la liste des réponses grâce à la BDD
        private void RemplirReponse(SQLiteConnection connexion)
        {
            ReponseCRUD LienReponse = new ReponseCRUD(connexion);
            _reponses = LienReponse.RecupReponses(_numero);
        }

        #endregion

    }
}
