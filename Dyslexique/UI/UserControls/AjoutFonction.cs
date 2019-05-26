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
    public partial class AjoutFonction : CustomUserControl
    {
        List<Fonction> listFonction = new List<Fonction>();

        public AjoutFonction()
        {
            InitializeComponent();

            this.Title = "Ajout d'une fonction";
        }

        public bool existe(string libelle)
        {
            foreach (Fonction fonction in listFonction)
            {
                if (fonction.Libelle == libelle)
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
            listFonction = Queries.GetAllFonction();
            foreach (Fonction fonction in listFonction)
            {
                String[] row = new string[]
                {
                    fonction.IdFonction.ToString(), fonction.Libelle
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string libelle = fonction.Text;
            if (string.IsNullOrEmpty(libelle) || string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!existe(libelle))
                {
                    Queries.InsertFonction(libelle.ToString());
                }
                else
                {
                    MessageBox.Show("La fonction existe deja.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.refreshDataGridView();
        }

        private void AjoutFonction_Load(object sender, EventArgs e)
        {
            this.refreshDataGridView();
        }
    }
}
