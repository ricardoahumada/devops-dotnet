using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace FirstUnitTest
{
    [TestClass]
    public class FirstUnitTest
    {
        [ClassInitialize()]
        public static void setupBeforeAllTestMethod(TestContext context) { 
            // 初始化資源
            // 在執行所有測試方法之前，會執行本測試方法
            // 本例只會執行一次
        }

        [TestInitialize]
        public void setupBeforeEachTestMethod() {
            // 初始化資源
            // 在執行每一個測試方法之前，會執行本測試方法
            // 本例會執行三次
        }


        [TestMethod]
        public void testBasic()
        {
            string expected = "Unit test";      // 期望值
            string actual = "Unit test";        // 實際運算值

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void testException()     // 測試預期會丟出 (throwing)的例外 (Exception)
        {
            int num1, num2;
            num1 = 10;  num2 = 0;
            double returnVal =  num1/ num2;
        }

        [TestMethod]
        [Timeout(500)]  // Milliseconds
        public void testTimeoutFail()       // 測試該方法可在預期執行的時間內完成
        {
            Thread.Sleep(499);
        }

        [ClassCleanup()]
        public static void cleanAfterAllTestMethod() {
            // 釋放資源
            // 在執行所有測試方法之前，會執行本測試方法
            // 本例會執行一次
        }

        [TestCleanup]
        public void cleanAfterEachTestMethod() {
            // 釋放資源
            // 在執行每一個測試方法之前，會執行本測試方法
            // 本例會執行三次        
        }
    }
}
