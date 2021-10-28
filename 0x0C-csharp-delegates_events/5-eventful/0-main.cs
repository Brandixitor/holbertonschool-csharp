using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(50f, Modifier.Base));
        player.PrintHealth();
    }
}