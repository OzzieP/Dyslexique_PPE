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

namespace Dyslexique.UI.Forms
{
    public partial class ConnexionForm : Form
    {
        /* Attributs/fonctions permettant le déplacement de la Form */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /* --------------------------------------------------------- */

        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void ConnexionForm_Load(object sender, EventArgs e)
        {

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
            string pseudo = textBox_Connexion_Pseudo.Text.ToString();
            string mdp = textBox_Connexion_Mdp.Text.ToString();

            bool isNullOrEmptyOrWhitespace = true;

            foreach (TextBox textBox in panel_Connexion.Controls.OfType<TextBox>())
            {
                //if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                //{
                //    isNullOrEmptyOrWhitespace = true;
                //    MessageBox.Show("Le champ \"" + textBox.Tag + "\" ne peut pas être vide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isNullOrEmptyOrWhitespace = true;
                    errorProvider_Textbox.SetError(textBox, "Le champ \"" + textBox.Tag + "\" ne peut pas être vide.");
                    errorProvider_Textbox.SetIconAlignment(textBox, ErrorIconAlignment.TopLeft);
                }
                else
                    isNullOrEmptyOrWhitespace = false;
            }

            if (!isNullOrEmptyOrWhitespace)
            {
                Global.Utilisateur = Queries.GetUtilisateurByPseudo(pseudo);

                if (Global.Utilisateur.Pseudo == pseudo && Global.Utilisateur.MotDePasse == mdp)
                {
                    Global.phrasesNonReussies = Queries.GetAllPhrasesNonReussies();
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    this.Dispose();
                    mainForm.Show();
                }
                else if (Global.Utilisateur.Pseudo != pseudo)
                    MessageBox.Show("Veuillez entrer un pseudo valide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Global.Utilisateur.MotDePasse != mdp)
                    MessageBox.Show("Veuillez entrer un mot de passe valide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Inscription_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in panel_Inscription.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider_Textbox.SetError(textBox, "Le champ \"" + textBox.Tag + "\" ne peut pas être vide.");
                    errorProvider_Textbox.SetIconAlignment(textBox, ErrorIconAlignment.TopLeft);
                }
            }


            //foreach (TextBox textBox in panel_Inscription.Controls.OfType<TextBox>())
            //{
            //    if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            //        MessageBox.Show("Le champ \"" + textBox.Tag + "\" ne peut pas être vide.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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

        private void Buttons_MouseLeave_ShowMdp(object sender, EventArgs e)
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
            errorProvider_Textbox.SetError(textBox, string.Empty);
        }


        //public static string Hash256(string rawData)
        //{
        //    try
        //    {
        //        using (SHA256 sha256Hash = SHA256.Create())
        //        {
        //            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

        //            StringBuilder builder = new StringBuilder();
        //            for (int i = 0; i < bytes.Length; i++)
        //            {
        //                builder.Append(bytes[i].ToString("x2"));
        //            }
        //            return builder.ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
