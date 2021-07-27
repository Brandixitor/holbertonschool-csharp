using System;

namespace Enemies
{
    /// <summary>
    /// This class creates a zombie.
    /// </summary>
    public class Zombie
    {
        // Private Field that defines the health of a zombie.
        private int health;
        // Private Field that defines the name of a zombie.
        private string name = "(No name)";
        /// <summary>Gets or sets the name of a zombie.</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class and checks if value is greater than 0.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>Gets the health of a zombie.</summary>
        public int GetHealth()
        {
            return health;
        }

    }
}