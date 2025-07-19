using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberQuiz_Lib
{
    public class Utilisateur
    {
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
        #region Propriétés
           
        private String _pseudo;
        private String _motDePasse;
        private float _highScoreDifficileResaux;
        private float _highScoreDifficileCulture;
        private float _highScoreDifficileEntreprise;
        private float _highScoreMoyenResaux;
        private float _highScoreMoyenCulture;
        private float _highScoreMoyenEntreprise;
        private float _highScoreFacileResaux;
        private float _highScoreFacileEntreprise;
        private float _highScoreFacileCulture;
        private int _admin;     //Transfo en bool et faire le calcule avant de l'insérer dans l'objet




        #endregion

        #region Property

        /// <summary>
        /// Obtient vrai si l'utilisateur est un admin faux sinon
        /// </summary>
        public int Admin
        {
            get
            {
                bool resu;
                if (_admin == 1) { resu = true; }
                else { resu = false; }
                return resu;
            }
            //set { _admin = value; }
        }

        /// <summary>
        /// Obtient ou modifie le high score pour 
        /// la difficulté facile et le thème Culture
        /// </summary>
        public float HighScoreFacileCulture
        {
            get { return _highScoreFacileCulture; }
            set { _highScoreFacileCulture = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreFacileEntreprise
        {
            get { return _highScoreFacileEntreprise; }
            set { _highScoreFacileEntreprise = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreFacileResaux
        {
            get { return _highScoreFacileResaux; }
            set { _highScoreFacileResaux = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreMoyenEntreprise
        {
            get { return _highScoreMoyenEntreprise; }
            set { _highScoreMoyenEntreprise = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreMoyenCulture
        {
            get { return _highScoreMoyenCulture; }
            set { _highScoreMoyenCulture = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreMoyenResaux
        {
            get { return _highScoreMoyenResaux; }
            set { _highScoreMoyenResaux = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreDifficileEntreprise
        {
            get { return _highScoreDifficileEntreprise; }
            set { _highScoreDifficileEntreprise = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        public float HighScoreDifficileCulture
        {
            get { return _highScoreDifficileCulture; }
            set { _highScoreDifficileCulture = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float HighScoreDifficileResaux
        {
            get { return _highScoreDifficileResaux; }
            set { _highScoreDifficileResaux = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String MyPrMotDePasseoperty
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }

        #endregion

        #region Constructeur




        #endregion

        #region Méthodes


        #endregion
    }
}
