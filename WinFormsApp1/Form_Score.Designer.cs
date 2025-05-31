namespace CyberQuizz_App
{
    partial class Form_Score
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
            label3 = new Label();
            button_quitter = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caladea", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(177, 9);
            label3.Name = "label3";
            label3.Size = new Size(269, 43);
            label3.TabIndex = 8;
            label3.Text = "AskMeIfYouCan";
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
            button_quitter.Location = new Point(551, 677);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(60, 60);
            button_quitter.TabIndex = 9;
            button_quitter.UseVisualStyleBackColor = false;
            // 
            // Form_Score
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 749);
            ControlBox = false;
            Controls.Add(button_quitter);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Score";
            Text = "Form_Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button_quitter;
    }
}