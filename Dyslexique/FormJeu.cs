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
    public partial class FormJeu : Form
    {
        private Utilisateur utilisateur;
        private Phrase phrase;

        public FormJeu()
        {
            InitializeComponent();
        }

        public FormJeu(Utilisateur utilisateur, Phrase phrase)
        {
            InitializeComponent();

            this.utilisateur = utilisateur;
            this.phrase = phrase;
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            label_Consigne.Text = this.phrase.Consigne;

            Fonction fonction = new Fonction("1", "Sujet");

            Mot mot = new Mot("1", "Bonjour", fonction, "1");
            Mot mot1 = new Mot("2", "Paris", fonction, "2");
            //Mot mot2 = new Mot("ça", fonction, "3");
            //Mot mot3 = new Mot("va", fonction, "4");

            List<Mot> listMots = new List<Mot>();
            listMots.Add(mot);
            listMots.Add(mot1);
            //listMots.Add(mot2);
            //listMots.Add(mot3);

            Phrase phrase = new Phrase(listMots);

            phrase.Afficher(this);
        }

        private void CheckType(Mot mot)
        {

        }

        private void CheckClasse(Mot mot)
        {

        }

        private void CheckFonction(Mot mot)
        {

        }

        private bool UserHasWon()
        {

        }
    }
}
