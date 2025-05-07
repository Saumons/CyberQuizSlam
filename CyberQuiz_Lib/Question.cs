using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// 
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
        public List<Reponse> MyProperty
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
        /// Initialise une nouvelle instance de la classe Reponses en 
        /// avec un libellé et un numéro
        /// </summary>
        /// <param name="libelle">libellé de la question</param>
        /// <param name="numero">numéro de la question</param>
        public Question(String libelle, int numero)
        {
            _libelle = libelle;
            _numero = numero;
        }


        #endregion

        #region Méthodes

        private void RemplirReponse()
        {
            //Utilisé la classe CRUD
        }

        #endregion

    }
}
