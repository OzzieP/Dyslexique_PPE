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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Astuce = new System.Windows.Forms.GroupBox();
            this.button_PhraseSuivante = new System.Windows.Forms.Button();
            this.button_PhrasePrecedente = new System.Windows.Forms.Button();
            this.label_Tentatives = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Location = new System.Drawing.Point(33, 31);
            this.label_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(84, 29);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "TITRE";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 145);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(972, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Progressbar à gauche / Nombre de questions répondues sur nombre de questions tota" +
    "les";
            // 
            // label_Consigne
            // 
            this.label_Consigne.AutoSize = true;
            this.label_Consigne.Location = new System.Drawing.Point(37, 303);
            this.label_Consigne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Consigne.Name = "label_Consigne";
            this.label_Consigne.Size = new System.Drawing.Size(122, 29);
            this.label_Consigne.TabIndex = 1;
            this.label_Consigne.Text = "Consigne ";
            // 
            // panel_Phrase
            // 
            this.panel_Phrase.Location = new System.Drawing.Point(40, 455);
            this.panel_Phrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Phrase.Name = "panel_Phrase";
            this.panel_Phrase.Size = new System.Drawing.Size(1295, 308);
            this.panel_Phrase.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voici la phrase :";
            // 
            // groupBox_Astuce
            // 
            this.groupBox_Astuce.Location = new System.Drawing.Point(1624, 201);
            this.groupBox_Astuce.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox_Astuce.Name = "groupBox_Astuce";
            this.groupBox_Astuce.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox_Astuce.Size = new System.Drawing.Size(807, 1086);
            this.groupBox_Astuce.TabIndex = 7;
            this.groupBox_Astuce.TabStop = false;
            this.groupBox_Astuce.Text = "Astuces pour aider ! ";
            // 
            // button_PhraseSuivante
            // 
            this.button_PhraseSuivante.Location = new System.Drawing.Point(703, 840);
            this.button_PhraseSuivante.Name = "button_PhraseSuivante";
            this.button_PhraseSuivante.Size = new System.Drawing.Size(50, 45);
            this.button_PhraseSuivante.TabIndex = 8;
            this.button_PhraseSuivante.Text = ">";
            this.button_PhraseSuivante.UseVisualStyleBackColor = true;
            // 
            // button_PhrasePrecedente
            // 
            this.button_PhrasePrecedente.Location = new System.Drawing.Point(478, 840);
            this.button_PhrasePrecedente.Name = "button_PhrasePrecedente";
            this.button_PhrasePrecedente.Size = new System.Drawing.Size(52, 45);
            this.button_PhrasePrecedente.TabIndex = 9;
            this.button_PhrasePrecedente.Text = "<";
            this.button_PhrasePrecedente.UseVisualStyleBackColor = true;
            // 
            // label_Tentatives
            // 
            this.label_Tentatives.AutoSize = true;
            this.label_Tentatives.Location = new System.Drawing.Point(763, 303);
            this.label_Tentatives.Name = "label_Tentatives";
            this.label_Tentatives.Size = new System.Drawing.Size(453, 29);
            this.label_Tentatives.TabIndex = 10;
            this.label_Tentatives.Text = "Nombre de tentatives pour cette phrase : ";
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2492, 1421);
            this.Controls.Add(this.label_Tentatives);
            this.Controls.Add(this.button_PhrasePrecedente);
            this.Controls.Add(this.button_PhraseSuivante);
            this.Controls.Add(this.groupBox_Astuce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Phrase);
            this.Controls.Add(this.label_Consigne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_titre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Astuce;
        private System.Windows.Forms.Button button_PhraseSuivante;
        private System.Windows.Forms.Button button_PhrasePrecedente;
        private System.Windows.Forms.Label label_Tentatives;
    }
}