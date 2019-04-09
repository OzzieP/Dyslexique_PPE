namespace Dyslexique
{
    partial class FormJeu
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
            this.label_titre = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Consigne = new System.Windows.Forms.Label();
            this.panel_Phrase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Location = new System.Drawing.Point(32, 32);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(84, 29);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "TITRE";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(491, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(972, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Progressbar à gauche / Nombre de questions répondues sur nombre de questions tota" +
    "les";
            // 
            // label_Consigne
            // 
            this.label_Consigne.AutoSize = true;
            this.label_Consigne.Location = new System.Drawing.Point(37, 75);
            this.label_Consigne.Name = "label_Consigne";
            this.label_Consigne.Size = new System.Drawing.Size(122, 29);
            this.label_Consigne.TabIndex = 1;
            this.label_Consigne.Text = "Consigne ";
            // 
            // panel_Phrase
            // 
            this.panel_Phrase.Location = new System.Drawing.Point(42, 282);
            this.panel_Phrase.Name = "panel_Phrase";
            this.panel_Phrase.Size = new System.Drawing.Size(1294, 308);
            this.panel_Phrase.TabIndex = 5;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2493, 1509);
            this.Controls.Add(this.panel_Phrase);
            this.Controls.Add(this.label_Consigne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_titre);
            this.Name = "FormJeu";
            this.Text = "Page de jeu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormJeu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Consigne;
        private System.Windows.Forms.Panel panel_Phrase;
    }
}