using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RzutMoneta;

namespace RzutTest
{
    [TestClass]
    public class TestyRM
    {
        //Test metody   Rzut.Losowanie
        [TestMethod]
        public void TestLosowanie()
        {
            int LMonet = 3;
            Rzut rz = new Rzut();
            rz.Losowanie(LMonet);
           int Liczbalosow = rz.orzel + rz.reszka;
            Assert.AreEqual(rz.wartosci.Length, LMonet, "Rzut nieudany");
        }
        //Test metody Rzut.Wyniki

        [TestMethod]
        public void TestWyniki()
        {
            
           
            Rzut rz = new Rzut();
            rz.wartosci = new int[] { 1,0,0,1};
                      
            rz.Wyniki();
            int a = rz.orzel + rz.reszka;
            
            Assert.AreEqual(a,rz.wartosci.Length , "Rzut nieudany");
        }
        //Test klasy Rzut rzut - górna granica 5 monet
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
        //Test klasy Rzut rzut dolna granica - 1 moneta
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
        //Test klasy rzut - przekroczenie założonej ilości monet
       public void SzescMonet()
        {
            int LMonet = 6;
            Rzut rz = new Rzut();
   
           Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => rz.Losowanie(LMonet));
        }

        [TestMethod]
        //Test klasy rzut - wprowadzenie zerowej ilości monet
        public void ZeroMonet()
        {
            int LMonet = 0;
            Rzut rz = new Rzut();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => rz.Losowanie(LMonet));
        }

                     
    }
}
