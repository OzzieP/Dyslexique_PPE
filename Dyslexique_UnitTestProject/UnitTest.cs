using System;
using Dyslexique.Classes;
using Dyslexique.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dyslexique_UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Verification_Suppression_DonneesUtilisateur_SignOut()
        {
            Utilisateur utilisateur = new Utilisateur
            {
                IdUtilisateur = "1",
                Pseudo = "blegendre",
                Nom = "Legendre",
                Prenom = "Brendan",
                Email = "bre.leg@gmail.com",
                MotDePasse = "bl123",
                IdRole = "1"
            };
            Global.Utilisateur = utilisateur;
            utilisateur.SignOut();

            Assert.IsNull(utilisateur.IdUtilisateur);
            Assert.IsNull(utilisateur.Pseudo);
            Assert.IsNull(utilisateur.IdRole);
            Assert.IsNull(utilisateur.Email);
            Assert.IsNull(utilisateur.Nom);
            Assert.IsNull(utilisateur.Prenom);
            Assert.IsNull(utilisateur.Role);
            Assert.IsNull(utilisateur.MotDePasse);
        }
    }
}
