using System;
using System.Collections.Generic;

    class LList
    {
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myList = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            myList.AddLast(i);
            Console.WriteLine(i);
        }
        return myList;
    }
}