using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    // abstract can never be instantiated
    abstract class Character : Items
    {
        // only can be access by the character and what other class is inheritanted
        protected int remainingshield;
        protected int shield;
        protected int health;
        protected int lives;
        protected string name = "";

        // overides  the field in item class
        // public can be access by any class
        public override void itemboost(int food)
        {
            // show all the contents in itemboost field plus its own content
            base.itemboost(food);
            if(food == 0)
            {
                health = health + 30;
                if (health > 100)
                {
                    health = 100;
                    Console.WriteLine(" health cant go past 100");
                }
            }
            if (food == 1)
            {
                health = health + 40;
                if (health > 100)
                {
                    health = 100;
                    Console.WriteLine(" health cant go past 100");
                }
            }
            if (food == 2)
            {
                health = health + 50;
                if (health > 100)
                {
                    health = 100;
                    Console.WriteLine(" health cant go past 100");
                }
            }
            if (food == 3)
            {
                health = health + 60;
                if (health > 100)
                {
                    health = 100;
                    Console.WriteLine(" health cant go past 100");
                }
            }
            if (food == 4)
            {
                health = health + 70;
                if (health > 100)
                {
                    health = 100;
                    Console.WriteLine(" health cant go past 100");
                }
            }

        }
        // take damge to the player and enemy and shows error checking
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
                // damage  spillover from shield to health
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
        //  heal the player and enemy and range checking
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
        // show the stats of the player and enemy
        public void ShowHub()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine( " Name: " + name + " |Shield: " + shield + " |Health: " + health + "%" + "| + Lives: " + lives);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" press any key to move on");
            
            Console.ReadKey(true);
        }
        // shows health checking
        //private can only be access in this class
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
        // show lives checking and replace the lifes when needed
        private void LivesRestock()
        {
            if (lives <= 0)
            {
                lives = 0;
                shield = 0;
                health = 0;
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
        // regenerates shield to the player and enemy
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
        // resets the player stats and enemy
        public void GameReset()
        {
            health = 100;
            shield = 100;
            remainingshield = shield;
            lives = 3;
            Console.WriteLine(" Game has reset");
        }
    }
}
