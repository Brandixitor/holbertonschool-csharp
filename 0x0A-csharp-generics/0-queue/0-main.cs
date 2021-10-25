using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}