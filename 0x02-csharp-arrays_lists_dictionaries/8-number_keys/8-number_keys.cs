using System;
using System.Collections.Generic;
class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict){
        int i = 0;
        foreach(var pair in myDict){
            i += 1;
        }
        return i;
    }
}
