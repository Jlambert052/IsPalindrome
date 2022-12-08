namespace Leetcode {
    public class Palindrome {
        public bool IsPalindromePureString(string s) {
           char[] arrayRevS = s.ToCharArray();
            Array.Reverse(arrayRevS);
            char[] arrayS = s.ToCharArray();
            if(arrayS.SequenceEqual(arrayRevS)) {
                System.Console.WriteLine($"The string is a palindrome");
                return true;
            } else 
            System.Console.WriteLine($"The string is not a palindrome");
                return false;

        }
    }
}