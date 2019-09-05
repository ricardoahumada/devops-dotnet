using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Samples.Money;

namespace MoneySamplesTest
{
    /// <summary>
    /// Summary description for MoneyBagTest
    /// </summary>
    [TestClass]
    public class MoneyBagTest
    {        
        [TestMethod]
        public void TestMoneyCurrency()
        {
            Money expected = new Money(1000, "TWD");
            Money actual = new Money(500, "TWD");
            Assert.AreEqual(expected.Currency, actual.Currency);
        }

        [TestMethod]
        public void TestMoneyAdd()
        {
            Money expected = new Money(1000, "TWD");
            Money actual = new Money(500, "TWD");
            Assert.AreNotEqual(expected, actual.Add(new Money(200, "TWD")));
        }

        [TestMethod]
        public void TestMoneySubtract()
        {
            IMoney expected = new Money(100, "TWD");
            IMoney actual = new Money(500, "TWD");
            actual = actual.Subtract(new Money(400, "TWD"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMoneyMultiply()
        {
            IMoney expected = new Money(1000, "TWD");
            IMoney actual = new Money(500, "TWD");
            actual = actual.Multiply(2);
            Assert.AreEqual(expected, actual);
        }
    }    
}
