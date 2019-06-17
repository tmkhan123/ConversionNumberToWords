using NUnit.Framework;
using NumberSystem;

namespace UnitTest
{
    [TestFixture]
    class NumberTowordConversionTest
    {        
        [Test]
        public void IsCovertingCorrectOneDigitNo()
        {
            ConversionNumberToWords objectConversion = new ConversionNumberToWords();
            string expectedResult = "four";
            string actualResult = objectConversion.ConvertNumberToWords(4);
            Assert.AreEqual(actualResult, expectedResult);
            
        }

        [Test]
        public void IsConvertingCorrect2DigitNo()
        {
            ConversionNumberToWords objectConversion = new ConversionNumberToWords();
            string expectedResult = "twelve";
            string actualResult = objectConversion.ConvertNumberToWords(12);
            Assert.AreEqual(actualResult, expectedResult);

        }
        [Test]
        public void IsCovertingCorrect3DigitNo()
        {
            ConversionNumberToWords objectConversion = new ConversionNumberToWords();
            string expectedResult = "one hundred twenty-nine";
            string actualResult = objectConversion.ConvertNumberToWords(129);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void IsConvertingCorrect4DigitNo()
        {
            ConversionNumberToWords objectConversion = new ConversionNumberToWords();
            string expectedResult = "one thousand, two hundred thirty-four";
            string actualResult = objectConversion.ConvertNumberToWords(1234);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
