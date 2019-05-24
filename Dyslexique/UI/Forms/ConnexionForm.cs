using Dyslexique.Classes;
using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Espace de nom contenant toutes les Windows Forms.
/// </summary>
namespace Dyslexique.UI.Forms
{
    /// <summary>
    /// Form affichant la page de connexion/inscription.
    /// </summary>
    public partial class ConnexionForm : Form
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
        /// Constructeur par défaut de la Form de connexion/inscription.
        /// </summary>
        public ConnexionForm()
        {
            InitializeComponent();
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

        private void Button_QuitterApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Connexion_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_Connexion_Pseudo.Text;
            string mdp = Global.Hash256(textBox_Connexion_Mdp.Text);

            try
            {
                List<TextBox> textBoxes = new List<TextBox>();

                foreach (TextBox textBox in panel_Connexion.Controls.OfType<TextBox>())
                {
                    textBoxes.Add(textBox);
                }

                bool isNullOrEmptyOrWhitespace = CheckIfTextBoxesAreValid(textBoxes);

                if (!isNullOrEmptyOrWhitespace)
                {
                    Utilisateur tempUtilisateur = Queries.GetUtilisateurByPseudo(pseudo);

                    if (tempUtilisateur.Pseudo == pseudo && tempUtilisateur.MotDePasse == mdp)
                    {
                        Global.Utilisateur = tempUtilisateur;
                        Global.phrasesNonReussies = Queries.GetAllPhrasesNonReussiesByIdUtilisateur();
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.Show();
                    }
                    else if (tempUtilisateur.Pseudo != pseudo)
                        MessageBox.Show("Veuillez entrer un pseudo valide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (tempUtilisateur.MotDePasse != mdp)
                        MessageBox.Show("Veuillez entrer un mot de passe valide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de se connecter.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Button_Inscription_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_Inscription_Pseudo.Text;
            string nom = textBox_Inscription_Nom.Text;
            string prenom = textBox_Inscription_Prenom.Text;
            string email = textBox_Inscription_Email.Text;
            string mdp = textBox_Inscription_Mdp.Text;
            string confMdp = textBox_Inscription_ConfMdp.Text;

            try
            {
                List<TextBox> textBoxes = new List<TextBox>();

                foreach (TextBox textBox in panel_Inscription.Controls.OfType<TextBox>())
                {
                    textBoxes.Add(textBox);
                }

                bool isNullOrEmptyOrWhitespace = CheckIfTextBoxesAreValid(textBoxes);

                if (!isNullOrEmptyOrWhitespace)
                {
                    if (mdp == confMdp)
                    {
                        Utilisateur tempUtilisateur = new Utilisateur()
                        {
                            Pseudo = pseudo,
                            Nom = nom,
                            Prenom = prenom,
                            Email = email,
                            MotDePasse = Global.Hash256(mdp),
                            IdRole = Global.ROLE_UTILISATEUR,
                            Role = "Utilisateur"
                        };

                        Queries.InsertUtilisateur(pseudo, nom, prenom, email, mdp, Global.ROLE_UTILISATEUR);
                        Global.Utilisateur = tempUtilisateur;
                        Global.phrasesNonReussies = Queries.GetAllPhrasesNonReussiesByIdUtilisateur();
                        MessageBox.Show("Inscription terminée.\nBienvenue sur Dyslexique !", "Bienvenue !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                        MessageBox.Show("Les deux mots de passe entrés ne correspondent pas.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Veuillez remplir tous les champs.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de s'inscrire.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Buttons_MouseHover_ShowMdp(object sender, EventArgs e)
        {
            if (sender == button_Connexion_ShowMdp)
            {
                textBox_Connexion_Mdp.UseSystemPasswordChar = false;
                button_Connexion_ShowMdp.Image = Dyslexique.Properties.Resources.EyeOff_16;
            }
            else if (sender == button_Inscription_ShowMdp)
            {
                textBox_Inscription_Mdp.UseSystemPasswordChar = false;
                button_Inscription_ShowMdp.Image = Dyslexique.Properties.Resources.EyeOff_16;
            }
            else if (sender == button_Inscription_ShowConfMdp)
            {
                textBox_Inscription_ConfMdp.UseSystemPasswordChar = false;
                button_Inscription_ShowConfMdp.Image = Dyslexique.Properties.Resources.EyeOff_16;
            }
        }

        private void Buttons_MouseLeave_HideMdp(object sender, EventArgs e)
        {
            if (sender == button_Connexion_ShowMdp)
            {
                textBox_Connexion_Mdp.UseSystemPasswordChar = true;
                button_Connexion_ShowMdp.Image = Dyslexique.Properties.Resources.Eye_16;
            }
            else if (sender == button_Inscription_ShowMdp)
            {
                textBox_Inscription_Mdp.UseSystemPasswordChar = true;
                button_Inscription_ShowMdp.Image = Dyslexique.Properties.Resources.Eye_16;
            }
            else if (sender == button_Inscription_ShowConfMdp)
            {
                textBox_Inscription_ConfMdp.UseSystemPasswordChar = true;
                button_Inscription_ShowConfMdp.Image = Dyslexique.Properties.Resources.Eye_16;
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            errorProvider_TextBox.SetError(textBox, string.Empty);
        }

        private bool CheckIfTextBoxesAreValid(List<TextBox> textBoxes)
        {
            List<bool> listBool = new List<bool>();
            bool isNullOrEmptyOrWhitespace = false;

            foreach (TextBox textBox in textBoxes)
            {
                bool isTextBoxValide = false;
                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isTextBoxValide = false;
                    listBool.Add(isTextBoxValide);
                    errorProvider_TextBox.SetError(textBox, "Le champ \"" + textBox.Tag + "\" ne peut pas être vide.");
                    errorProvider_TextBox.SetIconAlignment(textBox, ErrorIconAlignment.MiddleLeft);
                }
                else
                {
                    isTextBoxValide = true;
                    listBool.Add(isTextBoxValide);
                }
            }

            foreach (bool boolean in listBool)
            {
                if (boolean == false)
                {
                    isNullOrEmptyOrWhitespace = true;
                    break;
                }
            }

            return isNullOrEmptyOrWhitespace;
        }

        private void TextBoxes_Connexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button_Connexion_Click(sender, e);
        }

        private void TextBoxes_Inscription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button_Inscription_Click(sender, e);
        }
    }
}