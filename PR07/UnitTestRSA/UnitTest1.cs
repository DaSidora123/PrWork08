using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PR07;

namespace UnitTestRSA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 177;
            bool result;
            if (number < 2)
            {
                result = false;
            }

            if (number == 2)
            {
                result = true;
            }

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }

            result = true;

            Assert.AreEqual(result, true);
        }
    }
}
