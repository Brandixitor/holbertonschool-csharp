using System;

/// <summary>
/// Player's CalculateHealth Delegate
/// </summary>
/// <param name="amount">Amount for health,</param>
public delegate void CalculateHealth(float amount);

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
    }
}