namespace Dyslexique.UI.UserControls
{
    partial class Jeu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Phrase = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Consigne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ProgressCount = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Tentatives = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 712);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phrase :";
            // 
            // panel_Phrase
            // 
            this.panel_Phrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Phrase.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Phrase.Location = new System.Drawing.Point(86, 772);
            this.panel_Phrase.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Phrase.Name = "panel_Phrase";
            this.panel_Phrase.Size = new System.Drawing.Size(1986, 346);
            this.panel_Phrase.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(76, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consigne :";
            // 
            // label_Consigne
            // 
            this.label_Consigne.AutoSize = true;
            this.label_Consigne.Location = new System.Drawing.Point(91, 587);
            this.label_Consigne.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_Consigne.Name = "label_Consigne";
            this.label_Consigne.Size = new System.Drawing.Size(314, 29);
            this.label_Consigne.TabIndex = 15;
            this.label_Consigne.Text = "Dans la phrase ci-dessous : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(86, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1986, 11);
            this.panel1.TabIndex = 16;
            // 
            // label_ProgressCount
            // 
            this.label_ProgressCount.AutoSize = true;
            this.label_ProgressCount.Location = new System.Drawing.Point(549, 42);
            this.label_ProgressCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ProgressCount.Name = "label_ProgressCount";
            this.label_ProgressCount.Size = new System.Drawing.Size(244, 29);
            this.label_ProgressCount.TabIndex = 11;
            this.label_ProgressCount.Text = "Questions restantes : ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 42);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(490, 29);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.label_ProgressCount);
            this.panel2.Location = new System.Drawing.Point(86, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1724, 114);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(76, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 58);
            this.label4.TabIndex = 18;
            this.label4.Text = "Progression du test";
            // 
            // label_Tentatives
            // 
            this.label_Tentatives.AutoSize = true;
            this.label_Tentatives.Location = new System.Drawing.Point(91, 411);
            this.label_Tentatives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tentatives.Name = "label_Tentatives";
            this.label_Tentatives.Size = new System.Drawing.Size(623, 29);
            this.label_Tentatives.TabIndex = 19;
            this.label_Tentatives.Text = "Nombre de tentatives déjà effectuées pour cette phrase : ";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Tentatives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Consigne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Phrase);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(3050, 1530);
            this.MinimumSize = new System.Drawing.Size(3050, 1530);
            this.Name = "Jeu";
            this.Size = new System.Drawing.Size(3050, 1530);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Phrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Consigne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ProgressCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Tentatives;
        /// <summary>
        /// Montre à l'<c>Utilisateur</c> sa progression.
        /// </summary>
        public System.Windows.Forms.ProgressBar progressBar;
    }
}
