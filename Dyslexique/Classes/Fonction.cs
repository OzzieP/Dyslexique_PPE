using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Fonction</c> utilisée comme modèle pour la représentation d'une entité de la table Fonction dans la BDD.
    /// </summary>
    public class Fonction
    {
        private string idFonction;
        /// <summary>
        /// Obtient ou définit l'Id de la <c>Fonction</c>.
        /// </summary>
        public string IdFonction
        {
            get { return idFonction; }
            set { idFonction = value; }
        }

        private string libelle;
        /// <summary>
        /// Obtient ou définit le libellé de la <c>Fonction</c>.
        /// </summary>
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        /// <summary>
        /// Constructeur par défaut d'une <c>Fonction</c>.
        /// </summary>
        public Fonction()
        {

        }
    }
}
