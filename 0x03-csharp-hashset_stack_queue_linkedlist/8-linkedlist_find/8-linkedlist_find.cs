using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value){
        int index = 0;

        foreach(var elem in myLList){
            if (elem == value)
                return index;
            index++;
        }
        return -1;
    }
}
