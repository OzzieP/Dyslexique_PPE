﻿using System;
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
    /// <summary>
    /// Contrôle utilisateur affichant la page "Jeu".
    /// </summary>
    public partial class Jeu : UserControl
    {
        /// <summary>
        /// Obtient ou définit le titre de la page "Jeu".
        /// </summary>
        public string Title = "Passer les tests";
        private Phrase phraseSelectionnee;

        /// <summary>
        /// Constructeur par défaut de la page "Jeu".
        /// </summary>
        public Jeu()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            Global.RefreshListAllPhrases();
            DisplayPhrase();
        }

        /// <summary>
        /// Affiche à l'<c>Utilisateur</c> la <c>Phrase</c> sélectionnée de manière aléatoire sur laquelle il va passser le test.
        /// </summary>
        public void DisplayPhrase()
        {
            ClearJeu();
            Global.RefreshListAllPhrases();
            Global.RefreshListPhrasesNonReussies();
            SetProgressBar();

            Random random = new Random();
            int randomIndex = random.Next(Global.phrasesNonReussies.Count), indexOne = 0, indexTwo = 0;

            if (Global.phrasesNonReussies.Count == 0)
            {
                DialogResult result = MessageBox.Show("Il semblerait que vous avez surmonté tous les tests avec succès.\n" +
                    "Vous avez la possibilité de réinitialiser votre progression entièrement. Sinon, revenez plus tard pour passer des épreuves inédites !\n\n" +
                    "Souhaitez vous réinitialiser votre progression ?\n" +
                    "CHOIX :\n" +
                    "\"Oui\" : Réinitialiser votre progression.\n" +
                    "\"Non\" : Revenir sur l'application.",
                    "Félicitations ! Que souhaitez-vous faire maintenant ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    DialogResult resetOrNo = MessageBox.Show("Souhaitez-vous vraiment réinitialiser votre progression ? Cette action est irréversible !",
                        "Attention !",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (resetOrNo == DialogResult.Yes)
                        Global.Utilisateur.ResetProgression();
                }

                Accueil accueil = new Accueil();
                this.Dispose();
                accueil.BringToFront();
            }
            else
            {
                do
                {
                    randomIndex = random.Next(Global.phrasesNonReussies.Count);
                } while (randomIndex == indexOne || randomIndex == indexTwo);

                //if (randomIndex == indexOne || randomIndex == indexTwo)
                //    randomIndex = random.Next(Global.phrasesNonReussies.Count);

                this.phraseSelectionnee = Global.phrasesNonReussies.ElementAt(randomIndex);
                label_Consigne.Text += phraseSelectionnee.Consigne;
                phraseSelectionnee.DisplayMots(this, phraseSelectionnee);
                //label_Tentatives.Text += phraseSelectionnee.Tentative.ToString();
            }
        }

        private void ClearJeu()
        {
            //progressBar.Style = ProgressBarStyle.
            //label_ProgressCount.Text = Global.phrasesNonReussies.Count.ToString();
            label_Consigne.Text = "Dans la phrase ci-dessous : ";
            //label_Tentatives.Text = "Nombre de tentatives déjà effectuées pour cette phrase : ";

            foreach (Control control in panel_Phrase.Controls)
            {
                control.Dispose();
            }
            panel_Phrase.Controls.Clear();

            this.phraseSelectionnee = null;
        }

        private void SetProgressBar()
        {
            int phrases = Global.allPhrases.Count;
            int phrasesReussies = Global.allPhrases.Count - Global.phrasesNonReussies.Count;

            if (phrasesReussies != 0)
                this.progressBar.Step = phrases % phrasesReussies;

            this.progressBar.Value = phrasesReussies;
            this.progressBar.Maximum = phrases;
        }
    }
}