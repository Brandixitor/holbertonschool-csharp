using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                if (i != 'q' && i != 'e')
                {
                    System.Console.Write((char)i);
                }
            }
        }
    }
}