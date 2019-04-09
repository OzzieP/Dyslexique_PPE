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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Page Utilisateur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Page Profil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Page Jeu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_connexion);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label1);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.TextBox textBox_connexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

