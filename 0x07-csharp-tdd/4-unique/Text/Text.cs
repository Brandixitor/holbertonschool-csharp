using System;

namespace Text
{
    /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Checks the index of the first non-repeating character of a string</summary>
        /// <param name="s">String to check.</param>
        /// <returns>returns the index of the first non-repeating character of a string.</returns>

        public static int UniqueChar(string s){
            int len;
            int n = 0;
            int occurs = 0;
            try{
                len = s.Length;
            }
            catch{
                return -1;
            }
            foreach (var elem in s)
            {
                for (int i = 0; i < s.Length; i++){
                    if (s[i] == elem){
                        occurs += 1;
                    };
                }
                if (occurs == 1){
                    return n;
                }
                occurs = 0;
                n += 1;
            }
            return -1;
        }
    }
}
