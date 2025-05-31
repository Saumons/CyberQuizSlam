namespace CyberQuiz_App
{
    partial class Form_Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_quitter = new Button();
            button_entrer_quiz = new Button();
            textbox_pseudo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button_quitter
            // 
            button_quitter.BackColor = Color.Transparent;
            button_quitter.BackgroundImage = CyberQuizz_App.Properties.Resources.pictoQuitter;
            button_quitter.BackgroundImageLayout = ImageLayout.Stretch;
            button_quitter.Cursor = Cursors.Hand;
            button_quitter.FlatAppearance.BorderSize = 0;
            button_quitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_quitter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_quitter.FlatStyle = FlatStyle.Flat;
            button_quitter.Location = new Point(551, 728);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(60, 60);
            button_quitter.TabIndex = 3;
            button_quitter.UseVisualStyleBackColor = false;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_entrer_quiz
            // 
            button_entrer_quiz.BackColor = Color.Transparent;
            button_entrer_quiz.BackgroundImage = CyberQuizz_App.Properties.Resources.btn_rose;
            button_entrer_quiz.BackgroundImageLayout = ImageLayout.Stretch;
            button_entrer_quiz.Cursor = Cursors.Hand;
            button_entrer_quiz.FlatAppearance.BorderSize = 0;
            button_entrer_quiz.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_entrer_quiz.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_entrer_quiz.FlatStyle = FlatStyle.Flat;
            button_entrer_quiz.Font = new Font("Caladea", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_entrer_quiz.Location = new Point(98, 613);
            button_entrer_quiz.Name = "button_entrer_quiz";
            button_entrer_quiz.Size = new Size(437, 95);
            button_entrer_quiz.TabIndex = 1;
            button_entrer_quiz.Text = "Entrer dans le quiz";
            button_entrer_quiz.UseVisualStyleBackColor = false;
            button_entrer_quiz.Click += button_entrer_quiz_Click;
            // 
            // textbox_pseudo
            // 
            textbox_pseudo.Location = new Point(98, 512);
            textbox_pseudo.MaxLength = 30;
            textbox_pseudo.Name = "textbox_pseudo";
            textbox_pseudo.PlaceholderText = "Entrez votre pseudo";
            textbox_pseudo.Size = new Size(437, 30);
            textbox_pseudo.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 468);
            label1.Name = "label1";
            label1.Size = new Size(113, 41);
            label1.TabIndex = 4;
            label1.Text = "Pseudo : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caladea", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 9);
            label2.Name = "label2";
            label2.Size = new Size(295, 32);
            label2.TabIndex = 5;
            label2.Text = "QUIZ CYBER PAR SLAM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caladea", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 79);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 6;
            label3.Text = "AskMeIfYouCan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = CyberQuizz_App.Properties.Resources.SLAM_3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = CyberQuizz_App.Properties.Resources.logo_App_1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(169, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(295, 258);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form_Accueil
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = CyberQuizz_App.Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 785);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox_pseudo);
            Controls.Add(button_entrer_quiz);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Accueil";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLAM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_quitter;
        private Button button_entrer_quiz;
        private TextBox textbox_pseudo;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
