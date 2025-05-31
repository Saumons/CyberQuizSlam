using CyberQuizz_App;

namespace CyberQuiz_App
{
    public partial class Form_Accueil : Form
    {
        string pseudo;
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
            pseudo = textbox_pseudo.Text;

            Form_Choix uneFenetre = new Form_Choix(pseudo);
            uneFenetre.ShowDialog();
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
