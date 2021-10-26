using System;

class Program
{
    static void Main(string[] args)
    {
        Key carKey = new Key("Car Key");

        Console.WriteLine(carKey.ToString());

        carKey.Collect();
        carKey.Collect();
    }
}