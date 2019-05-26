namespace Dyslexique.UI.UserControls
{
    partial class AjoutType
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
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.idType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idType,
            this.libelle});
            this.dataGridView1.Location = new System.Drawing.Point(928, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 1434);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ajout type :";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(288, 111);
            this.type.Margin = new System.Windows.Forms.Padding(7);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(228, 35);
            this.type.TabIndex = 6;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(535, 111);
            this.ajouter.Margin = new System.Windows.Forms.Padding(7);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(175, 51);
            this.ajouter.TabIndex = 5;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // idType
            // 
            this.idType.HeaderText = "idType";
            this.idType.MinimumWidth = 11;
            this.idType.Name = "idType";
            // 
            // libelle
            // 
            this.libelle.HeaderText = "libelle";
            this.libelle.MinimumWidth = 11;
            this.libelle.Name = "libelle";
            // 
            // AjoutType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.ajouter);
            this.MaximumSize = new System.Drawing.Size(3050, 1530);
            this.MinimumSize = new System.Drawing.Size(3050, 1530);
            this.Name = "AjoutType";
            this.Size = new System.Drawing.Size(3050, 1530);
            this.Load += new System.EventHandler(this.AjoutType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idType;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
    }
}
