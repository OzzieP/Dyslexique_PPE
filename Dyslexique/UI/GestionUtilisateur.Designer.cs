namespace Dyslexique.UI
{
    partial class GestionUtilisateur
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteUtilisateur = new System.Windows.Forms.TextBox();
            this.button_DeleteUtilisateur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_UpdateUtilisateur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UpdatePseudo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_UpdateUtilisateur = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_UpdateAdministrateur = new System.Windows.Forms.RadioButton();
            this.groupBox_InsertUtilisateur = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_InsertUtilisateur = new System.Windows.Forms.Button();
            this.textBox_InsertPseudo = new System.Windows.Forms.TextBox();
            this.radioButton_InsertUtilisateur = new System.Windows.Forms.RadioButton();
            this.radioButton_InsertAdministrateur = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllUtilisateurs = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_InsertUtilisateur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.textBox_DeleteUtilisateur);
            this.groupBox2.Controls.Add(this.button_DeleteUtilisateur);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.groupBox2.Location = new System.Drawing.Point(1367, 1020);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 322);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression d\'un utilisateur";
            // 
            // textBox_DeleteUtilisateur
            // 
            this.textBox_DeleteUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeleteUtilisateur.Location = new System.Drawing.Point(328, 140);
            this.textBox_DeleteUtilisateur.Name = "textBox_DeleteUtilisateur";
            this.textBox_DeleteUtilisateur.ReadOnly = true;
            this.textBox_DeleteUtilisateur.Size = new System.Drawing.Size(470, 35);
            this.textBox_DeleteUtilisateur.TabIndex = 5;
            // 
            // button_DeleteUtilisateur
            // 
            this.button_DeleteUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.button_DeleteUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_DeleteUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_DeleteUtilisateur.Location = new System.Drawing.Point(328, 216);
            this.button_DeleteUtilisateur.Name = "button_DeleteUtilisateur";
            this.button_DeleteUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_DeleteUtilisateur.TabIndex = 4;
            this.button_DeleteUtilisateur.Text = "Supprimer l\'utilisateur";
            this.button_DeleteUtilisateur.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(157, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Utilisateur :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(87, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(855, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez supprimer.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button_UpdateUtilisateur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_UpdatePseudo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton_UpdateUtilisateur);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButton_UpdateAdministrateur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(1367, 636);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 347);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour d\'un utilisateur";
            // 
            // button_UpdateUtilisateur
            // 
            this.button_UpdateUtilisateur.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_UpdateUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UpdateUtilisateur.Enabled = false;
            this.button_UpdateUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_UpdateUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_UpdateUtilisateur.Location = new System.Drawing.Point(303, 267);
            this.button_UpdateUtilisateur.Name = "button_UpdateUtilisateur";
            this.button_UpdateUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_UpdateUtilisateur.TabIndex = 7;
            this.button_UpdateUtilisateur.Text = "Modifier l\'utilisateur";
            this.button_UpdateUtilisateur.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(87, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(834, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez modifier.";
            // 
            // textBox_UpdatePseudo
            // 
            this.textBox_UpdatePseudo.Enabled = false;
            this.textBox_UpdatePseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_UpdatePseudo.Location = new System.Drawing.Point(303, 139);
            this.textBox_UpdatePseudo.Name = "textBox_UpdatePseudo";
            this.textBox_UpdatePseudo.Size = new System.Drawing.Size(470, 35);
            this.textBox_UpdatePseudo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(161, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pseudo :";
            // 
            // radioButton_UpdateUtilisateur
            // 
            this.radioButton_UpdateUtilisateur.AutoSize = true;
            this.radioButton_UpdateUtilisateur.Enabled = false;
            this.radioButton_UpdateUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_UpdateUtilisateur.Location = new System.Drawing.Point(622, 213);
            this.radioButton_UpdateUtilisateur.Name = "radioButton_UpdateUtilisateur";
            this.radioButton_UpdateUtilisateur.Size = new System.Drawing.Size(151, 33);
            this.radioButton_UpdateUtilisateur.TabIndex = 5;
            this.radioButton_UpdateUtilisateur.TabStop = true;
            this.radioButton_UpdateUtilisateur.Text = "Utilisateur";
            this.radioButton_UpdateUtilisateur.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(161, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rôle : ";
            // 
            // radioButton_UpdateAdministrateur
            // 
            this.radioButton_UpdateAdministrateur.AutoSize = true;
            this.radioButton_UpdateAdministrateur.Enabled = false;
            this.radioButton_UpdateAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_UpdateAdministrateur.Location = new System.Drawing.Point(303, 213);
            this.radioButton_UpdateAdministrateur.Name = "radioButton_UpdateAdministrateur";
            this.radioButton_UpdateAdministrateur.Size = new System.Drawing.Size(198, 33);
            this.radioButton_UpdateAdministrateur.TabIndex = 4;
            this.radioButton_UpdateAdministrateur.TabStop = true;
            this.radioButton_UpdateAdministrateur.Text = "Administrateur";
            this.radioButton_UpdateAdministrateur.UseVisualStyleBackColor = true;
            // 
            // groupBox_InsertUtilisateur
            // 
            this.groupBox_InsertUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_InsertUtilisateur.Controls.Add(this.label5);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label2);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label4);
            this.groupBox_InsertUtilisateur.Controls.Add(this.button_InsertUtilisateur);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertPseudo);
            this.groupBox_InsertUtilisateur.Controls.Add(this.radioButton_InsertUtilisateur);
            this.groupBox_InsertUtilisateur.Controls.Add(this.radioButton_InsertAdministrateur);
            this.groupBox_InsertUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_InsertUtilisateur.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox_InsertUtilisateur.Location = new System.Drawing.Point(1367, 241);
            this.groupBox_InsertUtilisateur.Name = "groupBox_InsertUtilisateur";
            this.groupBox_InsertUtilisateur.Size = new System.Drawing.Size(1045, 364);
            this.groupBox_InsertUtilisateur.TabIndex = 12;
            this.groupBox_InsertUtilisateur.TabStop = false;
            this.groupBox_InsertUtilisateur.Text = "Ajout d\'un utilisateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(161, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rôle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(117, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(804, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renseignez le pseudo et le rôle de l\'utilisateur que vous souhaitez ajouter.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(161, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pseudo :";
            // 
            // button_InsertUtilisateur
            // 
            this.button_InsertUtilisateur.BackColor = System.Drawing.Color.DarkGreen;
            this.button_InsertUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InsertUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_InsertUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_InsertUtilisateur.Location = new System.Drawing.Point(303, 275);
            this.button_InsertUtilisateur.Name = "button_InsertUtilisateur";
            this.button_InsertUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_InsertUtilisateur.TabIndex = 1;
            this.button_InsertUtilisateur.Text = "Ajouter l\'utilisateur";
            this.button_InsertUtilisateur.UseVisualStyleBackColor = false;
            // 
            // textBox_InsertPseudo
            // 
            this.textBox_InsertPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_InsertPseudo.Location = new System.Drawing.Point(303, 135);
            this.textBox_InsertPseudo.Name = "textBox_InsertPseudo";
            this.textBox_InsertPseudo.Size = new System.Drawing.Size(470, 35);
            this.textBox_InsertPseudo.TabIndex = 3;
            // 
            // radioButton_InsertUtilisateur
            // 
            this.radioButton_InsertUtilisateur.AutoSize = true;
            this.radioButton_InsertUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_InsertUtilisateur.Location = new System.Drawing.Point(622, 204);
            this.radioButton_InsertUtilisateur.Name = "radioButton_InsertUtilisateur";
            this.radioButton_InsertUtilisateur.Size = new System.Drawing.Size(151, 33);
            this.radioButton_InsertUtilisateur.TabIndex = 5;
            this.radioButton_InsertUtilisateur.TabStop = true;
            this.radioButton_InsertUtilisateur.Text = "Utilisateur";
            this.radioButton_InsertUtilisateur.UseVisualStyleBackColor = true;
            // 
            // radioButton_InsertAdministrateur
            // 
            this.radioButton_InsertAdministrateur.AutoSize = true;
            this.radioButton_InsertAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_InsertAdministrateur.Location = new System.Drawing.Point(303, 200);
            this.radioButton_InsertAdministrateur.Name = "radioButton_InsertAdministrateur";
            this.radioButton_InsertAdministrateur.Size = new System.Drawing.Size(198, 33);
            this.radioButton_InsertAdministrateur.TabIndex = 4;
            this.radioButton_InsertAdministrateur.TabStop = true;
            this.radioButton_InsertAdministrateur.Text = "Administrateur";
            this.radioButton_InsertAdministrateur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dataGridView_AllUtilisateurs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(168, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1098, 1101);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des utilisateurs";
            // 
            // dataGridView_AllUtilisateurs
            // 
            this.dataGridView_AllUtilisateurs.AllowUserToAddRows = false;
            this.dataGridView_AllUtilisateurs.AllowUserToDeleteRows = false;
            this.dataGridView_AllUtilisateurs.AllowUserToOrderColumns = true;
            this.dataGridView_AllUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllUtilisateurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_AllUtilisateurs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_AllUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AllUtilisateurs.Location = new System.Drawing.Point(3, 37);
            this.dataGridView_AllUtilisateurs.MultiSelect = false;
            this.dataGridView_AllUtilisateurs.Name = "dataGridView_AllUtilisateurs";
            this.dataGridView_AllUtilisateurs.ReadOnly = true;
            this.dataGridView_AllUtilisateurs.RowTemplate.Height = 37;
            this.dataGridView_AllUtilisateurs.Size = new System.Drawing.Size(1092, 1061);
            this.dataGridView_AllUtilisateurs.TabIndex = 0;
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_InsertUtilisateur);
            this.Name = "GestionUtilisateur";
            this.Size = new System.Drawing.Size(2671, 1656);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_InsertUtilisateur.ResumeLayout(false);
            this.groupBox_InsertUtilisateur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_DeleteUtilisateur;
        private System.Windows.Forms.Button button_DeleteUtilisateur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_UpdateUtilisateur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_UpdatePseudo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_UpdateUtilisateur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton_UpdateAdministrateur;
        private System.Windows.Forms.GroupBox groupBox_InsertUtilisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_InsertUtilisateur;
        private System.Windows.Forms.TextBox textBox_InsertPseudo;
        private System.Windows.Forms.RadioButton radioButton_InsertUtilisateur;
        private System.Windows.Forms.RadioButton radioButton_InsertAdministrateur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_AllUtilisateurs;
    }
}
