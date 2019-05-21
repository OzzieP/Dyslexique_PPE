using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.UI.UserControls
{
    /// <summary>
    /// Contrôle utilisateur affichant la page "À propos".
    /// </summary>
    public partial class Apropos : UserControl
    {
        /// <summary>
        /// Obtient ou définit le titre de la page "À propos".
        /// </summary>
        public string Title = "À propos de nous";

        /// <summary>
        /// Constructeur par défaut de la page "À propos".
        /// </summary>
        public Apropos()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }
    }
}
