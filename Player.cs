using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Player : Character
    {
        public Player()
        {
            name = "Dylan";
            health = 100;
            lives = 3;
            shield = 100;
            remainingshield = shield;
        }
       
    }
}
