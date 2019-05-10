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
    public partial class Accueil : UserControl
    {
        public string Title = "Accueil";


        public Accueil()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.Name = "accueil";
        }
    }
}
