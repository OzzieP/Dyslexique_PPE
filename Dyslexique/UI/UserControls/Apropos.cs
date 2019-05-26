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
    public partial class Apropos : CustomUserControl
    {
        /// <summary>
        /// Constructeur par défaut de la page "À propos".
        /// </summary>
        public Apropos()
        {
            InitializeComponent();

            this.Title = "À propos de nous";
        }
    }
}
