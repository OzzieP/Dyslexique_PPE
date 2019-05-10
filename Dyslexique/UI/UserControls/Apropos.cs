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
    public partial class Apropos : UserControl
    {
        public string Title = "À propos de nous";


        public Apropos()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.Name = "aPropos";
        }
    }
}
