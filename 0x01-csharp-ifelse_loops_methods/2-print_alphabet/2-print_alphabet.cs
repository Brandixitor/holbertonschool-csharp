using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i < 123; i++)
            {
                char c = (char)i;
                Console.Write(c);
            }
        }
    }
}