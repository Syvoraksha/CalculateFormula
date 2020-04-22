using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CalculateFormula;
namespace MyTestUnitCalc
{
    [TestFixture]

    public class UnitTest1
    {
        [TestCase("2", 2)]
        [TestCase("-10013", -10013)]
        [TestCase("-0.002", -0.002)]
        [TestCase("0", 0)]
        [TestCase("123456.123", 123456.123)]

        public void TestMethodInputA(string numberA, double expRes)
        {
            double actRes = new Menu().ReturnA(numberA);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase("28384", 28384)]
        [TestCase("-100143", -100143)]
        [TestCase("-0.012", -0.012)]
        [TestCase("0.001", 0.001)]
        [TestCase("12345.1203", 12345.1203)]

        public void TestMethodInputB(string numberB, double expRes)
        {
            double actRes = new Menu().ReturnB(numberB);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase("2384", 2384)]
        [TestCase("-100143.003", -100143.003)]
        [TestCase("0.012", 0.012)]
        [TestCase("0", 0)]
        [TestCase("4332.1203", 4332.1203)]

        public void TestMethodInputC(string numberC, double expRes)
        {
            double actRes = new Menu().ReturnC(numberC);
            Assert.AreEqual(expRes, actRes);

        }


        [TestCase("54333", 54333)]
        [TestCase("-100.011", -100.011)]
        [TestCase("0.0012", 0.0012)]
        [TestCase("0", 0)]
        [TestCase("433232.1203", 433232.1203)]

        public void TestMethodInputD(string numberD, double expRes)
        {
            double actRes = new Menu().ReturnD(numberD);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase("5333", 5333)]
        [TestCase("-10.011", -10.011)]
        [TestCase("0.001", 0.001)]
        [TestCase("-0.05", -0.05)]
        [TestCase("433232.1203", 433232.1203)]

        public void TestMethodInputE(string numberE, double expRes)
        {
            double actRes = new Menu().ReturnE(numberE);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase("1", 1)]
        [TestCase("-1", -1)]
        [TestCase("0.1", 0.1)]
        [TestCase("-0.1", -0.1)]
        [TestCase("7", 7)]
        [TestCase("-7.2", -7.2)]
        [TestCase("-8", -8)]

        public void TestMethodInputF(string numberF, double expRes)
        {
            double actRes = new Menu().ReturnF(numberF);
            Assert.AreEqual(expRes, actRes);

        }


        [TestCase(1,2,3,4,5,6, "7")]
        [TestCase(1000000, 4, 0.1, 10, 3, 1, "1000000.05714")]
        [TestCase(-1000000, 3, 0, 3, 3, -1, "-1000000")]
        [TestCase(0.2, 0, 7, 7, 0.5, 4, "0.2")]
        [TestCase(-0.2, 0.5, 0.1, -7, -8.2, 0.1, "-0.1509")]
        [TestCase(-3.2, -17.5, 8.2, 3, 7, 0, "-146.7")]
        [TestCase(7.5, 1000, 1000, 8, 5, 4, "12353.17901")]
        [TestCase(3.5, -0.7, 1001, 7, -8, -5, "-532094059")]


        public void TestMethodFormula(double a, double b, double c, double d, double e, double f, string expRes)
        {
            string actRes = new Calculations().ReturnResult(a, b, c, d, e, f);
            Assert.AreEqual(expRes, actRes);

        }
    }
}
