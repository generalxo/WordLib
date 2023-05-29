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

        [TestMethod]
        public void WordLib_IsPalindrome_hello_false()
        {
            WordLibClass wordLib = new WordLibClass();

            bool expected = false;
            bool actual = wordLib.IsPalindrome("hello");

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void WordLib_IsPalindrome_null_exception()
        {
            WordLibClass wordLib = new WordLibClass();

            Assert.ThrowsException<ArgumentException>(() => wordLib.IsPalindrome(null));

        }

        [TestMethod]
        public void WordLib_IsPalindrome_empty_exception()
        {
            WordLibClass wordLib = new WordLibClass();

            Assert.ThrowsException<ArgumentException>(() => wordLib.IsPalindrome(string.Empty));

        }

        [TestMethod]
        public void WordLib_WordLength_radar_5()
        {
            WordLibClass wordLib = new WordLibClass();

            int expected = 5;
            int actual = wordLib.WordLength("radar");

            Assert.AreEqual(expected, actual);

        }
    }
}