using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        int lastDigit = number % 10;
        if (number > 5)
            Console.WriteLine("{1} and is greater than 5", lastDigit);
        else if (number == 0)
            Console.WriteLine("{1} and is 0", lastDigit);
        else
            Console.WriteLine("{1} and is less than 6 and not 0", lastDigit);
    }
}