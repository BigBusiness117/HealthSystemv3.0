using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
            Console.WriteLine("HYBEOY");
            player.ShowHub();
            player.TakeDamage(50);
            player.ShowHub();
            player.Heal(25);
            player.ShowHub();
            player.TakeDamage(75);
            player.ShowHub();
            enemy.ShowHub();
            Console.ReadKey();
        }
    }
}
