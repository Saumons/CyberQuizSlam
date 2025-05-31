namespace CyberQuizz_App
{
    partial class Form_Jeu
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
            pictureBox1 = new PictureBox();
            button_retour = new Button();
            button_quitter = new Button();
            button_prof = new Button();
            label_nombre_question = new Label();
            button_a = new Button();
            button_b = new Button();
            button_c = new Button();
            button_d = new Button();
            label3 = new Label();
            button_question = new Button();
            label_question = new Label();
            button_valider = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_App_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 115);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
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
            button_retour.TabIndex = 5;
            button_retour.UseVisualStyleBackColor = false;
            button_retour.Click += button_retour_Click;
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
            button_quitter.TabIndex = 6;
            button_quitter.UseVisualStyleBackColor = false;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_prof
            // 
            button_prof.BackColor = Color.Transparent;
            button_prof.BackgroundImage = Properties.Resources.prof_mains_hanches;
            button_prof.BackgroundImageLayout = ImageLayout.Stretch;
            button_prof.Cursor = Cursors.Hand;
            button_prof.FlatAppearance.BorderSize = 0;
            button_prof.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_prof.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_prof.FlatStyle = FlatStyle.Flat;
            button_prof.Location = new Point(875, 52);
            button_prof.Name = "button_prof";
            button_prof.Size = new Size(171, 318);
            button_prof.TabIndex = 7;
            button_prof.UseVisualStyleBackColor = false;
            // 
            // label_nombre_question
            // 
            label_nombre_question.AutoSize = true;
            label_nombre_question.BackColor = Color.Transparent;
            label_nombre_question.ForeColor = Color.White;
            label_nombre_question.Location = new Point(12, 145);
            label_nombre_question.Name = "label_nombre_question";
            label_nombre_question.Size = new Size(177, 22);
            label_nombre_question.TabIndex = 23;
            label_nombre_question.Text = "Nombre de questions";
            label_nombre_question.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_a
            // 
            button_a.BackColor = Color.Transparent;
            button_a.BackgroundImage = Properties.Resources.reponseQuizzA;
            button_a.BackgroundImageLayout = ImageLayout.Stretch;
            button_a.Cursor = Cursors.Hand;
            button_a.FlatAppearance.BorderColor = Color.Black;
            button_a.FlatAppearance.BorderSize = 0;
            button_a.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_a.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_a.FlatStyle = FlatStyle.Flat;
            button_a.Location = new Point(51, 383);
            button_a.Name = "button_a";
            button_a.Size = new Size(450, 95);
            button_a.TabIndex = 1;
            button_a.TextAlign = ContentAlignment.MiddleRight;
            button_a.UseVisualStyleBackColor = false;
            button_a.Click += button_a_Click;
            // 
            // button_b
            // 
            button_b.BackColor = Color.Transparent;
            button_b.BackgroundImage = Properties.Resources.reponseQuizzB;
            button_b.BackgroundImageLayout = ImageLayout.Stretch;
            button_b.Cursor = Cursors.Hand;
            button_b.FlatAppearance.BorderSize = 0;
            button_b.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_b.FlatStyle = FlatStyle.Flat;
            button_b.Location = new Point(580, 383);
            button_b.Name = "button_b";
            button_b.Size = new Size(450, 95);
            button_b.TabIndex = 2;
            button_b.TextAlign = ContentAlignment.MiddleRight;
            button_b.UseVisualStyleBackColor = false;
            button_b.Click += button_a_Click;
            // 
            // button_c
            // 
            button_c.BackColor = Color.Transparent;
            button_c.BackgroundImage = Properties.Resources.reponseQuizzC;
            button_c.BackgroundImageLayout = ImageLayout.Stretch;
            button_c.Cursor = Cursors.Hand;
            button_c.FlatAppearance.BorderSize = 0;
            button_c.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_c.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_c.FlatStyle = FlatStyle.Flat;
            button_c.Location = new Point(51, 529);
            button_c.Name = "button_c";
            button_c.Size = new Size(450, 95);
            button_c.TabIndex = 3;
            button_c.TextAlign = ContentAlignment.MiddleRight;
            button_c.UseVisualStyleBackColor = false;
            button_c.Click += button_a_Click;
            // 
            // button_d
            // 
            button_d.BackColor = Color.Transparent;
            button_d.BackgroundImage = Properties.Resources.reponseQuizzD;
            button_d.BackgroundImageLayout = ImageLayout.Stretch;
            button_d.Cursor = Cursors.Hand;
            button_d.FlatAppearance.BorderSize = 0;
            button_d.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_d.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_d.FlatStyle = FlatStyle.Flat;
            button_d.Location = new Point(580, 529);
            button_d.Name = "button_d";
            button_d.Size = new Size(450, 95);
            button_d.TabIndex = 4;
            button_d.TextAlign = ContentAlignment.MiddleRight;
            button_d.UseVisualStyleBackColor = false;
            button_d.Click += button_a_Click;
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
            label3.TabIndex = 28;
            label3.Text = "AskMeIfYouCan";
            // 
            // button_question
            // 
            button_question.BackColor = Color.Transparent;
            button_question.BackgroundImage = Properties.Resources.bulle_grande;
            button_question.BackgroundImageLayout = ImageLayout.Stretch;
            button_question.Cursor = Cursors.Hand;
            button_question.FlatAppearance.BorderSize = 0;
            button_question.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_question.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_question.FlatStyle = FlatStyle.Flat;
            button_question.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_question.Location = new Point(202, 71);
            button_question.Name = "button_question";
            button_question.Size = new Size(667, 198);
            button_question.TabIndex = 29;
            button_question.UseVisualStyleBackColor = false;
            // 
            // label_question
            // 
            label_question.BackColor = Color.FromArgb(252, 235, 243);
            label_question.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_question.Location = new Point(232, 99);
            label_question.Name = "label_question";
            label_question.Size = new Size(571, 143);
            label_question.TabIndex = 30;
            label_question.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_valider
            // 
            button_valider.Enabled = false;
            button_valider.FlatAppearance.BorderSize = 0;
            button_valider.FlatAppearance.MouseOverBackColor = Color.White;
            button_valider.FlatStyle = FlatStyle.Flat;
            button_valider.Font = new Font("Caladea", 17.9999981F);
            button_valider.Location = new Point(410, 659);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(264, 86);
            button_valider.TabIndex = 32;
            button_valider.Text = "Valider";
            button_valider.UseVisualStyleBackColor = true;
            button_valider.Click += button_valider_Click;
            // 
            // Form_Jeu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 749);
            ControlBox = false;
            Controls.Add(button_valider);
            Controls.Add(label_question);
            Controls.Add(button_question);
            Controls.Add(label3);
            Controls.Add(button_d);
            Controls.Add(button_c);
            Controls.Add(button_b);
            Controls.Add(button_a);
            Controls.Add(label_nombre_question);
            Controls.Add(button_prof);
            Controls.Add(button_retour);
            Controls.Add(button_quitter);
            Controls.Add(pictureBox1);
            Font = new Font("Caladea", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Jeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_retour;
        private Button button_quitter;
        private Button button_prof;
        private Label label_nombre_question;
        private Button button_a;
        private Button button_b;
        private Button button_c;
        private Button button_d;
        private Label label3;
        private Button button_question;
        private Label label_question;
        private Button button_valider;
    }
}