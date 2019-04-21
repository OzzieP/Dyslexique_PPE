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
    //public partial class FormAccueil : Form
    //{
    //    private List<Utilisateur> listUtilisateurs;
    //    private Utilisateur utilisateur;

    //    public FormAccueil()
    //    {
    //        InitializeComponent();
    //    }

    //    public FormAccueil(Utilisateur utilisateur)
    //    {
    //        InitializeComponent();
    //        this.utilisateur = utilisateur;

    //        ToolStripLabel toolStripLabel1 = new ToolStripLabel(this.utilisateur.Pseudo)
    //        {
    //            Margin = new Padding(50, 3, 3, 3)
    //        };
    //        menuStrip1.Items.Add(toolStripLabel1);

    //        if (this.utilisateur.IdRole == "1")
    //            administrationToolStripMenuItem.Visible = true;
    //        else
    //            administrationToolStripMenuItem.Visible = false;

    //        this.listUtilisateurs = Queries.GetAllUtilisateurs();
    //        dataGridView_Utilisateur.DataSource = listUtilisateurs;
    //    }
    //}

    public partial class FormAccueil : Form
    {
        private List<Utilisateur> listUtilisateurs;

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            ToolStripLabel toolStripLabel1 = new ToolStripLabel(Global.Utilisateur.Pseudo)
            {
                Margin = new Padding(50, 3, 3, 3)
            };
            menuStrip1.Items.Add(toolStripLabel1);

            if (Global.Utilisateur.IdRole == "1")
                administrationToolStripMenuItem.Visible = true;
            else
                administrationToolStripMenuItem.Visible = false;

            this.listUtilisateurs = Queries.GetAllUtilisateurs();
            dataGridView_Utilisateur.DataSource = listUtilisateurs;
        }
    }
}
