using Dyslexique.UI.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.Classes
{
    public class Phrase
    {
        private string idPhrase;
        public string IdPhrase
        {
            get { return idPhrase; }
            set { idPhrase = value; }
        }

        private string texte;
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        private List<Mot> mots;
        public List<Mot> Mots
        {
            get { return mots; }
            set { mots = value; }
        }

        private string consigne;
        public string Consigne
        {
            get { return consigne; }
            set { consigne = value; }
        }

        private Mot motATrouver;
        public Mot MotATrouver
        {
            get { return motATrouver; }
            set { motATrouver = value; }
        }

        private int tentative;
        public int Tentative
        {
            get { return tentative; }
            set { tentative = value; }
        }

        private DateTime? dateDerniereTentative;
        public DateTime? DateDerniereTentative
        {
            get { return dateDerniereTentative; }
            set { dateDerniereTentative = value; }
        }

        private bool aEteReussie;
        public bool AEteReussie
        {
            get { return aEteReussie; }
            set { aEteReussie = value; }
        }


        public Phrase()
        {
            this.mots = new List<Mot>();
            this.motATrouver = new Mot();
        }

        public Phrase(List<Mot> listMots)
        {
            this.Mots = listMots;

            foreach (Mot mot in listMots)
            {
                this.Texte += mot.Texte + " ";
            }
        }


        public void Afficher(FormJeu formJeu, Phrase phrase)
        {
            int x = 0;

            foreach (Mot mot in mots)
            {
                CustomLabel customLabel = new CustomLabel(mot, phrase, x);

                SizeF stringSize = new SizeF();
                Graphics g = formJeu.CreateGraphics();
                stringSize = g.MeasureString(mot.Texte, customLabel.Font);
                customLabel.Width = Convert.ToInt32(stringSize.Width) + 5;
                formJeu.Controls["panel_Phrase"].Controls.Add(customLabel);
                x = x + Convert.ToInt32(stringSize.Width) + 5;
            }
        }
    }
}
