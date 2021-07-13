using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string separator = ", ";

                if (i == 99) separator = "\n";
                System.Console.Write($"{i:d2}{separator}");

            }
        }
    }
}