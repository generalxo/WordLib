namespace WordLib
{
    public class WordLibClass
    {
        public bool IsPalindrome(string input)
        {
            if (input == null || input == string.Empty)
            {
                throw new ArgumentException("Parameter cannot be null or empty");
            }

            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (reversed == input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int WordLength(string v)
        {
            return v.Length;
        }
    }
}