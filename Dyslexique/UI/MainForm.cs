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

namespace Dyslexique.UI
{
    public partial class MainForm : Form
    {
        GestionUtilisateur gestionUtilisateur;

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

            this.gestionUtilisateur = new GestionUtilisateur
            {
                Dock = DockStyle.Fill,
                Name = "gestionUtilisateur"
            };
            this.Controls.Add(gestionUtilisateur);

            Utilisateur utilisateur = new Utilisateur
            {
                Pseudo = "Brendan",
                IdRole = "1"
            };
            Global.Utilisateur = utilisateur;
        }

        private void Button_QuitterApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_Pseudo.Text = Global.Utilisateur.Pseudo;
            label_Title.Text = gestionUtilisateur.Title;

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

        private void button_Menu_Accueil_Click(object sender, EventArgs e)
        {
            GestionUtilisateur gestionUtilisateur = new GestionUtilisateur();
            gestionUtilisateur.BringToFront();
            label_Title.Text = gestionUtilisateur.Title;
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
    }
}
