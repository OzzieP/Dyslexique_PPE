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
    public partial class PhrasePossederMot : Form
    {
        //ajout en BDD pas encore fait
        //pour les fonctions, faire une liste de int, lors de l'affichage de la combobox, placer une nouvelle comboBox avec les fonctions
        //si pas de fonctions au mot (genre les mots comme "la" "d'" où autre) sélectionner "pas de fonction dans la phrase"
        //soit le mettre directement en BDD dans la table fonction
        //soit lorsqu'il est selectionné mettre 0 et dans la fonction d'insert dans la BDD dire si 0 alors null.
        //mais bon pour l'instant on peut pas interragir avec les fonctions faudrait peut être faire ca en premier
        //après je sais pas fait comme tu veux moi je dis jsute ce qui est logique hein
        //si tu t'en fous de ce que je dis c'est ton problème pas le mien
        //mais bon si tu suis pas mon conseil c'est que t'es un peut con quand même
        List<ComboBox> ComboBoxes = new List<ComboBox>();
        List<Mot> listMot = new List<Mot>();
        int x = 100;
        int y = 100;
        int nbComBox = 0;
        private void AfficherLaList()
        {
            x = 100;
            y = 100;
            nbComBox = 0;
            foreach (ComboBox combo in ComboBoxes)
            {
                            
                combo.Location = new System.Drawing.Point(x, y);
                x += 130;
                nbComBox++;
                if (nbComBox / 8.0 == nbComBox / 8)
                {
                    y += 50;
                    x = 100;
                }
            }
        }
        public PhrasePossederMot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList; 
            comboBox.DisplayMember = "Texte";
            comboBox.ValueMember = "idMot";
            foreach (Mot mot in listMot)
            {
                comboBox.Items.Add(new { Texte = mot.Texte, idMot = mot.IdMot });
            }
            this.ComboBoxes.Add(comboBox);
            this.Controls.Add(comboBox);
            AfficherLaList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ComboBox combo in ComboBoxes)
            {
                try
                {
                    label.Text +=(combo.SelectedItem as dynamic).Texte + " ";
                }
                catch (Exception)
                {
                    MessageBox.Show("Les champs ne peuvent pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //throw;
                }
            }
        }

        private void PhrasePossederMot_Load(object sender, EventArgs e)
        {
            listMot = Queries.GetAllMotOrderByTexte();
        }
    }
}
