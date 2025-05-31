using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberQuiz_Lib
{
    /// <summary>
    /// Représente un quiz
    /// </summary>
    public class Quiz
    {
        #region Propriétés

        private List<Question> _questions;
        private String _joueur;
        private String _theme;
        private String _difficulte;
        private int _nbQuestions;
        private int _numQuestion;

        #endregion

        #region Property

        /// <summary>
        /// Obtient le nombre de question du quiz
        /// </summary>
        public int NbQuestions
        {
            get { return _nbQuestions; }
            //set { _nbQuestions = value; }
        }

        /// <summary>
        /// Obtient la difficulté du quiz
        /// </summary>
        public String Difficulte
        {
            get { return _difficulte; }
            //set { _difficulte = value; }
        }

        /// <summary>
        /// Obtient le thème du quiz
        /// </summary>
        public String Theme
        {
            get { return _theme; }
            //set { _theme = value; }
        }

        /// <summary>
        /// Obtient le nom du joueur du quiz
        /// </summary>
        public String Joueur
        {
            get { return _joueur; }
            //set { _joueur = value; }
        }

        /// <summary>
        /// Obtient la liste des questions du quiz
        /// </summary>
        public List<Question> Questions
        {
            get { return _questions; }
            //set { _questions = value; }
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe Quiz
        /// avec un nom de joueur, un thème, une difficulté et 
        /// un nombre de question. Et en initialisant la liste
        /// de questions grâce à la BDD, et le numero de question
        /// à 0
        /// </summary>
        /// <param name="joueur">Nom du joueur</param>
        /// <param name="theme">Thème du quiz</param>
        /// <param name="difficulte">Difficulté du quiz</param>
        /// <param name="nbQuestions">Nombre de question du quiz</param>
        public Quiz(String joueur, String theme, String difficulte, int nbQuestions)
        {
            _joueur = joueur;
            _theme = theme;
            _difficulte = difficulte;
            _nbQuestions = nbQuestions;
            _questions = new List<Question>();
            RemplirQuestions();
            _numQuestion = 0;
        }


        #endregion

        #region Méthodes

        //Remplit la liste des questions grâce à la BDD
        private void RemplirQuestions()
        {
            QuestionCRUD questionCRUD = new QuestionCRUD();
            _questions = questionCRUD.ChoixQuestion(_theme, _difficulte);
        }

        /// <summary>
        /// Test les réponses à la question actuel et
        /// renvoie la bonne réponse
        /// </summary>
        /// <returns>la bonne réponse</returns>
        public Reponse TestReponses()
        {
            Question QuestionActuel = _questions[_numQuestion];
            int cpt = 0;
            while (QuestionActuel.Reponses[cpt].BonneReponse && cpt < 4) {cpt++; }
            return QuestionActuel.Reponses[cpt];
        }

        /// <summary>
        /// Test si la partie est finis.
        /// </summary>
        /// <returns>Vrai si la partie est fini, faux sinon</returns>
        public bool TestPartiFini()
        {
            return (_nbQuestions < _numQuestion);
        }

        public Question QuestionSuivante()
        {   
            _numQuestion++;
            return _questions[_numQuestion]; 
        }
        #endregion

    }
}
