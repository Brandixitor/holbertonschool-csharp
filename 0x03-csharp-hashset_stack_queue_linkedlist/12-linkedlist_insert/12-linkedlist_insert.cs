using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n){
        LinkedListNode<int> node = myLList.First;
        if (node.Value >= n)
            return myLList.AddFirst(n);
        while (node.Next != null){
            if (node.Next.Value >= n){
                node = myLList.AddAfter(node, n);
                return node;
            }
            node = node.Next;
        }
        node = myLList.AddLast(n);
        return node;
    }
}
