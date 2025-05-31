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
            button_quitter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_quitter.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            button_retour_choix.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_retour_choix.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_retour_choix.FlatStyle = FlatStyle.Flat;
            button_retour_choix.Location = new Point(51, 501);
            button_retour_choix.Name = "button_retour_choix";
            button_retour_choix.Size = new Size(150, 150);
            button_retour_choix.TabIndex = 12;
            button_retour_choix.Text = "RETOUR";
            button_retour_choix.UseVisualStyleBackColor = false;
            button_retour_choix.Click += button_retour_choix_Click;
            // 
            // Form_Fin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 745);
            ControlBox = false;
            Controls.Add(button_retour_choix);
            Controls.Add(button_retour);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Fin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fin de la partie";
            ResumeLayout(false);
        }

        #endregion

        private Button button_retour;
        private Button button_quitter;
        private Button button_retour_choix;
    }
}