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
    public partial class AjoutType : CustomUserControl
    {
        List<Types> listTypes = new List<Types>();

        public AjoutType()
        {
            InitializeComponent();

            this.Title = "Ajout d'un type";
        }

        public bool existe(string libelle)
        {
            foreach (Types type in listTypes)
            {
                if (type.Libelle == libelle)
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
            listTypes = Queries.GetAllType();
            foreach (Types type in listTypes)
            {
                String[] row = new string[]
                {
                    type.IdTypes.ToString(), type.Libelle
                };
                dataGridView1.Rows.Add(row);
            }
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            string libelle = type.Text;
            if (string.IsNullOrEmpty(libelle) || string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!existe(libelle))
                {
                    Queries.InsertType(libelle.ToString());
                }
                else
                {
                    MessageBox.Show("Le type existe deja.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.refreshDataGridView();
        }

        private void AjoutType_Load(object sender, EventArgs e)
        {
            this.refreshDataGridView();
        }
    }
}
