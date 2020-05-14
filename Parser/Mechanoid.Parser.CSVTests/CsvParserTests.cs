using Mechanoid.Parser.CSV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanoid.Parser.CSV.Tests
{
    [TestClass()]
    public class CsvParserTests
    {
        public CsvParserTests()
        {
           
        }

        [TestMethod()]
        public void ParseDocumentTest()
        {
            

        }

        [TestMethod()]
        public void ParserStringTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void ParseMultiObjectDocumentTest()
        {
            var parser = new CsvParser<TestDataObject>(true);
            var result = parser.ParseMultiObjectDocument("Testdata.csv");

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual("zander", result[1].Name);
        }
    }
}