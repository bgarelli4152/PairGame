using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairGame
{
    class Monster
    {
        public int monsterRating;
        public string monster;
        public string[] bestiary = { "Chilling Chicken", "Scary Squid", "Wandering Wolf", "Gross Goblin", "Dangerous Demon" };

        public Monster() //constructor
        {
            monsterRating = 0;
            monster = "Blundering Bug";
            
        }

        public void Encounter() //generates a new monster with a new monsterRating
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 4);
            monsterRating = i;
            monster = bestiary[i];
            Console.WriteLine("You encountered a " + bestiary[i]);

        }
    }
}
