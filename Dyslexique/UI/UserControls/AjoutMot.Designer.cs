namespace Dyslexique.UI.UserControls
{
    partial class AjoutMot
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
            this.label2 = new System.Windows.Forms.Label();
            this.distinctLibelleClasse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.texteMot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "affiner la recherche des classes :";
            // 
            // distinctLibelleClasse
            // 
            this.distinctLibelleClasse.FormattingEnabled = true;
            this.distinctLibelleClasse.Location = new System.Drawing.Point(470, 146);
            this.distinctLibelleClasse.Margin = new System.Windows.Forms.Padding(7);
            this.distinctLibelleClasse.Name = "distinctLibelleClasse";
            this.distinctLibelleClasse.Size = new System.Drawing.Size(277, 37);
            this.distinctLibelleClasse.TabIndex = 12;
            this.distinctLibelleClasse.SelectedIndexChanged += new System.EventHandler(this.distinctLibelleClasse_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMot,
            this.texte,
            this.Classe,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(1069, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 1434);
            this.dataGridView1.TabIndex = 11;
            // 
            // idMot
            // 
            this.idMot.HeaderText = "idMot";
            this.idMot.MinimumWidth = 11;
            this.idMot.Name = "idMot";
            // 
            // texte
            // 
            this.texte.HeaderText = "texte";
            this.texte.MinimumWidth = 11;
            this.texte.Name = "texte";
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.MinimumWidth = 11;
            this.Classe.Name = "Classe";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 11;
            this.Type.Name = "Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(470, 35);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(7);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(277, 37);
            this.comboBoxClasse.TabIndex = 9;
            // 
            // texteMot
            // 
            this.texteMot.Location = new System.Drawing.Point(222, 37);
            this.texteMot.Margin = new System.Windows.Forms.Padding(7);
            this.texteMot.Name = "texteMot";
            this.texteMot.Size = new System.Drawing.Size(228, 35);
            this.texteMot.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ajout d\'un mot :";
            // 
            // AjoutMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distinctLibelleClasse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.texteMot);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(3050, 1530);
            this.MinimumSize = new System.Drawing.Size(3050, 1530);
            this.Name = "AjoutMot";
            this.Size = new System.Drawing.Size(3050, 1530);
            this.Load += new System.EventHandler(this.AjoutMot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox distinctLibelleClasse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMot;
        private System.Windows.Forms.DataGridViewTextBoxColumn texte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.TextBox texteMot;
        private System.Windows.Forms.Label label1;
    }
}
