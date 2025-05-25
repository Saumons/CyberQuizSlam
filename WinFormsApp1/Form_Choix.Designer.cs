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
            button2 = new Button();
            button_moyen = new Button();
            button_difficile = new Button();
            button_entreprise = new Button();
            button_reseaux_harcelement = new Button();
            button_culture_mdp = new Button();
            label_theme = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_quitter
            // 
            button_quitter.BackColor = Color.Transparent;
            button_quitter.BackgroundImage = Properties.Resources.pictoQuitter;
            button_quitter.BackgroundImageLayout = ImageLayout.Stretch;
            button_quitter.FlatStyle = FlatStyle.Popup;
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
            label3.Font = new Font("Caladea", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 9);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 7;
            label3.Text = "AskMeIfYouCan";
            // 
            // button_facile
            // 
            button_facile.BackColor = Color.Transparent;
            button_facile.BackgroundImage = Properties.Resources.btn_vert;
            button_facile.FlatStyle = FlatStyle.Popup;
            button_facile.Font = new Font("Caladea", 17.9999981F);
            button_facile.Location = new Point(65, 208);
            button_facile.Name = "button_facile";
            button_facile.Size = new Size(264, 87);
            button_facile.TabIndex = 8;
            button_facile.Text = "Facile";
            button_facile.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.pictoMenu;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 759);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            // 
            // button_moyen
            // 
            button_moyen.BackColor = Color.Transparent;
            button_moyen.BackgroundImage = Properties.Resources.btn_orange;
            button_moyen.FlatStyle = FlatStyle.Popup;
            button_moyen.Font = new Font("Caladea", 17.9999981F);
            button_moyen.Location = new Point(410, 208);
            button_moyen.Name = "button_moyen";
            button_moyen.Size = new Size(264, 87);
            button_moyen.TabIndex = 10;
            button_moyen.Text = "Moyen";
            button_moyen.UseVisualStyleBackColor = false;
            // 
            // button_difficile
            // 
            button_difficile.BackColor = Color.Transparent;
            button_difficile.BackgroundImage = Properties.Resources.btn_rouge;
            button_difficile.FlatStyle = FlatStyle.Popup;
            button_difficile.Font = new Font("Caladea", 17.9999981F);
            button_difficile.Location = new Point(753, 208);
            button_difficile.Name = "button_difficile";
            button_difficile.Size = new Size(264, 87);
            button_difficile.TabIndex = 11;
            button_difficile.Text = "Difficile";
            button_difficile.UseVisualStyleBackColor = false;
            // 
            // button_entreprise
            // 
            button_entreprise.BackColor = Color.Transparent;
            button_entreprise.BackgroundImage = Properties.Resources.btn_bleu;
            button_entreprise.FlatStyle = FlatStyle.Popup;
            button_entreprise.Font = new Font("Caladea", 17.9999981F);
            button_entreprise.Location = new Point(65, 545);
            button_entreprise.Name = "button_entreprise";
            button_entreprise.Size = new Size(264, 86);
            button_entreprise.TabIndex = 12;
            button_entreprise.Text = "Entreprise";
            button_entreprise.UseVisualStyleBackColor = false;
            // 
            // button_reseaux_harcelement
            // 
            button_reseaux_harcelement.BackColor = Color.Transparent;
            button_reseaux_harcelement.BackgroundImage = Properties.Resources.btn_bleu;
            button_reseaux_harcelement.FlatStyle = FlatStyle.Popup;
            button_reseaux_harcelement.Font = new Font("Caladea", 17.9999981F);
            button_reseaux_harcelement.Location = new Point(410, 545);
            button_reseaux_harcelement.Name = "button_reseaux_harcelement";
            button_reseaux_harcelement.Size = new Size(264, 86);
            button_reseaux_harcelement.TabIndex = 13;
            button_reseaux_harcelement.Text = "Réseaux Sociaux\r\nCyber-Harcèlement";
            button_reseaux_harcelement.UseVisualStyleBackColor = false;
            // 
            // button_culture_mdp
            // 
            button_culture_mdp.BackColor = Color.Transparent;
            button_culture_mdp.BackgroundImage = Properties.Resources.btn_bleu;
            button_culture_mdp.FlatStyle = FlatStyle.Popup;
            button_culture_mdp.Font = new Font("Caladea", 17.9999981F);
            button_culture_mdp.Location = new Point(753, 545);
            button_culture_mdp.Name = "button_culture_mdp";
            button_culture_mdp.Size = new Size(264, 86);
            button_culture_mdp.TabIndex = 14;
            button_culture_mdp.Text = "Culture Cyber\r\nMots de passe";
            button_culture_mdp.UseVisualStyleBackColor = false;
            // 
            // label_theme
            // 
            label_theme.AutoSize = true;
            label_theme.BackColor = Color.Transparent;
            label_theme.Font = new Font("Caladea", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_theme.ForeColor = SystemColors.ControlText;
            label_theme.Location = new Point(501, 478);
            label_theme.Name = "label_theme";
            label_theme.Size = new Size(85, 28);
            label_theme.TabIndex = 15;
            label_theme.Text = "Thème";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caladea", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(484, 127);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
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
            // button1
            // 
            button1.Font = new Font("Caladea", 17.9999981F);
            button1.Location = new Point(410, 721);
            button1.Name = "button1";
            button1.Size = new Size(264, 86);
            button1.TabIndex = 18;
            button1.Text = "Lancer le jeu";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_Choix
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 831);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label_theme);
            Controls.Add(button_culture_mdp);
            Controls.Add(button_reseaux_harcelement);
            Controls.Add(button_entreprise);
            Controls.Add(button_difficile);
            Controls.Add(button_moyen);
            Controls.Add(button2);
            Controls.Add(button_facile);
            Controls.Add(label3);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F);
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
        private Button button2;
        private Button button_moyen;
        private Button button_difficile;
        private Button button_entreprise;
        private Button button_reseaux_harcelement;
        private Button button_culture_mdp;
        private Label label_theme;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}