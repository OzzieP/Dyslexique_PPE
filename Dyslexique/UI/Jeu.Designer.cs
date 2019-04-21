namespace Dyslexique.UI
{
    partial class Tests
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
            this.groupBox_Astuce = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Phrase = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_Consigne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Astuce
            // 
            this.groupBox_Astuce.Location = new System.Drawing.Point(953, 38);
            this.groupBox_Astuce.Name = "groupBox_Astuce";
            this.groupBox_Astuce.Size = new System.Drawing.Size(505, 684);
            this.groupBox_Astuce.TabIndex = 14;
            this.groupBox_Astuce.TabStop = false;
            this.groupBox_Astuce.Text = "Astuces pour aider ! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phrase :";
            // 
            // panel_Phrase
            // 
            this.panel_Phrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Phrase.Location = new System.Drawing.Point(38, 346);
            this.panel_Phrase.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Phrase.Name = "panel_Phrase";
            this.panel_Phrase.Size = new System.Drawing.Size(851, 156);
            this.panel_Phrase.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(35, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consigne : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Progressbar à gauche / Nombre de questions répondues sur nombre de questions tota" +
    "les";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 19);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 13);
            this.progressBar1.TabIndex = 10;
            // 
            // label_Consigne
            // 
            this.label_Consigne.AutoSize = true;
            this.label_Consigne.Location = new System.Drawing.Point(35, 261);
            this.label_Consigne.Name = "label_Consigne";
            this.label_Consigne.Size = new System.Drawing.Size(140, 13);
            this.label_Consigne.TabIndex = 15;
            this.label_Consigne.Text = "Dans la phrase ci-dessous : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(38, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 5);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(38, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 51);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Progression du test";
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Consigne);
            this.Controls.Add(this.groupBox_Astuce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Phrase);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Tests";
            this.Size = new System.Drawing.Size(1523, 774);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Astuce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Phrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_Consigne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
