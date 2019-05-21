using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyslexique.Classes;
using Moq;

namespace Dyslexique_UnitTestProject
{
    [TestClass]
    public class MockTest
    {
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

            IDAL iDal = Mock.Of <IDAL>();
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
    }
}
