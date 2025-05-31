using CyberQuiz_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberQuizz_App
{
    public partial class Form_Jeu : Form
    {
        Quiz quiz_actuel;

        Question question_actuelle;
        List<Question> toute_questions;

        int nbQuestion;

        public Form_Jeu(string theme, string diff)
        {
            InitializeComponent();

            nbQuestion = 15;

            //label_nombre_question.Text = quiz_actuel.NbQuestions.ToString();

            QuestionCRUD question_actuelle = new QuestionCRUD();

            List<Question> toute_questions = new List<Question>();
            toute_questions = question_actuelle.ChoixQuestion(theme, diff, nbQuestion);
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            // On retire la bordure des boutons
            button_a.FlatAppearance.BorderSize = 0;
            button_b.FlatAppearance.BorderSize = 0;
            button_c.FlatAppearance.BorderSize = 0;
            button_d.FlatAppearance.BorderSize = 0;

            // On met la bordure du bouton cliqué à 2 et on change le texte de la question
            Button unBouton = (Button)sender;
            unBouton.FlatAppearance.BorderSize = 2;

            button_valider.Enabled = true;
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            if (button_valider.Text == "Question suivante")
            {
                button_valider.Text = "Valider";
                button_valider.Enabled = false;
                if (quiz_actuel.Questions.Count() > int.Parse(label_nombre_question.Text))
                {
                    //passer à la question suivante
                    //Question question_actuelle = Quiz.QuestionSuivante();
                }
            }
            else
            {
                button_valider.Text = "Question suivante";

                // Ici, on pourrait vérifier la réponse donnée par le joueur
                //Quiz.TestReponse te renvoie la bonne réponse à la question
            }
        }
    }
}
