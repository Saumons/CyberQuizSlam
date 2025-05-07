namespace CyberQuiz_Lib
{
	/// <summary>
	/// 
	/// </summary>
    public class Reponse
    {
        #region Propriétés

        private String _libelle;
		private int _numero;

        #endregion

        #region Property

		/// <summary>
		/// Obtient le numéro de la question
		/// </summary>
        public int Numero
		{
			get { return _numero; }
			//set { _numero = value; }
		}

		/// <summary>
		/// Obtient le libellé de la question
		/// </summary>
		public String Libelle
		{
			get { return _libelle; }
			//set { _libelle = value; }
		}

        #endregion

        #region Constructeur

        /// <summary>
        /// Initialise une nouvelle instance de la classe Reponse en 
        /// avec un libellé et un numéro
        /// </summary>
        /// <param name="libelle">libellé de la question</param>
        /// <param name="numero">numéro de la question</param>
        public Reponse(String libelle, int numero)
		{ 
			_libelle = libelle;
			_numero = numero;
		}


		#endregion

	}
}
