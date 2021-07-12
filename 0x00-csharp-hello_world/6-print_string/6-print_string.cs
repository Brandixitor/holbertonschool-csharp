using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        string str2 = $"{str}{str}{str}\n";
        Console.Write(str2);
        Console.WriteLine(str.Substring(0, 9));
    }
}