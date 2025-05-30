namespace CyberQuizz_App
{
    partial class Form_Choix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_quitter = new Button();
            label3 = new Label();
            button_facile = new Button();
            button_retour = new Button();
            button_moyen = new Button();
            button_difficile = new Button();
            button_entreprise = new Button();
            button_reseaux_harcelement = new Button();
            button_culture_mdp = new Button();
            label_theme = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_lancer = new Button();
            button_regles = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_quitter
            // 
            button_quitter.BackColor = Color.Transparent;
            button_quitter.BackgroundImage = Properties.Resources.pictoQuitter;
            button_quitter.BackgroundImageLayout = ImageLayout.Stretch;
            button_quitter.Cursor = Cursors.Hand;
            button_quitter.FlatAppearance.BorderSize = 0;
            button_quitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_quitter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_quitter.FlatStyle = FlatStyle.Flat;
            button_quitter.Location = new Point(1012, 759);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(60, 60);
            button_quitter.TabIndex = 1;
            button_quitter.UseVisualStyleBackColor = false;
            button_quitter.Click += button_quitter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caladea", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(395, 12);
            label3.Name = "label3";
            label3.Size = new Size(269, 43);
            label3.TabIndex = 7;
            label3.Text = "AskMeIfYouCan";
            // 
            // button_facile
            // 
            button_facile.BackColor = Color.Transparent;
            button_facile.BackgroundImage = Properties.Resources.btn_vert;
            button_facile.Cursor = Cursors.Hand;
            button_facile.FlatAppearance.BorderColor = Color.Black;
            button_facile.FlatAppearance.BorderSize = 0;
            button_facile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_facile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_facile.FlatStyle = FlatStyle.Flat;
            button_facile.Font = new Font("Caladea", 17.9999981F);
            button_facile.Location = new Point(65, 261);
            button_facile.Name = "button_facile";
            button_facile.Size = new Size(264, 87);
            button_facile.TabIndex = 8;
            button_facile.Tag = "";
            button_facile.Text = "Facile";
            button_facile.UseVisualStyleBackColor = false;
            button_facile.Click += button_facile_Click;
            // 
            // button_retour
            // 
            button_retour.BackColor = Color.Transparent;
            button_retour.BackgroundImage = Properties.Resources.retour_btn;
            button_retour.BackgroundImageLayout = ImageLayout.Stretch;
            button_retour.Cursor = Cursors.Hand;
            button_retour.FlatAppearance.BorderSize = 0;
            button_retour.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_retour.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_retour.FlatStyle = FlatStyle.Flat;
            button_retour.Location = new Point(-5, 740);
            button_retour.Name = "button_retour";
            button_retour.Size = new Size(98, 98);
            button_retour.TabIndex = 9;
            button_retour.UseVisualStyleBackColor = false;
            button_retour.Click += button_retour_Click;
            // 
            // button_moyen
            // 
            button_moyen.BackColor = Color.Transparent;
            button_moyen.BackgroundImage = Properties.Resources.btn_orange;
            button_moyen.Cursor = Cursors.Hand;
            button_moyen.FlatAppearance.BorderColor = Color.Black;
            button_moyen.FlatAppearance.BorderSize = 0;
            button_moyen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_moyen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_moyen.FlatStyle = FlatStyle.Flat;
            button_moyen.Font = new Font("Caladea", 17.9999981F);
            button_moyen.Location = new Point(410, 261);
            button_moyen.Name = "button_moyen";
            button_moyen.Size = new Size(264, 87);
            button_moyen.TabIndex = 10;
            button_moyen.Tag = "";
            button_moyen.Text = "Moyen";
            button_moyen.UseVisualStyleBackColor = false;
            button_moyen.Click += button_facile_Click;
            // 
            // button_difficile
            // 
            button_difficile.BackColor = Color.Transparent;
            button_difficile.BackgroundImage = Properties.Resources.btn_rouge;
            button_difficile.Cursor = Cursors.Hand;
            button_difficile.FlatAppearance.BorderColor = Color.Black;
            button_difficile.FlatAppearance.BorderSize = 0;
            button_difficile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_difficile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_difficile.FlatStyle = FlatStyle.Flat;
            button_difficile.Font = new Font("Caladea", 17.9999981F);
            button_difficile.Location = new Point(753, 261);
            button_difficile.Name = "button_difficile";
            button_difficile.Size = new Size(264, 87);
            button_difficile.TabIndex = 11;
            button_difficile.Tag = "";
            button_difficile.Text = "Difficile";
            button_difficile.UseVisualStyleBackColor = false;
            button_difficile.Click += button_facile_Click;
            // 
            // button_entreprise
            // 
            button_entreprise.BackColor = Color.Transparent;
            button_entreprise.BackgroundImage = Properties.Resources.btn_bleu;
            button_entreprise.Cursor = Cursors.Hand;
            button_entreprise.FlatAppearance.BorderColor = Color.Black;
            button_entreprise.FlatAppearance.BorderSize = 0;
            button_entreprise.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_entreprise.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_entreprise.FlatStyle = FlatStyle.Flat;
            button_entreprise.Font = new Font("Caladea", 17.9999981F);
            button_entreprise.Location = new Point(65, 545);
            button_entreprise.Name = "button_entreprise";
            button_entreprise.Size = new Size(264, 86);
            button_entreprise.TabIndex = 12;
            button_entreprise.Text = "Entreprise";
            button_entreprise.UseVisualStyleBackColor = false;
            button_entreprise.Click += button_entreprise_Click;
            // 
            // button_reseaux_harcelement
            // 
            button_reseaux_harcelement.BackColor = Color.Transparent;
            button_reseaux_harcelement.BackgroundImage = Properties.Resources.btn_bleu;
            button_reseaux_harcelement.Cursor = Cursors.Hand;
            button_reseaux_harcelement.FlatAppearance.BorderColor = Color.Black;
            button_reseaux_harcelement.FlatAppearance.BorderSize = 0;
            button_reseaux_harcelement.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_reseaux_harcelement.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_reseaux_harcelement.FlatStyle = FlatStyle.Flat;
            button_reseaux_harcelement.Font = new Font("Caladea", 17.9999981F);
            button_reseaux_harcelement.Location = new Point(410, 545);
            button_reseaux_harcelement.Name = "button_reseaux_harcelement";
            button_reseaux_harcelement.Size = new Size(264, 86);
            button_reseaux_harcelement.TabIndex = 13;
            button_reseaux_harcelement.Text = "Réseaux Sociaux\r\nCyber-Harcèlement";
            button_reseaux_harcelement.UseVisualStyleBackColor = false;
            button_reseaux_harcelement.Click += button_entreprise_Click;
            // 
            // button_culture_mdp
            // 
            button_culture_mdp.BackColor = Color.Transparent;
            button_culture_mdp.BackgroundImage = Properties.Resources.btn_bleu;
            button_culture_mdp.Cursor = Cursors.Hand;
            button_culture_mdp.FlatAppearance.BorderColor = Color.Black;
            button_culture_mdp.FlatAppearance.BorderSize = 0;
            button_culture_mdp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_culture_mdp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_culture_mdp.FlatStyle = FlatStyle.Flat;
            button_culture_mdp.Font = new Font("Caladea", 17.9999981F);
            button_culture_mdp.Location = new Point(753, 545);
            button_culture_mdp.Name = "button_culture_mdp";
            button_culture_mdp.Size = new Size(264, 86);
            button_culture_mdp.TabIndex = 14;
            button_culture_mdp.Text = "Culture Cyber\r\nMots de passe";
            button_culture_mdp.UseVisualStyleBackColor = false;
            button_culture_mdp.Click += button_entreprise_Click;
            // 
            // label_theme
            // 
            label_theme.AutoSize = true;
            label_theme.BackColor = Color.Transparent;
            label_theme.Font = new Font("Caladea", 21.75F, FontStyle.Bold);
            label_theme.ForeColor = Color.White;
            label_theme.Location = new Point(495, 479);
            label_theme.Name = "label_theme";
            label_theme.Size = new Size(101, 34);
            label_theme.TabIndex = 15;
            label_theme.Text = "Thème";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caladea", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(478, 181);
            label1.Name = "label1";
            label1.Size = new Size(136, 34);
            label1.TabIndex = 16;
            label1.Text = "Difficulté";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_App_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 115);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button_lancer
            // 
            button_lancer.FlatAppearance.BorderSize = 0;
            button_lancer.FlatAppearance.MouseOverBackColor = Color.White;
            button_lancer.FlatStyle = FlatStyle.Flat;
            button_lancer.Font = new Font("Caladea", 17.9999981F);
            button_lancer.Location = new Point(410, 721);
            button_lancer.Name = "button_lancer";
            button_lancer.Size = new Size(264, 86);
            button_lancer.TabIndex = 18;
            button_lancer.Text = "Lancer le jeu";
            button_lancer.UseVisualStyleBackColor = true;
            button_lancer.Click += button_lancer_Click;
            // 
            // button_regles
            // 
            button_regles.BackColor = Color.Transparent;
            button_regles.BackgroundImage = Properties.Resources.regles;
            button_regles.BackgroundImageLayout = ImageLayout.Stretch;
            button_regles.Cursor = Cursors.Hand;
            button_regles.FlatAppearance.BorderSize = 0;
            button_regles.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_regles.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_regles.FlatStyle = FlatStyle.Flat;
            button_regles.Location = new Point(979, 12);
            button_regles.Name = "button_regles";
            button_regles.Size = new Size(90, 90);
            button_regles.TabIndex = 19;
            button_regles.UseVisualStyleBackColor = false;
            // 
            // Form_Choix
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 831);
            ControlBox = false;
            Controls.Add(button_regles);
            Controls.Add(button_lancer);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label_theme);
            Controls.Add(button_culture_mdp);
            Controls.Add(button_reseaux_harcelement);
            Controls.Add(button_entreprise);
            Controls.Add(button_difficile);
            Controls.Add(button_moyen);
            Controls.Add(button_retour);
            Controls.Add(button_facile);
            Controls.Add(label3);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Choix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLAM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_quitter;
        private Label label3;
        private Button button_facile;
        private Button button_retour;
        private Button button_moyen;
        private Button button_difficile;
        private Button button_entreprise;
        private Button button_reseaux_harcelement;
        private Button button_culture_mdp;
        private Label label_theme;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button_lancer;
        private Button button_regles;
    }
}