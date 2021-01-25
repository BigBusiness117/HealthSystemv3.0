using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv3._0
{
    class Enemy : Character 
    {
       public Enemy()
       {
            lives = 1;
            health = 100;
            shield = 0;
            name = "Dog";
       }
    }
}
