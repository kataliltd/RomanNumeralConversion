using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Service;

namespace RomanNumeral.UnitTest
{
    [TestClass]
    public class GetRomanNumeralFromNumberTest
    {
        private RomanNumeralConversion _service;

        [TestInitialize]
        public void SetUp()
        {
            _service = new RomanNumeralConversion();
        }


        [TestMethod]
        public void GetRomanNumeralFromNumber_Number0Passed_ReturnsRomanNumeralErrorMessage()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(0);

            //Assert
            Assert.AreEqual("Invalid value entered, must be a number between 1 and 2000", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number5000Passed_ReturnsRomanNumeralErrorMessage()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(5000);

            //Assert
            Assert.AreEqual("Invalid value entered, must be a number between 1 and 2000", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number1Passed_ReturnsRomanNumeralI()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(1);

            //Assert
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number2Passed_ReturnsRomanNumeralII()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(2);

            //Assert
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number3Passed_ReturnsRomanNumeralIII()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(3);

            //Assert
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number4Passed_ReturnsRomanNumeralIV()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(4);

            //Assert
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number5Passed_ReturnsRomanNumeralV()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(5);

            //Assert
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number9Passed_ReturnsRomanNumeralIX()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(9);

            //Assert
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number10Passed_ReturnsRomanNumeralX()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(10);

            //Assert
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number50Passed_ReturnsRomanNumeralL()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(50);

            //Assert
            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number100Passed_ReturnsRomanNumeralC()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(100);

            //Assert
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number500Passed_ReturnsRomanNumeralD()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(500);

            //Assert
            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void GetRomanNumeralFromNumber_Number1000Passed_ReturnsRomanNumeralM()
        {
            //Act
            var result = _service.GetRomanNumeralFromNumber(1000);

            //Assert
            Assert.AreEqual("M", result);
        }
    }
}
