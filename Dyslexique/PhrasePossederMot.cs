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
        List<ComboBox> ComboBoxes = new List<ComboBox>();
        List<ComboBox> ComboFonction = new List<ComboBox>();
        List<Mot> listMot = new List<Mot>();
        List<Fonction> listFonction = new List<Fonction>();
        List<RadioButton> radioList = new List<RadioButton>();
        int x = 100;
        int xf = 100;
        int xr = 1140;
        int y = 100;
        int yf = 130;
        int yr = 100;
        int nbComBox = 0;
        int nbFonctionBox = 0;
        private void AfficherLaList()
        {
            x = 100;
            xf = 100;
            y = 100;
            yf = 130;
            nbComBox = 0;
            nbFonctionBox = 0;
            foreach (ComboBox combo in ComboBoxes)
            {
                            
                combo.Location = new System.Drawing.Point(x, y);
                x += 130;
                nbComBox++;
                if (nbComBox / 8.0 == nbComBox / 8)
                {
                    y += 150;
                    x = 100;
                }
            }
            foreach (ComboBox comboF in ComboFonction)
            {

                comboF.Location = new System.Drawing.Point(xf, yf);
                xf+= 130;
                nbFonctionBox++;
                if (nbFonctionBox / 8.0 == nbFonctionBox / 8)
                {
                    yf += 150;
                    xf = 100;
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
            ComboBox fonctionBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fonctionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = "Texte";
            comboBox.ValueMember = "idMot";
            fonctionBox.DisplayMember = "Libelle";
            fonctionBox.ValueMember = "idFonction";
            foreach (Mot mot in listMot)
            {
                comboBox.Items.Add(new { Texte = mot.Texte, idMot = mot.IdMot });
            }
            foreach (Fonction fonction in listFonction)
            {
                fonctionBox.Items.Add(new { Libelle = fonction.Libelle, idFonction = fonction.IdFonction });
            }
            this.ComboBoxes.Add(comboBox);
            this.Controls.Add(comboBox);
            this.ComboFonction.Add(fonctionBox);
            this.Controls.Add(fonctionBox);
            AfficherLaList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label.Text = "";
            //label.Text = (ComboBoxes[0].SelectedItem as dynamic).Texte;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            labelTrouver.Visible = true;
            foreach (ComboBox combo in ComboBoxes)
            {
                try
                {
                    label.Text +=(combo.SelectedItem as dynamic).Texte + " ";
                    RadioButton radio = new RadioButton();
                    radio.Text = (combo.SelectedItem as dynamic).Texte;
                    this.radioList.Add(radio);
                    this.Controls.Add(radio);
                    radio.Location = new System.Drawing.Point(xr, yr);
                    yr += 30;
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
            listFonction = Queries.GetAllFonction();
            button3.Enabled = false;
            labelTrouver.Visible = false;
            labelTrouver.Location = new System.Drawing.Point(1140, 80);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Queries.InsertPhrase(label.Text, consigne.Text);
            List<int> idPhrase = new List<int>();
            idPhrase = Queries.GetLastIdPhrase();
            for (int i=0; i<nbComBox; i++)
            {
                Queries.InsertPhrasePossederMot(idPhrase[0], (ComboBoxes[i].SelectedItem as dynamic).idMot, (ComboFonction[i].SelectedItem as dynamic).idFonction, i, radioList[i].Checked);
            }
        }
    }
}
