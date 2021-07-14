using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var newDict = new Dictionary<string, int>();
        foreach (var pair in myDict)
        {
            newDict[pair.Key] = pair.Value * 2;
        }
        return newDict;
    }
}
