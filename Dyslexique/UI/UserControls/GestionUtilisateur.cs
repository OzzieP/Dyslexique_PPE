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
    public partial class GestionUtilisateur : UserControl
    {
        public string Title = "Gestion des utilisateurs";
        private List<Utilisateur> listUtilisateurs;
        private Utilisateur utilisateur;

        public GestionUtilisateur()
        {
            InitializeComponent();

            listUtilisateurs = Queries.GetAllUtilisateurs();
        }

        private void GestionUtilisateur_Load(object sender, EventArgs e)
        {
            dataGridView_AllUtilisateurs.DataSource = listUtilisateurs;
            dataGridView_AllUtilisateurs.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        }

        private void Buttons_MouseHover_ShowMdp(object sender, EventArgs e)
        {
            if (sender == button_Ajout_ShowMdp)
            {
                textBox_InsertMdp.UseSystemPasswordChar = false;
                button_Ajout_ShowMdp.Image = Dyslexique.Properties.Resources.EyeOff_16;
            }
            else if (sender == button_Ajout_ShowConfMdp)
            {
                textBox_InsertConfMdp.UseSystemPasswordChar = false;
                button_Ajout_ShowConfMdp.Image = Dyslexique.Properties.Resources.EyeOff_16;
            }
        }

        private void Buttons_MouseLeave_HideMdp(object sender, EventArgs e)
        {
            if (sender == button_Ajout_ShowMdp)
            {
                textBox_InsertMdp.UseSystemPasswordChar = true;
                button_Ajout_ShowMdp.Image = Dyslexique.Properties.Resources.Eye_16;
            }
            else if (sender == button_Ajout_ShowConfMdp)
            {
                textBox_InsertConfMdp.UseSystemPasswordChar = true;
                button_Ajout_ShowConfMdp.Image = Dyslexique.Properties.Resources.Eye_16;
            }
        }

        private void Refresh_DataGridView_AllUtilisateur()
        {
            this.listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_AllUtilisateurs.DataSource = listUtilisateurs;

            ResetTextBoxes();
            ResetRadioButtons();

            button_UpdateUtilisateur.Enabled = false;
            button_DeleteUtilisateur.Enabled = false;
        }

        private void ResetTextBoxes()
        {
            // Insert
            foreach (TextBox textBox in groupBox_InsertUtilisateur.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            // Update
            foreach (TextBox textBox in groupBox_UpdateUtilisateur.Controls.OfType<TextBox>())
            {
                textBox.Clear();
                textBox.Enabled = false;
            }

            // Delete
            foreach (TextBox textBox in groupBox_DeleteUtilisateur.Controls.OfType<TextBox>())
            {
                textBox.Clear();
                textBox.Enabled = false;
            }
        }

        private void ResetRadioButtons()
        {
            // Insert
            foreach (RadioButton radioButton in groupBox_InsertUtilisateur.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }

            // Update
            foreach (RadioButton radioButton in groupBox_UpdateUtilisateur.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
                radioButton.Enabled = false;
            }
        }

        private void Button_InsertUtilisateur_Click(object sender, EventArgs e)
        {
            string pseudo = textBox_InsertPseudo.Text;
            string nom = textBox_InsertNom.Text;
            string prenom = textBox_InsertPrenom.Text;
            string email = textBox_InsertEmail.Text;
            string mdp = textBox_InsertMdp.Text;
            string confMdp = textBox_InsertConfMdp.Text;

            try
            {
                List<TextBox> textBoxes = new List<TextBox>();

                foreach (TextBox textBox in groupBox_InsertUtilisateur.Controls.OfType<TextBox>())
                {
                    textBoxes.Add(textBox);
                }

                bool isNullOrEmptyOrWhitespace = CheckIfTextBoxesAreValid(textBoxes);

                if (!isNullOrEmptyOrWhitespace)
                {
                    if (!radioButton_InsertAdministrateur.Checked && !radioButton_InsertUtilisateur.Checked)
                    {
                        MessageBox.Show("Un Rôle doit être sélectionné.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (mdp == confMdp)
                        {
                            if (radioButton_InsertAdministrateur.Checked)
                                Queries.InsertUtilisateur(pseudo, nom, prenom, email, mdp, Global.ROLE_ADMINISTRATEUR);
                            else if (radioButton_InsertUtilisateur.Checked)
                                Queries.InsertUtilisateur(pseudo, nom, prenom, email, mdp, Global.ROLE_UTILISATEUR);

                            Refresh_DataGridView_AllUtilisateur();
                        }
                        else
                        {
                            MessageBox.Show("Les deux mots de passe entrés ne correspondent pas.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un Utilisateur doit être sélectionné.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Button_UpdateUtilisateur_Click(object sender, EventArgs e)
        {
            string idUtilisateur = utilisateur.IdUtilisateur;
            string pseudo = textBox_UpdatePseudo.Text;
            string nom = textBox_UpdateNom.Text;
            string prenom = textBox_UpdatePrenom.Text;
            string email = textBox_UpdateEmail.Text;

            try
            {
                List<TextBox> textBoxes = new List<TextBox>();

                foreach (TextBox textBox in groupBox_UpdateUtilisateur.Controls.OfType<TextBox>())
                {
                    textBoxes.Add(textBox);
                }

                bool isNullOrEmptyOrWhitespace = CheckIfTextBoxesAreValid(textBoxes);

                if (!isNullOrEmptyOrWhitespace)
                {
                    if (!radioButton_UpdateAdministrateur.Checked && !radioButton_UpdateUtilisateur.Checked)
                    {
                        MessageBox.Show("Un Rôle doit être sélectionné.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (radioButton_UpdateAdministrateur.Checked)
                            Queries.UpdateUtilisateur(idUtilisateur, pseudo, nom, prenom, email, Global.ROLE_ADMINISTRATEUR);
                        else if (radioButton_UpdateUtilisateur.Checked)
                            Queries.UpdateUtilisateur(idUtilisateur, pseudo, nom, prenom, email, Global.ROLE_UTILISATEUR);

                        Refresh_DataGridView_AllUtilisateur();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un Utilisateur doit être sélectionné.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Button_DeleteUtilisateur_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'utilisateur : " + utilisateur.Pseudo + " ?",
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
                    MessageBox.Show("Un Utilisateur doit être sélectionné.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private bool CheckIfTextBoxesAreValid(List<TextBox> textBoxes)
        {
            List<bool> listBool = new List<bool>();
            bool isNullOrEmptyOrWhitespace = false;

            foreach (TextBox textBox in textBoxes)
            {
                bool isTextBoxValide = false;
                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isTextBoxValide = false;
                    listBool.Add(isTextBoxValide);
                    errorProvider_TextBox.SetError(textBox, "Le champ \"" + textBox.Tag + "\" ne peut pas être vide.");
                    errorProvider_TextBox.SetIconAlignment(textBox, ErrorIconAlignment.MiddleLeft);
                }
                else
                {
                    isTextBoxValide = true;
                    listBool.Add(isTextBoxValide);
                }
            }

            foreach (bool boolean in listBool)
            {
                if (boolean == false)
                {
                    isNullOrEmptyOrWhitespace = true;
                    break;
                }
            }

            return isNullOrEmptyOrWhitespace;
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

                this.utilisateur = new Utilisateur
                {
                    IdUtilisateur = selectedRow.Cells[0].Value.ToString(),
                    Pseudo = selectedRow.Cells[1].Value.ToString(),
                    Nom = selectedRow.Cells[2].Value.ToString(),
                    Prenom = selectedRow.Cells[3].Value.ToString(),
                    Email = selectedRow.Cells[4].Value.ToString(),
                    IdRole = selectedRow.Cells[5].Value.ToString(),
                    Role = selectedRow.Cells[6].Value.ToString()
                };

                // Update
                foreach (TextBox textBox in groupBox_UpdateUtilisateur.Controls.OfType<TextBox>())
                {
                    textBox.Enabled = true;
                }
                textBox_UpdatePseudo.Text = utilisateur.Pseudo;
                textBox_UpdateNom.Text = utilisateur.Nom;
                textBox_UpdatePrenom.Text = utilisateur.Prenom;
                textBox_UpdateEmail.Text = utilisateur.Email;
                radioButton_UpdateAdministrateur.Enabled = true;
                radioButton_UpdateUtilisateur.Enabled = true;
                button_UpdateUtilisateur.Enabled = true;

                // Delete
                textBox_DeletePseudo.Text = utilisateur.Pseudo;
                textBox_DeleteNom.Text = utilisateur.Nom;
                textBox_DeletePrenom.Text = utilisateur.Prenom;
                textBox_DeleteRole.Text = utilisateur.Role;
                button_DeleteUtilisateur.Enabled = true;

                // Rôles
                if (utilisateur.IdRole == Global.ROLE_ADMINISTRATEUR)
                    radioButton_UpdateAdministrateur.Checked = true;
                else if (utilisateur.IdRole == Global.ROLE_UTILISATEUR)
                    radioButton_UpdateUtilisateur.Checked = true;
            }
        }
    }
}
