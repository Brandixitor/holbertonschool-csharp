using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object from where to get informations.</param>
    public static void Print(object myObj){
        string cType = myObj.GetType().Name;
        Type t = myObj.GetType();
        Console.WriteLine("{0} Properties:", cType);
        foreach (var p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", cType);
        foreach (var m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
