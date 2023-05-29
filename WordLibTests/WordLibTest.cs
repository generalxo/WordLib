using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WordLibTest
    {
        [TestMethod]
        public void WordLib_IsPalindrome_radar_true()
        {
            WordLibClass wordLib = new WordLibClass();

            bool expected = true;
            bool actual = wordLib.IsPalindrome("radar");

            Assert.AreEqual(expected, actual);

        }
    }
}