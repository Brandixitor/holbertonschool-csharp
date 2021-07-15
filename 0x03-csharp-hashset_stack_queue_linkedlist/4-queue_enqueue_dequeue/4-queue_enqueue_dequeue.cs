using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        string item;
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
        {
            item = "Queue is empty";
        }
        else
        {
            item = "First item: " + aQueue.Peek();
        }
        Console.WriteLine(item);
        aQueue.Enqueue(newItem);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        while (aQueue.Contains(search))
        {
            aQueue.Dequeue();
        }
        return aQueue;
    }
