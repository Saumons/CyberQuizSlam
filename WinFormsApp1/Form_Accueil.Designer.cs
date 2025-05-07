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
            button_admin = new Button();
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
            button_quitter.BackgroundImageLayout = ImageLayout.Stretch;
            button_quitter.FlatStyle = FlatStyle.Popup;
            button_quitter.Location = new Point(535, 750);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(136, 73);
            button_quitter.TabIndex = 0;
            button_quitter.Text = "QUITTER";
            button_quitter.UseVisualStyleBackColor = true;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_admin
            // 
            button_admin.FlatStyle = FlatStyle.Popup;
            button_admin.Location = new Point(12, 750);
            button_admin.Name = "button_admin";
            button_admin.Size = new Size(136, 73);
            button_admin.TabIndex = 1;
            button_admin.Text = "Compte Admin";
            button_admin.UseVisualStyleBackColor = true;
            // 
            // button_entrer_quiz
            // 
            button_entrer_quiz.FlatStyle = FlatStyle.Popup;
            button_entrer_quiz.Font = new Font("Caladea", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_entrer_quiz.Location = new Point(118, 626);
            button_entrer_quiz.Name = "button_entrer_quiz";
            button_entrer_quiz.Size = new Size(437, 95);
            button_entrer_quiz.TabIndex = 2;
            button_entrer_quiz.Text = "Entrer dans le quiz";
            button_entrer_quiz.UseVisualStyleBackColor = true;
            // 
            // textbox_pseudo
            // 
            textbox_pseudo.Location = new Point(118, 512);
            textbox_pseudo.Name = "textbox_pseudo";
            textbox_pseudo.PlaceholderText = "Entrez votre pseudo";
            textbox_pseudo.Size = new Size(437, 30);
            textbox_pseudo.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 468);
            label1.Name = "label1";
            label1.Size = new Size(113, 41);
            label1.TabIndex = 4;
            label1.Text = "Pseudo : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Caladea", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(295, 32);
            label2.TabIndex = 5;
            label2.Text = "QUIZ CYBER PAR SLAM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Caladea", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 80);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 6;
            label3.Text = "AskMeIfYouCan";
            // 
            // pictureBox1
            // 
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
            pictureBox2.Location = new Point(189, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(295, 258);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form_Accueil
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = WinFormsApp1.Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(667, 819);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox_pseudo);
            Controls.Add(button_entrer_quiz);
            Controls.Add(button_admin);
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
        private Button button_admin;
        private Button button_entrer_quiz;
        private TextBox textbox_pseudo;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
