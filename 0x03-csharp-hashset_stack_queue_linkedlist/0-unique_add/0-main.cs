using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 8 };
        List<int> myList2 = new List<int>() { 98, 98, -14, 972, 0, -42, -972 };

        Console.WriteLine(List.Sum(myList1));
        Console.WriteLine(List.Sum(myList2));
    }
}