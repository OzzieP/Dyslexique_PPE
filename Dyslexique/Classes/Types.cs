using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Types</c> utilisée comme modèle pour la représentation d'une entité de la table Type dans la BDD.
    /// </summary>
    public class Types
    {
        private string idTypes;
        /// <summary>
        /// Obtient ou définit l'Id du <c>Types</c>.
        /// </summary>
        public string IdTypes
        {
            get { return idTypes; }
            set { idTypes = value; }
        }

        private string libelle;
        /// <summary>
        /// Obtient ou définit le libellé du <c>Types</c>.
        /// </summary>
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
    }
}
