using Dyslexique.Classes;
using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            
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
                Utilisateur utilisateur = Queries.GetUtilisateurByPseudo(pseudo);

                if (utilisateur.Pseudo == pseudo)
                {
                    FormAccueil formAccueil = new FormAccueil(utilisateur);
                    this.Hide();
                    formAccueil.Show();
                    //this.Close();

                    //this.IsMdiContainer = true;
                    //Accueil accueil = new Accueil(utilisateur)
                    //{
                    //    MdiParent = this
                    //};
                    //accueil.Show();
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
    }
}
