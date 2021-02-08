using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RzutMoneta;

namespace RzutTest
{
    [TestClass]
    public class TestyRM
    {
        [TestMethod]
        public void TestLosowanie()
        {
            int LMonet = 3;
            Rzut rz = new Rzut();
            rz.Losowanie(LMonet);
           int Liczbalosow = rz.orzel + rz.reszka;
            Assert.AreEqual(rz.wartosci.Length, LMonet, "Rzut nieudany");
        }

       /* [TestMethod]
        public void TestWyniki()
        {
            
           // int[] values = new int[] { 0, 1, 0 };
            Rzut rz = new Rzut();
            
            //int[] values = new int[] { 0, 1, 0,1 };
            
            rz.Wyniki();
            int a = rz.orzel + rz.reszka;
            
            /*rz.Losowanie(LMonet);
            int Liczbalosow = rz.orzel + rz.reszka;
            Assert.AreEqual(a,0 , "Rzut nieudany");
        }*/

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

        [TestMethod]
       public void SzescMonet()
        {
            int LMonet = 6;
            Rzut rz = new Rzut();
   
           Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => rz.Losowanie(LMonet));
        }

        [TestMethod]
        public void ZeroMonet()
        {
            int LMonet = 0;
            Rzut rz = new Rzut();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => rz.Losowanie(LMonet));
        }

                     
    }
}
