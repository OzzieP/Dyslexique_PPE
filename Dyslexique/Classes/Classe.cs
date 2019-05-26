using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Espace de nom contenant toutes les classes représentant des entités des tables dans la BDD.
/// </summary>
namespace Dyslexique.Classes
{
    /// <summary>
    /// Classe <c>Classe</c> utilisée comme modèle pour la représentation d'une entité de la table Classe dans la BDD.
    /// </summary>
    public class Classe
    {
        private string idClasse;
        /// <summary>
        /// Obtient ou définit l'Id de la <c>Classe</c>.
        /// </summary>
        public string IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        private string libelle;
        /// <summary>
        /// Obtient ou définit le libellé de la <c>Classe</c>.
        /// </summary>
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        private Types type;
        /// <summary>
        /// Obtient ou définit l'objet <c>Types</c> de la <c>Classe</c>.
        /// </summary>
        public Types Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
