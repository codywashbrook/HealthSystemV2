using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System V2"); //player class only
            Console.WriteLine();
            
            //declaration
            Player player = new Player();

            player.ShowStats();
            player.TakeDamage(10);
            player.ShowStats();


            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
