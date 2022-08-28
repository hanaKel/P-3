using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Razred_Racun;

namespace RazredRacun_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PologDenarja()
        {
            Razred_Racun.Racun test = new Racun("dollar", 1); 
            test.Polog(100);
            test.Polog(-50);
            Assert.AreEqual(test.StanjeEUR, 50);
        }

        [TestMethod()]
        public void StanjeNaRacunu()
        {
            Racun test = new Racun("dollar", 1);
            test.Polog(100);
            Assert.AreEqual(test.StanjeEUR, 100);
        }
    }
}
