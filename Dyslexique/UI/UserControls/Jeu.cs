using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyslexique.Classes;
using Dyslexique.DAL;

namespace Dyslexique.UI.UserControls
{
    public partial class Jeu : UserControl
    {
        public string Title = "Passer les tests";
        private Phrase phraseSelectionnee;

        public Jeu()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            DisplayPhrase();

            //progressBar.Value = 
        }


        public void DisplayPhrase()
        {
            ClearJeu();
            Global.RefreshListPhrasesNonReussies();

            Random random = new Random();
            int randomIndex = random.Next(Global.phrasesNonReussies.Count);

            if (Global.phrasesNonReussies.Count == 0)
            {
                DialogResult result = MessageBox.Show("Il semblerait que vous avez surmonté tous les tests avec succès.\n" +
                    "Vous avez la possibilité de réinitialiser votre progression entièrement. Sinon, revenez plus tard pour passer des épreuves inédites !\n" +
                    "Souhaitez vous réinitialiser votre progression ? Cliquez sur \"Oui\". Cliquez sur \"Non\" pour quitter l'application.",
                    "Félicitations !",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    DialogResult resetOrNo = MessageBox.Show("Souhaitez-vous vraiment réinitialiser votre progression ? Cette action est irréversible !",
                        "Félicitations !",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    //if (resetOrNo == DialogResult.Yes)
                    //    /* Reset la progression de l'utilisateur
                    //    Global.Utilisateur.ResetProgression(); */
                    //else
                }
                else
                {
                    // Redirection vers la page d'accueil
                }
            }
            else
            {
                this.phraseSelectionnee = Global.phrasesNonReussies.ElementAt(randomIndex);
                label_Consigne.Text += phraseSelectionnee.Consigne;
                phraseSelectionnee.DisplayMots(this, phraseSelectionnee);
                label_Tentatives.Text += phraseSelectionnee.Tentative.ToString();
            }
        }

        private void ClearJeu()
        {
            //progressBar.Style = ProgressBarStyle.
            //label_ProgressCount.Text = Global.phrasesNonReussies.Count.ToString();
            label_Consigne.Text = "Dans la phrase ci-dessous : ";
            label_Tentatives.Text = "Nombre de tentatives déjà effectuées pour cette phrase : ";

            foreach (Control control in panel_Phrase.Controls)
            {
                control.Dispose();
            }
            panel_Phrase.Controls.Clear();

            this.phraseSelectionnee = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            progressBar.Increment(10);
        }
    }
}
