using System;
using System.Collections.Generic;

namespace _0_print_array
{
    class array
    {
        public static int[] CreatePrint(int size)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
    }
}
