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
    public partial class FormUtilisateur : Form
    {
        private List<Utilisateur> listUtilisateurs;
        private Utilisateur utilisateur = new Utilisateur();

        public FormUtilisateur()
        {
            InitializeComponent();

            listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_AllUtilisateurs.DataSource = listUtilisateurs;

            textBox_UpdatePseudo.Clear();
            radioButton_UpdateAdministrateur.Checked = false;
            radioButton_UpdateUtilisateur.Checked = false;
        }

        private void Refresh_DataGridView_AllUtilisateur()
        {
            this.listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_AllUtilisateurs.DataSource = listUtilisateurs;

            textBox_InsertPseudo.Clear();
            textBox_UpdatePseudo.Clear();
            textBox_DeleteUtilisateur.Text = string.Empty;
            radioButton_InsertAdministrateur.Checked = false;
            radioButton_InsertUtilisateur.Checked = false;
            radioButton_UpdateAdministrateur.Checked = false;
            radioButton_UpdateUtilisateur.Checked = false;
            textBox_UpdatePseudo.Enabled = false;
            radioButton_UpdateAdministrateur.Enabled = false;
            radioButton_UpdateUtilisateur.Enabled = false;
            button_UpdateUtilisateur.Enabled = false;
            //button_DeleteUtilisateur.Enabled = true;
        }

        private void Button_InsertUtilisateur_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_InsertPseudo.Text;

            if (string.IsNullOrEmpty(pseudo) || string.IsNullOrWhiteSpace(pseudo))
            {
                MessageBox.Show("Le champ Pseudo ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!radioButton_InsertAdministrateur.Checked && !radioButton_InsertUtilisateur.Checked)
                {
                    MessageBox.Show("Un Rôle doit être sélectionné.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (radioButton_InsertAdministrateur.Checked)
                        Queries.InsertUtilisateur(pseudo, "1");
                    else if (radioButton_InsertUtilisateur.Checked)
                        Queries.InsertUtilisateur(pseudo, "2");

                    Refresh_DataGridView_AllUtilisateur();
                }
            }
        }

        private void Button_UpdateUtilisateur_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_UpdatePseudo.Text;

            try
            {
                if (string.IsNullOrEmpty(pseudo) || string.IsNullOrWhiteSpace(pseudo))
                {
                    MessageBox.Show("Le champ Pseudo ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!radioButton_UpdateAdministrateur.Checked && !radioButton_UpdateUtilisateur.Checked)
                    {
                        MessageBox.Show("Un Rôle doit être sélectionné.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (radioButton_UpdateAdministrateur.Checked)
                            Queries.UpdateUtilisateur(utilisateur.IdUtilisateur, pseudo, "1");
                        else if (radioButton_UpdateUtilisateur.Checked)
                            Queries.UpdateUtilisateur(utilisateur.IdUtilisateur, pseudo, "2");

                        Refresh_DataGridView_AllUtilisateur();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un utilisateur doit être sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Button_DeleteUtilisateur_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'utilisateur : " + utilisateur.Pseudo + " " + utilisateur.IdUtilisateur +" ?", 
                "Attention !", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Queries.DeleteUtilisateur(utilisateur.IdUtilisateur);
                    Refresh_DataGridView_AllUtilisateur();
                }
                catch (Exception)
                {
                    MessageBox.Show("Un utilisateur doit être sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void DataGridView_AllUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView_AllUtilisateurs.CurrentRow;
                utilisateur.IdUtilisateur = selectedRow.Cells[0].Value.ToString();
                utilisateur.Pseudo = selectedRow.Cells[1].Value.ToString();
                utilisateur.IdRole = selectedRow.Cells[2].Value.ToString();
                utilisateur.Role = selectedRow.Cells[3].Value.ToString();

                textBox_UpdatePseudo.Enabled = true;
                radioButton_UpdateAdministrateur.Enabled = true;
                radioButton_UpdateUtilisateur.Enabled = true;
                button_UpdateUtilisateur.Enabled = true;
                //button_DeleteUtilisateur.Enabled = true;

                textBox_UpdatePseudo.Text = utilisateur.Pseudo;
                textBox_DeleteUtilisateur.Text = utilisateur.Pseudo;
                
                if (utilisateur.IdRole == "1")
                    radioButton_UpdateAdministrateur.Checked = true;
                else if (utilisateur.IdRole == "2")
                    radioButton_UpdateUtilisateur.Checked = true;
            }
        }
    }
}
