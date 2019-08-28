using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordConverter;

namespace NumberToWordConverterTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow(56945781)]
        public void CheckValueRange(int number)
        {
            Assert.AreEqual(NumberToText.ConvertNumberToText(number.ToString()), "Fifty Six Million Nine Hundred Fourty Five Thousand Seven Hundred Eighty One");
        }
    }
}
