using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 122; i++)
            {
                if (i != 113 && i != 101)
                    Console.Write("{0}", Convert.ToChar(i));
            }
        }
    }
}