using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexique.Classes
{
    public class Test
    {
        private ElementSujet elementSujet;
        private ElementVerbe elementVerbe;
        private ElementComplement elementComplement;

        private List<Element> elements;

        public Phrase(ElementSujet elementSujet, ElementVerbe elementVerbe, ElementComplement elementComplement)
        {
            this.elementSujet = elementSujet;
            this.elementVerbe = elementVerbe;
            this.elementComplement = elementComplement;
            this.elements = new List<Element>();
            this.elements.Add(elementSujet);
            this.elements.Add(elementVerbe);
            this.elements.Add(elementComplement);

        }
        public String getPhrase()
        {
            String texte = "";
            foreach (Element unElement in elements)
            {
                texte = texte + unElement.getText() + " ";
            }


            return texte;
        }
        public void Afficher(Form3 form3)
        {
            int x = 0;
            foreach (Element unElement in elements)
            {

                Label label = new LabelPerso();
                label.Text = unElement.getText();
                label.Top = 0;
                label.Left = x;
                // Measure string.
                SizeF stringSize = new SizeF();
                Graphics g = form3.CreateGraphics();
                stringSize = g.MeasureString(unElement.getText(), label.Font);
                label.Width = Convert.ToInt32(stringSize.Width) + 5;
                form3.Controls.Add(label);

                x = x + Convert.ToInt32(stringSize.Width) + 5;
                //x = x + 100;

                MessageBox.Show(Convert.ToString(Convert.ToInt32(stringSize.Width)), "My Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}