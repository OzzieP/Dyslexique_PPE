using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.Classes
{
    public class CustomLabel : Label
    {
        private Mot mot = new Mot();

        public CustomLabel(Mot mot, int x)
        {
            this.mot = mot;
            this.Text = this.mot.Texte;
            this.Top = 0;
            this.Left = x;

            this.Click += new EventHandler(OnClick);
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);
        }

        private void OnClick(object s, EventArgs e)
        {
            string fonc = this.mot.Fonction.Libelle;
            MessageBox.Show("Le click marche ! Fonction : " + fonc, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.Font = new Font(this.Font, FontStyle.Underline);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Font = new Font(this.Font, FontStyle.Regular);
        }
    }
}
