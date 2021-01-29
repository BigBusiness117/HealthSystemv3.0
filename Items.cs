using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Items  
    {
        // array of items that will heal the player
        static string[] healups = new string[5];
       public Items()
       {
            // items in the array
            healups[0] = "apple";
            healups[1] = "bannana";
            healups[2] = "coconut";
            healups[3] = "tomatoe";
            healups[4] = "peach";
            
            
        }
        // show the player the cureent item they ate  depending on the food chosen
        // this field can be overide by field in character class 
        // Polymorphism
        public virtual void itemboost(int food)
    {
            // pick the players item depening on the number given
            healups[food] = healups[food];
            if (food == 0)
            {
                
                Console.WriteLine(" you ate an " + healups[0] + " and gained 30 health");
            }
            if (food == 1)
            {

                Console.WriteLine(" you ate an " + healups[1] + " and gained 40 health");
            }
            if (food == 2)
            {

                Console.WriteLine(" you ate an " + healups[2] + " and gained 50 health");
            }
            if (food == 3)
            {

                Console.WriteLine(" you ate an " + healups[3] + " and gained 60 health");
            }
            if (food == 4)
            {

                Console.WriteLine(" you ate an " + healups[4] + " and gained 70 health");
            }
        }
    
    }
}
