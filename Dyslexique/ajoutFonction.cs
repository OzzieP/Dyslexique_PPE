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
    public partial class ajoutFonction : Form
    {
        public ajoutFonction()
        {
            InitializeComponent();
        }
        public void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<Fonction> listFonction = new List<Fonction>();
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
                Queries.InsertFonction(libelle.ToString());
            }
            this.refreshDataGridView();
        }

        private void ajoutFonction_Load(object sender, EventArgs e)
        {
            this.refreshDataGridView();
        }
    }
}
