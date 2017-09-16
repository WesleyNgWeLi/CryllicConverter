using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryllicConverter;
using System.IO;

namespace CryllicConverterTests
{
    [TestClass]
    public class ConsoleHelperTests
    {
        ConsoleHelper CH;

        [TestInitialize]
        public void SetUp()
        {
            CH = new ConsoleHelper();
        }
        [TestMethod]
        public void GetInputShouldReturnPopulatedStringIfInputIsAlphanumeric()
        {

            var sr = new StringReader("abc123");
            Console.SetIn(sr);
            var result = CH.GetInput();
            Assert.IsTrue(result == "abc123");
        }

        [TestMethod]
        public void ValidateIsAlphanumericShouldReturnTrueIfAlphabetsAndNumbersOnly()
        {
            Assert.IsTrue(CH.AlphanumericCheck("abc123"));
        }

        [TestMethod]
        public void ValidateIsAlphanumericShouldReturnFalseIfNotAlphabetsAndNumbersOnly()
        {
            Assert.IsFalse(CH.AlphanumericCheck("abc123#@%"));
        }


    }
}
