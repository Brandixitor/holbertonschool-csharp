using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Checks if the string is a palindrome</summary>
        /// <param name="s">String to check.</param>
        /// <returns>True if a string is a palindrome or False if it’s not.</returns>
        public static bool IsPalindrome(string s){
            int len;
             string revS = "";
            try{
                len = s.Length - 1;
            }
            catch{
                return false;
            }
            if (s.Length == 0)
                return true;
            while (len >= 0){
                revS = revS + s[len];
                len--;
            }

            revS = Regex.Replace(revS, @"\W|_", string.Empty);
            s = Regex.Replace(s, @"\W|_", string.Empty);
            if (string.Compare(revS.ToLower(), s.ToLower()) == 0)
                return true;
            return false;
        }
    }
}
