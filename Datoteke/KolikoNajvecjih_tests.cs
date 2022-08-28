using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericniTipi_KolikoNajvecjih;


namespace KolikoNajvecjih_TESTS
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod()]
        public void PraznaTabela()
        {
            double[] tab = new double[0];
            int rez = GenericniTipi_KolikoNajvecjih.Najvecji.StNajvecji(tab);
            Assert.AreEqual(rez, 0);
        }

        [TestMethod()]
        public void TabelaIntov()
        {
            int[] tab = new int[] { 2, 3, 4, 5, 1, 2, 2, 5 };
            int rez = GenericniTipi_KolikoNajvecjih.Najvecji.StNajvecji(tab);
            Assert.AreEqual(rez, 2);
        }

        [TestMethod()]
        public void TabelaStringov()
        {
            string[] tab = new string[] { "hana", "isabela", "leon" };
            int rez = GenericniTipi_KolikoNajvecjih.Najvecji.StNajvecji(tab);
            Assert.AreEqual(rez, 3);
        }

        [TestMethod()]
        public void TabelaStringov2()
        {
            string[] tab = new string[] { "hana", "isabela", "leon" };
            int rez = GenericniTipi_KolikoNajvecjih.Najvecji.StNajvecji(tab);
            Assert.AreEqual(rez, 5);
        }
    }
}
