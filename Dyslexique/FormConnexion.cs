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
    //public partial class FormConnexion : Form
    //{
    //    Utilisateur utilisateur = new Utilisateur();

    //    public FormConnexion()
    //    {
    //        InitializeComponent();
    //    }

    //    private void Button_connexion_Click(object sender, EventArgs e)
    //    {
    //        string pseudo = textBox_connexion.Text.ToString();

    //        if (string.IsNullOrEmpty(pseudo) || string.IsNullOrWhiteSpace(pseudo))
    //        {
    //            MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //        }
    //        else
    //        {
    //            this.utilisateur = Queries.GetUtilisateurByPseudo(pseudo);

    //            if (utilisateur.Pseudo == pseudo)
    //            {
    //                FormAccueil formAccueil = new FormAccueil(utilisateur);
    //                this.Hide();
    //                formAccueil.Show();
    //                //this.Close();

    //                //this.IsMdiContainer = true;
    //                //Accueil accueil = new Accueil(utilisateur)
    //                //{
    //                //    MdiParent = this
    //                //};
    //                //accueil.Show();
    //            }
    //            else
    //            {
    //                MessageBox.Show("Veuillez entrer un pseudo valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //            }
    //        }
    //    }

    //    private void Button1_Click(object sender, EventArgs e)
    //    {
    //        FormUtilisateur formUtilisateur = new FormUtilisateur();
    //        formUtilisateur.Show();
    //    }

    //    private void Button2_Click(object sender, EventArgs e)
    //    {
    //        FormProfil formProfil = new FormProfil();
    //        formProfil.Show();
    //    }


    //    // Fonction pour commencer le jeu
    //    private void Button3_Click(object sender, EventArgs e)
    //    {
    //        Mot bonjour = new Mot("Bonjour", "1");
    //        Mot je = new Mot("je", "2");
    //        Mot mange = new Mot("mange", "3");
    //        Mot une = new Mot("une", "4");
    //        Mot pomme = new Mot("pomme", "5");

    //        List<Mot> mots = new List<Mot>();
    //        mots.Add(bonjour);
    //        mots.Add(je);
    //        mots.Add(mange);
    //        mots.Add(une);
    //        mots.Add(pomme);

    //        Phrase phrase = new Phrase
    //        {
    //            IdPhrase = "1",
    //            Consigne = "Trouver le mot ayant pour classe : Nom.",
    //            Mots = mots,
    //            Texte = "Bonjour je mange une pomme"
    //        };

    //        List<Phrase> listPhrases = new List<Phrase>();

    //        FormJeu formJeu = new FormJeu(utilisateur, phrase);
    //        formJeu.Show();
    //    }

    //    //private void Button3_Click(object sender, EventArgs e)
    //    //{
    //    //    Mot bonjour = new Mot("Bonjour", "1");
    //    //    Mot je = new Mot("je", "2");
    //    //    Mot mange = new Mot("mange", "3");
    //    //    Mot une = new Mot("une", "4");
    //    //    Mot pomme = new Mot("pomme", "5");

    //    //    List<Mot> mots = new List<Mot>();
    //    //    mots.Add(bonjour);
    //    //    mots.Add(je);
    //    //    mots.Add(mange);
    //    //    mots.Add(une);
    //    //    mots.Add(pomme);

    //    //    Phrase phrase = new Phrase
    //    //    {
    //    //        IdPhrase = "1",
    //    //        Consigne = "Trouver le mot ayant pour classe : Nom.",
    //    //        Mots = mots,
    //    //        Texte = "Bonjour je mange une pomme"
    //    //    };

    //    //    FormJeu formJeu = new FormJeu(utilisateur, phrase);
    //    //    formJeu.Show();
    //    //}

    //}

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
            Utilisateur utilisateur = new Utilisateur
            {
                Pseudo = "Brendan",
                IdRole = "1"
            };
            Global.Utilisateur = utilisateur;

            FormJeu formJeu = new FormJeu();
            formJeu.Show();
        }
    }
}
