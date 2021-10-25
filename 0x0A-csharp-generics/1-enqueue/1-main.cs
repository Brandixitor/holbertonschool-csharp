using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        myStrQ.Enqueue("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        myFloatQ.Enqueue(-9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}