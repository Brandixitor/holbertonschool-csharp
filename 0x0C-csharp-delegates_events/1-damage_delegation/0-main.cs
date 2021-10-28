using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.TakeDamage(25f);

        player.HealDamage(10f);

        player.TakeDamage(-25f);
    }
}