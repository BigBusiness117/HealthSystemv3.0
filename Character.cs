using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    abstract class Character : Items
    {
        public int remainingshield;
        public int shield;
        public int health;
        public int level;
        public int lives;
        public int stamina;
        public int weapon;
        public int currentWeapon;
        public string weaponNames;
        public string name = "";

        Items items = new Items();
        public void itemboost(int food)
        {
            items.healups[food] = items.healups[food];
            if(food == 0)
            {
                health = health + 30;
                Console.WriteLine("you ate an apple and gained 30 health");
            } 

        }
        public void TakeDamage(int damage)
        {

            Console.WriteLine(" You are about to take " + damage + " damage");
            if (damage < 0)
            {
                Console.WriteLine(" Error You Cant use negative input");

                damage -= damage;
            }
            if (shield > 0)
            {
                shield -= damage;
                remainingshield -= damage;
            }
            else if (shield == 0)
            {
                health -= damage;

            }
            if (shield < 0)
            {
                shield = 0;
                health += remainingshield;
                remainingshield = 0;
            }
            HealthRegain();
            LivesRestock();
        }
        public void Heal(int hp)
        {
            Console.WriteLine(" You are about to take " + hp + " of healing");
            if (hp < 0)
            {
                hp -= hp;
                Console.WriteLine(" Error you cannot put negitive values for healing");
            }
            if (health > 0)
            {
                health += hp;
            }
            if (health > 100)
            {
                health = 100;
                Console.WriteLine(" health cant go past 100");
            }
        }
        public void Energy(int energy)
        {
            stamina -= energy;
        }
        public void ShowHub()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine( " Name: " + name + " |Level: " + level + " |Shield: " + shield + " |Health: " + health + "%" + "| + Lives: " + lives + "| Stamina: " + stamina);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" press any key to move on");
            // Console.ReadKey(true);
        }
        private void HealthRegain()
        {
            if (health < 0)
            {
                health = 0;

            }
            if (health <= 0)
            {
                health = 0;
                remainingshield = shield;
                lives = lives - 1;
                Console.WriteLine(" You lost a life");
                Console.WriteLine(" You use a 1 UP");



            }
            if (health == 0)
            {
                health = 100;
                shield = 100;
            }
        }
        private void LivesRestock()
        {
            if (lives <= 0)
            {
                lives = 0;
                shield = 0;
                health = 0;
                stamina = 0;
            }
            if (lives >= 99)
            {
                lives = 99;
            }
            if (lives == 0)
            {

                Console.WriteLine(" You Died press any key to restart");
                Console.ReadKey(true);
                Console.Clear();
                health = 100;
                shield = 100;
                remainingshield = shield;
                lives = 3;
            }


        }
        public void Regenerateshields(int Armor)
        {
            Console.WriteLine(" you are about to take " + Armor + " of Shield regeneration");
            if (Armor < 0)
            {

                Console.WriteLine(" Error you cannot put negative values for Shield Regeneration");
                Armor -= Armor;

            }


            shield += Armor;

            if (shield > 100)
            {
                Console.WriteLine(" shields can't go past 100");
                shield = 100;
            }
        }
    }
}
