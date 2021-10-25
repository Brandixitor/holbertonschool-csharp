using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        Console.WriteLine(myStrQ.Concatenate());

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Concatenate();

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        myCharQ.Enqueue('a');
        myCharQ.Enqueue('b');
        myCharQ.Enqueue('c');
        Console.WriteLine(myCharQ.Concatenate());
    }
}