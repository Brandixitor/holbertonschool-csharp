using System;

class Program
{
    static void Main(string[] args)
    {
        SoftwareEngineer engineer = new SoftwareEngineer();

        engineer.name = "Betty";

        Console.WriteLine(engineer.ToString());
    }
}

class SoftwareEngineer : Base
{
    // Empty class
}