using Dyslexique.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyslexique_UnitTestProject
{
    public interface IDAL
    {
        Utilisateur GetUtilisateurByPseudo();

        Utilisateur GetUtilisateurById();

        Phrase GetPhraseById();
    }
}
