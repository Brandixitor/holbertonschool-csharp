using System;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// Checks if the object is a derived class. 
    /// </summary>
    /// <param name="derivedType">Derived type to be checked.</param>
    /// <param name="baseType">Base class type.</param>
    /// <returns>returns True if the object is an instance of a class that inherits from the specified class, 
    /// otherwise return False. The object must be a subclass.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType){
        if (derivedType.IsSubclassOf(baseType)){
            return true;
        }
        return false;
    }
}
