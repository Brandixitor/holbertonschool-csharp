using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";

        Console.WriteLine("{0} {1} {2} {3}", str.Substring(49, 15), str.Substring(80, 11), str.Substring(119, 2), str.Substring(0, 2));
    }
}