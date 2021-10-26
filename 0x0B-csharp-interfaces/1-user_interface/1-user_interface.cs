using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base{
    /// <summary>
    /// Name property
    /// </summary>
    private string name {get; set;}
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
/// Used for test purpose
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable{

    /// <summary>
    /// Used for item durability
    /// </summary>
    /// <value>Getter and setter</value>
    public int durability {get; set;}
    /// <summary>
    /// Used for collection
    /// </summary>
    /// <value></value>
    public bool isCollected {get; set;}
    /// <summary>
    /// Used for interaction
    /// </summary>
    public void Interact(){
        // Method implementation.
    }
    /// <summary>
    /// Used to break item
    /// </summary>
    public void Break(){
        // Method implementation.
    }

    /// <summary>
    /// Used to collect something
    /// </summary>
    public void Collect(){
        // Method implementation.
    }
} 