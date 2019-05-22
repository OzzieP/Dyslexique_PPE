using System;
using System.Collections.Generic;
using Dyslexique.Classes;
using Dyslexique.DAL;
using Dyslexique.UI.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
                IdRole = Global.ROLE_ADMINISTRATEUR
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

        [TestMethod]
        public void Test_Verification_Utilisateur_LogIn_SignIn()
        {
            Utilisateur utilisateur = new Utilisateur
            {
                IdUtilisateur = "1",
                Pseudo = "blegendre",
                Nom = "Legendre",
                Prenom = "Brendan",
                Email = "bre.leg@gmail.com",
                MotDePasse = "bl123",
                IdRole = Global.ROLE_ADMINISTRATEUR
            };
            Global.Utilisateur = utilisateur;

            Assert.AreEqual(Global.Utilisateur, utilisateur);
        }

        #region Tests Mock
        [TestMethod]
        public void MockTest_GetUtilisateurByPseudo()
        {
            string pseudo = "unitTest", nom = "Unit", prenom = "Test", email = "unit.test@gmail.com", mdp = "ut123";

            Utilisateur tempUtilisateur = new Utilisateur()
            {
                Pseudo = pseudo,
                Nom = nom,
                Prenom = prenom,
                Email = email,
                MotDePasse = Global.Hash256(mdp),
                IdRole = Global.ROLE_UTILISATEUR,
                Role = "Utilisateur"
            };

            IDAL iDal = Mock.Of<IDAL>();
            Mock.Get(iDal).Setup(dal => dal.GetUtilisateurByPseudo()).Returns(tempUtilisateur);

            Utilisateur utilisateur = iDal.GetUtilisateurByPseudo();
            Assert.AreEqual(tempUtilisateur, utilisateur);
        }

        [TestMethod]
        public void MockTest_GetUtilisateurById()
        {
            string idUtilisateur = "1", pseudo = "unitTest", nom = "Unit", prenom = "Test", email = "unit.test@gmail.com", mdp = "ut123";

            Utilisateur tempUtilisateur = new Utilisateur()
            {
                IdUtilisateur = idUtilisateur,
                Pseudo = pseudo,
                Nom = nom,
                Prenom = prenom,
                Email = email,
                MotDePasse = Global.Hash256(mdp),
                IdRole = Global.ROLE_UTILISATEUR,
                Role = "Utilisateur"
            };

            IDAL iDal = Mock.Of<IDAL>();
            Mock.Get(iDal).Setup(dal => dal.GetUtilisateurById()).Returns(tempUtilisateur);

            Utilisateur utilisateur = iDal.GetUtilisateurById();
            Assert.AreEqual(tempUtilisateur, utilisateur);
        }

        [TestMethod]
        public void MockTest_GetPhraseById()
        {
            Mot mot = new Mot("Bonjour", "1");
            Mot mot1 = new Mot("ou", "2");
            Mot mot2 = new Mot("bonsoir", "3");
            List<Mot> mots = new List<Mot> { mot, mot1, mot2 };

            Phrase tempPhrase = new Phrase
            {
                IdPhrase = "1",
                AEteReussie = true,
                Consigne = "Retrouver l'adjectif qualificatif.",
                DateDerniereTentative = DateTime.Now,
                MotATrouver = mot,
                Mots = mots,
                Tentative = 0,
                Texte = "Bonjour ou bonsoir."
            };


            IDAL iDal = Mock.Of<IDAL>();
            Mock.Get(iDal).Setup(dal => dal.GetPhraseById()).Returns(tempPhrase);

            Phrase phrase = iDal.GetPhraseById();
            Assert.AreEqual(tempPhrase, phrase);
        }
        #endregion
    }
}
