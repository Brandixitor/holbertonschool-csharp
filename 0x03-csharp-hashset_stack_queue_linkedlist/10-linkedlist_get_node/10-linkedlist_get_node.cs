using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n){
        int index = 0;
        foreach (var elem in myLList){
            if (index == n)
                return elem;
            index++;
        }
        return 0;
    }
}
