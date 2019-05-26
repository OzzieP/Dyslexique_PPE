namespace Dyslexique.UI.UserControls
{
    partial class AjoutFonction
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fonction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFonction,
            this.libelle});
            this.dataGridView1.Location = new System.Drawing.Point(1246, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.Size = new System.Drawing.Size(569, 335);
            this.dataGridView1.TabIndex = 7;
            // 
            // idFonction
            // 
            this.idFonction.HeaderText = "idFonction";
            this.idFonction.MinimumWidth = 11;
            this.idFonction.Name = "idFonction";
            this.idFonction.Width = 225;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "libelle";
            this.libelle.MinimumWidth = 11;
            this.libelle.Name = "libelle";
            this.libelle.Width = 225;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fonction
            // 
            this.fonction.Location = new System.Drawing.Point(331, 48);
            this.fonction.Margin = new System.Windows.Forms.Padding(7);
            this.fonction.Name = "fonction";
            this.fonction.Size = new System.Drawing.Size(228, 35);
            this.fonction.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ajout d\'une Fonction : ";
            // 
            // AjoutFonction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fonction);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(3050, 1530);
            this.MinimumSize = new System.Drawing.Size(3050, 1530);
            this.Name = "AjoutFonction";
            this.Size = new System.Drawing.Size(3050, 1530);
            this.Load += new System.EventHandler(this.AjoutFonction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fonction;
        private System.Windows.Forms.Label label1;
    }
}
