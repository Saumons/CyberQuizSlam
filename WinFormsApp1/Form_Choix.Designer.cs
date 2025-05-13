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
            button1 = new Button();
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
            label3.Location = new Point(417, 9);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 7;
            label3.Text = "AskMeIfYouCan";
            // 
            // button1
            // 
            button1.Location = new Point(377, 295);
            button1.Name = "button1";
            button1.Size = new Size(167, 198);
            button1.TabIndex = 8;
            button1.Text = "button1";
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
            Controls.Add(label3);
            Controls.Add(button_quitter);
            Font = new Font("Caladea", 14.25F);
            Name = "Form_Choix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLAM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_quitter;
        private Label label3;
        private Button button1;
    }
}