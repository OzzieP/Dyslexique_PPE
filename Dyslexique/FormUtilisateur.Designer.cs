namespace Dyslexique
{
    partial class FormUtilisateur
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
            this.components = new System.ComponentModel.Container();
            this.button_InsertUtilisateur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_InsertPseudo = new System.Windows.Forms.TextBox();
            this.radioButton_InsertAdministrateur = new System.Windows.Forms.RadioButton();
            this.radioButton_InsertUtilisateur = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_UpdateAdministrateur = new System.Windows.Forms.RadioButton();
            this.radioButton_UpdateUtilisateur = new System.Windows.Forms.RadioButton();
            this.textBox_UpdatePseudo = new System.Windows.Forms.TextBox();
            this.button_UpdateUtilisateur = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_DeleteUtilisateur = new System.Windows.Forms.Button();
            this.groupBox_InsertUtilisateur = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteUtilisateur = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllUtilisateurs = new System.Windows.Forms.DataGridView();
            this.idUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_InsertUtilisateur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_InsertUtilisateur
            // 
            this.button_InsertUtilisateur.BackColor = System.Drawing.Color.DarkGreen;
            this.button_InsertUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InsertUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_InsertUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_InsertUtilisateur.Location = new System.Drawing.Point(130, 123);
            this.button_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_InsertUtilisateur.Name = "button_InsertUtilisateur";
            this.button_InsertUtilisateur.Size = new System.Drawing.Size(141, 26);
            this.button_InsertUtilisateur.TabIndex = 1;
            this.button_InsertUtilisateur.Text = "Ajouter l\'utilisateur";
            this.button_InsertUtilisateur.UseVisualStyleBackColor = false;
            this.button_InsertUtilisateur.Click += new System.EventHandler(this.Button_InsertUtilisateur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renseignez le pseudo et le rôle de l\'utilisateur que vous souhaitez ajouter.";
            // 
            // textBox_InsertPseudo
            // 
            this.textBox_InsertPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_InsertPseudo.Location = new System.Drawing.Point(130, 61);
            this.textBox_InsertPseudo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox_InsertPseudo.Name = "textBox_InsertPseudo";
            this.textBox_InsertPseudo.Size = new System.Drawing.Size(204, 20);
            this.textBox_InsertPseudo.TabIndex = 3;
            // 
            // radioButton_InsertAdministrateur
            // 
            this.radioButton_InsertAdministrateur.AutoSize = true;
            this.radioButton_InsertAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_InsertAdministrateur.Location = new System.Drawing.Point(130, 90);
            this.radioButton_InsertAdministrateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton_InsertAdministrateur.Name = "radioButton_InsertAdministrateur";
            this.radioButton_InsertAdministrateur.Size = new System.Drawing.Size(91, 17);
            this.radioButton_InsertAdministrateur.TabIndex = 4;
            this.radioButton_InsertAdministrateur.TabStop = true;
            this.radioButton_InsertAdministrateur.Text = "Administrateur";
            this.radioButton_InsertAdministrateur.UseVisualStyleBackColor = true;
            // 
            // radioButton_InsertUtilisateur
            // 
            this.radioButton_InsertUtilisateur.AutoSize = true;
            this.radioButton_InsertUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_InsertUtilisateur.Location = new System.Drawing.Point(267, 91);
            this.radioButton_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton_InsertUtilisateur.Name = "radioButton_InsertUtilisateur";
            this.radioButton_InsertUtilisateur.Size = new System.Drawing.Size(71, 17);
            this.radioButton_InsertUtilisateur.TabIndex = 5;
            this.radioButton_InsertUtilisateur.TabStop = true;
            this.radioButton_InsertUtilisateur.Text = "Utilisateur";
            this.radioButton_InsertUtilisateur.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pseudo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rôle : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez modifier.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(69, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pseudo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(69, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rôle : ";
            // 
            // radioButton_UpdateAdministrateur
            // 
            this.radioButton_UpdateAdministrateur.AutoSize = true;
            this.radioButton_UpdateAdministrateur.Enabled = false;
            this.radioButton_UpdateAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_UpdateAdministrateur.Location = new System.Drawing.Point(130, 95);
            this.radioButton_UpdateAdministrateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton_UpdateAdministrateur.Name = "radioButton_UpdateAdministrateur";
            this.radioButton_UpdateAdministrateur.Size = new System.Drawing.Size(91, 17);
            this.radioButton_UpdateAdministrateur.TabIndex = 4;
            this.radioButton_UpdateAdministrateur.TabStop = true;
            this.radioButton_UpdateAdministrateur.Text = "Administrateur";
            this.radioButton_UpdateAdministrateur.UseVisualStyleBackColor = true;
            // 
            // radioButton_UpdateUtilisateur
            // 
            this.radioButton_UpdateUtilisateur.AutoSize = true;
            this.radioButton_UpdateUtilisateur.Enabled = false;
            this.radioButton_UpdateUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButton_UpdateUtilisateur.Location = new System.Drawing.Point(267, 95);
            this.radioButton_UpdateUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton_UpdateUtilisateur.Name = "radioButton_UpdateUtilisateur";
            this.radioButton_UpdateUtilisateur.Size = new System.Drawing.Size(71, 17);
            this.radioButton_UpdateUtilisateur.TabIndex = 5;
            this.radioButton_UpdateUtilisateur.TabStop = true;
            this.radioButton_UpdateUtilisateur.Text = "Utilisateur";
            this.radioButton_UpdateUtilisateur.UseVisualStyleBackColor = true;
            // 
            // textBox_UpdatePseudo
            // 
            this.textBox_UpdatePseudo.Enabled = false;
            this.textBox_UpdatePseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_UpdatePseudo.Location = new System.Drawing.Point(130, 62);
            this.textBox_UpdatePseudo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox_UpdatePseudo.Name = "textBox_UpdatePseudo";
            this.textBox_UpdatePseudo.Size = new System.Drawing.Size(204, 20);
            this.textBox_UpdatePseudo.TabIndex = 6;
            // 
            // button_UpdateUtilisateur
            // 
            this.button_UpdateUtilisateur.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_UpdateUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UpdateUtilisateur.Enabled = false;
            this.button_UpdateUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_UpdateUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_UpdateUtilisateur.Location = new System.Drawing.Point(130, 120);
            this.button_UpdateUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_UpdateUtilisateur.Name = "button_UpdateUtilisateur";
            this.button_UpdateUtilisateur.Size = new System.Drawing.Size(141, 26);
            this.button_UpdateUtilisateur.TabIndex = 7;
            this.button_UpdateUtilisateur.Text = "Modifier l\'utilisateur";
            this.button_UpdateUtilisateur.UseVisualStyleBackColor = false;
            this.button_UpdateUtilisateur.Click += new System.EventHandler(this.Button_UpdateUtilisateur_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(37, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez supprimer.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(67, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Utilisateur :";
            // 
            // button_DeleteUtilisateur
            // 
            this.button_DeleteUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.button_DeleteUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_DeleteUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_DeleteUtilisateur.Location = new System.Drawing.Point(141, 97);
            this.button_DeleteUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_DeleteUtilisateur.Name = "button_DeleteUtilisateur";
            this.button_DeleteUtilisateur.Size = new System.Drawing.Size(141, 26);
            this.button_DeleteUtilisateur.TabIndex = 4;
            this.button_DeleteUtilisateur.Text = "Supprimer l\'utilisateur";
            this.button_DeleteUtilisateur.UseVisualStyleBackColor = false;
            this.button_DeleteUtilisateur.Click += new System.EventHandler(this.Button_DeleteUtilisateur_Click);
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
            this.groupBox_InsertUtilisateur.Location = new System.Drawing.Point(554, 81);
            this.groupBox_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox_InsertUtilisateur.Name = "groupBox_InsertUtilisateur";
            this.groupBox_InsertUtilisateur.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox_InsertUtilisateur.Size = new System.Drawing.Size(448, 163);
            this.groupBox_InsertUtilisateur.TabIndex = 10;
            this.groupBox_InsertUtilisateur.TabStop = false;
            this.groupBox_InsertUtilisateur.Text = "Ajout d\'un utilisateur";
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
            this.groupBox1.Location = new System.Drawing.Point(554, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(448, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour d\'un utilisateur";
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
            this.groupBox2.Location = new System.Drawing.Point(554, 430);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Size = new System.Drawing.Size(448, 144);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression d\'un utilisateur";
            // 
            // textBox_DeleteUtilisateur
            // 
            this.textBox_DeleteUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeleteUtilisateur.Location = new System.Drawing.Point(141, 63);
            this.textBox_DeleteUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox_DeleteUtilisateur.Name = "textBox_DeleteUtilisateur";
            this.textBox_DeleteUtilisateur.ReadOnly = true;
            this.textBox_DeleteUtilisateur.Size = new System.Drawing.Size(204, 20);
            this.textBox_DeleteUtilisateur.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dataGridView_AllUtilisateurs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(41, 81);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Size = new System.Drawing.Size(471, 494);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des utilisateurs";
            // 
            // dataGridView_AllUtilisateurs
            // 
            this.dataGridView_AllUtilisateurs.AllowUserToAddRows = false;
            this.dataGridView_AllUtilisateurs.AllowUserToDeleteRows = false;
            this.dataGridView_AllUtilisateurs.AllowUserToOrderColumns = true;
            this.dataGridView_AllUtilisateurs.AutoGenerateColumns = false;
            this.dataGridView_AllUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllUtilisateurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_AllUtilisateurs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_AllUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateurDataGridViewTextBoxColumn,
            this.pseudoDataGridViewTextBoxColumn,
            this.idRoleDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView_AllUtilisateurs.DataSource = this.utilisateurBindingSource;
            this.dataGridView_AllUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AllUtilisateurs.Location = new System.Drawing.Point(1, 17);
            this.dataGridView_AllUtilisateurs.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView_AllUtilisateurs.MultiSelect = false;
            this.dataGridView_AllUtilisateurs.Name = "dataGridView_AllUtilisateurs";
            this.dataGridView_AllUtilisateurs.ReadOnly = true;
            this.dataGridView_AllUtilisateurs.RowTemplate.Height = 37;
            this.dataGridView_AllUtilisateurs.Size = new System.Drawing.Size(469, 476);
            this.dataGridView_AllUtilisateurs.TabIndex = 0;
            this.dataGridView_AllUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_AllUtilisateurs_CellClick);
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            this.idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "IdUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.HeaderText = "IdUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            this.idUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtilisateurDataGridViewTextBoxColumn.Visible = false;
            // 
            // pseudoDataGridViewTextBoxColumn
            // 
            this.pseudoDataGridViewTextBoxColumn.DataPropertyName = "Pseudo";
            this.pseudoDataGridViewTextBoxColumn.HeaderText = "Pseudo";
            this.pseudoDataGridViewTextBoxColumn.Name = "pseudoDataGridViewTextBoxColumn";
            this.pseudoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRoleDataGridViewTextBoxColumn
            // 
            this.idRoleDataGridViewTextBoxColumn.DataPropertyName = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.HeaderText = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.Name = "idRoleDataGridViewTextBoxColumn";
            this.idRoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRoleDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Rôle";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(Dyslexique.Classes.Utilisateur);
            // 
            // FormUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 637);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_InsertUtilisateur);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUtilisateur_Load);
            this.groupBox_InsertUtilisateur.ResumeLayout(false);
            this.groupBox_InsertUtilisateur.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_InsertUtilisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_InsertUtilisateur;
        private System.Windows.Forms.RadioButton radioButton_InsertAdministrateur;
        private System.Windows.Forms.TextBox textBox_InsertPseudo;
        private System.Windows.Forms.TextBox textBox_UpdatePseudo;
        private System.Windows.Forms.RadioButton radioButton_UpdateUtilisateur;
        private System.Windows.Forms.RadioButton radioButton_UpdateAdministrateur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_UpdateUtilisateur;
        private System.Windows.Forms.Button button_DeleteUtilisateur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_InsertUtilisateur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_AllUtilisateurs;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.TextBox textBox_DeleteUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}