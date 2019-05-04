using Dyslexique.Classes;
using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Button_connexion_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_connexion.Text.ToString();

            if (string.IsNullOrEmpty(pseudo) || string.IsNullOrWhiteSpace(pseudo))
            {
                MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Global.Utilisateur = Queries.GetUtilisateurByPseudo(pseudo);

                if (Global.Utilisateur.Pseudo == pseudo)
                {
                    Global.phrasesNonReussies = Queries.GetAllPhrasesNonReussies();
                    FormAccueil formAccueil = new FormAccueil();
                    this.Hide();
                    formAccueil.Show();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un pseudo valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormUtilisateur formUtilisateur = new FormUtilisateur();
            formUtilisateur.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil();
            formProfil.Show();
        }


        // Fonction pour commencer le jeu
        private void Button3_Click(object sender, EventArgs e)
        {
            //Utilisateur utilisateur = new Utilisateur
            //{
            //    Pseudo = "Brendan",
            //    IdUtilisateur = "2",
            //    IdRole = "1"
            //};
            Global.Utilisateur = Queries.GetUtilisateurById("2");

            FormJeu formJeu = new FormJeu();
            formJeu.Show();
        }
    }
}
