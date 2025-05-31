namespace CyberQuiz_Lib
{
	/// <summary>
	/// Représente une réponse à la question
	/// </summary>
    public class Reponse
    {
        #region Propriétés

        private String _libelle;
		private int _numero;
		private bool _bonneReponse;

        #endregion

        #region Property

        /// <summary>
        /// Obtient le numéro de la réponse
        /// </summary>
        public int Numero
		{
			get { return _numero; }
			//set { _numero = value; }
		}

        /// <summary>
        /// Obtient le libellé de la réponse
        /// </summary>
        public String Libelle
		{
			get { return _libelle; }
			//set { _libelle = value; }
		}

        /// <summary>
        ///  Obtient vrai si c'est la bonne réponse, 
        ///  Faux sinon
        /// </summary>
        public bool BonneReponse
        {
            get { return _bonneReponse; }
            //set { _bonneReponse = value; }
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe Reponse 
        /// avec un libellé et un numéro
        /// </summary>
        /// <param name="libelle">libellé de la question</param>
        /// <param name="numero">numéro de la question</param>
        public Reponse(String libelle, int numero, bool bonneReponse)
		{ 
			_libelle = libelle;
			_numero = numero;
            _bonneReponse = bonneReponse;

        }


		#endregion

	}
}
