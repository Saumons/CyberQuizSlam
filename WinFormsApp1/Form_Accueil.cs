using CyberQuizz_App;

namespace CyberQuiz_App
{
    public partial class Form_Accueil : Form
    {
        public Form_Accueil()
        {
            InitializeComponent();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_entrer_quiz_Click(object sender, EventArgs e)
        {
            Form_Choix uneFenetre = new Form_Choix();
            uneFenetre.ShowDialog();
        }

        //             form_regles uneFenetre = new form_regles();
        //             uneFenetre.ShowDialog();
        // Pour les regles

    }
}
