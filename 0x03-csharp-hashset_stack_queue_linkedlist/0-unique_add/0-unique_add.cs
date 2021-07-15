using System;
using System.Collections.Generic;

    class List
    {
    public static int Sum(List<int> myList)
        {
        List<int> newList = new List<int>();
        int sum = 0;
        foreach (var elem in myList)
        {
            if (! newList.Contains(elem))
            {
                newList.Add(elem);
                sum += elem;
            }
        }
        return sum;
        }
    }