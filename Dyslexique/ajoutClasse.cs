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
    public partial class ajoutClasse : Form
    {
        List<Classe> listClasse = new List<Classe>();
        public ajoutClasse()
        {
            InitializeComponent();
        }

        public bool existe(string libelle)
        {
            foreach (Classe classe in listClasse)
            {
                if (classe.Libelle == libelle)
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
            listClasse = Queries.GetAllClasse();
            foreach (Classe classe in listClasse)
            {
                String[] row = new string[]
           {
                classe.IdClasse.ToString(), classe.Libelle, classe.Types.Libelle
           };
                dataGridView1.Rows.Add(row);
            }
        }
        private void ajoutClasse_Load(object sender, EventArgs e)
        {
            List<Types> listTypes = new List<Types>();
            listTypes = Queries.GetAllType();
            comboBox.DisplayMember = "Libelle";
            comboBox.ValueMember = "idType";
            foreach (Types type in listTypes)
            {
                comboBox.Items.Add(new { Libelle = type.Libelle, idType = type.IdTypes });
            }
            this.refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              int idType = (comboBox.SelectedItem as dynamic).idType;
                string libelle = libelleClasse.Text;
                if (string.IsNullOrEmpty(libelle) || string.IsNullOrWhiteSpace(libelle))
                {
                    MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!existe(libelle))
                    {
                        Queries.InsertClasse(libelle.ToString(), idType);
                    }
                    else
                    {
                        MessageBox.Show("La classe existe deja.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Les champs ne peuvent pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.refreshDataGridView();
        }
    }
}
