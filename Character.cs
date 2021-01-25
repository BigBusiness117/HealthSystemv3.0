using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Character
    {
        public int health;
        public int level;
        public int lives;
        public int stamina;
        public int weapon;
        public int currentWeapon;
        public string weaponNames;
        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        public void Heal(int hp)
        {
            health += hp;
        }
        public void Energy(int energy)
        {
            stamina -= energy;
        }
        public void ShowStats()
        {
            Console.WriteLine("Health:" + health);
        }

    }
}
