﻿using Dyslexique.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dyslexique.UI.UserControls;

namespace Dyslexique.UI.Forms
{
    /// <summary>
    /// Form affichant la page principale.
    /// </summary>
    public partial class MainForm : Form
    {
        /* Attributs/fonctions permettant le déplacement de la Form */
        /// <summary>
        /// Attribut permettant le déplacement de la Form.
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;

        /// <summary>
        /// Attribut permettant le déplacement de la Form.
        /// </summary>
        public const int HT_CAPTION = 0x2;

        /// <summary>
        /// Fonction importée permettant le déplacement de la Form.
        /// </summary>
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// Fonction importée permettant le déplacement de la Form.
        /// </summary>
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /* --------------------------------------------------------- */

        /// <summary>
        /// Constructeur par défaut de la Form principale.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Controls.Add(accueil);
            accueil.BringToFront();
            label_Title.Text = accueil.Title;

            label_Pseudo.Text = Global.Utilisateur.Pseudo;

            if (Global.Utilisateur.IdRole == Global.ROLE_UTILISATEUR)
                pictureBox_Role_Utilisateur.Image = Properties.Resources.Utilisateur_64;
            else if (Global.Utilisateur.IdRole == Global.ROLE_ADMINISTRATEUR)
            {
                pictureBox_Role_Utilisateur.Image = Dyslexique.Properties.Resources.Administrateur_64;
                panel_Administration.Visible = true;
            }
        }

        // Fonction permettant de déplacer la Form
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Fonction pour quitter et arrêter l'application
        private void Button_QuitterApplication_Click(object sender, EventArgs e)
        {
            DialogResult logoutOrExit = MessageBox.Show("Souhaitez-vous vraiment quitter l'application ?\n" +
                "CHOIX :\n" +
                "\"Oui\" : Quitter l'application.\n" +
                "\"Non\" : Se déconnecter.\n" +
                "\"Annuler\" : Revenir sur l'application.",
                "Êtes-vous sûr ?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (logoutOrExit == DialogResult.Yes)
                Application.Exit();
            else if (logoutOrExit == DialogResult.No)
            {
                Global.Utilisateur.SignOut();
                DisplayFormConnexion();
                this.Close();
            }
        }

        // Fonction pour afficher le formulaire de connexion/inscription
        private void DisplayFormConnexion()
        {
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }

        // Fonction pour afficher la page d'accueil
        private void Button_Menu_Accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            DisplayPage(accueil);
        }

        // Fonction pour afficher la page de jeu/tests
        private void Button_Menu_Tests_Click(object sender, EventArgs e)
        {
            Jeu jeu = new Jeu();
            DisplayPage(jeu);
        }

        // Fonction pour afficher la page de gestion des Utilisateurs
        private void Button_Menu_Utilisateurs_Click(object sender, EventArgs e)
        {
            GestionUtilisateur gestionUtilisateur = new GestionUtilisateur();
            DisplayPage(gestionUtilisateur);
        }

        // Fonction pour afficher la page de gestion des Phrases
        private void Button_Menu_Phrases_Click(object sender, EventArgs e)
        {
            AjoutPhrase ajoutPhrase = new AjoutPhrase();
            DisplayPage(ajoutPhrase);
        }

        // Fonction pour afficher la page de gestion des Mots
        private void Button_Menu_Mots_Click(object sender, EventArgs e)
        {
            AjoutMot ajoutMot = new AjoutMot();
            DisplayPage(ajoutMot);
        }

        // Fonction pour afficher la page d'ajout des Classes
        private void Button_Menu_Classes_Click(object sender, EventArgs e)
        {
            AjoutClasse ajoutClasse = new AjoutClasse();
            DisplayPage(ajoutClasse);
        }

        // Fonction pour afficher la page d'ajout des Types
        private void Button_Menu_Types_Click(object sender, EventArgs e)
        {
            AjoutType ajoutType = new AjoutType();
            DisplayPage(ajoutType);
        }

        // Fonction pour afficher la page d'ajout des Fonctions
        private void Button_Menu_Fonctions_Click(object sender, EventArgs e)
        {
            AjoutFonction ajoutFonction = new AjoutFonction();
            DisplayPage(ajoutFonction);
        }

        // Fonction pour afficher la page "A propos"
        private void Button_Menu_Apropos_Click(object sender, EventArgs e)
        {
            Apropos aPropos = new Apropos();
            DisplayPage(aPropos);
        }

        private void DisplayPage(CustomUserControl customUserControl)
        {
            this.Controls.Add(customUserControl);
            customUserControl.BringToFront();
            label_Title.Text = customUserControl.Title;
        }
    }
}
