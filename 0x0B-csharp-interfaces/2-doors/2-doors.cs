using System;

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