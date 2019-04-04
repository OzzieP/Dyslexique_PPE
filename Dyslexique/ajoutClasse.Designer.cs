namespace Dyslexique
{
    partial class ajoutClasse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.libelleClasse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasse,
            this.libelle,
            this.type});
            this.dataGridView1.Location = new System.Drawing.Point(444, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // idClasse
            // 
            this.idClasse.HeaderText = "idClasse";
            this.idClasse.Name = "idClasse";
            // 
            // libelle
            // 
            this.libelle.HeaderText = "libelle";
            this.libelle.Name = "libelle";
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ajout d\'une Classe :";
            // 
            // libelleClasse
            // 
            this.libelleClasse.Location = new System.Drawing.Point(117, 12);
            this.libelleClasse.Name = "libelleClasse";
            this.libelleClasse.Size = new System.Drawing.Size(100, 20);
            this.libelleClasse.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ajout Classe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(223, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            // 
            // ajoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.libelleClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ajoutClasse";
            this.Text = "ajoutAdjectif";
            this.Load += new System.EventHandler(this.ajoutClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox libelleClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}