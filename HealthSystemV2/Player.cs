using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    internal class Player
    {

        //fields
        int health; // declaration
        int lives;


        //methods
        public Player() //constructor
        {
            health = 100;
            lives = 3;
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
        }

        public void Heal(int hp)
        {
            health += hp;
        }

        public void ShowStats()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
        }
    }
}
