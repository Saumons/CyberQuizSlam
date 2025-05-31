using CyberQuiz_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberQuizz_App
{
    public partial class Form_Fin : Form
    {
        public Form_Fin(Quiz quiz_actuel_fournis, int nb_bonnes_rep)
        {
            InitializeComponent();
            //NomDuChampPourLeScore.Text = nb_bonnes_rep.ToString() + " / " + quiz_actuel_fournis.NbQuestions.ToString()
            //Si tu peux un label qui dit ça : test_score(nb_bonnes_rep);
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_retour_choix_Click(object sender, EventArgs e)
        {
            Form_Choix uneFenetre = new Form_Choix("");
            uneFenetre.Show();
            this.Close();
        }

        private String test_score(int nb_bonnes_rep)
        {
            String info_resultat;
            switch(nb_bonnes_rep)
            {
                case < 7:
                    info_resultat = "Notions acquises, mais il faut se renforcer";
                    break;
                case <= 9:
                    info_resultat = "Il est recommandé de se former davantage";
                    break;
                case <= 12 :
                    info_resultat = "Bon niveau de vigilance";
                    break;
                default:
                    info_resultat = " Excellent agent potentiel";
                    break;

            }
            return info_resultat;
        }

    }
}
