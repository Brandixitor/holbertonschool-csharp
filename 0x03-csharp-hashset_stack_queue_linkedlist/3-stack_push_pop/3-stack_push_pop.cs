using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        var item = "";

        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
        {
            item = "Stack is empty";
        }
        else
        {
            item = "Top item: " + aStack.Peek();
        }
        Console.WriteLine(item);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}