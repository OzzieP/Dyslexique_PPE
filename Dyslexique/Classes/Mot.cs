using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique.Classes
{
    public class Mot // Texte, Genre, Classe
    {
        #region Cours
        // Attributs
        private String texte;
        private String type;

        // Accesseurs de l'attribut Texte
        public String getTexte()
        {
            return this.texte;
        }
        public void setTexte(String texte)
        {
            this.texte = texte;
        }

        public String getType()
        {
            return this.type;
        }
        public void setType(String type)
        {
            this.type = type;
        }

        // Constructeurs
        public Mot()
        {

        }

        public Mot(String texte)
        {
            this.texte = texte;
        }

        public Mot(String texte, String type)
        {
            this.texte = texte;
            this.type = type;
        }
        #endregion

        #region Nouveau
        private int idMot;
        public int IdMot
        {
            get { return idMot; }
            set { idMot = value; }
        }

        private string text;
        public string Texte
        {
            get { return text; }
            set { text = value; }
        }

        private int idClasse;
        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        private int idGenre;
        public int IdGenre
        {
            get { return idGenre; }
            set { idGenre = value; }
        }
        #endregion

    }
}