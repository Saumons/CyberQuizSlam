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
        public Form_Choix()
        {
            InitializeComponent();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_lancer_Click(object sender, EventArgs e)
        {
            Form_Jeu uneFenetre = new Form_Jeu();
            uneFenetre.ShowDialog();
        }
    }
}
