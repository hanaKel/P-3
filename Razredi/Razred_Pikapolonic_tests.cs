using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Razred_Pikapolonica;

namespace RazredPikapolonica_test
{
    [TestClass]
    public class ValidacijaPodatkov
    {

        [TestMethod()]
        public void PrevelikaStarost()
        {
            Action preveri = () => new Pikapolonica(300, 100);
            Assert.ThrowsException<Exception>(preveri);
        }
        [TestMethod()]
        public void NegativnoStloPik()
        {
            Action preveri = () => new Pikapolonica(300, -10);
            Assert.ThrowsException<Exception>(preveri);
        }
        [TestMethod()]
        public void OKvnos()
        {
            Pikapolonica testna = new Pikapolonica(120, 7);
            Assert.AreEqual(testna.Starost, 120);
        }

    }

    [TestClass]
    public class PravilnostIzracunov
    {

        [TestMethod()]
        public void NegPodatek_Kopije()
        {
            // starost, st.pik
            // starost je 40t, kar je manj kot 300t. to je ok
           
            Pikapolonica pikapoka = new Pikapolonica(40, 10);
            Action preveri = () => { Pikapolonica[] kopije = pikapoka * -2; };
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void PozPodatek_Kopije()
        {
            // starost, st.pik
            // starost je 40t, kar je manj kot 300t. to je ok

            Pikapolonica polonca = new Pikapolonica(40, 10);
            Action preveri = () => { Pikapolonica[] kopije = polonca * 2; };
            Assert.ThrowsException<Exception>(preveri);
        }



        [TestMethod()]
        public void PravilnoSestevanje()
        {
            Pikapolonica[] tabela = new Pikapolonica[2];

            // dve pikapolinici imata skupaj 10pik.
            tabela[0] = new Pikapolonica(220, 3);
            tabela[1] = new Pikapolonica(10, 7);

            Assert.AreEqual(Pikapolonica.VsotaPik(tabela), 10);

        }
    }
}
