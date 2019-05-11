using Dyslexique.Classes;
using Dyslexique.DAL;
using Dyslexique.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.UI.CustomControls
{
    public class CustomLabel : Label
    {
        private Mot mot = new Mot();
        private Phrase phrase = new Phrase();
        private Jeu jeu;


        public CustomLabel(Mot mot, Phrase phrase, Jeu jeu, int x)
        {
            this.mot = mot;
            this.phrase = phrase;
            this.jeu = jeu;
            this.Text = this.mot.Texte;
            this.Top = 0;
            this.Left = x;
            this.Font = new Font("Century Gothic", 16, FontStyle.Regular);

            this.Click += new EventHandler(OnClick);
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);

            // Définition de la couleur du CustomLabel selon la classe du Mot
            switch (this.mot.Classe.Libelle)
            {
                case Global.ADJECTIF:
                    this.ForeColor = Color.Blue;
                    break;
                case Global.ADVERBE:
                    this.ForeColor = Color.Maroon;
                    break;
                case Global.CONJONCTION:
                    this.ForeColor = Color.DarkOrange;
                    break;
                case Global.DETERMINANT:
                    this.ForeColor = Color.Green;
                    break;
                case Global.INTERJECTION:
                    this.ForeColor = Color.DarkViolet;
                    break;
                case Global.NOM:
                    this.ForeColor = Color.Black;
                    break;
                case Global.PREPOSITION:
                    this.ForeColor = Color.DarkRed;
                    break;
                case Global.PRONOM:
                    this.ForeColor = Color.DarkGreen;
                    break;
                case Global.VERBE:
                    this.ForeColor = Color.Red;
                    break;
                default:
                    this.ForeColor = Color.Black;
                    break;
            }
        }


        private void OnClick(object s, EventArgs e)
        {
            bool utilisateurAGagne = EstLeMotATrouver();
            DateTime date = DateTime.Now;
            date.ToUniversalTime();
            //DialogResult result;

            if (utilisateurAGagne)
            {
                /*result = */MessageBox.Show("Bravo ! Le mot à trouver était : " + phrase.MotATrouver.Texte,
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                Global.phrasesNonReussies.Remove(this.phrase);
                this.phrase.Tentative++;
                this.phrase.AEteReussie = true;
                this.phrase.DateDerniereTentative = date;

                Queries.InsertOrUpdateTentative(Global.Utilisateur, this.phrase);
            }
            else
            {
                /*result = */MessageBox.Show("Dommage ! Rééssayez une prochaine fois !",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                this.phrase.Tentative++;
                this.phrase.AEteReussie = false;
                this.phrase.DateDerniereTentative = date;

                Queries.InsertOrUpdateTentative(Global.Utilisateur, this.phrase);
                Global.RefreshListPhrasesNonReussies();
            }

            //if (result == DialogResult.OK)
            //    jeu.DisplayPhrase();
            jeu.DisplayPhrase();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.Font = new Font(this.Font, FontStyle.Underline);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Font = new Font(this.Font, FontStyle.Regular);
        }

        private bool EstLeMotATrouver()
        {
            if (this.phrase.MotATrouver.Equals(this.mot))
                return true;
            else
                return false;
        }






        //private void CheckType(Mot mot)
        //{
        //    string type = mot.Classe.Types.Libelle;
        //}

        //private void CheckClasse(Mot mot)
        //{
        //    Classe classeToFind = new Classe();
        //    Classe classeabc = mot.Classe;
        //    Classe classe = mot.Classe;

        //    if (classe.Equals(classeabc))
        //        MessageBox.Show("Le click marche ! Classe : " + classe.Libelle, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    else
        //        MessageBox.Show("Le click marche ! La Classe : " + classeabc.Libelle + " n'est pas pareil !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        //private void CheckFonction(Mot mot)
        //{
        //    string Fonction = mot.Fonction.Libelle;

        //    //Utilisateur utilisateur1 = new Utilisateur
        //    //{
        //    //    IdUtilisateur = "2",
        //    //};
        //    //Phrase phrase = new Phrase
        //    //{
        //    //    IdPhrase = "1004",
        //    //    Tentative = "204"
        //    //};
        //    //DateTime aDate = DateTime.Now;
        //    //string date = aDate.ToString("dddd-dd-MMMM-yyyy HH:mm:ss");

        //    //CultureInfo MyCultureInfo = new CultureInfo("fr-FR");
        //    //string MyString = DateTime.Now.ToString();
        //    //DateTime MyDateTime = DateTime.Parse(MyString, MyCultureInfo);

        //    //label2.Text = MyDateTime.ToString();

        //    //Queries.InsertOrUpdateTentative(utilisateur1, phrase, MyDateTime.ToString(), true);

        //}
    }
}
