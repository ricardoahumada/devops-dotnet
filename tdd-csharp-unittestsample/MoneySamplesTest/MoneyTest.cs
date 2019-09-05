using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Samples.Money;

namespace MoneySamplesTest
{ 
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void testMoneyEquals()           // 比對值
        {
            IMoney expected = new Money(100, "TWD");
            IMoney actual = new Money(100, "TWD");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testMoneyArrayEquals()      // 陣列比對
        {
            IMoney[] expected = new Money[2];
            expected[0] = new Money(100, "TWD");
            expected[1] = new Money(100, "USD");

            IMoney[] actual = new Money[2];
            actual[0] = new Money(100, "TWD");
            actual[1] = new Money(100, "USD");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testMoneySame()             // 是否指向同一物件(instance)參考
        {
            IMoney money = new Money(100, "TWD");
            IMoney expected = money;
            IMoney actual = money;

            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void testMoneyNotSame()           // 比對不同的物件參考
        {           
            IMoney expected = new Money(100, "TWD");
            IMoney actual = new Money(100, "TWD");

            Assert.AreNotSame(expected, actual);
        }

        [TestMethod]
        public void testMoneyEqualsTrue()        // 比對預期的條件判斷為 True
        {
            IMoney expected = new Money(100, "TWD");
            IMoney actual = new Money(100, "TWD");

            Assert.IsTrue(expected.Equals(actual));            
        }

        [TestMethod]
        public void testMoneyEquaFalse()        // 比對預期的條件判斷為 False
        {
            IMoney expected = new Money(100, "TWD");
            IMoney actual = new Money(100, "TWD");

            Assert.IsFalse(expected == actual);
        }
    }
}
