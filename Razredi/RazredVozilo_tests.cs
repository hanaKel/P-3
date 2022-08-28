using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Razred_Vozilo; 

namespace RazredVozilo_test
{
    [TestClass]
    public class NesmiselniVhodniPodatki
    {
        [TestMethod()]
        public void NesmiselnaPoraba()
        {
            Action preveri = () => new Vozilo(100, 0);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void NesmiselnaKapaciteta()
        {
            Action preveri = () => new Vozilo(-100, 5.6);
            Assert.ThrowsException<Exception>(preveri);
        }

        public void NegativnaPoraba()
        {
            Action preveri = () => new Vozilo(100, -10);
            Assert.ThrowsException<Exception>(preveri);
        }



    public class PravilnostIzracunov
    {
        [TestMethod()]
        public void KolikoKm()
            {
                Vozilo avtomobil1 = new Vozilo(51, 5.1);
                Assert.AreEqual(avtomobil1.PreostaliKilometri, 1000);
            }
        }

        [TestMethod()]
        public void AliPrevozitrue()
        {
            Vozilo avtomobil2= new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0 };
            bool aliKonca = avtomobil2.Prevozi(pot);
            Assert.AreEqual(aliKonca, true);
        }

        [TestMethod()]
        public void AliPrevozifalse()
        {
            Vozilo avtomobil3 = new Vozilo(60, 5);
            double[] pot = new double[] { 1000, 500, 100 };
            bool aliKonca2 = avtomobil3.Prevozi(pot);
            Assert.AreEqual(aliKonca2, false);
        }


    }
}
