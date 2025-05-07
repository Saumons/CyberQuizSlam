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
    public class Quiz
    {
        #region Propriétés

        private List<Question> _questions;
        private String _joueur;
        private String _theme;
        private String _difficulte;

        public String Difficulte
        {
            get { return _difficulte; }
            set { _difficulte = value; }
        }


        public String Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }


        public String Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }


        public List<Question> Question
        {
            get { return _questions; }
            set { _questions = value; }
        }


        #endregion

        #region Property



        #endregion

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe Reponses en 
        /// avec un libellé et un numéro
        /// </summary>
        /// <param name="libelle">libellé de la question</param>
        /// <param name="numero">numéro de la question</param>
        public QuestionCRUD(String libelle, int numero)
        {

        }


        #endregion

        #region Méthodes


        #endregion

    }
}
