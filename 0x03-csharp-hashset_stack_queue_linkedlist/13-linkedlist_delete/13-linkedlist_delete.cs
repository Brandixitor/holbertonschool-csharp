using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index){
        foreach(var elem in myLList){
            if (index == 0){
                myLList.Remove(elem);
                break;
            }
            index--;
        }
    }
}
