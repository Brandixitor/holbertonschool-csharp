using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Properties:");
        foreach (PropertyInfo info in type.GetProperties())
            Console.WriteLine(info.Name);

        Console.WriteLine("Methods:");
        foreach (MethodInfo info in type.GetMethods())
            Console.WriteLine(info.Name);
    }
}