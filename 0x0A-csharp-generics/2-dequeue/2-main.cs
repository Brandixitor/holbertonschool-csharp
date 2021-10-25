using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}