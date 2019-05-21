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

/// <summary>
/// Espace de nom contenant les éléments graphiques personnalisés.
/// </summary>
namespace Dyslexique.UI.CustomControls
{
    /// <summary>
    /// Classe héritant de la classe <c>Label</c>. Le <c>CustomLabel</c> est utilisé dans la page <c>Jeu</c>. Il affiche un mot d'une phrase et est clickable.
    /// </summary>
    public class CustomLabel : Label
    {
        private Mot mot = new Mot();
        private Phrase phrase = new Phrase();
        private Jeu jeu;


        /// <summary>
        /// Constructeur du <c>CustomLabel</c>. Définit le <c>Mot</c>, la <c>Phrase</c>, la page de <c>Jeu</c>, ainsi que les éléments graphiques et les méthodes événementielles auxquels il est associé.
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="phrase"></param>
        /// <param name="jeu"></param>
        /// <param name="x"></param>
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


        /// <summary>
        /// Détermine si l'<c>Utilisateur</c> a réussi la <c>Phrase</c> ou non.
        /// <para>S'il a réussi la Phrase, alors on le précise dans la BDD. Dans le cas contraire, on passe à une Phrase suivante.</para>
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void OnClick(object s, EventArgs e)
        {
            bool utilisateurAGagne = EstLeMotATrouver();
            DateTime date = DateTime.Now;
            date.ToUniversalTime();

            if (utilisateurAGagne)
            {
                MessageBox.Show("Bravo ! Le mot à trouver était : " + phrase.MotATrouver.Texte,
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
                MessageBox.Show("Dommage ! Rééssayez une prochaine fois !",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                this.phrase.Tentative++;
                this.phrase.AEteReussie = false;
                this.phrase.DateDerniereTentative = date;

                Queries.InsertOrUpdateTentative(Global.Utilisateur, this.phrase);
                Global.RefreshListPhrasesNonReussies();
            }

            jeu.DisplayPhrase();
        }

        /// <summary>
        /// Transforme le curseur en main et souligne le <c>Mot</c> lorsque la souris passe dessus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.Font = new Font(this.Font, FontStyle.Underline);
        }

        /// <summary>
        /// Rétablit les valeurs par défaut des propriétés Cursor du curseur et Font du <c>CustomLabel</c> lorsque la souris ne pointe plus dessus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Font = new Font(this.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Détermine si le <c>Mot</c> qui a été cliqué est celui à trouver pour réussir la <c>Phrase</c>.
        /// </summary>
        private bool EstLeMotATrouver()
        {
            if (this.phrase.MotATrouver.Equals(this.mot))
                return true;
            else
                return false;
        }
    }
}
