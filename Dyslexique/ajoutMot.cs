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
    public partial class ajoutMot : Form
    {
        List<Mot> listMot = new List<Mot>();

        public ajoutMot()
        {
            InitializeComponent();
        }

        public bool existe(string libelle)
        {
            foreach (Mot mot in listMot)
            {
                if (mot.Texte == libelle)
                {
                    return true;
                }
            }
            return false;
        }

        public void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            listMot = Queries.GetAllMotOrderByClasse();
            foreach (Mot mot in listMot)
            {
                String[] row = new string[]
           {
                mot.IdMot.ToString(), mot.Texte, mot.Classe.Libelle, mot.Classe.Types.Libelle
           };
                dataGridView1.Rows.Add(row);
            }
        }


        private void ajoutMot_Load(object sender, EventArgs e)
        {
            //une seule comboBox avec affichage nom commun, nom propre, adjectif qualificatif ...
            List<Classe> listClasse = new List<Classe>();
            listClasse = Queries.GetAllClasse();
            comboBoxClasse.DisplayMember = "Libelle";
            comboBoxClasse.ValueMember = "idClasse";
            foreach (Classe classe in listClasse)
            {
                comboBoxClasse.Items.Add(new { Libelle = classe.Libelle + " " + classe.Types.Libelle, idClasse = classe.IdClasse });
            }
            this.refreshDataGridView();
            List<String> listDistinctLibelle;
            listDistinctLibelle = Queries.GetDistinctClasse();
            distinctLibelleClasse.ValueMember = "libelle";
            foreach (String classe in listDistinctLibelle)
                distinctLibelleClasse.Items.Add(new { libelle = classe.ToString() });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idClasse = (comboBoxClasse.SelectedItem as dynamic).idClasse;
                string texte = texteMot.Text;
                if (string.IsNullOrEmpty(texte) || string.IsNullOrWhiteSpace(texte))
                {
                    MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!existe(texte))
                    {
                        Queries.InsertMot(texte.ToString(), idClasse);
                    }
                    else
                    {
                        MessageBox.Show("Le mot existe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.refreshDataGridView();
        }

        private void distinctLibelleClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxClasse.Items.Clear();
            string libelleClasse = (distinctLibelleClasse.SelectedItem as dynamic).libelle;
            List<Classe> listClasse = new List<Classe>();
            listClasse = Queries.GetClasseByLibelleClasse(libelleClasse);
            comboBoxClasse.DisplayMember = "Libelle";
            comboBoxClasse.ValueMember = "idClasse";
            foreach (Classe classe in listClasse)
            {
                comboBoxClasse.Items.Add(new { Libelle = classe.Libelle + " " + classe.Types.Libelle, idClasse = classe.IdClasse });
            }
        }
    }
}
