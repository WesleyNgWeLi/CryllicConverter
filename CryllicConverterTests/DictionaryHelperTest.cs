using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryllicConverter;
using System.IO;

namespace CryllicConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        DictionaryHelper DH;
        [TestInitialize]
        public void SetUp()
        {
            DH = new DictionaryHelper();
        }

        [TestMethod]
        public void ReturnTrueIfGetCryllicReturnsCorrectCryllicConversion()
        {
            var result = DH.CryllicConvert("abc123");
            Assert.IsTrue(result == "ӒҔГАВГ");
        }

        [TestMethod]
        public void ReturnFalseIfGetCryllicReturnsWrongCryllicConversion()
        {

            var result = DH.CryllicConvert("abc123");
            Assert.IsFalse(result == "asd");
        }
    }
}
