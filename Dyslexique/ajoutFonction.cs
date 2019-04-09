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
        }
    }
}
