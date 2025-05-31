namespace CyberQuizz_App
{
    partial class Form_Fin
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
            button_retour = new Button();
            button_quitter = new Button();
            button_retour_choix = new Button();
            label_score = new Label();
            label_point = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            button_retour.Location = new Point(-471, 654);
            button_retour.Name = "button_retour";
            button_retour.Size = new Size(98, 98);
            button_retour.TabIndex = 11;
            button_retour.UseVisualStyleBackColor = false;
            // 
            // button_quitter
            // 
            button_quitter.BackColor = Color.FromArgb(252, 235, 243);
            button_quitter.BackgroundImageLayout = ImageLayout.Stretch;
            button_quitter.Cursor = Cursors.Hand;
            button_quitter.FlatAppearance.BorderSize = 0;
            button_quitter.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 235, 243);
            button_quitter.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 243);
            button_quitter.FlatStyle = FlatStyle.Flat;
            button_quitter.Location = new Point(413, 501);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(150, 150);
            button_quitter.TabIndex = 10;
            button_quitter.Text = "QUITTER";
            button_quitter.UseVisualStyleBackColor = false;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_retour_choix
            // 
            button_retour_choix.BackColor = Color.FromArgb(252, 235, 243);
            button_retour_choix.BackgroundImageLayout = ImageLayout.Stretch;
            button_retour_choix.Cursor = Cursors.Hand;
            button_retour_choix.FlatAppearance.BorderSize = 0;
            button_retour_choix.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 235, 243);
            button_retour_choix.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 243);
            button_retour_choix.FlatStyle = FlatStyle.Flat;
            button_retour_choix.Location = new Point(51, 501);
            button_retour_choix.Name = "button_retour_choix";
            button_retour_choix.Size = new Size(150, 150);
            button_retour_choix.TabIndex = 12;
            button_retour_choix.Text = "RETOUR";
            button_retour_choix.UseVisualStyleBackColor = false;
            button_retour_choix.Click += button_retour_choix_Click;
            // 
            // label_score
            // 
            label_score.BackColor = Color.Transparent;
            label_score.Font = new Font("Caladea", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score.Location = new Point(132, 236);
            label_score.Name = "label_score";
            label_score.Size = new Size(357, 262);
            label_score.TabIndex = 13;
            label_score.Text = "SCORE";
            label_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_point
            // 
            label_point.BackColor = Color.Transparent;
            label_point.Font = new Font("Caladea", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_point.Location = new Point(188, 137);
            label_point.Name = "label_point";
            label_point.Size = new Size(243, 89);
            label_point.TabIndex = 14;
            label_point.Text = "SCORE";
            label_point.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_App_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 146);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caladea", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(175, 9);
            label3.Name = "label3";
            label3.Size = new Size(269, 43);
            label3.TabIndex = 29;
            label3.Text = "AskMeIfYouCan";
            // 
            // Form_Fin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 745);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label_point);
            Controls.Add(label_score);
            Controls.Add(button_retour_choix);
            Controls.Add(button_retour);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Fin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fin de la partie";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_retour;
        private Button button_quitter;
        private Button button_retour_choix;
        private Label label_score;
        private Label label_point;
        private PictureBox pictureBox1;
        private Label label3;
    }
}