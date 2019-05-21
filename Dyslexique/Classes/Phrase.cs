using Dyslexique.UI.CustomControls;
using Dyslexique.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Phrase</c> utilisée comme modèle pour la représentation d'une entité de la table Phrase dans la BDD.
    /// </summary>
    public class Phrase
    {
        private string idPhrase;
        /// <summary>
        /// Obtient ou définit l'Id de la <c>Phrase</c>.
        /// </summary>
        public string IdPhrase
        {
            get { return idPhrase; }
            set { idPhrase = value; }
        }

        private string texte;
        /// <summary>
        /// Obtient ou définit le texte de la <c>Phrase</c>.
        /// </summary>
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        private List<Mot> mots;
        /// <summary>
        /// Obtient ou définit la liste de tous les mots de la <c>Phrase</c>.
        /// </summary>
        public List<Mot> Mots
        {
            get { return mots; }
            set { mots = value; }
        }

        private string consigne;
        /// <summary>
        /// Obtient ou définit la consigne de la <c>Phrase</c>.
        /// </summary>
        public string Consigne
        {
            get { return consigne; }
            set { consigne = value; }
        }

        private Mot motATrouver;
        /// <summary>
        /// Obtient ou définit le <c>Mot</c> à trouver dans la <c>Phrase</c>.
        /// </summary>
        public Mot MotATrouver
        {
            get { return motATrouver; }
            set { motATrouver = value; }
        }

        private int tentative;
        /// <summary>
        /// Obtient ou définit le nombre de tentatives effectuées par l'<c>Utilisateur</c> pour réussir la <c>Phrase</c>.
        /// </summary>
        public int Tentative
        {
            get { return tentative; }
            set { tentative = value; }
        }

        private DateTime? dateDerniereTentative;
        /// <summary>
        /// Obtient ou définit la date de dernière tentative effectuée par l'<c>Utilisateur</c> sur la <c>Phrase</c>.
        /// </summary>
        /// <remarks>Cette propriété est nullable.</remarks>
        public DateTime? DateDerniereTentative
        {
            get { return dateDerniereTentative; }
            set { dateDerniereTentative = value; }
        }

        private bool aEteReussie;
        /// <summary>
        /// Détermine si la <c>Phrase</c> a été réussie par l'<c>Utilisateur</c>.
        /// </summary>
        public bool AEteReussie
        {
            get { return aEteReussie; }
            set { aEteReussie = value; }
        }


        /// <summary>
        /// Constructeur par défaut d'une <c>Phrase</c>. Définit les mots présents dans la Phrase et le <c>Mot</c> à trouver.
        /// </summary>
        public Phrase()
        {
            this.mots = new List<Mot>();
            this.motATrouver = new Mot();
        }


        /// <summary>
        /// Initialise, pour chaque <c>Mot</c> présent dans la liste de mots de la <c>Phrase</c>, un <c>CustomLabel</c> qui sera affiché sur la page <c>Jeu</c>.
        /// </summary>
        /// <param name="jeu"></param>
        /// <param name="phrase"></param>
        public void DisplayMots(Jeu jeu, Phrase phrase)
        {
            int x = 0;

            foreach (Mot mot in mots)
            {
                CustomLabel customLabel = new CustomLabel(mot, phrase, jeu, x);

                SizeF stringSize = new SizeF();
                Graphics g = jeu.CreateGraphics();
                stringSize = g.MeasureString(mot.Texte, customLabel.Font);
                customLabel.Width = Convert.ToInt32(stringSize.Width) + 10;
                customLabel.Height = Convert.ToInt32(stringSize.Height) + 10;
                jeu.Controls["panel_Phrase"].Controls.Add(customLabel);
                x = x + Convert.ToInt32(stringSize.Width) + 20;
            }
        }
    }
}
