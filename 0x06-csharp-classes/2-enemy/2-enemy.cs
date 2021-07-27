using System;

namespace Enemies
{
    /// <summary>
    /// This class creates a zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>Field that defines the health of zombie.</summary> 
        public int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}