using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble2Joueurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble2Joueurs.Tests
{
    [TestClass()]
    public class JoueurTests
    {
        [TestMethod()]
        public void JoueurTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AjouterMotTest()
        {
            Joueur J1 = new Joueur("J1");
            J1.AjouterMot("mot");
            Assert.AreEqual(4, J1.GetTotalPoints());
            Assert.AreEqual("mot", J1.GetLesMots()[0]);
            J1.AjouterMot("phrase");
            Assert.AreEqual(15, J1.GetTotalPoints());
            Assert.AreEqual("phrase", J1.GetLesMots()[1]);
        }

        [TestMethod()]
        public void GetTotalPointsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNbMotsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetLesMotsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MotMeilleurTest()
        {
            Joueur J1 = new Joueur("J1");
            J1.AjouterMot("mot");
            J1.AjouterMot("xylophone");
            J1.AjouterMot("phrase");
            Assert.AreEqual("xylophone", J1.MotMeilleur());
        }
    }
}