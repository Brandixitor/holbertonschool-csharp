using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Holberton";
        var word_first_3 = word.Substring(0, 3);
        var word_last_2 = word.Substring(word.Length - 2, 2);
        var middle_word = word.Substring(1, word.Length - 2);
        Console.WriteLine("First 3 letters: {0}", word_first_3);
        Console.WriteLine("Last 2 letters: {0}", word_last_2);
        Console.WriteLine("Middle word: {0}", middle_word);
    }
}