using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.UI.UserControls
{
    public class CustomUserControl : UserControl
    {
        public string Title { get; protected set; }

        public CustomUserControl()
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
