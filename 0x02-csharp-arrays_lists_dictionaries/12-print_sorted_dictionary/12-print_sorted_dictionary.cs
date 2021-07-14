using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict){
        var myList = new List<string>();
        var newDict = new Dictionary<string, string>();
        
        foreach (var pair in myDict){
            myList.Add(pair.Key);
        }
        myList.Sort();
        foreach(var key in myList){
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
