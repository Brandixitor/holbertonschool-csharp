using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; 
            int j = 0;
            for (i = 0; i < 9; i ++)
                for (j = 0; j < 10; j++)
                {
                    if (j > i)
                    {
                        if (i < 8 || j < 9)
                            Console.Write($"{i}{j}, ");
                        else
                            Console.Write($"{i}{j}");
                    }                      
                }
            Console.WriteLine();
        }
    
    }
}
