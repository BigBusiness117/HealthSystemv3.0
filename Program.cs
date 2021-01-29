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
            Gameplay gameplay = new Gameplay();
            Console.WriteLine("Dylan Bruhm");
            player.ShowHub();
            gameplay.Dog();
            player.TakeDamage(50);
            player.ShowHub();
            gameplay.PackofDogs();
            player.TakeDamage(120);
            player.ShowHub();
            gameplay.Bear();
            player.TakeDamage(250);
            player.ShowHub();
            player.TakeDamage(-250);
            player.ShowHub();
            player.GameReset();
            player.ShowHub();
            gameplay.OldMan();
            player.Heal(100);
            player.ShowHub();
            gameplay.PackofDogs();
            player.TakeDamage(150);
            player.ShowHub();
            gameplay.Nap();
            player.Heal(25);
            player.ShowHub();
            player.Heal(-45);
            player.ShowHub();
            gameplay.Mushrooms();
            player.Regenerateshields(50);
            player.ShowHub();
            gameplay.LargeMushrooms();
            player.Regenerateshields(100);
            player.ShowHub();
            player.Regenerateshields(-50);
            player.ShowHub();
            enemy.ShowHub();
            enemy.TakeDamage(50);
            enemy.ShowHub();
            enemy.TakeDamage(60);
            enemy.ShowHub();
            enemy.TakeDamage(250);
            enemy.ShowHub();
            enemy.TakeDamage(-250);
            enemy.ShowHub();
            enemy.GameReset();
            enemy.ShowHub();
            enemy.Heal(100);
            enemy.ShowHub();
            enemy.TakeDamage(150);
            enemy.ShowHub();
            enemy.Heal(25);
            enemy.ShowHub();
            enemy.Heal(-45);
            enemy.ShowHub();
            enemy.Regenerateshields(50);
            enemy.ShowHub();
            enemy.Regenerateshields(100);
            enemy.ShowHub();
            enemy.Regenerateshields(-50);
            enemy.ShowHub();
            player.GameReset();
            player.ShowHub();
            player.TakeDamage(199);
            player.ShowHub();
            player.itemboost(0);
            player.ShowHub();
            player.itemboost(1);
            player.ShowHub();
            player.itemboost(2);
            player.ShowHub();
            player.itemboost(3);
            player.ShowHub();
            player.itemboost(4);
            player.ShowHub();
            Console.WriteLine("------------------END-------------------");
            Console.WriteLine("------------------END-------------------");
            Console.WriteLine("------------------END-------------------");
            Console.ReadKey();
        }
    }
}
