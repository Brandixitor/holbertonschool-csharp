using System;
using System.Collections.Generic;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// Checks if Obj is type of int.
    /// </summary>
    /// <param name="obj">Obj to be checked.</param>
    /// <returns>returns True if the object is an int, otherwise return False.</returns>
    public static bool IsOfTypeInt(object obj){
        if (obj.GetType() == typeof(int)){
            return true;
        }
        return false;
    }
}