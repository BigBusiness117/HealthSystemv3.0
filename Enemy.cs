using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Enemy : Character 
    {
        // conductor 
       public Enemy()
       {
            // enemy stats
            lives = 2;
            health = 100;
            shield = 100;
            name = "Dog";
            remainingshield = shield;
        }
        //shows all the contents in showhub plus adds some of its own
        public new void ShowHub()
        {
            Console.WriteLine("");
            Console.WriteLine(" Enemy Stats:");
            base.ShowHub();
        }
    }
}
