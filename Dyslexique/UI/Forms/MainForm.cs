using Dyslexique.Classes;
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
    public partial class MainForm : Form
    {
        /* Attributs/fonctions permettant le déplacement de la Form */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /* --------------------------------------------------------- */

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_Title.Text = "Accueil";
            label_Pseudo.Text = Global.Utilisateur.Pseudo;

            if (Global.Utilisateur.IdRole == Global.ROLE_UTILISATEUR)
            {
                pictureBox_Utilisateur.Visible = true;
            }
            else if (Global.Utilisateur.IdRole == Global.ROLE_ADMINISTRATEUR)
            {
                pictureBox_Administrateur.Visible = true;
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

        private void DisplayFormConnexion()
        {
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }

        // Fonction pour afficher la page d'accueil
        private void Button_Menu_Accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Controls.Add(accueil);
            accueil.BringToFront();
            label_Title.Text = accueil.Title;
        }

        // Fonction pour afficher la page de jeu/tests
        private void Button_Menu_Tests_Click(object sender, EventArgs e)
        {
            Jeu jeu = new Jeu();
            this.Controls.Add(jeu);
            jeu.BringToFront();
            label_Title.Text = jeu.Title;
        }

        // Fonction pour afficher la page de gestion des Utilisateurs
        private void Button_Menu_Utilisateurs_Click(object sender, EventArgs e)
        {
            GestionUtilisateur gestionUtilisateur = new GestionUtilisateur();
            this.Controls.Add(gestionUtilisateur);
            gestionUtilisateur.BringToFront();
            label_Title.Text = gestionUtilisateur.Title;
        }

        // Fonction pour afficher la page de gestion des Phrases
        private void Button_Menu_Phrases_Click(object sender, EventArgs e)
        {
            //GestionPhrases gestionPhrases = new GestionPhrases()
            //{
            //    Dock = DockStyle.Fill,
            //    Name = "gestionPhrases"
            //};

            //this.Controls.Add(gestionPhrases);
            //gestionPhrases.BringToFront();
            //label_Title.Text = gestionPhrases.Title;
        }

        // Fonction pour afficher la page de gestion des Mots
        private void Button_Menu_Mots_Click(object sender, EventArgs e)
        {
            //GestionMots gestionMots = new GestionMots()
            //{
            //    Dock = DockStyle.Fill,
            //    Name = "gestionMots"
            //};

            //this.Controls.Add(gestionMots);
            //gestionMots.BringToFront();
            //label_Title.Text = gestionMots.Title;
        }

        private void Button_Menu_Apropos_Click(object sender, EventArgs e)
        {
            Apropos aPropos = new Apropos();
            this.Controls.Add(aPropos);
            aPropos.BringToFront();
            label_Title.Text = aPropos.Title;
        }
    }
}
