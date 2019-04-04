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
    public partial class FormAccueil : Form
    {
        private List<Utilisateur> listUtilisateurs;
        private Utilisateur utilisateur;

        public FormAccueil()
        {
            InitializeComponent();
        }

        public FormAccueil(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;

            ToolStripLabel toolStripLabel1 = new ToolStripLabel(this.utilisateur.Pseudo)
            {
                Margin = new Padding(50, 3, 3, 3)
            };
            menuStrip1.Items.Add(toolStripLabel1);

            if (this.utilisateur.IdRole == "1")
                administrationToolStripMenuItem.Visible = true;
            else
                administrationToolStripMenuItem.Visible = false;

            this.listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_Utilisateur.DataSource = listUtilisateurs;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_Pseudo.Text;

            if (string.IsNullOrEmpty(pseudo) || string.IsNullOrWhiteSpace(pseudo))
            {
                MessageBox.Show("Le champ ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!radioButton_Administrateur.Checked && !radioButton_Utilisateur.Checked)
                {
                    MessageBox.Show("Un rôle doit être sélectionné.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (radioButton_Administrateur.Checked)
                        Queries.InsertUtilisateur(pseudo.ToString(), "1");
                    else if (radioButton_Utilisateur.Checked)
                        Queries.InsertUtilisateur(pseudo.ToString(), "2");

                    Refresh_DataGridView_Utilisateur();
                }
            }
        }

        private void Refresh_DataGridView_Utilisateur()
        {
            this.listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_Utilisateur.DataSource = listUtilisateurs;
        }
    }
}
