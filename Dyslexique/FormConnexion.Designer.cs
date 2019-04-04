namespace Dyslexique
{
    partial class FormConnexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_connexion = new System.Windows.Forms.Button();
            this.textBox_connexion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renseignez votre pseudo pour vous connecter";
            // 
            // button_connexion
            // 
            this.button_connexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_connexion.Location = new System.Drawing.Point(308, 276);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(184, 54);
            this.button_connexion.TabIndex = 1;
            this.button_connexion.Text = "Se connecter";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.Button_connexion_Click);
            // 
            // textBox_connexion
            // 
            this.textBox_connexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_connexion.Location = new System.Drawing.Point(234, 193);
            this.textBox_connexion.Name = "textBox_connexion";
            this.textBox_connexion.Size = new System.Drawing.Size(333, 35);
            this.textBox_connexion.TabIndex = 2;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_connexion);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label1);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.TextBox textBox_connexion;
    }
}

