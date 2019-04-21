using Dyslexique.Classes;
using Dyslexique.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
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


        public CustomLabel(Mot mot, Phrase phrase, int x)
        {
            this.mot = mot;
            this.phrase = phrase;
            this.Text = this.mot.Texte;
            this.Top = 0;
            this.Left = x;

            this.Click += new EventHandler(OnClick);
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);
        }


        private void OnClick(object s, EventArgs e)
        {
            bool UtilisateurAGagne = EstLeMotATrouver();

            if (UtilisateurAGagne)
            {
                MessageBox.Show("Bravo ! Le mot à trouver était : " + phrase.MotATrouver.Texte, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.phrase.Tentative++;
                this.phrase.AEteReussie = true;
                Queries.InsertOrUpdateTentative(Global.Utilisateur, this.phrase);
            }
            else
            {
                MessageBox.Show("Dommage ! Rééssayez une prochaine fois !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.phrase.Tentative++;
                this.phrase.AEteReussie = false;
                Queries.InsertOrUpdateTentative(Global.Utilisateur, this.phrase);
            }
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
