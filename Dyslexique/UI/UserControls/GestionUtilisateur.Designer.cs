namespace Dyslexique.UI.UserControls
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_DeleteUtilisateur = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteRole = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_DeletePrenom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_DeleteNom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_DeletePseudo = new System.Windows.Forms.TextBox();
            this.button_DeleteUtilisateur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_UpdateUtilisateur = new System.Windows.Forms.GroupBox();
            this.textBox_UpdateEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_UpdatePrenom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_UpdateNom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_UpdateUtilisateur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UpdatePseudo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_UpdateUtilisateur = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_UpdateAdministrateur = new System.Windows.Forms.RadioButton();
            this.groupBox_InsertUtilisateur = new System.Windows.Forms.GroupBox();
            this.button_Ajout_ShowConfMdp = new System.Windows.Forms.Button();
            this.button_Ajout_ShowMdp = new System.Windows.Forms.Button();
            this.textBox_InsertConfMdp = new System.Windows.Forms.TextBox();
            this.textBox_InsertMdp = new System.Windows.Forms.TextBox();
            this.textBox_InsertNom = new System.Windows.Forms.TextBox();
            this.textBox_InsertPrenom = new System.Windows.Forms.TextBox();
            this.textBox_InsertEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_InsertUtilisateur = new System.Windows.Forms.Button();
            this.textBox_InsertPseudo = new System.Windows.Forms.TextBox();
            this.radioButton_InsertUtilisateur = new System.Windows.Forms.RadioButton();
            this.radioButton_InsertAdministrateur = new System.Windows.Forms.RadioButton();
            this.groupBox_DataGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllUtilisateurs = new System.Windows.Forms.DataGridView();
            this.idUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider_TextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_DeleteUtilisateur.SuspendLayout();
            this.groupBox_UpdateUtilisateur.SuspendLayout();
            this.groupBox_InsertUtilisateur.SuspendLayout();
            this.groupBox_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_DeleteUtilisateur
            // 
            this.groupBox_DeleteUtilisateur.Controls.Add(this.textBox_DeleteRole);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.label19);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.textBox_DeletePrenom);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.label17);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.textBox_DeleteNom);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.label16);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.textBox_DeletePseudo);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.button_DeleteUtilisateur);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.label11);
            this.groupBox_DeleteUtilisateur.Controls.Add(this.label10);
            this.groupBox_DeleteUtilisateur.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DeleteUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.groupBox_DeleteUtilisateur.Location = new System.Drawing.Point(1644, 1112);
            this.groupBox_DeleteUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_DeleteUtilisateur.Name = "groupBox_DeleteUtilisateur";
            this.groupBox_DeleteUtilisateur.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_DeleteUtilisateur.Size = new System.Drawing.Size(1228, 389);
            this.groupBox_DeleteUtilisateur.TabIndex = 14;
            this.groupBox_DeleteUtilisateur.TabStop = false;
            this.groupBox_DeleteUtilisateur.Text = "Suppression d\'un utilisateur";
            // 
            // textBox_DeleteRole
            // 
            this.textBox_DeleteRole.Enabled = false;
            this.textBox_DeleteRole.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeleteRole.Location = new System.Drawing.Point(58, 236);
            this.textBox_DeleteRole.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DeleteRole.Name = "textBox_DeleteRole";
            this.textBox_DeleteRole.ReadOnly = true;
            this.textBox_DeleteRole.Size = new System.Drawing.Size(471, 37);
            this.textBox_DeleteRole.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(53, 205);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 28);
            this.label19.TabIndex = 10;
            this.label19.Text = "Rôle :";
            // 
            // textBox_DeletePrenom
            // 
            this.textBox_DeletePrenom.Enabled = false;
            this.textBox_DeletePrenom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeletePrenom.Location = new System.Drawing.Point(677, 236);
            this.textBox_DeletePrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DeletePrenom.Name = "textBox_DeletePrenom";
            this.textBox_DeletePrenom.ReadOnly = true;
            this.textBox_DeletePrenom.Size = new System.Drawing.Size(471, 37);
            this.textBox_DeletePrenom.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(672, 205);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 28);
            this.label17.TabIndex = 8;
            this.label17.Text = "Prénom :";
            // 
            // textBox_DeleteNom
            // 
            this.textBox_DeleteNom.Enabled = false;
            this.textBox_DeleteNom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeleteNom.Location = new System.Drawing.Point(677, 144);
            this.textBox_DeleteNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DeleteNom.Name = "textBox_DeleteNom";
            this.textBox_DeleteNom.ReadOnly = true;
            this.textBox_DeleteNom.Size = new System.Drawing.Size(471, 37);
            this.textBox_DeleteNom.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(672, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 28);
            this.label16.TabIndex = 6;
            this.label16.Text = "Nom :";
            // 
            // textBox_DeletePseudo
            // 
            this.textBox_DeletePseudo.Enabled = false;
            this.textBox_DeletePseudo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DeletePseudo.Location = new System.Drawing.Point(58, 144);
            this.textBox_DeletePseudo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DeletePseudo.Name = "textBox_DeletePseudo";
            this.textBox_DeletePseudo.ReadOnly = true;
            this.textBox_DeletePseudo.Size = new System.Drawing.Size(471, 37);
            this.textBox_DeletePseudo.TabIndex = 5;
            // 
            // button_DeleteUtilisateur
            // 
            this.button_DeleteUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.button_DeleteUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteUtilisateur.Enabled = false;
            this.button_DeleteUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_DeleteUtilisateur.Location = new System.Drawing.Point(435, 312);
            this.button_DeleteUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteUtilisateur.Name = "button_DeleteUtilisateur";
            this.button_DeleteUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_DeleteUtilisateur.TabIndex = 4;
            this.button_DeleteUtilisateur.Text = "Supprimer l\'utilisateur";
            this.button_DeleteUtilisateur.UseVisualStyleBackColor = false;
            this.button_DeleteUtilisateur.Click += new System.EventHandler(this.Button_DeleteUtilisateur_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "Pseudo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(949, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez supprimer.";
            // 
            // groupBox_UpdateUtilisateur
            // 
            this.groupBox_UpdateUtilisateur.Controls.Add(this.textBox_UpdateEmail);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label18);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.textBox_UpdatePrenom);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label15);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.textBox_UpdateNom);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label14);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.button_UpdateUtilisateur);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label6);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.textBox_UpdatePseudo);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label7);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.radioButton_UpdateUtilisateur);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.label8);
            this.groupBox_UpdateUtilisateur.Controls.Add(this.radioButton_UpdateAdministrateur);
            this.groupBox_UpdateUtilisateur.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_UpdateUtilisateur.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox_UpdateUtilisateur.Location = new System.Drawing.Point(1644, 605);
            this.groupBox_UpdateUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_UpdateUtilisateur.Name = "groupBox_UpdateUtilisateur";
            this.groupBox_UpdateUtilisateur.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_UpdateUtilisateur.Size = new System.Drawing.Size(1228, 458);
            this.groupBox_UpdateUtilisateur.TabIndex = 13;
            this.groupBox_UpdateUtilisateur.TabStop = false;
            this.groupBox_UpdateUtilisateur.Text = "Mise à jour d\'un utilisateur";
            // 
            // textBox_UpdateEmail
            // 
            this.textBox_UpdateEmail.Enabled = false;
            this.textBox_UpdateEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdateEmail.Location = new System.Drawing.Point(677, 232);
            this.textBox_UpdateEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_UpdateEmail.MaxLength = 50;
            this.textBox_UpdateEmail.Name = "textBox_UpdateEmail";
            this.textBox_UpdateEmail.Size = new System.Drawing.Size(471, 37);
            this.textBox_UpdateEmail.TabIndex = 17;
            this.textBox_UpdateEmail.Tag = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(672, 201);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 28);
            this.label18.TabIndex = 16;
            this.label18.Text = "Email :";
            // 
            // textBox_UpdatePrenom
            // 
            this.textBox_UpdatePrenom.Enabled = false;
            this.textBox_UpdatePrenom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdatePrenom.Location = new System.Drawing.Point(58, 323);
            this.textBox_UpdatePrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_UpdatePrenom.MaxLength = 50;
            this.textBox_UpdatePrenom.Name = "textBox_UpdatePrenom";
            this.textBox_UpdatePrenom.Size = new System.Drawing.Size(471, 37);
            this.textBox_UpdatePrenom.TabIndex = 11;
            this.textBox_UpdatePrenom.Tag = "Prénom";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 292);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 28);
            this.label15.TabIndex = 10;
            this.label15.Text = "Prénom :";
            // 
            // textBox_UpdateNom
            // 
            this.textBox_UpdateNom.Enabled = false;
            this.textBox_UpdateNom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdateNom.Location = new System.Drawing.Point(58, 232);
            this.textBox_UpdateNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_UpdateNom.MaxLength = 50;
            this.textBox_UpdateNom.Name = "textBox_UpdateNom";
            this.textBox_UpdateNom.Size = new System.Drawing.Size(471, 37);
            this.textBox_UpdateNom.TabIndex = 9;
            this.textBox_UpdateNom.Tag = "Nom";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 201);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Nom :";
            // 
            // button_UpdateUtilisateur
            // 
            this.button_UpdateUtilisateur.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_UpdateUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UpdateUtilisateur.Enabled = false;
            this.button_UpdateUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_UpdateUtilisateur.Location = new System.Drawing.Point(435, 384);
            this.button_UpdateUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdateUtilisateur.Name = "button_UpdateUtilisateur";
            this.button_UpdateUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_UpdateUtilisateur.TabIndex = 7;
            this.button_UpdateUtilisateur.Text = "Modifier l\'utilisateur";
            this.button_UpdateUtilisateur.UseVisualStyleBackColor = false;
            this.button_UpdateUtilisateur.Click += new System.EventHandler(this.Button_UpdateUtilisateur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(931, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sélectionnez dans la liste de gauche l\'utilisateur que vous souhaitez modifier.";
            // 
            // textBox_UpdatePseudo
            // 
            this.textBox_UpdatePseudo.Enabled = false;
            this.textBox_UpdatePseudo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdatePseudo.Location = new System.Drawing.Point(58, 138);
            this.textBox_UpdatePseudo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_UpdatePseudo.MaxLength = 50;
            this.textBox_UpdatePseudo.Name = "textBox_UpdatePseudo";
            this.textBox_UpdatePseudo.Size = new System.Drawing.Size(471, 37);
            this.textBox_UpdatePseudo.TabIndex = 6;
            this.textBox_UpdatePseudo.Tag = "Pseudo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pseudo :";
            // 
            // radioButton_UpdateUtilisateur
            // 
            this.radioButton_UpdateUtilisateur.AutoSize = true;
            this.radioButton_UpdateUtilisateur.Enabled = false;
            this.radioButton_UpdateUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_UpdateUtilisateur.Location = new System.Drawing.Point(997, 140);
            this.radioButton_UpdateUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_UpdateUtilisateur.Name = "radioButton_UpdateUtilisateur";
            this.radioButton_UpdateUtilisateur.Size = new System.Drawing.Size(158, 34);
            this.radioButton_UpdateUtilisateur.TabIndex = 5;
            this.radioButton_UpdateUtilisateur.TabStop = true;
            this.radioButton_UpdateUtilisateur.Text = "Utilisateur";
            this.radioButton_UpdateUtilisateur.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rôle : ";
            // 
            // radioButton_UpdateAdministrateur
            // 
            this.radioButton_UpdateAdministrateur.AutoSize = true;
            this.radioButton_UpdateAdministrateur.Enabled = false;
            this.radioButton_UpdateAdministrateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_UpdateAdministrateur.Location = new System.Drawing.Point(677, 140);
            this.radioButton_UpdateAdministrateur.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_UpdateAdministrateur.Name = "radioButton_UpdateAdministrateur";
            this.radioButton_UpdateAdministrateur.Size = new System.Drawing.Size(215, 34);
            this.radioButton_UpdateAdministrateur.TabIndex = 4;
            this.radioButton_UpdateAdministrateur.TabStop = true;
            this.radioButton_UpdateAdministrateur.Text = "Administrateur";
            this.radioButton_UpdateAdministrateur.UseVisualStyleBackColor = true;
            // 
            // groupBox_InsertUtilisateur
            // 
            this.groupBox_InsertUtilisateur.Controls.Add(this.button_Ajout_ShowConfMdp);
            this.groupBox_InsertUtilisateur.Controls.Add(this.button_Ajout_ShowMdp);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertConfMdp);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertMdp);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertNom);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertPrenom);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertEmail);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label13);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label12);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label9);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label3);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label1);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label5);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label2);
            this.groupBox_InsertUtilisateur.Controls.Add(this.label4);
            this.groupBox_InsertUtilisateur.Controls.Add(this.button_InsertUtilisateur);
            this.groupBox_InsertUtilisateur.Controls.Add(this.textBox_InsertPseudo);
            this.groupBox_InsertUtilisateur.Controls.Add(this.radioButton_InsertUtilisateur);
            this.groupBox_InsertUtilisateur.Controls.Add(this.radioButton_InsertAdministrateur);
            this.groupBox_InsertUtilisateur.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_InsertUtilisateur.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox_InsertUtilisateur.Location = new System.Drawing.Point(1644, 28);
            this.groupBox_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_InsertUtilisateur.Name = "groupBox_InsertUtilisateur";
            this.groupBox_InsertUtilisateur.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_InsertUtilisateur.Size = new System.Drawing.Size(1228, 533);
            this.groupBox_InsertUtilisateur.TabIndex = 12;
            this.groupBox_InsertUtilisateur.TabStop = false;
            this.groupBox_InsertUtilisateur.Text = "Ajout d\'un utilisateur";
            // 
            // button_Ajout_ShowConfMdp
            // 
            this.button_Ajout_ShowConfMdp.FlatAppearance.BorderSize = 0;
            this.button_Ajout_ShowConfMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajout_ShowConfMdp.Image = global::Dyslexique.Properties.Resources.Eye_16;
            this.button_Ajout_ShowConfMdp.Location = new System.Drawing.Point(1157, 311);
            this.button_Ajout_ShowConfMdp.Margin = new System.Windows.Forms.Padding(7);
            this.button_Ajout_ShowConfMdp.Name = "button_Ajout_ShowConfMdp";
            this.button_Ajout_ShowConfMdp.Size = new System.Drawing.Size(44, 37);
            this.button_Ajout_ShowConfMdp.TabIndex = 23;
            this.button_Ajout_ShowConfMdp.UseVisualStyleBackColor = true;
            this.button_Ajout_ShowConfMdp.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave_HideMdp);
            this.button_Ajout_ShowConfMdp.MouseHover += new System.EventHandler(this.Buttons_MouseHover_ShowMdp);
            // 
            // button_Ajout_ShowMdp
            // 
            this.button_Ajout_ShowMdp.FlatAppearance.BorderSize = 0;
            this.button_Ajout_ShowMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajout_ShowMdp.Image = global::Dyslexique.Properties.Resources.Eye_16;
            this.button_Ajout_ShowMdp.Location = new System.Drawing.Point(1157, 219);
            this.button_Ajout_ShowMdp.Margin = new System.Windows.Forms.Padding(7);
            this.button_Ajout_ShowMdp.Name = "button_Ajout_ShowMdp";
            this.button_Ajout_ShowMdp.Size = new System.Drawing.Size(44, 37);
            this.button_Ajout_ShowMdp.TabIndex = 22;
            this.button_Ajout_ShowMdp.UseVisualStyleBackColor = true;
            this.button_Ajout_ShowMdp.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave_HideMdp);
            this.button_Ajout_ShowMdp.MouseHover += new System.EventHandler(this.Buttons_MouseHover_ShowMdp);
            // 
            // textBox_InsertConfMdp
            // 
            this.textBox_InsertConfMdp.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertConfMdp.Location = new System.Drawing.Point(677, 311);
            this.textBox_InsertConfMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertConfMdp.Name = "textBox_InsertConfMdp";
            this.textBox_InsertConfMdp.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertConfMdp.TabIndex = 18;
            this.textBox_InsertConfMdp.Tag = "Confirmation du mot de passe";
            this.textBox_InsertConfMdp.UseSystemPasswordChar = true;
            // 
            // textBox_InsertMdp
            // 
            this.textBox_InsertMdp.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertMdp.Location = new System.Drawing.Point(677, 219);
            this.textBox_InsertMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertMdp.Name = "textBox_InsertMdp";
            this.textBox_InsertMdp.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertMdp.TabIndex = 17;
            this.textBox_InsertMdp.Tag = "Mot de passe";
            this.textBox_InsertMdp.UseSystemPasswordChar = true;
            // 
            // textBox_InsertNom
            // 
            this.textBox_InsertNom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertNom.Location = new System.Drawing.Point(58, 219);
            this.textBox_InsertNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertNom.Name = "textBox_InsertNom";
            this.textBox_InsertNom.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertNom.TabIndex = 16;
            this.textBox_InsertNom.Tag = "Nom";
            // 
            // textBox_InsertPrenom
            // 
            this.textBox_InsertPrenom.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertPrenom.Location = new System.Drawing.Point(58, 311);
            this.textBox_InsertPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertPrenom.Name = "textBox_InsertPrenom";
            this.textBox_InsertPrenom.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertPrenom.TabIndex = 15;
            this.textBox_InsertPrenom.Tag = "Prénom";
            // 
            // textBox_InsertEmail
            // 
            this.textBox_InsertEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertEmail.Location = new System.Drawing.Point(58, 403);
            this.textBox_InsertEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertEmail.Name = "textBox_InsertEmail";
            this.textBox_InsertEmail.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertEmail.TabIndex = 14;
            this.textBox_InsertEmail.Tag = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(672, 280);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(379, 28);
            this.label13.TabIndex = 13;
            this.label13.Text = "Confirmation du mot de passe :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "Prénom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rôle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(756, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renseignez les informations ci-dessus afin d\'ajouter l\'utilisateur.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pseudo :";
            // 
            // button_InsertUtilisateur
            // 
            this.button_InsertUtilisateur.BackColor = System.Drawing.Color.DarkGreen;
            this.button_InsertUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InsertUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertUtilisateur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_InsertUtilisateur.Location = new System.Drawing.Point(435, 459);
            this.button_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.button_InsertUtilisateur.Name = "button_InsertUtilisateur";
            this.button_InsertUtilisateur.Size = new System.Drawing.Size(329, 58);
            this.button_InsertUtilisateur.TabIndex = 1;
            this.button_InsertUtilisateur.Text = "Ajouter l\'utilisateur";
            this.button_InsertUtilisateur.UseVisualStyleBackColor = false;
            this.button_InsertUtilisateur.Click += new System.EventHandler(this.Button_InsertUtilisateur_Click);
            // 
            // textBox_InsertPseudo
            // 
            this.textBox_InsertPseudo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertPseudo.Location = new System.Drawing.Point(58, 129);
            this.textBox_InsertPseudo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InsertPseudo.MaxLength = 50;
            this.textBox_InsertPseudo.Name = "textBox_InsertPseudo";
            this.textBox_InsertPseudo.Size = new System.Drawing.Size(471, 37);
            this.textBox_InsertPseudo.TabIndex = 3;
            this.textBox_InsertPseudo.Tag = "Pseudo";
            // 
            // radioButton_InsertUtilisateur
            // 
            this.radioButton_InsertUtilisateur.AutoSize = true;
            this.radioButton_InsertUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_InsertUtilisateur.Location = new System.Drawing.Point(997, 129);
            this.radioButton_InsertUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_InsertUtilisateur.Name = "radioButton_InsertUtilisateur";
            this.radioButton_InsertUtilisateur.Size = new System.Drawing.Size(158, 34);
            this.radioButton_InsertUtilisateur.TabIndex = 5;
            this.radioButton_InsertUtilisateur.TabStop = true;
            this.radioButton_InsertUtilisateur.Text = "Utilisateur";
            this.radioButton_InsertUtilisateur.UseVisualStyleBackColor = true;
            // 
            // radioButton_InsertAdministrateur
            // 
            this.radioButton_InsertAdministrateur.AutoSize = true;
            this.radioButton_InsertAdministrateur.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_InsertAdministrateur.Location = new System.Drawing.Point(677, 129);
            this.radioButton_InsertAdministrateur.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_InsertAdministrateur.Name = "radioButton_InsertAdministrateur";
            this.radioButton_InsertAdministrateur.Size = new System.Drawing.Size(215, 34);
            this.radioButton_InsertAdministrateur.TabIndex = 4;
            this.radioButton_InsertAdministrateur.TabStop = true;
            this.radioButton_InsertAdministrateur.Text = "Administrateur";
            this.radioButton_InsertAdministrateur.UseVisualStyleBackColor = true;
            // 
            // groupBox_DataGridView
            // 
            this.groupBox_DataGridView.Controls.Add(this.dataGridView_AllUtilisateurs);
            this.groupBox_DataGridView.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DataGridView.Location = new System.Drawing.Point(178, 28);
            this.groupBox_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_DataGridView.Name = "groupBox_DataGridView";
            this.groupBox_DataGridView.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_DataGridView.Size = new System.Drawing.Size(1374, 1475);
            this.groupBox_DataGridView.TabIndex = 15;
            this.groupBox_DataGridView.TabStop = false;
            this.groupBox_DataGridView.Text = "Liste des utilisateurs";
            // 
            // dataGridView_AllUtilisateurs
            // 
            this.dataGridView_AllUtilisateurs.AllowUserToAddRows = false;
            this.dataGridView_AllUtilisateurs.AllowUserToDeleteRows = false;
            this.dataGridView_AllUtilisateurs.AutoGenerateColumns = false;
            this.dataGridView_AllUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllUtilisateurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_AllUtilisateurs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_AllUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateurDataGridViewTextBoxColumn,
            this.pseudoDataGridViewTextBoxColumn,
            this.Nom,
            this.Prenom,
            this.Email,
            this.idRoleDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView_AllUtilisateurs.DataSource = this.utilisateurBindingSource;
            this.dataGridView_AllUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AllUtilisateurs.Location = new System.Drawing.Point(2, 39);
            this.dataGridView_AllUtilisateurs.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_AllUtilisateurs.MultiSelect = false;
            this.dataGridView_AllUtilisateurs.Name = "dataGridView_AllUtilisateurs";
            this.dataGridView_AllUtilisateurs.ReadOnly = true;
            this.dataGridView_AllUtilisateurs.RowHeadersWidth = 92;
            this.dataGridView_AllUtilisateurs.RowTemplate.Height = 37;
            this.dataGridView_AllUtilisateurs.Size = new System.Drawing.Size(1370, 1434);
            this.dataGridView_AllUtilisateurs.TabIndex = 0;
            this.dataGridView_AllUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_AllUtilisateurs_CellClick);
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            this.idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "IdUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.HeaderText = "IdUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            this.idUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtilisateurDataGridViewTextBoxColumn.Visible = false;
            // 
            // pseudoDataGridViewTextBoxColumn
            // 
            this.pseudoDataGridViewTextBoxColumn.DataPropertyName = "Pseudo";
            this.pseudoDataGridViewTextBoxColumn.HeaderText = "Pseudo";
            this.pseudoDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.pseudoDataGridViewTextBoxColumn.Name = "pseudoDataGridViewTextBoxColumn";
            this.pseudoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 11;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.MinimumWidth = 11;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 11;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 144;
            // 
            // idRoleDataGridViewTextBoxColumn
            // 
            this.idRoleDataGridViewTextBoxColumn.DataPropertyName = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.HeaderText = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.idRoleDataGridViewTextBoxColumn.Name = "idRoleDataGridViewTextBoxColumn";
            this.idRoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRoleDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Rôle";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(Dyslexique.Classes.Utilisateur);
            // 
            // errorProvider_TextBox
            // 
            this.errorProvider_TextBox.ContainerControl = this;
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_DataGridView);
            this.Controls.Add(this.groupBox_DeleteUtilisateur);
            this.Controls.Add(this.groupBox_UpdateUtilisateur);
            this.Controls.Add(this.groupBox_InsertUtilisateur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(3050, 1530);
            this.MinimumSize = new System.Drawing.Size(3050, 1530);
            this.Name = "GestionUtilisateur";
            this.Size = new System.Drawing.Size(3050, 1530);
            this.Load += new System.EventHandler(this.GestionUtilisateur_Load);
            this.groupBox_DeleteUtilisateur.ResumeLayout(false);
            this.groupBox_DeleteUtilisateur.PerformLayout();
            this.groupBox_UpdateUtilisateur.ResumeLayout(false);
            this.groupBox_UpdateUtilisateur.PerformLayout();
            this.groupBox_InsertUtilisateur.ResumeLayout(false);
            this.groupBox_InsertUtilisateur.PerformLayout();
            this.groupBox_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DeleteUtilisateur;
        private System.Windows.Forms.TextBox textBox_DeletePseudo;
        private System.Windows.Forms.Button button_DeleteUtilisateur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_UpdateUtilisateur;
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
        private System.Windows.Forms.GroupBox groupBox_DataGridView;
        private System.Windows.Forms.DataGridView dataGridView_AllUtilisateurs;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.TextBox textBox_InsertConfMdp;
        private System.Windows.Forms.TextBox textBox_InsertMdp;
        private System.Windows.Forms.TextBox textBox_InsertNom;
        private System.Windows.Forms.TextBox textBox_InsertPrenom;
        private System.Windows.Forms.TextBox textBox_InsertEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UpdateEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_UpdatePrenom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_UpdateNom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_DeleteRole;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_DeletePrenom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_DeleteNom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider_TextBox;
        private System.Windows.Forms.Button button_Ajout_ShowConfMdp;
        private System.Windows.Forms.Button button_Ajout_ShowMdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}
