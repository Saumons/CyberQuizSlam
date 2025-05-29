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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_App_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
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
            button_retour.FlatStyle = FlatStyle.Popup;
            button_retour.Location = new Point(-5, 740);
            button_retour.Name = "button_retour";
            button_retour.Size = new Size(98, 98);
            button_retour.TabIndex = 20;
            button_retour.UseVisualStyleBackColor = false;
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
            button_quitter.TabIndex = 19;
            button_quitter.UseVisualStyleBackColor = false;
            // 
            // Form_Jeu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 831);
            ControlBox = false;
            Controls.Add(button_retour);
            Controls.Add(button_quitter);
            Controls.Add(pictureBox1);
            Name = "Form_Jeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_retour;
        private Button button_quitter;
    }
}