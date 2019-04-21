namespace Dyslexique.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Administrateur = new System.Windows.Forms.PictureBox();
            this.pictureBox_Utilisateur = new System.Windows.Forms.PictureBox();
            this.label_Pseudo = new System.Windows.Forms.Label();
            this.button_QuitterApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Administration = new System.Windows.Forms.Panel();
            this.button_Menu_Phrases = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Menu_Utilisateurs = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Menu_Apropos = new System.Windows.Forms.Button();
            this.button_Menu_Tests = new System.Windows.Forms.Button();
            this.button_Menu_Accueil = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Administrateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Administration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panel_Header.Controls.Add(this.label_Title);
            this.panel_Header.Controls.Add(this.pictureBox_Administrateur);
            this.panel_Header.Controls.Add(this.pictureBox_Utilisateur);
            this.panel_Header.Controls.Add(this.label_Pseudo);
            this.panel_Header.Controls.Add(this.button_QuitterApplication);
            this.panel_Header.Controls.Add(this.label2);
            this.panel_Header.Controls.Add(this.label1);
            this.panel_Header.Controls.Add(this.pictureBox1);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1703, 67);
            this.panel_Header.TabIndex = 0;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(470, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(217, 39);
            this.label_Title.TabIndex = 7;
            this.label_Title.Text = "Titre de la page";
            // 
            // pictureBox_Administrateur
            // 
            this.pictureBox_Administrateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Administrateur.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Administrateur.Image")));
            this.pictureBox_Administrateur.Location = new System.Drawing.Point(1340, 0);
            this.pictureBox_Administrateur.Name = "pictureBox_Administrateur";
            this.pictureBox_Administrateur.Size = new System.Drawing.Size(69, 67);
            this.pictureBox_Administrateur.TabIndex = 6;
            this.pictureBox_Administrateur.TabStop = false;
            this.pictureBox_Administrateur.Visible = false;
            // 
            // pictureBox_Utilisateur
            // 
            this.pictureBox_Utilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Utilisateur.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Utilisateur.Image")));
            this.pictureBox_Utilisateur.Location = new System.Drawing.Point(1340, 0);
            this.pictureBox_Utilisateur.Name = "pictureBox_Utilisateur";
            this.pictureBox_Utilisateur.Size = new System.Drawing.Size(69, 67);
            this.pictureBox_Utilisateur.TabIndex = 5;
            this.pictureBox_Utilisateur.TabStop = false;
            this.pictureBox_Utilisateur.Visible = false;
            // 
            // label_Pseudo
            // 
            this.label_Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Pseudo.AutoSize = true;
            this.label_Pseudo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pseudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Pseudo.Location = new System.Drawing.Point(1416, 20);
            this.label_Pseudo.Name = "label_Pseudo";
            this.label_Pseudo.Size = new System.Drawing.Size(77, 22);
            this.label_Pseudo.TabIndex = 4;
            this.label_Pseudo.Text = "Pseudo";
            // 
            // button_QuitterApplication
            // 
            this.button_QuitterApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_QuitterApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QuitterApplication.FlatAppearance.BorderSize = 0;
            this.button_QuitterApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuitterApplication.ForeColor = System.Drawing.SystemColors.Control;
            this.button_QuitterApplication.Image = ((System.Drawing.Image)(resources.GetObject("button_QuitterApplication.Image")));
            this.button_QuitterApplication.Location = new System.Drawing.Point(1641, 0);
            this.button_QuitterApplication.Margin = new System.Windows.Forms.Padding(1);
            this.button_QuitterApplication.Name = "button_QuitterApplication";
            this.button_QuitterApplication.Size = new System.Drawing.Size(61, 66);
            this.button_QuitterApplication.TabIndex = 3;
            this.button_QuitterApplication.UseVisualStyleBackColor = true;
            this.button_QuitterApplication.Click += new System.EventHandler(this.Button_QuitterApplication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Créé par Simpléduc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dyslexique";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.panel_Administration);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_Menu_Apropos);
            this.panel2.Controls.Add(this.button_Menu_Tests);
            this.panel2.Controls.Add(this.button_Menu_Accueil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 773);
            this.panel2.TabIndex = 1;
            // 
            // panel_Administration
            // 
            this.panel_Administration.Controls.Add(this.button_Menu_Phrases);
            this.panel_Administration.Controls.Add(this.panel4);
            this.panel_Administration.Controls.Add(this.label5);
            this.panel_Administration.Controls.Add(this.button_Menu_Utilisateurs);
            this.panel_Administration.Location = new System.Drawing.Point(0, 345);
            this.panel_Administration.Name = "panel_Administration";
            this.panel_Administration.Size = new System.Drawing.Size(180, 232);
            this.panel_Administration.TabIndex = 2;
            this.panel_Administration.Visible = false;
            // 
            // button_Menu_Phrases
            // 
            this.button_Menu_Phrases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Menu_Phrases.FlatAppearance.BorderSize = 0;
            this.button_Menu_Phrases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu_Phrases.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Menu_Phrases.ForeColor = System.Drawing.Color.White;
            this.button_Menu_Phrases.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu_Phrases.Image")));
            this.button_Menu_Phrases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu_Phrases.Location = new System.Drawing.Point(0, 91);
            this.button_Menu_Phrases.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu_Phrases.Name = "button_Menu_Phrases";
            this.button_Menu_Phrases.Size = new System.Drawing.Size(180, 50);
            this.button_Menu_Phrases.TabIndex = 7;
            this.button_Menu_Phrases.Text = "    Phrases";
            this.button_Menu_Phrases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Menu_Phrases.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 10);
            this.panel4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Administration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Menu_Utilisateurs
            // 
            this.button_Menu_Utilisateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Menu_Utilisateurs.FlatAppearance.BorderSize = 0;
            this.button_Menu_Utilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu_Utilisateurs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Menu_Utilisateurs.ForeColor = System.Drawing.Color.White;
            this.button_Menu_Utilisateurs.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu_Utilisateurs.Image")));
            this.button_Menu_Utilisateurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu_Utilisateurs.Location = new System.Drawing.Point(0, 48);
            this.button_Menu_Utilisateurs.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu_Utilisateurs.Name = "button_Menu_Utilisateurs";
            this.button_Menu_Utilisateurs.Size = new System.Drawing.Size(180, 50);
            this.button_Menu_Utilisateurs.TabIndex = 1;
            this.button_Menu_Utilisateurs.Text = "    Utilisateurs";
            this.button_Menu_Utilisateurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Menu_Utilisateurs.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 10);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Navigation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Menu_Apropos
            // 
            this.button_Menu_Apropos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Menu_Apropos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Menu_Apropos.FlatAppearance.BorderSize = 0;
            this.button_Menu_Apropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu_Apropos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Menu_Apropos.ForeColor = System.Drawing.Color.White;
            this.button_Menu_Apropos.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu_Apropos.Image")));
            this.button_Menu_Apropos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu_Apropos.Location = new System.Drawing.Point(1, 723);
            this.button_Menu_Apropos.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu_Apropos.Name = "button_Menu_Apropos";
            this.button_Menu_Apropos.Size = new System.Drawing.Size(180, 50);
            this.button_Menu_Apropos.TabIndex = 3;
            this.button_Menu_Apropos.Text = "    À propos";
            this.button_Menu_Apropos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Menu_Apropos.UseVisualStyleBackColor = true;
            // 
            // button_Menu_Tests
            // 
            this.button_Menu_Tests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Menu_Tests.FlatAppearance.BorderSize = 0;
            this.button_Menu_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu_Tests.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Menu_Tests.ForeColor = System.Drawing.Color.White;
            this.button_Menu_Tests.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu_Tests.Image")));
            this.button_Menu_Tests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu_Tests.Location = new System.Drawing.Point(0, 118);
            this.button_Menu_Tests.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu_Tests.Name = "button_Menu_Tests";
            this.button_Menu_Tests.Size = new System.Drawing.Size(180, 50);
            this.button_Menu_Tests.TabIndex = 2;
            this.button_Menu_Tests.Text = "    Tests";
            this.button_Menu_Tests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Menu_Tests.UseVisualStyleBackColor = true;
            // 
            // button_Menu_Accueil
            // 
            this.button_Menu_Accueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Menu_Accueil.FlatAppearance.BorderSize = 0;
            this.button_Menu_Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu_Accueil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Menu_Accueil.ForeColor = System.Drawing.Color.White;
            this.button_Menu_Accueil.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu_Accueil.Image")));
            this.button_Menu_Accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu_Accueil.Location = new System.Drawing.Point(0, 66);
            this.button_Menu_Accueil.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu_Accueil.Name = "button_Menu_Accueil";
            this.button_Menu_Accueil.Size = new System.Drawing.Size(180, 50);
            this.button_Menu_Accueil.TabIndex = 0;
            this.button_Menu_Accueil.Text = "    Accueil";
            this.button_Menu_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Menu_Accueil.UseVisualStyleBackColor = true;
            this.button_Menu_Accueil.Click += new System.EventHandler(this.button_Menu_Accueil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 840);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dyslexique";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Administrateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Utilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Administration.ResumeLayout(false);
            this.panel_Administration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_QuitterApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Menu_Utilisateurs;
        private System.Windows.Forms.Button button_Menu_Accueil;
        private System.Windows.Forms.Button button_Menu_Apropos;
        private System.Windows.Forms.Button button_Menu_Tests;
        private System.Windows.Forms.Label label_Pseudo;
        private System.Windows.Forms.PictureBox pictureBox_Utilisateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_Administrateur;
        private System.Windows.Forms.Panel panel_Administration;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Menu_Phrases;
    }
}