using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RzutMoneta;

namespace RzutTest
{
    [TestClass]
    public class TestyRM
    {
        [TestMethod]
        public void PiecMonet()
        {
            int LMonet = 5;
            Rzut rz = new Rzut();
            rz.Losowanie(LMonet);
            rz.Wyniki();
            int Liczbalosow = rz.orzel + rz.reszka;
            Assert.AreEqual(Liczbalosow, LMonet, "Rzut nieudany");
        }

        [TestMethod]
        public void JednaMoneta()
        {
            int LMonet = 1;
            Rzut rz = new Rzut();
            rz.Losowanie(LMonet);
            rz.Wyniki();
            int Liczbalosow = rz.orzel + rz.reszka;
            Assert.AreEqual(Liczbalosow, LMonet, "Rzut nieudany");
        }
       /* [TestMethod]
        public void szescMonet()
        {
            int LMonet = 0;
            Rzut rz = new Rzut();
            rz.Losowanie(LMonet);
            rz.Wyniki();
            int Liczbalosow = rz.orly + rz.reszki;
            Assert.AreEqual(Liczbalosow, LMonet, "Rzut nieudany");
        }*/



    }
}
