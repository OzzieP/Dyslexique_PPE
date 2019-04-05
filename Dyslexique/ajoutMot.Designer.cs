namespace Dyslexique
{
    partial class ajoutMot
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
            this.label1 = new System.Windows.Forms.Label();
            this.texteMot = new System.Windows.Forms.TextBox();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distinctLibelleClasse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ajout d\'un mot :";
            // 
            // texteMot
            // 
            this.texteMot.Location = new System.Drawing.Point(97, 9);
            this.texteMot.Name = "texteMot";
            this.texteMot.Size = new System.Drawing.Size(100, 20);
            this.texteMot.TabIndex = 1;
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(203, 8);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasse.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMot,
            this.texte,
            this.Classe,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(570, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // idMot
            // 
            this.idMot.HeaderText = "idMot";
            this.idMot.Name = "idMot";
            // 
            // texte
            // 
            this.texte.HeaderText = "texte";
            this.texte.Name = "texte";
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // distinctLibelleClasse
            // 
            this.distinctLibelleClasse.FormattingEnabled = true;
            this.distinctLibelleClasse.Location = new System.Drawing.Point(203, 58);
            this.distinctLibelleClasse.Name = "distinctLibelleClasse";
            this.distinctLibelleClasse.Size = new System.Drawing.Size(121, 21);
            this.distinctLibelleClasse.TabIndex = 5;
            this.distinctLibelleClasse.SelectedIndexChanged += new System.EventHandler(this.distinctLibelleClasse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "affiner la recherche des classes :";
            // 
            // ajoutMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distinctLibelleClasse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.texteMot);
            this.Controls.Add(this.label1);
            this.Name = "ajoutMot";
            this.Text = "ajoutMot";
            this.Load += new System.EventHandler(this.ajoutMot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texteMot;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMot;
        private System.Windows.Forms.DataGridViewTextBoxColumn texte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ComboBox distinctLibelleClasse;
        private System.Windows.Forms.Label label2;
    }
}