using System;
using System.Collections.Generic;

/// <summary>
/// Base class
/// </summary>
public abstract class Base{
    /// <summary>
    /// Name property
    /// </summary>
    /// <value>Getter and setter</value>
    public string name {get; set;}
    /// <summary>
    /// Overrides ToString Method
    /// </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }

     
}

/// <summary>
/// Interactive interface
/// </summary>
public interface IInteractive{
    /// <summary>
    /// Used for interactions.
    /// </summary>
    void Interact();
}
/// <summary>
/// IBreakable interface
/// </summary>
public interface IBreakable{
    /// <summary>
    /// Used for item durability.
    /// </summary>
    /// <value>Getter and setter</value>
    int durability { get; set; }
    /// <summary>
    /// Used to break an item.
    /// </summary>
    void Break();
}
/// <summary>
/// ICollectable interface
/// </summary>
public interface ICollectable{
    /// <summary>
    /// Used to check if collected or not.
    /// </summary>
    /// <value>Getter and setter</value>
    bool isCollected { get; set; }
    /// <summary>
    /// Used to collect something.
    /// </summary>
    void Collect();  
}
/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive{
    /// <summary>
    /// Door default constructor
    /// </summary>
    /// <param name="Name">Default name Door, value constructor</param>
    public Door(string Name="Door"){
        this.name = Name;
    }
     /// <summary>
    /// Used for interactions.
    /// </summary>
    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
/// <summary>
/// Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable{
    /// <summary>
    /// Used for item durability.
    /// </summary>
    /// <value>Getter and setter</value>
    public int durability { get; set; }
    /// <summary>
    /// Is quest item boolean
    /// </summary>
    public bool isQuestItem;
    /// <summary>
    /// Decoration constructor
    /// </summary>
    /// <param name="name">Name of the decoration</param>
    /// <param name="durability">Durability of the decoration</param>
    /// <param name="isQuestItem">Checks if it is quest item or not</param>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false){
        if (durability <= 0){
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    /// <summary>
    /// Used for interactions
    /// </summary>
    public void Interact(){
        if (durability <= 0){
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem){
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else{
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
    /// <summary>
    /// Used for broken item.
    /// </summary>
    public void Break(){
        durability -= 1;
        if (durability > 0){
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0){
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else{
            Console.WriteLine($"The {name} is already broken.");
        }
    }


}
/// <summary>
/// Key class
/// </summary>
public class Key : Base, ICollectable{
    /// <summary>
    /// Used to check if collected or not.
    /// </summary>
    /// <value>Getter and setter</value>
    public bool isCollected { get; set; }
    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="name">name of the key</param>
    /// <param name="isCollected">is collected or not</param>
    public Key(string name="Key", bool isCollected=false){
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary>
    /// Used to collect the key
    /// </summary>
    public void Collect(){
        if (!isCollected){
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        } else{
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
/// <summary>
/// Objs enumerable
/// </summary>
public class Objs<T>: List<T>{

}