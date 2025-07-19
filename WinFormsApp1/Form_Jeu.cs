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
        List<Button> liste_boutons;
        List<Button> liste_boutons_reponses;

        Reponse bonne_reponse;
        List<Reponse> reponses_question;
        Dictionary<int, Button> lien_boutons_reponses;
        Dictionary<Button, Button> lien_boutons;

        Button button_click;

        int nb_bonnes_rep;

        int nbQuestion;

        public Form_Jeu(string theme, string diff, Quiz quiz_actuel_fournis)
        {
            InitializeComponent();

            nbQuestion = 15;

            button_click = new Button();

            // On initialise la liste des boutons de la question
            liste_boutons = new List<Button>()
            {
                button_a, button_b, button_c, button_d
            };

            // On initialise la liste des boutons de réponses
            liste_boutons_reponses = new List<Button>()
            {
                button_answer_a, button_answer_b, button_answer_c, button_answer_d
            };


            //label_nombre_question.Text = quiz_actuel.NbQuestions.ToString();
            //QuestionCRUD question_actuelle = new QuestionCRUD();
            //toute_questions = question_actuelle.ChoixQuestion(theme, diff, nbQuestion);
            quiz_actuel = quiz_actuel_fournis;
            nb_bonnes_rep = 0;
            List<Question> toute_questions = quiz_actuel.Questions;
            lien_boutons_reponses = new Dictionary<int, Button>();
            lien_boutons = new Dictionary<Button, Button>();
            question_actuelle = toute_questions[0];
            afficher_question_reponse();

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            Button unBouton = (Button)sender;

            button_click = lien_boutons[unBouton];

            foreach (Button bouton in lien_boutons.Values)
            {
                bouton.FlatAppearance.BorderSize = 0; // On retire la bordure des boutons
                bouton.FlatAppearance.BorderColor = Color.Black;
            }

            // On met la bordure du bouton cliqué à 2 et on change le texte de la question
            button_click.FlatAppearance.BorderSize = 2;

            //unBouton.FlatAppearance.BorderSize = 2;

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
                foreach (Button bouton in lien_boutons.Values)
                {
                    bouton.FlatAppearance.BorderSize = 0; // On retire la bordure des boutons
                    bouton.FlatAppearance.BorderColor = Color.Black;
                }

                foreach (Button bouton in liste_boutons_reponses)
                {
                    bouton.Enabled = true; // On réactive les boutons de réponse
                }
                foreach (Button bouton in liste_boutons)
                {
                    bouton.Enabled = true; // On réactive les boutons de réponse
                }




                button_valider.Text = "Valider";
                button_valider.Enabled = false;
                if (!quiz_actuel.TestPartiFini())
                {
                    //passer à la question suivante
                    question_actuelle = quiz_actuel.QuestionSuivante();
                    afficher_question_reponse();
                }
                else
                {
                    Form_Fin uneFenetre = new Form_Fin(quiz_actuel, nb_bonnes_rep);
                    uneFenetre.Show();
                    this.Close();
                }
            }
            else
            {
                foreach (Button bouton in lien_boutons_reponses.Values)
                {
                    bouton.Enabled = false; // On désactive les boutons de réponse
                }
                foreach (Button bouton in liste_boutons_reponses)
                {
                    bouton.Enabled = false; // On désactive les boutons de réponse
                }
                button_valider.Text = "Question suivante";

                // Ici, on pourrait vérifier la réponse donnée par le joueur
                bonne_reponse = quiz_actuel.TestReponses(); //te renvoie la bonne réponse à la question



                lien_boutons[lien_boutons_reponses[bonne_reponse.Numero]].FlatAppearance.BorderSize = 3;
                lien_boutons[lien_boutons_reponses[bonne_reponse.Numero]].FlatAppearance.BorderColor = Color.Green;
                //Faut aussi tester si la réponse sélectionner est la bonne(nb_bonnes_rep++) sinon tu la met d'une autre couleur

            }
        }

        //Gère l'affichage de la page et le refresh
        private void afficher_question_reponse()
        {
            //Affiche le numéro de la question sur le nombre total de question
            label_nombre_question.Text = (quiz_actuel.NumQuestion + 1).ToString() + " / " + quiz_actuel.NbQuestions.ToString();
            reponses_question = question_actuelle.Reponses;
            label_question.Text = question_actuelle.Libelle;

            for (int i = 0; i < liste_boutons.Count; i++)
            {
                lien_boutons_reponses[reponses_question[i].Numero] = liste_boutons[i];
                liste_boutons_reponses[i].Text = reponses_question[i].Libelle;
                
            }

            lien_boutons[button_a] = button_bordure_a;
            lien_boutons[button_b] = button_bordure_b;
            lien_boutons[button_c] = button_bordure_c;
            lien_boutons[button_d] = button_bordure_d;
            lien_boutons[button_answer_a] = button_bordure_a;
            lien_boutons[button_answer_b] = button_bordure_b;
            lien_boutons[button_answer_c] = button_bordure_c;
            lien_boutons[button_answer_d] = button_bordure_d;

            button_valider.Enabled = true;
        }

    }
}
