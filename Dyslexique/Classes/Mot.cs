using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Mot</c> utilisée comme modèle pour la représentation d'une entité de la table Mot dans la BDD.
    /// </summary>
    public class Mot
    {
        private string idMot;
        /// <summary>
        /// Obtient ou définit l'Id du <c>Mot</c>.
        /// </summary>
        public string IdMot
        {
            get { return idMot; }
            set { idMot = value; }
        }

        private string texte;
        /// <summary>
        /// Obtient ou définit le texte du <c>Mot</c>.
        /// </summary>
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        private Classe classe;
        /// <summary>
        /// Obtient ou définit l'objet <c>Classe</c> du <c>Mot</c>.
        /// </summary>
        public Classe Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        private Fonction fonction;
        /// <summary>
        /// Obtient ou définit l'objet <c>Fonction</c> du <c>Mot</c>.
        /// </summary>
        public Fonction Fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }

        private string position;
        /// <summary>
        /// Obtient ou définit la position du <c>Mot</c> dans la <c>Phrase</c>.
        /// </summary>
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private bool estATrouver;
        /// <summary>
        /// Obtient ou définit si le <c>Mot</c> est celui qui doit être trouvé dans la <c>Phrase</c>.
        /// </summary>
        public bool EstATrouver
        {
            get { return estATrouver; }
            set { estATrouver = value; }
        }

        /// <summary>
        /// Constructeur par défaut d'un <c>Mot</c>.
        /// </summary>
        public Mot()
        {

        }

        /// <summary>
        /// Constructeur spécialisé d'un <c>Mot</c>.
        /// </summary>
        /// <param name="texte"></param>
        /// <param name="position"></param>
        public Mot(string texte, string position)
        {
            this.Texte = texte;
            this.Position = position;
            this.classe = new Classe();
            this.fonction = new Fonction();
        }
    }
}
