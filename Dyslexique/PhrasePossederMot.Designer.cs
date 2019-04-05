namespace Dyslexique
{
    partial class PhrasePossederMot
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
            this.button1 = new System.Windows.Forms.Button();
            this.UniqueClasse = new System.Windows.Forms.ComboBox();
            this.ClasseEtType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ajouter Mot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UniqueClasse
            // 
            this.UniqueClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UniqueClasse.FormattingEnabled = true;
            this.UniqueClasse.Location = new System.Drawing.Point(150, 43);
            this.UniqueClasse.Name = "UniqueClasse";
            this.UniqueClasse.Size = new System.Drawing.Size(121, 21);
            this.UniqueClasse.TabIndex = 1;
            // 
            // ClasseEtType
            // 
            this.ClasseEtType.FormattingEnabled = true;
            this.ClasseEtType.Location = new System.Drawing.Point(324, 43);
            this.ClasseEtType.Name = "ClasseEtType";
            this.ClasseEtType.Size = new System.Drawing.Size(121, 21);
            this.ClasseEtType.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ajouter Mot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 191);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "quasi sur qu\'elles sont utilent mais je sais plus pourquoi elles sont là";
            // 
            // PhrasePossederMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClasseEtType);
            this.Controls.Add(this.UniqueClasse);
            this.Controls.Add(this.button1);
            this.Name = "PhrasePossederMot";
            this.Text = "PhrasePossederMot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhrasePossederMot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox UniqueClasse;
        private System.Windows.Forms.ComboBox ClasseEtType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}