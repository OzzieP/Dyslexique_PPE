namespace Dyslexique
{
    partial class FormAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPhrasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Utilisateur = new System.Windows.Forms.DataGridView();
            this.textBox_Pseudo = new System.Windows.Forms.TextBox();
            this.button_Valider = new System.Windows.Forms.Button();
            this.radioButton_Administrateur = new System.Windows.Forms.RadioButton();
            this.radioButton_Utilisateur = new System.Windows.Forms.RadioButton();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.profilToolStripMenuItem1,
            this.testsToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1474, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(113, 41);
            this.profilToolStripMenuItem.Text = "Accueil";
            // 
            // profilToolStripMenuItem1
            // 
            this.profilToolStripMenuItem1.Name = "profilToolStripMenuItem1";
            this.profilToolStripMenuItem1.Size = new System.Drawing.Size(91, 41);
            this.profilToolStripMenuItem1.Text = "Profil";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(85, 41);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionDesMotsToolStripMenuItem,
            this.gestionDesPhrasesToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(204, 41);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(402, 42);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des Utilisateurs";
            // 
            // gestionDesMotsToolStripMenuItem
            // 
            this.gestionDesMotsToolStripMenuItem.Name = "gestionDesMotsToolStripMenuItem";
            this.gestionDesMotsToolStripMenuItem.Size = new System.Drawing.Size(402, 42);
            this.gestionDesMotsToolStripMenuItem.Text = "Gestion des Mots";
            // 
            // gestionDesPhrasesToolStripMenuItem
            // 
            this.gestionDesPhrasesToolStripMenuItem.Name = "gestionDesPhrasesToolStripMenuItem";
            this.gestionDesPhrasesToolStripMenuItem.Size = new System.Drawing.Size(402, 42);
            this.gestionDesPhrasesToolStripMenuItem.Text = "Gestion des Phrases";
            // 
            // dataGridView_Utilisateur
            // 
            this.dataGridView_Utilisateur.AllowUserToOrderColumns = true;
            this.dataGridView_Utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Utilisateur.Location = new System.Drawing.Point(34, 91);
            this.dataGridView_Utilisateur.Name = "dataGridView_Utilisateur";
            this.dataGridView_Utilisateur.RowTemplate.Height = 37;
            this.dataGridView_Utilisateur.Size = new System.Drawing.Size(1364, 587);
            this.dataGridView_Utilisateur.TabIndex = 1;
            // 
            // textBox_Pseudo
            // 
            this.textBox_Pseudo.Location = new System.Drawing.Point(34, 736);
            this.textBox_Pseudo.Name = "textBox_Pseudo";
            this.textBox_Pseudo.Size = new System.Drawing.Size(382, 35);
            this.textBox_Pseudo.TabIndex = 2;
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(464, 736);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(169, 42);
            this.button_Valider.TabIndex = 3;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButton_Administrateur
            // 
            this.radioButton_Administrateur.AutoSize = true;
            this.radioButton_Administrateur.Location = new System.Drawing.Point(34, 791);
            this.radioButton_Administrateur.Name = "radioButton_Administrateur";
            this.radioButton_Administrateur.Size = new System.Drawing.Size(198, 33);
            this.radioButton_Administrateur.TabIndex = 4;
            this.radioButton_Administrateur.TabStop = true;
            this.radioButton_Administrateur.Text = "Administrateur";
            this.radioButton_Administrateur.UseVisualStyleBackColor = true;
            // 
            // radioButton_Utilisateur
            // 
            this.radioButton_Utilisateur.AutoSize = true;
            this.radioButton_Utilisateur.Location = new System.Drawing.Point(265, 791);
            this.radioButton_Utilisateur.Name = "radioButton_Utilisateur";
            this.radioButton_Utilisateur.Size = new System.Drawing.Size(151, 33);
            this.radioButton_Utilisateur.TabIndex = 5;
            this.radioButton_Utilisateur.TabStop = true;
            this.radioButton_Utilisateur.Text = "Utilisateur";
            this.radioButton_Utilisateur.UseVisualStyleBackColor = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(Dyslexique.Classes.Utilisateur);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 910);
            this.Controls.Add(this.radioButton_Utilisateur);
            this.Controls.Add(this.radioButton_Administrateur);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.textBox_Pseudo);
            this.Controls.Add(this.dataGridView_Utilisateur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Page d\'accueil";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Utilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPhrasesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Utilisateur;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.TextBox textBox_Pseudo;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.RadioButton radioButton_Administrateur;
        private System.Windows.Forms.RadioButton radioButton_Utilisateur;
    }
}