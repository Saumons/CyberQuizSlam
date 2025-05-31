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
        public Form_Fin(Quiz quiz_actuel,int nb_bonnes_rep)
        {
            InitializeComponent();
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
    }
}
