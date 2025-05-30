﻿using CyberQuiz_Lib;
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
    public partial class Form_Choix : Form
    {
        string pseudo_joueur = "";

        Quiz quiz;

        string button_theme = "";
        string button_difficulte = "";

        public Form_Choix(string pseudo)
        {
            InitializeComponent();
            pseudo_joueur = pseudo;
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_regles_Click(object sender, EventArgs e)
        {
            Form_Regles uneFenetre = new Form_Regles();
            uneFenetre.ShowDialog();
        }
        private void button_facile_Click(object sender, EventArgs e)
        {
            // On retire la bordure des boutons
            button_facile.FlatAppearance.BorderSize = 0;
            button_moyen.FlatAppearance.BorderSize = 0;
            button_difficile.FlatAppearance.BorderSize = 0;

            // On met la bordure du bouton cliqué à 1 et on enregistre la difficulté choisie
            Button unBouton = (Button)sender;
            button_difficulte = unBouton.Text;
            unBouton.FlatAppearance.BorderSize = 2;
        }

        private void button_entreprise_Click(object sender, EventArgs e)
        {
            // On retire la bordure des boutons
            button_entreprise.FlatAppearance.BorderSize = 0;
            button_culture_mdp.FlatAppearance.BorderSize = 0;
            button_reseaux_harcelement.FlatAppearance.BorderSize = 0;

            // On met la bordure du bouton cliqué à 1 et on enregistre le thème choisi
            Button unBouton = (Button)sender;
            button_theme = unBouton.Text;
            unBouton.FlatAppearance.BorderSize = 2;
        }

        private void button_lancer_Click(object sender, EventArgs e)
        {
            if (button_theme == "" || button_difficulte == "")
            {
               
            }
            else
            {
                Quiz quiz = new Quiz(pseudo_joueur, button_theme, button_difficulte, 15);

                Form_Jeu uneFenetre = new Form_Jeu(button_theme, button_difficulte, quiz);
                uneFenetre.Show();
            }
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
