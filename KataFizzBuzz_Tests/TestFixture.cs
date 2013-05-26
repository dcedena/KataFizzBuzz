using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataFizzBuzz
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void Test_NumerosDivisibleEntre_NumeroConfiguradoComo_FIZZ()
        {
            Assert.IsFalse(GameFizzBuzz.IsDivisible(1, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(2, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.IsDivisible(3, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(4, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(5, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.IsDivisible(6, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(7, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(8, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.IsDivisible(9, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(10, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(11, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.IsDivisible(12, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(13, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.IsDivisible(14, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.IsDivisible(15, GameFizzBuzz.DEN_FIZZ));
        }

        [Test]
        public void Test_NumerosDivisibleEntre_NumeroConfiguradoComo_BUZZ()
        {
             Assert.IsFalse(GameFizzBuzz.IsDivisible(1, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(2, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(3, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(4, GameFizzBuzz.DEN_BUZZ));
             Assert.IsTrue(GameFizzBuzz.IsDivisible(5, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(6, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(7, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(8, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(9, GameFizzBuzz.DEN_BUZZ));
             Assert.IsTrue(GameFizzBuzz.IsDivisible(10, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(11, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(12, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(13, GameFizzBuzz.DEN_BUZZ));
             Assert.IsFalse(GameFizzBuzz.IsDivisible(14, GameFizzBuzz.DEN_BUZZ));
             Assert.IsTrue(GameFizzBuzz.IsDivisible(15, GameFizzBuzz.DEN_BUZZ));
        }

        [Test]
        public void Test_Lista_1_al_15_Requisitos1()
        {
            Assert.AreEqual(1, GameFizzBuzz.GetValueFizzBuzz(1));
            Assert.AreEqual(2, GameFizzBuzz.GetValueFizzBuzz(2));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz(3));
            Assert.AreEqual(4, GameFizzBuzz.GetValueFizzBuzz(4));
            Assert.AreEqual(GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz(5));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz(6));
            Assert.AreEqual(7, GameFizzBuzz.GetValueFizzBuzz(7));
            Assert.AreEqual(8, GameFizzBuzz.GetValueFizzBuzz(8));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz(9));
            Assert.AreEqual(GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz(10));
            Assert.AreEqual(11, GameFizzBuzz.GetValueFizzBuzz(11));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz(12));
            Assert.AreEqual(13, GameFizzBuzz.GetValueFizzBuzz(13));
            Assert.AreEqual(14, GameFizzBuzz.GetValueFizzBuzz(14));
            Assert.AreEqual(GameFizzBuzz.FIZZ+GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz(15));
            Assert.AreEqual(16, GameFizzBuzz.GetValueFizzBuzz(16));
        }

        [Test]
        public void Test_PintarEnConsola_Del_1_al_100_Requisitos1()
        {
            int num = 100;
            for (int i = 1; i < num; i++)
                Console.WriteLine(GameFizzBuzz.GetValueFizzBuzz(i).ToString());
        }

        [Test]
        public void Test_NumerosContienen_DEN_FIZZ_Requisitos2()
        {
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(1, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(2, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.ContainsDenominator(3, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(4, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(5, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(6, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(7, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(8, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(9, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(10, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(11, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(12, GameFizzBuzz.DEN_FIZZ));
            Assert.IsTrue(GameFizzBuzz.ContainsDenominator(13, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(14, GameFizzBuzz.DEN_FIZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(15, GameFizzBuzz.DEN_FIZZ));
        }

        [Test]
        public void Test_NumerosContienen_DEN_BUZZ_Requisitos2()
        {
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(1, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(2, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(3, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(4, GameFizzBuzz.DEN_BUZZ));
            Assert.IsTrue(GameFizzBuzz.ContainsDenominator(5, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(6, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(7, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(8, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(9, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(10, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(11, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(12, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(13, GameFizzBuzz.DEN_BUZZ));
            Assert.IsFalse(GameFizzBuzz.ContainsDenominator(14, GameFizzBuzz.DEN_BUZZ));
            Assert.IsTrue(GameFizzBuzz.ContainsDenominator(15, GameFizzBuzz.DEN_BUZZ));
        }

        [Test]
        public void Test_Lista_1_al_15_Requisitos2()
        {
            Assert.AreEqual(1, GameFizzBuzz.GetValueFizzBuzz2(1));
            Assert.AreEqual(2, GameFizzBuzz.GetValueFizzBuzz2(2));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz2(3));
            Assert.AreEqual(4, GameFizzBuzz.GetValueFizzBuzz2(4));
            Assert.AreEqual(GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz2(5));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz2(6));
            Assert.AreEqual(7, GameFizzBuzz.GetValueFizzBuzz2(7));
            Assert.AreEqual(8, GameFizzBuzz.GetValueFizzBuzz2(8));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz2(9));
            Assert.AreEqual(GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz2(10));
            Assert.AreEqual(11, GameFizzBuzz.GetValueFizzBuzz2(11));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz2(12));
            Assert.AreEqual(GameFizzBuzz.FIZZ, GameFizzBuzz.GetValueFizzBuzz2(13));
            Assert.AreEqual(14, GameFizzBuzz.GetValueFizzBuzz2(14));
            Assert.AreEqual(GameFizzBuzz.FIZZ + GameFizzBuzz.BUZZ, GameFizzBuzz.GetValueFizzBuzz2(15));
            Assert.AreEqual(16, GameFizzBuzz.GetValueFizzBuzz2(16));
        }

        [Test]
        public void Test_PintarEnConsola_Del_1_al_100_Requisitos2()
        {
            int num = 100;
            for (int i = 1; i < num; i++)
                Console.WriteLine(GameFizzBuzz.GetValueFizzBuzz2(i).ToString());
        }
    }
}
