using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        myIntQ.Enqueue(102);

        Console.WriteLine("First value: " + myIntQ.Peek());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        Console.WriteLine("First value: " + myCharQ.Peek());
    }
}