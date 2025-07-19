namespace CyberQuizz_App
{
    partial class Form_Regles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Regles));
            button_retour = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            button_retour.Location = new Point(534, 660);
            button_retour.Name = "button_retour";
            button_retour.Size = new Size(98, 98);
            button_retour.TabIndex = 6;
            button_retour.UseVisualStyleBackColor = false;
            button_retour.Click += button_retour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Professeur_torse;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(449, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 194);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(252, 235, 243);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(390, 558);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.bulle_grande;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 604);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form_Regles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.fond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 745);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(button_retour);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Caladea", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form_Regles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Règles du Jeu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_retour;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}