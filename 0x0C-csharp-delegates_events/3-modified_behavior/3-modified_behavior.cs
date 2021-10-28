using System;

/// <summary>
/// Modifier used with delegates
/// </summary>
public enum Modifier
{
    /// <summary> 
    /// Weak default value should be 0.5 
    /// </summary>
    Weak,
    /// <summary> 
    /// Base default value should be 1 
    /// </summary>
    Base,
    /// <summary> 
    /// Strong default value should be 1.5 
    /// </summary>
    Strong
}
/// <summary>
/// Player's CalculateHealth Delegate
/// </summary>
/// <param name="amount">Amount for health,</param>
public delegate void CalculateHealth(float amount);
/// <summary>
/// Calculate Modifier Delegate
/// </summary>
/// <param name="baseValue">Base value</param>
/// <param name="modifier">Modifier: Weak, Base, Strong</param>
/// <returns>Returns a delegate</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// Player class
/// </summary>
public class Player
{
    // Player's name
    private string name { get; set; }
    // Player's max hp.
    private float maxHp { get; set; }
    // Player's hp
    private float hp { get; set; }
    /// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">Player's name</param>
    /// <param name="maxHp">Player's max hp</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary>
    /// Prints player Health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// Player's take damage
    /// </summary>
    /// <param name="damage">Amount of damage taken</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        this.ValidateHP(this.hp - damage);
    }
    /// <summary>
    /// Player's heal
    /// </summary>
    /// <param name="heal">Amount of heals recieved</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        this.ValidateHP(this.hp + heal);
    }
    /// <summary>
    /// Define new player's hp depending on occured event.
    /// </summary>
    /// <param name="newHp">Sets up the new player's hp.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp >= maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
    /// <summary>
    /// Method used with delegate to apply a BaseValue depending on the modifier
    /// </summary>
    /// <param name="baseValue">Base value to apply</param>
    /// <param name="modifier">Modifier : Weak, Base, Strong</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modifiedVal = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                modifiedVal = baseValue * 0.5f;
                break;
            case Modifier.Base:
                modifiedVal = baseValue * 1f;
                break;
            case Modifier.Strong:
                modifiedVal = baseValue * 1.5f;
                break;
        }
        return modifiedVal;
    }
}

