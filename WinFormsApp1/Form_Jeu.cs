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
    public partial class Form_Jeu : Form
    {
        public Form_Jeu()
        {
            InitializeComponent();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            button_a.Text = "Comment s'appelle l'attaque consistant à avoir un homme entre les deux PC des gens ?";
        }
    }
}
