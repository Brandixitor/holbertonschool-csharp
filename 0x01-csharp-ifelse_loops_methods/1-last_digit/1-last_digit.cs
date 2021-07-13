using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number > 0)
            Console.WriteLine("{0 % 10} is positive", number);
        else if (number == 0)
            Console.WriteLine("{0 % 10} is zero", number);
        else
            Console.WriteLine("{0 % 10} is negative", number);
    }
}