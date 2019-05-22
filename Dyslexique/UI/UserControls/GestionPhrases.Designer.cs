namespace Dyslexique.UI.UserControls
{
    partial class GestionPhrases
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
            this.labelTrouver = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consigne = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrouver
            // 
            this.labelTrouver.AutoSize = true;
            this.labelTrouver.Location = new System.Drawing.Point(729, 21);
            this.labelTrouver.Name = "labelTrouver";
            this.labelTrouver.Size = new System.Drawing.Size(69, 13);
            this.labelTrouver.TabIndex = 15;
            this.labelTrouver.Text = "mot à trouver";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "consigne :";
            // 
            // consigne
            // 
            this.consigne.Location = new System.Drawing.Point(84, 14);
            this.consigne.Name = "consigne";
            this.consigne.Size = new System.Drawing.Size(369, 20);
            this.consigne.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(259, 426);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "créer phrase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ajouter Mot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionPhrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTrouver);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consigne);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GestionPhrases";
            this.Size = new System.Drawing.Size(1307, 686);
            this.Load += new System.EventHandler(this.PhrasePossederMot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrouver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consigne;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
