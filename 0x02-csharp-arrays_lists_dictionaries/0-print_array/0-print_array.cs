using System;
using System.Collections.Generic;

namespace _0_print_array
{
    class array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
        }
    }
}
