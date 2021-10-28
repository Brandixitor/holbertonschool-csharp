using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.PrintHealth();

        player.TakeDamage(50f);

        player.PrintHealth();

        player.HealDamage(49f);

        player.PrintHealth();
    }
}