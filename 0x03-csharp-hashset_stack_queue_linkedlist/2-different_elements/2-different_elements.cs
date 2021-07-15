using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2){
        List<int> List3 = new List<int>();
        foreach (var elem in list1)
            {
            if (!list2.Contains(elem))
            {
                List3.Add(elem);
            }
        }
        foreach (var elem in list2)
        {
            if (!list1.Contains(elem))
            {
                List3.Add(elem);
            }
        }
        List3.Sort();
        return List3;
    }
}