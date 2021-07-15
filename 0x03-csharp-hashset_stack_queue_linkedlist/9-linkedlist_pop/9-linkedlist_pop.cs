using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList){
        if (myLList.Count == 0)
            return 0;
        LinkedListNode<int> head = myLList.First;
        myLList.RemoveFirst();
        return head.Value;
    }
}