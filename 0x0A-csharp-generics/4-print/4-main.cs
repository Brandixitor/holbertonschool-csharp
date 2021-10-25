using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        myStrQ.Print();

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Print();
    }
}