using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HectorAndradeTest.AplicationConsole.ProcessCore.Tests
{
    [TestClass()]
    public class PrimeNumberProcessTests
    {
        [TestMethod()]
        public void True_IsNumberPrimeTest()
        {
            bool result = PrimeNumberProcess.IsNumberPrime(1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void False_IsNumberPrimeTest()
        {
            bool result = PrimeNumberProcess.IsNumberPrime(8);
            Assert.IsFalse(result);
        }
    }
}