using System;
using System.Collections.Generic;

    class List
    {
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> List3 = new List<int>();

        foreach (var elem in list1)
        {
            if (list2.Contains(elem))
            {
                List3.Add(elem);
            }
        }
        return List3;
    }
}