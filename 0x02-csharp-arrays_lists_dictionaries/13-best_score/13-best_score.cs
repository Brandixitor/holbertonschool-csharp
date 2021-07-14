using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList){
        int max = int.MinValue;
        string maxKey = "None";
        foreach(var pair in myList){
            if (pair.Value > max){
                max = pair.Value;
                maxKey = pair.Key; 
            }
        }
        return maxKey;
    }
}
