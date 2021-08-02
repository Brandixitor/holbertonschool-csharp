using System;
using System.Collections.Generic;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// Checks type and instance of Obj.
    /// </summary>
    /// <param name="obj">Obj that need to be checked.</param>
    /// <returns> returns True if the object is an instance of, or if the object is an instance of a class that inherited from,
    /// Array, otherwise return False.</returns>
    public static bool IsInstanceOfArray(object obj){
        if (obj.GetType() == typeof(Array) || obj is Array)
            return true;
        return false;
    }
}
