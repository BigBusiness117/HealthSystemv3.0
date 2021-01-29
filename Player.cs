using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Player : Character
    {
        // conductor 
        public Player()
        {
            name = "Jogger";
            health = 100;
            lives = 3;
            shield = 100;
            remainingshield = shield;
        }
        // shows the contents of showhub plus some of its own contents
        public new void ShowHub()
        {
            Console.WriteLine("");
            Console.WriteLine(" Player Stats:");
            base.ShowHub();
        }


    }
}
