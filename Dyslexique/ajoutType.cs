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
    public partial class ajoutType : Form
    {
        public ajoutType()
        {
            InitializeComponent();
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
                Queries.InsertType(libelle.ToString());
            }
        }
    }
}
