using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307_Test
{
    public class Monster
    {
        Random rand = new Random();

        public void low_Monster()
        {
            int attack = rand.Next(5, 10);
            int health = rand.Next(10, 20);
        }
        public void middle_Monster()
        {
            int attack = rand.Next(10, 15);
            int health = rand.Next(20, 30);
        }
        public void high_Monster()
        {
            int attack = rand.Next(15, 20);
            int health = rand.Next(30, 40);
        }
    }
}
